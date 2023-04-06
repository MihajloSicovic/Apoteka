CREATE DATABASE Apoteka
USE Apoteka

/* BRISANJE TABELA
DROP TABLE racun
DROP TABLE transakcija
DROP TABLE kartica
DROP TABLE kupac
DROP TABLE zaposleni
DROP TABLE magacin
DROP TABLE lokal
DROP TABLE dostava
DROP TABLE proizvod
*/

BEGIN /*TABELE*/
	CREATE TABLE proizvod
	(proizvod_id INT IDENTITY(1, 1) PRIMARY KEY,
	naziv NVARCHAR(30),
	cena FLOAT,
	lek BIT,	-- 1 = lek, 0 = nelek
	podvrsta NVARCHAR(20),
	opis NVARCHAR(50))

	CREATE TABLE lokal
	(lokal_id INT IDENTITY(1, 1) PRIMARY KEY,
	adresa NVARCHAR(30) NOT NULL,
	kontakt NVARCHAR(15))

	CREATE TABLE zaposleni
	(zaposleni_id INT IDENTITY(1, 1) PRIMARY KEY,
	ime NVARCHAR(20),
	prezime NVARCHAR(20),
	jmbg VARCHAR(13),
	adresa NVARCHAR(30),
	broj_racuna VARCHAR(20),
	email NVARCHAR(50) UNIQUE NOT NULL,
	sifra NVARCHAR(20) NOT NULL,
	uloga INT NOT NULL,
	id_lokala INT FOREIGN KEY REFERENCES lokal(lokal_id),
	id_menadzera INT FOREIGN KEY REFERENCES zaposleni(zaposleni_id),
	CHECK (LEN(jmbg) = 13))

	CREATE TABLE dostava
	(dostava_id INT IDENTITY(1, 1) PRIMARY KEY,
	datum DATE,
	primljeno BIT NOT NULL DEFAULT 0)

	CREATE TABLE magacin
	(magacin_id INT IDENTITY(1, 1) PRIMARY KEY,
	id_dostave INT FOREIGN KEY REFERENCES dostava(dostava_id) ON DELETE CASCADE,
	id_leka INT FOREIGN KEY REFERENCES proizvod(proizvod_id),
	rok_trajanja DATE,
	u_magacinu INT NOT NULL DEFAULT 1,
	id_lokala INT FOREIGN KEY REFERENCES lokal(lokal_id),
	CHECK(u_magacinu >= 0))

	CREATE TABLE kupac
	(kupac_id INT IDENTITY(1, 1) PRIMARY KEY,
	ime NVARCHAR(20),
	prezime NVARCHAR(20),
	datum_rodjenja DATE,
	email NVARCHAR(50) NOT NULL UNIQUE,
	sifra NVARCHAR(20) NOT NULL,
	kontakt NVARCHAR(15),
	CHECK (DATEDIFF(yy, datum_rodjenja, GETDATE()) > 17))

	CREATE TABLE kartica
	(kartica_id INT IDENTITY(1, 1) PRIMARY KEY,
	broj_kartice VARCHAR(15) NOT NULL UNIQUE,
	poeni FLOAT NOT NULL DEFAULT 0,
	tip_kartice INT NOT NULL DEFAULT 0,
	id_kupca INT FOREIGN KEY REFERENCES kupac(kupac_id) UNIQUE,
	CHECK (poeni >= 0),
	CHECK (tip_kartice > -1))

	CREATE TABLE transakcija
	(trans_id INT IDENTITY(1, 1) PRIMARY KEY,
	korisceni_poeni INT NOT NULL DEFAULT 0,
	datum_obrade DATE DEFAULT GETDATE(),
	id_kartice INT FOREIGN KEY REFERENCES kartica(kartica_id),
	id_kupca INT FOREIGN KEY REFERENCES kupac(kupac_id),
	CHECK (datum_obrade <= GETDATE()))

	CREATE TABLE racun
	(racun_id INT IDENTITY(1, 1) PRIMARY KEY,
	id_magacina INT FOREIGN KEY REFERENCES magacin(magacin_id),
	cena_s_popustom FLOAT NOT NULL DEFAULT 0,
	kolicina INT NOT NULL,
	id_trans INT,
	CONSTRAINT fk_racun_trans FOREIGN KEY (id_trans) REFERENCES transakcija(trans_id))
END

BEGIN /*POGLEDI*/
	CREATE VIEW obavljanje_transakcije AS 
	SELECT proizvod.*, magacin.*, racun.*, transakcija.*, kartica.kartica_id, 
	kartica.broj_kartice, FLOOR(kartica.poeni) AS poeni, kartica.tip_kartice
	FROM proizvod 
	JOIN magacin ON proizvod_id = magacin.id_leka
	JOIN racun ON magacin_id = racun.id_magacina
	JOIN transakcija ON racun.id_trans = trans_id
	LEFT JOIN kartica ON kartica_id = transakcija.id_kartice

	CREATE VIEW kupci_bez_kartice AS
	SELECT kupac.* FROM kupac
	FULL JOIN kartica ON id_kupca = kupac_id
	WHERE kupac_id NOT IN (SELECT id_kupca FROM kartica)

	CREATE VIEW u_magacinu_bez_racuna AS
	SELECT magacin.* FROM magacin
	FULL JOIN racun ON magacin_id = id_magacina
	WHERE magacin_id NOT IN (SELECT id_magacina FROM racun)

	CREATE VIEW pretraga_lekova AS
	SELECT naziv, lek, podvrsta, cena, opis, rok_trajanja, adresa, kontakt
	FROM lokal
	JOIN magacin ON lokal_id = id_lokala
	JOIN proizvod ON id_leka = proizvod_id
	LEFT JOIN dostava ON id_dostave = dostava_id
	WHERE id_dostave IS NULL OR primljeno = 1

	CREATE VIEW pretraga_lokala AS
	SELECT lokal.adresa, kontakt, ime, prezime
	FROM lokal
	LEFT JOIN zaposleni ON lokal_id = id_lokala

	CREATE VIEW pregled_kartica AS
	SELECT kartica_id, broj_kartice, FLOOR(poeni) AS poeni, tip_kartice,
		CASE 
			WHEN tip_kartice = 0 THEN 'Obična'
			WHEN tip_kartice = 1 THEN 'Bebi'
			WHEN tip_kartice = 2 THEN 'Penzioner'
			ELSE 'VIP'
		END
		AS "naziv_kartice", kupac_id, ime + ' ' + prezime AS kupac
	FROM kartica
	JOIN kupac ON id_kupca = kupac_id

	CREATE VIEW svi_zaposleni AS
	SELECT zaposleni.ime, zaposleni.prezime, zaposleni.email, zaposleni.uloga, 
			zaposleni.zaposleni_id, zaposleni.id_lokala, zaposleni.id_menadzera,
	CASE
		WHEN zaposleni.uloga = 0 THEN 'Vlasnik'
		WHEN zaposleni.uloga = 1 THEN 'Menadžer'
		WHEN zaposleni.uloga = 2 THEN 'Farmaceut'
		ELSE 'Farmaceutski tehničar'
	END AS "status",
	lokal.adresa AS "adresa lokala", m.ime + ' ' + m.prezime AS menadzer FROM zaposleni
	LEFT JOIN zaposleni m ON zaposleni.id_menadzera = m.zaposleni_id
	LEFT JOIN lokal ON zaposleni.id_lokala = lokal_id
	
	CREATE VIEW pregled_transakcija AS
	SELECT transakcija.*, broj_kartice AS "kartica", ime + ' ' + prezime AS "kupac", 
	STR(dbo.ukupni_racun(trans_id)) + ' RSD' AS "ukupno" FROM transakcija
	LEFT JOIN kupac ON id_kupca = kupac_id
	LEFT JOIN kartica ON id_kartice = kartica_id
END

BEGIN /*TRIGGER kartica*/ 
	CREATE TRIGGER kartica_ins
	ON kartica
	AFTER INSERT
	AS
	BEGIN
		UPDATE kartica SET poeni += 100 WHERE kartica_id IN (SELECT kartica_id FROM inserted);
	END
END

SELECT * FROM obavljanje_transakcije

BEGIN /*TRIGGERI racun*/
	CREATE TRIGGER racun_ins
	ON racun
	AFTER INSERT
	AS
	BEGIN
		UPDATE m SET u_magacinu = u_magacinu - kolicina
		FROM (SELECT u_magacinu, kolicina FROM magacin
		JOIN inserted ON magacin_id = id_magacina) m

		UPDATE obavljanje_transakcije SET cena_s_popustom =
		CASE
			WHEN tip_kartice = 3 THEN cena * 0.75
			WHEN tip_kartice = 1 AND podvrsta = 'bebi' THEN cena * 0.8
			WHEN tip_kartice = 2 AND lek = 1 AND DAY(GETDATE()) IN (13, 14, 15) THEN cena * 0.85
			ELSE cena 
		END
		WHERE racun_id IN (SELECT racun_id FROM inserted);

		UPDATE kartica SET poeni += (SELECT SUM(kolicina * cena_s_popustom) / 20 AS dodatni_poeni FROM transakcija 
									JOIN inserted ON trans_id = id_trans)
		WHERE kartica_id IN (SELECT id_kartice FROM transakcija JOIN inserted ON trans_id = id_trans)
	END

	CREATE TRIGGER racun_del
	ON racun
	AFTER DELETE
	AS
	BEGIN
		UPDATE m SET u_magacinu = u_magacinu + kolicina
		FROM (SELECT u_magacinu, kolicina FROM magacin
		JOIN deleted ON magacin_id = id_magacina) m

		UPDATE kartica SET poeni -= (SELECT SUM(kolicina * cena_s_popustom) / 20 AS dodatni_poeni FROM transakcija 
									JOIN deleted ON trans_id = id_trans)
		WHERE kartica_id IN (SELECT id_kartice FROM transakcija JOIN deleted ON trans_id = id_trans)
	END

	CREATE TRIGGER racun_upd
	ON racun
	AFTER UPDATE
	AS
	BEGIN
		UPDATE obavljanje_transakcije SET cena_s_popustom =
		CASE
			WHEN tip_kartice = 3 THEN cena * 0.75
			WHEN tip_kartice = 1 AND podvrsta = 'bebi' THEN cena * 0.8
			WHEN tip_kartice = 2 AND lek = 1 AND DAY(GETDATE()) IN (13, 14, 15) THEN cena * 0.85
			ELSE cena 
		END
		WHERE racun_id IN (SELECT racun_id FROM inserted);

		UPDATE m SET u_magacinu = u_magacinu + kolicina
		FROM (SELECT u_magacinu, kolicina FROM magacin
		JOIN deleted ON magacin_id = id_magacina) m

		UPDATE kartica SET poeni -= (SELECT SUM(kolicina * cena_s_popustom) / 20 AS dodatni_poeni FROM transakcija 
									JOIN deleted ON trans_id = id_trans)
		WHERE kartica_id IN (SELECT id_kartice FROM transakcija JOIN deleted ON trans_id = id_trans)
		
		UPDATE m SET u_magacinu = u_magacinu - kolicina
		FROM (SELECT u_magacinu, kolicina FROM magacin
		JOIN inserted ON magacin_id = id_magacina) m

		UPDATE kartica SET poeni += (SELECT SUM(kolicina * cena_s_popustom) / 20 AS dodatni_poeni FROM transakcija 
									JOIN inserted ON trans_id = id_trans)
		WHERE kartica_id IN (SELECT id_kartice FROM transakcija JOIN inserted ON trans_id = id_trans)
	END
END

BEGIN /*TRIGGERI transakcija*/
	CREATE TRIGGER trans_ins
	ON transakcija
	AFTER INSERT
	AS
	BEGIN
		UPDATE kartica SET poeni -= (SELECT korisceni_poeni FROM inserted)
		WHERE kartica_id = (SELECT id_kartice FROM inserted)
	END

	CREATE TRIGGER trans_upd
	ON transakcija
	AFTER UPDATE
	AS
	BEGIN
		UPDATE racun SET id_trans = (SELECT trans_id FROM inserted)
		WHERE id_trans = (SELECT trans_id FROM inserted)
		
		UPDATE kartica SET poeni += (SELECT korisceni_poeni FROM deleted)
		WHERE kartica_id = (SELECT id_kartice FROM deleted) AND kartica_id IS NOT NULL
		
		UPDATE kartica SET poeni += COALESCE((SELECT SUM(kolicina * cena_s_popustom) / 20 AS dodatni_poeni FROM inserted
									JOIN racun ON trans_id = id_trans), 0)
		WHERE kartica_id IN (SELECT id_kartice FROM inserted) AND kartica_id IS NOT NULL
		
		UPDATE kartica SET poeni -= (SELECT korisceni_poeni FROM inserted)
		WHERE kartica_id = (SELECT id_kartice FROM inserted) AND kartica_id IS NOT NULL

		UPDATE kartica SET poeni -= COALESCE((SELECT SUM(kolicina * cena_s_popustom) / 20 AS dodatni_poeni FROM deleted
									JOIN racun ON trans_id = id_trans), 0)
		WHERE kartica_id IN (SELECT id_kartice FROM deleted) AND kartica_id IS NOT NULL
	END

	CREATE TRIGGER trans_del
	ON transakcija
	INSTEAD OF DELETE
	AS
	BEGIN
		UPDATE kartica SET poeni += (SELECT korisceni_poeni FROM deleted)
		WHERE kartica_id = (SELECT id_kartice FROM deleted)

		DELETE FROM racun WHERE id_trans IN (SELECT trans_id FROM deleted)

		DELETE FROM transakcija WHERE trans_id = (SELECT trans_id FROM deleted)
	END
END

BEGIN /*TRIGGER magacin*/
	CREATE TRIGGER magacin_del
	ON magacin
	AFTER DELETE
	AS
	BEGIN
		DELETE FROM dostava WHERE dostava_id NOT IN (SELECT id_dostave FROM magacin)
	END
END

BEGIN /*FUNKCIJE*/
	CREATE FUNCTION ukupni_racun(@trans_id INT)
	RETURNS FLOAT
	AS
	BEGIN
		RETURN ROUND((SELECT SUM(kolicina * cena_s_popustom) - SUM(korisceni_poeni) FROM obavljanje_transakcije WHERE trans_id = @trans_id), 0)
	END

	CREATE FUNCTION magacin_lokala(@lokal_id INT)
	RETURNS TABLE
	AS RETURN
	SELECT magacin_id, id_leka, naziv AS "Naziv leka", dostava.datum AS Dostavljeno, rok_trajanja AS "Rok trajanja", u_magacinu AS "Količina" 
	FROM magacin
	JOIN proizvod ON id_leka = proizvod_id
	LEFT JOIN dostava ON id_dostave = dostava_id
	WHERE id_lokala = @lokal_id AND (id_dostave IS NULL OR primljeno = 1)

	CREATE FUNCTION dostava_lokala(@lokal_id INT)
	RETURNS TABLE
	AS RETURN
	SELECT DISTINCT dostava_id, datum, primljeno
	FROM dostava
	LEFT JOIN magacin ON dostava_id = id_dostave
	WHERE id_lokala = @lokal_id

	CREATE FUNCTION podredjeni_zaposlenom(@zaposleni_id INT)
	RETURNS TABLE
	AS RETURN
	(WITH podredjeni AS (SELECT ime, prezime, email, uloga, zaposleni_id, id_lokala, id_menadzera 
					FROM zaposleni WHERE id_menadzera = @zaposleni_id

					UNION ALL

					SELECT zaposleni.ime, zaposleni.prezime, zaposleni.email, zaposleni.uloga, zaposleni.zaposleni_id, 
					zaposleni.id_lokala, zaposleni.id_menadzera 
					FROM podredjeni, zaposleni
					WHERE podredjeni.zaposleni_id = zaposleni.id_menadzera)
	SELECT podredjeni.*,
	CASE
		WHEN podredjeni.uloga = 0 THEN 'Vlasnik'
		WHEN podredjeni.uloga = 1 THEN 'Menadžer'
		WHEN podredjeni.uloga = 2 THEN 'Farmaceut'
		ELSE 'Farmaceutski tehničar'
	END AS "status",
	lokal.adresa AS "adresa lokala", zaposleni.ime + ' ' + zaposleni.prezime AS menadzer FROM podredjeni
	LEFT JOIN zaposleni ON podredjeni.id_menadzera = zaposleni.zaposleni_id
	LEFT JOIN lokal ON podredjeni.id_lokala = lokal_id)

	CREATE FUNCTION najnovija_dostava()
	RETURNS INT
	AS
	BEGIN
		DECLARE @najnoviji_id INT
		SELECT TOP 1 @najnoviji_id = dostava_id FROM dostava ORDER BY dostava_id DESC
		RETURN @najnoviji_id
	END

	CREATE FUNCTION najnovija_transakcija()
	RETURNS INT
	AS
	BEGIN
		DECLARE @najnoviji_id INT
		SELECT TOP 1 @najnoviji_id = trans_id FROM transakcija ORDER BY trans_id DESC
		RETURN @najnoviji_id
	END

	CREATE FUNCTION magacin_dostave(@dostava_id INT)
	RETURNS TABLE
	AS RETURN
	SELECT magacin_id, id_leka, naziv AS "Naziv leka", rok_trajanja AS "Rok trajanja", u_magacinu AS "Količina" 
	FROM magacin
	JOIN proizvod ON id_leka = proizvod_id
	JOIN dostava ON id_dostave = dostava_id
	WHERE id_dostave = @dostava_id

	CREATE FUNCTION racun_transakcije(@trans_id INT)
	RETURNS TABLE
	AS RETURN
	SELECT racun.racun_id, proizvod.naziv, proizvod.opis, racun.cena_s_popustom, racun.kolicina, id_magacina
	FROM racun
	JOIN magacin ON magacin_id = id_magacina
	JOIN proizvod ON proizvod_id = id_leka
	WHERE id_trans = @trans_id
END

BEGIN /*PROCEDURE*/
	CREATE PROCEDURE regulisi_magacin
	@lokal_id INT
	AS
	BEGIN
		UPDATE m SET u_magacinu = 0
		FROM (SELECT * FROM magacin
		LEFT JOIN dostava ON id_dostave = dostava_id) m
		WHERE (DATEDIFF(dd, rok_trajanja, GETDATE()) >= 0) AND id_lokala = @lokal_id AND (id_dostave IS NULL OR primljeno = 1)

		DELETE FROM magacin WHERE u_magacinu = 0 AND magacin_id IN (SELECT magacin_id FROM u_magacinu_bez_racuna) AND id_lokala = @lokal_id
	END

	CREATE PROCEDURE primi_dostave
	@lokal_id INT
	AS
	BEGIN
		UPDATE dostava SET primljeno = 1 WHERE (DATEDIFF(dd, datum, GETDATE()) >= 0) AND dostava_id IN (SELECT dostava_id FROM dbo.dostava_lokala(@lokal_id))
	END
END