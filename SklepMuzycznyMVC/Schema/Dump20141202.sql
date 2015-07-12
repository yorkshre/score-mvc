CREATE DATABASE  IF NOT EXISTS `szkola` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `szkola`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: szkola
-- ------------------------------------------------------
-- Server version	5.6.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `gatunek`
--

DROP TABLE IF EXISTS `gatunek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gatunek` (
  `idGatunku` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Opis` varchar(45) NOT NULL,
  PRIMARY KEY (`idGatunku`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gatunek`
--

LOCK TABLES `gatunek` WRITE;
/*!40000 ALTER TABLE `gatunek` DISABLE KEYS */;
INSERT INTO `gatunek` VALUES (1,'Rock','Mocne brzmienie z nutka lekkosci...'),(2,'Metal','Poczuj moc ognia...'),(3,'Pop','Jak sama nazwa wskazuje'),(4,'Jazz','Polaczenie roznych swiatow z pomoca jednego g'),(5,'Alternative','Muzyka moze byc dobra lub zla. Tutaj mamy do ');
/*!40000 ALTER TABLE `gatunek` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klient`
--

DROP TABLE IF EXISTS `klient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klient` (
  `idKlienta` int(4) NOT NULL,
  `Imie` varchar(25) NOT NULL,
  `Nazwisko` varchar(45) NOT NULL,
  `Telefon` int(9) NOT NULL,
  `Adres` varchar(90) NOT NULL,
  `Nr.konta` int(20) NOT NULL,
  PRIMARY KEY (`idKlienta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klient`
--

LOCK TABLES `klient` WRITE;
/*!40000 ALTER TABLE `klient` DISABLE KEYS */;
INSERT INTO `klient` VALUES (1,'Agata','Mala',721934098,'Mala 9/10 77-220 Miastko',2147483647),(2,'Karol','Bukek',345123789,'Chlebowo 3 77-200 Miastko',2147483647),(3,'Maria','Szymanska',743567890,'Czluchowska 8 77-220 Koczala',2147483647),(4,'Jerzy','Wrobel',786456098,'Sportowa 5 77-200 Kocza?a',1100050000),(5,'Anna','Misiolek',567432123,'Dzialkowa 6 77-220 Miastko',2147483647);
/*!40000 ALTER TABLE `klient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pracownicy`
--

DROP TABLE IF EXISTS `pracownicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pracownicy` (
  `idPracownika` int(3) NOT NULL,
  `Imie` varchar(25) NOT NULL,
  `Nazwisko` varchar(45) NOT NULL,
  `Stanowisko` varchar(45) NOT NULL,
  `Nr_telefonu` int(9) NOT NULL,
  PRIMARY KEY (`idPracownika`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pracownicy`
--

LOCK TABLES `pracownicy` WRITE;
/*!40000 ALTER TABLE `pracownicy` DISABLE KEYS */;
INSERT INTO `pracownicy` VALUES (1,'Mariusz','Fijalkowski','Sprzedawca',606147687),(2,'Dominik','Maska','Sprzedawca',789345098),(3,'Damian','Zych','Kierownik',567098345),(4,'Kamila','Kukielka','Sprzedawca',501023456),(5,'Monika','Micha?ek','Sprzedawca',506789456),(6,'Lukasz','Samolub','Sprzedawca',507456098),(7,'Agata','Zacierka','Sprzedawca',888934098);
/*!40000 ALTER TABLE `pracownicy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `towar`
--

DROP TABLE IF EXISTS `towar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `towar` (
  `idTowaru` int(4) NOT NULL,
  `idWykonawcy` int(4) NOT NULL,
  `idGatunku` int(11) NOT NULL,
  `Nazwa` varchar(25) NOT NULL,
  `Cena` int(11) NOT NULL,
  `Rok_wyd` date NOT NULL,
  `Ilosc_cd` int(11) NOT NULL,
  PRIMARY KEY (`idTowaru`),
  KEY `idwykonawcy_idx` (`idWykonawcy`),
  KEY `idgatunku_idx` (`idGatunku`),
  CONSTRAINT `idgatunku` FOREIGN KEY (`idGatunku`) REFERENCES `gatunek` (`idGatunku`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idwykonawcy` FOREIGN KEY (`idWykonawcy`) REFERENCES `wykonawca` (`idWykonawcy`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `towar`
--

LOCK TABLES `towar` WRITE;
/*!40000 ALTER TABLE `towar` DISABLE KEYS */;
INSERT INTO `towar` VALUES (1,1,1,'Brand New Day',30,'1999-09-24',30),(2,1,1,'The Last Ship',30,'2014-09-15',35),(3,3,1,'Reckless',30,'1984-11-05',15),(4,4,1,'Bare Bones',45,'2009-03-19',40),(5,5,1,'A Kind of Magic',34,'1986-06-02',16),(6,4,1,'Jagged  Little Pill',23,'1995-06-09',30),(7,2,1,'Reggatta de Blanc ',45,'1979-10-02',30),(8,6,2,'Master of Puppets',36,'1986-02-24',34),(9,6,2,'Metallica ',46,'1991-08-12',34),(10,6,2,'St.Anger',30,'2003-09-04',39),(11,6,2,'S&M',32,'1999-11-22',23),(12,7,5,'The 2nd Law',34,'2012-09-28',23),(13,7,5,'Black holes and Reveletio',35,'2006-09-28',12),(14,8,3,'Celebration',45,'2009-09-18',34),(15,8,3,'Erotica',24,'2009-09-18',12),(16,9,3,'Unapologetic',34,'1992-10-19',12),(17,10,5,'Hybrid Theory',37,'2012-11-19',13),(18,10,5,'The Hunting Party',51,'2000-10-24',45),(19,11,5,'Antichrist Superstar',34,'2014-06-13',34),(20,11,5,'Holy Wood ',32,'1996-10-08',12),(21,12,4,'Live at The Baked Potato',62,'2014-01-28',5),(22,13,4,'American Freedom',34,'1961-12-12',10),(23,14,4,'Ella Fitzgerald Sings the',12,'1956-06-12',10);
/*!40000 ALTER TABLE `towar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `towar_zamowienie`
--

DROP TABLE IF EXISTS `towar_zamowienie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `towar_zamowienie` (
  `idTowaru` int(4) NOT NULL,
  `idZamówienia` int(6) NOT NULL,
  `Ilość` int(10) NOT NULL,
  `Cena` int(11) NOT NULL,
  KEY `idtowaru_idx` (`idTowaru`),
  KEY `idzamowienia_idx` (`idZamówienia`),
  CONSTRAINT `idtowaru` FOREIGN KEY (`idTowaru`) REFERENCES `towar` (`idTowaru`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idzamowienia` FOREIGN KEY (`idZamówienia`) REFERENCES `zamowienia` (`idZamowienia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `towar_zamowienie`
--

LOCK TABLES `towar_zamowienie` WRITE;
/*!40000 ALTER TABLE `towar_zamowienie` DISABLE KEYS */;
INSERT INTO `towar_zamowienie` VALUES (1,1,1,30),(2,2,1,35),(3,3,1,15),(4,4,1,40),(5,5,3,16);
/*!40000 ALTER TABLE `towar_zamowienie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wykonawca`
--

DROP TABLE IF EXISTS `wykonawca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wykonawca` (
  `idWykonawcy` int(4) NOT NULL,
  `idWytwórni` int(4) NOT NULL,
  `Imie` varchar(25) NOT NULL,
  `Nazwisko` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idWykonawcy`),
  KEY `idwytworni_idx` (`idWytwórni`),
  CONSTRAINT `idwytworni` FOREIGN KEY (`idWytwórni`) REFERENCES `wytwornia` (`idWytworni`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wykonawca`
--

LOCK TABLES `wykonawca` WRITE;
/*!40000 ALTER TABLE `wykonawca` DISABLE KEYS */;
INSERT INTO `wykonawca` VALUES (1,5,'Sting',NULL),(2,1,'The Police',NULL),(3,1,'Bryan','Adams'),(4,7,'Alanis','Morissette'),(5,1,'Queen',NULL),(6,3,'Metallica',NULL),(7,5,'Muse',' '),(8,5,'Madonna',''),(9,2,'Rihanna',NULL),(10,2,'Linkin Park',NULL),(11,2,'Marilyn ','Manson'),(12,2,'Karizma',NULL),(13,2,'Luis','Armstrong'),(14,2,'Ella','Fitzgerald');
/*!40000 ALTER TABLE `wykonawca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wytwornia`
--

DROP TABLE IF EXISTS `wytwornia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wytwornia` (
  `idWytworni` int(4) NOT NULL,
  `Nazwa` varchar(45) NOT NULL,
  PRIMARY KEY (`idWytworni`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wytwornia`
--

LOCK TABLES `wytwornia` WRITE;
/*!40000 ALTER TABLE `wytwornia` DISABLE KEYS */;
INSERT INTO `wytwornia` VALUES (1,'A&M Records'),(2,'Universal'),(3,'Warner Bros. Records'),(4,'Megaforces records'),(5,'Moverick'),(6,'Sony Studio'),(7,'Warner'),(8,'EMI'),(9,'GOOD music');
/*!40000 ALTER TABLE `wytwornia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zamowienia`
--

DROP TABLE IF EXISTS `zamowienia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zamowienia` (
  `idZamowienia` int(6) NOT NULL,
  `idKlienta` int(4) NOT NULL,
  `idPracownika` int(4) NOT NULL,
  `Data` date NOT NULL,
  PRIMARY KEY (`idZamowienia`),
  KEY `idklienta_idx` (`idKlienta`),
  KEY `idpracownika_idx` (`idPracownika`),
  CONSTRAINT `idklienta` FOREIGN KEY (`idKlienta`) REFERENCES `klient` (`idKlienta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idpracownika` FOREIGN KEY (`idPracownika`) REFERENCES `pracownicy` (`idPracownika`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zamowienia`
--

LOCK TABLES `zamowienia` WRITE;
/*!40000 ALTER TABLE `zamowienia` DISABLE KEYS */;
INSERT INTO `zamowienia` VALUES (1,1,1,'2014-10-28'),(2,2,2,'2014-10-29'),(3,3,3,'2014-10-29'),(4,4,1,'2014-11-03'),(5,5,5,'2014-11-06');
/*!40000 ALTER TABLE `zamowienia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-12-02 15:41:37
