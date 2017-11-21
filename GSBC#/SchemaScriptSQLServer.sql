/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: connexion
------------------------------------------------------------*/
CREATE TABLE connexion(
	login    VARCHAR (25) NOT NULL ,
	password VARCHAR (25)  ,
	CONSTRAINT prk_constraint_connexion PRIMARY KEY NONCLUSTERED (login)
);


/*------------------------------------------------------------
-- Table: Produits
------------------------------------------------------------*/
CREATE TABLE Produits(
	idProduit     INT IDENTITY (1,1) NOT NULL ,
	nomCommercial VARCHAR (25)  ,
	description   VARCHAR (100)  ,
	dosage        INT   ,
	effetThera    VARCHAR (50)  ,
	contreIndic   VARCHAR (50)  ,
	PrixHT        INT   ,
	idFamille     INT   ,
	CONSTRAINT prk_constraint_Produits PRIMARY KEY NONCLUSTERED (idProduit)
);


/*------------------------------------------------------------
-- Table: Praticiens
------------------------------------------------------------*/
CREATE TABLE Praticiens(
	idPraticien    INT IDENTITY (1,1) NOT NULL ,
	social         VARCHAR (25)  ,
	adresse        VARCHAR (50)  ,
	telephone      VARCHAR (10)  ,
	contact        VARCHAR (50)  ,
	coeffnoto      FLOAT   ,
	coeffconfiance FLOAT   ,
	idSpecialite   INT   ,
	CONSTRAINT prk_constraint_Praticiens PRIMARY KEY NONCLUSTERED (idPraticien)
);


/*------------------------------------------------------------
-- Table: Spécialité
------------------------------------------------------------*/
CREATE TABLE Specialite(
	idSpecialite INT IDENTITY (1,1) NOT NULL ,
	typeSpe      VARCHAR (30)  ,
	CONSTRAINT prk_constraint_Specialite PRIMARY KEY NONCLUSTERED (idSpecialite)
);


/*------------------------------------------------------------
-- Table: Visiteurs
------------------------------------------------------------*/
CREATE TABLE Visiteurs(
	idVisiteur   INT IDENTITY (1,1) NOT NULL ,
	nom          VARCHAR (30)  ,
	prenom       VARCHAR (30)  ,
	login        VARCHAR (25)  ,
	mdp          VARCHAR (25)  ,
	adresse      VARCHAR (50)  ,
	cp           VARCHAR (5)  ,
	ville        VARCHAR (25)  ,
	dateEmbauche DATETIME  ,
	idGeo        INT   ,
	CONSTRAINT prk_constraint_Visiteurs PRIMARY KEY NONCLUSTERED (idVisiteur)
);


/*------------------------------------------------------------
-- Table: SecteurGeo
------------------------------------------------------------*/
CREATE TABLE SecteurGeo(
	idGeo        INT IDENTITY (1,1) NOT NULL ,
	situationGeo VARCHAR (50)  ,
	CONSTRAINT prk_constraint_SecteurGeo PRIMARY KEY NONCLUSTERED (idGeo)
);


/*------------------------------------------------------------
-- Table: Famille
------------------------------------------------------------*/
CREATE TABLE Famille(
	idFamille   INT IDENTITY (1,1) NOT NULL ,
	typeFamille VARCHAR (30)  ,
	CONSTRAINT prk_constraint_Famille PRIMARY KEY NONCLUSTERED (idFamille)
);


/*------------------------------------------------------------
-- Table: Interaction
------------------------------------------------------------*/
CREATE TABLE Interaction(
	descriptioninteraction VARCHAR (25)  ,
	idProduit              INT  NOT NULL ,
	idProduit_Produits     INT  NOT NULL ,
	CONSTRAINT prk_constraint_Interaction PRIMARY KEY NONCLUSTERED (idProduit,idProduit_Produits)
);



ALTER TABLE Produits ADD CONSTRAINT FK_Produits_idFamille FOREIGN KEY (idFamille) REFERENCES Famille(idFamille);
ALTER TABLE Praticiens ADD CONSTRAINT FK_Praticiens_idSpecialite FOREIGN KEY (idSpecialite) REFERENCES Specialite(idSpecialite);
ALTER TABLE Visiteurs ADD CONSTRAINT FK_Visiteurs_idGeo FOREIGN KEY (idGeo) REFERENCES SecteurGeo(idGeo);
ALTER TABLE Interaction ADD CONSTRAINT FK_Interaction_idProduit FOREIGN KEY (idProduit) REFERENCES Produits(idProduit);
ALTER TABLE Interaction ADD CONSTRAINT FK_Interaction_idProduit_Produits FOREIGN KEY (idProduit_Produits) REFERENCES Produits(idProduit);
