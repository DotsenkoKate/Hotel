CREATE DATABASE  IF NOT EXISTS `hotel_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `hotel_db`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: hotel_db
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `администратор`
--

DROP TABLE IF EXISTS `администратор`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `администратор` (
  `idАдминистратор` int unsigned NOT NULL AUTO_INCREMENT,
  `ФИО` varchar(100) NOT NULL,
  PRIMARY KEY (`idАдминистратор`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `администратор`
--

LOCK TABLES `администратор` WRITE;
/*!40000 ALTER TABLE `администратор` DISABLE KEYS */;
INSERT INTO `администратор` VALUES (1,'Гнусарева Анфиса Романовна'),(2,'Гершковича Азалия Анатолиевна '),(3,'Кочубей Бронислава Мефодиевна '),(4,'Янышева Оксана Михеевна '),(5,'Кузинкова Оксана Алексеевна '),(6,'Лещёва Виктория Федотовна '),(7,'Эвентова Влада Родионовна '),(8,'Кочерёжкина Вера Феликсовна '),(9,'Ярмольника Эльвира Марковна '),(10,'Жиренкова Кира Владиленовна ');
/*!40000 ALTER TABLE `администратор` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `бронь`
--

DROP TABLE IF EXISTS `бронь`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `бронь` (
  `idБронь` int unsigned NOT NULL AUTO_INCREMENT,
  `Кол-во гостей` int unsigned NOT NULL,
  `Дата начала` date NOT NULL,
  `Дата конца` date NOT NULL,
  `id категории` int unsigned NOT NULL,
  `id гостя` int unsigned NOT NULL,
  PRIMARY KEY (`idБронь`),
  KEY `id категории_idx` (`id категории`),
  KEY `id гостя_idx` (`id гостя`),
  KEY `Дата` (`Дата начала`),
  KEY `Кол-во гостей` (`Кол-во гостей`),
  CONSTRAINT `id гостя` FOREIGN KEY (`id гостя`) REFERENCES `гость` (`idГость`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `id категории` FOREIGN KEY (`id категории`) REFERENCES `категория номера` (`idКатегория номера`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `бронь`
--

LOCK TABLES `бронь` WRITE;
/*!40000 ALTER TABLE `бронь` DISABLE KEYS */;
INSERT INTO `бронь` VALUES (1,1,'2020-02-17','2020-02-18',1,1),(2,2,'2014-09-13','2014-09-20',1,3),(3,2,'2010-10-24','2010-10-28',1,2),(4,2,'2012-09-15','2012-09-20',3,4),(5,3,'2012-10-20','2012-10-25',3,6),(6,3,'2019-10-04','2019-10-10',2,5),(7,4,'2015-08-22','2015-08-31',4,9),(8,3,'2016-03-07','2016-03-15',2,8),(9,2,'2012-10-22','2012-10-29',1,7),(10,1,'2012-11-01','2012-11-09',2,10),(11,2,'2012-10-22','2012-10-23',3,1),(12,3,'2013-11-14','2013-11-24',3,15),(13,2,'2015-11-25','2015-11-26',2,21),(14,3,'2017-11-14','2017-11-24',3,12),(15,4,'2017-12-24','2017-12-26',4,13),(16,4,'2020-07-18','2020-07-19',5,14),(17,3,'2020-02-05','2020-02-10',6,15),(18,2,'2020-08-06','2020-08-10',7,16),(19,1,'2019-09-26','2019-09-28',8,17),(20,2,'2018-09-30','2018-10-03',9,18),(21,2,'2018-07-23','2018-07-24',10,19),(22,3,'2014-03-08','2014-03-15',3,20),(23,3,'2015-02-22','2015-02-25',3,21),(24,2,'2017-11-19','2017-11-27',3,22),(25,2,'2015-03-29','2015-03-30',3,23),(26,3,'2020-04-14','2020-04-15',3,25),(27,4,'2019-09-21','2019-09-25',3,25),(28,5,'2019-09-08','2019-09-12',2,29),(29,6,'2018-12-01','2018-12-09',2,27),(30,2,'2019-09-15','2019-09-16',2,28),(31,3,'2016-08-14','2016-08-16',2,29),(32,1,'2014-09-13','2014-09-18',2,30),(33,1,'2017-05-23','2017-05-24',2,31),(34,2,'2015-06-22','2015-06-25',2,32),(35,2,'2017-11-24','2017-11-27',2,33),(36,2,'2018-02-10','2018-02-18',2,34),(37,2,'2020-12-06','2020-12-10',2,35),(38,2,'2016-03-11','2016-03-14',1,36),(39,2,'2015-12-06','2015-12-06',1,37),(40,2,'2015-12-03','2015-12-03',1,38),(41,2,'2016-06-19','2016-06-19',1,39),(42,2,'2014-07-08','2014-07-08',1,40),(43,3,'2016-06-29','2016-06-29',1,41),(44,3,'2017-09-12','2017-09-12',1,42),(45,3,'2015-03-01','2015-03-01',1,43),(46,3,'2018-06-21','2018-06-21',3,44),(47,3,'2017-10-30','2017-10-30',2,45),(48,4,'2018-07-15','2018-07-15',7,46),(49,4,'2014-11-07','2014-11-07',7,47),(50,1,'2017-01-06','2017-01-06',7,48);
/*!40000 ALTER TABLE `бронь` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `горничная`
--

DROP TABLE IF EXISTS `горничная`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `горничная` (
  `idГорничная` int unsigned NOT NULL AUTO_INCREMENT,
  `ФИО` varchar(100) NOT NULL,
  PRIMARY KEY (`idГорничная`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `горничная`
--

LOCK TABLES `горничная` WRITE;
/*!40000 ALTER TABLE `горничная` DISABLE KEYS */;
INSERT INTO `горничная` VALUES (1,'Бобра Тамара Мефодьевна'),(2,'Ярлыкова Лидия Потаповна '),(3,'Крутелева Любовь Филипповна '),(4,'Курышина Инга Карповна '),(5,'Пирогова Пелагея Карповна '),(6,'Шульгина ﻿Агата Ефимовна '),(7,'Колбенева Анисья Олеговна '),(8,'Яковалева Бронислава Юлиевна '),(9,'Богомазова Светлана Николаевна '),(10,'Крюкова Регина Иосифовна ');
/*!40000 ALTER TABLE `горничная` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `гость`
--

DROP TABLE IF EXISTS `гость`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `гость` (
  `idГость` int unsigned NOT NULL AUTO_INCREMENT,
  `ФИО` varchar(100) NOT NULL,
  `Дата рождения` date NOT NULL,
  `Паспортные данные` varchar(255) NOT NULL,
  `Информация о прошлых заездах` varchar(255) DEFAULT NULL,
  `Привилегии` enum('+','-') NOT NULL,
  `Номер телефона` varchar(54) NOT NULL,
  PRIMARY KEY (`idГость`),
  KEY `ФИО` (`ФИО`)
) ENGINE=InnoDB AUTO_INCREMENT=339 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `гость`
--

LOCK TABLES `гость` WRITE;
/*!40000 ALTER TABLE `гость` DISABLE KEYS */;
INSERT INTO `гость` VALUES (1,'Липова Светлана Игоревна ','1984-10-31','4882 328020','2016.09.02','+','88005553535'),(2,'Чернаков Валентин Ефремович ','1973-07-10','4232 322140','','+','88585953835'),(3,'Панарина Жанна Марковна ','1985-10-06','2132 323220','','-','89061665568'),(4,'Янзинов Никифор Андронович ','1993-08-21','4274 744798','2012.12.30','-','89023869277'),(5,'Маслюка Антонина Тимофеевна ','1971-07-26','4887 487034','','-','89043483488'),(6,'Ярушин Валерий Ульянович ','1978-08-14','4861 167726','','+','89061665568'),(7,'Аршавин Артемий Юриевич ','1996-06-16','4889 390862','2020.07.14','+','86548020240'),(8,'Сукачёв Лев Никонович ','1981-05-28','4031 291366','','-','84055822220'),(9,'Веселкова Мария Ильевна ','1989-05-26','4795 481150','2013.08.13','-','85648712274'),(10,'Кошечкина Инесса Семеновна ','1974-05-16','4696 974704','','+','83052818307'),(11,'Козликов Петр Романович','1989-01-21','6897 687668','','-','81228499156'),(12,'Касьяненко Галина Данилевна ','1966-08-20','1212 123231','','-','80779686827'),(13,'Цельнер Всеволод Моисеевич ','1966-09-28','3245 321345','2020.12.17','+','89430077362'),(14,'Бялика Владислава Вячеславовна ','1967-07-20','1810 611823','2020.10.29','+','88391722517'),(15,'Выгузов Эдуард Прокофиевич ','1988-02-15','1234 34543','2018.05.20, 2012.04.23','+','84744712790'),(16,'Лагутов Якуб Евграфович ','1989-03-15','7765 234423','2017.01.11','+','84106490240'),(17,'Целобанова Агафья Иларионовна ','2000-03-12','4234 565454','','-','86351840527'),(18,'Дульцев Аскольд Макарович ','1964-12-14','1820 915900','','-','80292586499'),(19,'Чичерин Пахом Семенович ','1975-05-12','2423 453465','','-','80930366531'),(20,'Замятнин Адриан Денисович ','1998-01-21','4565 234234','2017.11.21','+','82235621037'),(21,'Марков Андрей Николаевич','1992-07-01','2132 342123','','-','89061662245'),(22,'Рафиков Адам Тихонович','2009-04-10','1234 542789','2012-12-05','+','84355822220'),(23,'Григолюка Ефросиния Ипполитовна','1966-02-11','2348 678345','2019-02-03','-','84055220543'),(24,'Бакаринцев Эдуард Ермолаевич','1986-04-12','2345 092004','','-','89072345676'),(25,'Тёмкина Василиса Константиновна','1976-01-03','1234 567532','','-','89065664789'),(26,'Канищева Елена Николаевна','1983-09-02','1820 981752',NULL,'-','89275415519'),(27,'Рафиков Адам Тихонович','2003-04-10','1234 542789','2012-12-05','+','84355822220'),(28,'Григолюка Ефросиния Ипполитовна','1966-02-11','2348 678345','2019-02-03','-','84055220543'),(29,'Бакаринцев Эдуард Ермолаевич','1986-04-12','2345 092004','','-','89072345676'),(30,'Тёмкина Василиса Константиновна','1976-01-03','1234 567532','','-','89065664789'),(31,'Панькива Анна Анатолиевна','1995-07-24','1653 187680','2020-02-03','+','74956586583'),(32,'Конаков Тихон Федосиевич','1983-06-08','1584 509239','','-','74954124606'),(33,'Устинов Святослав Адамович','1997-11-14','1515 830799','','-','74958737956'),(34,'Бояринова Зоя Родионовна','1961-06-12','1447 152358','2019-12-06','+','74956554419'),(35,'Лидин Давид Зиновиевич','1977-07-04','1378 473917','','-','74956771519'),(36,'Шушалев Ипполит Миронович','1985-11-04','1309 795477','','-','74953249211'),(37,'Коченков Леонид Вадимович','1979-10-08','1241 117036','','-','74958578141'),(38,'Николаенко Рада Глебовна','1988-05-04','1172 438595','','-','74950724815'),(39,'Язина Влада Ивановна','1977-02-24','1103 760154','','-','74959265355'),(40,'Ратаева Инга Юлиевна','1967-08-14','1035 081714','','-','74958960181'),(41,'Киреев Никита Никанорович','1993-12-19','1234 543534','2012-02-02','+','74211516255'),(42,'Щепетинникова Алина Трофимовна','1979-11-24','1234 543543','','-','74210660713'),(43,'Шостенко Лаврентий Саввевич','1998-12-21','3454 323423','','-','74215202551'),(44,'Болокана Бронислава Никитевна','1961-04-30','3423 543463','','-','74210348267'),(45,'Александрина Доминика Евгениевна','1970-09-09','5654 345345','','-','89096239577'),(46,'Бабинова Марфа Якововна','1967-01-11','4524 654326','','-','89099665374'),(47,'Юнге Осип Венедиктович','1997-11-11','3464 627542','','-','89094950033'),(48,'Богуна Анна Мефодиевна','1977-08-28','3253 521653','','-','89098209863'),(49,'Капустина Вероника Фомевна','1994-02-02','3242 251234','','-','89099644421'),(50,'Урусов Матвей Егорович','1997-05-08','1236 568782','','-','89098892531'),(338,'Варакин Петр Митрофанович','1985-06-15','213123  21221','','-','89087762245');
/*!40000 ALTER TABLE `гость` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `гость/выселение`
--

DROP TABLE IF EXISTS `гость/выселение`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `гость/выселение` (
  `idгость/выселение` int unsigned NOT NULL,
  `id гостя` int unsigned NOT NULL,
  `id записи о выселении` int unsigned NOT NULL,
  PRIMARY KEY (`idгость/выселение`),
  KEY `id_гость_idx` (`id гостя`),
  KEY `id_запись о выселении_idx` (`id записи о выселении`),
  CONSTRAINT `id_гость` FOREIGN KEY (`id гостя`) REFERENCES `гость` (`idГость`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `id_запись о выселении` FOREIGN KEY (`id записи о выселении`) REFERENCES `запись о выселении` (`idзапись о выселении`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `гость/выселение`
--

LOCK TABLES `гость/выселение` WRITE;
/*!40000 ALTER TABLE `гость/выселение` DISABLE KEYS */;
INSERT INTO `гость/выселение` VALUES (1,1,5),(2,2,4),(3,5,3),(4,4,10),(5,3,9),(6,6,7),(7,7,8),(8,8,1),(9,10,2),(10,9,6),(11,12,11),(12,44,12),(13,3,13),(14,6,14),(15,5,15),(16,4,16),(17,1,17),(18,3,18),(19,5,19),(20,2,20),(21,1,21),(22,5,22),(23,24,23),(24,23,24),(25,15,25),(26,24,26),(27,23,27),(28,25,28),(29,24,29),(30,28,30),(31,29,31),(32,31,32),(33,32,33),(34,38,34),(35,39,35),(36,38,36),(37,36,37),(38,35,38),(39,45,39),(40,41,40),(41,43,41),(42,44,42),(43,44,43),(44,45,44),(45,46,45),(46,47,46),(47,48,47),(48,49,48),(49,50,49),(50,11,50);
/*!40000 ALTER TABLE `гость/выселение` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `гость/заселение`
--

DROP TABLE IF EXISTS `гость/заселение`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `гость/заселение` (
  `idгость/заселение` int unsigned NOT NULL AUTO_INCREMENT,
  `гость` int unsigned NOT NULL,
  `запись о заселении` int unsigned NOT NULL,
  PRIMARY KEY (`idгость/заселение`),
  KEY `id гостя_idx` (`гость`),
  KEY `id записи о заселении_idx` (`запись о заселении`),
  CONSTRAINT `id_записи о заселении` FOREIGN KEY (`запись о заселении`) REFERENCES `запись о заселении` (`idЗапись о заселении`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `гость_id` FOREIGN KEY (`гость`) REFERENCES `гость` (`idГость`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `гость/заселение`
--

LOCK TABLES `гость/заселение` WRITE;
/*!40000 ALTER TABLE `гость/заселение` DISABLE KEYS */;
INSERT INTO `гость/заселение` VALUES (1,2,8),(2,1,10),(3,4,4),(4,3,1),(5,4,3),(6,6,7),(7,7,6),(8,8,5),(9,9,2),(10,10,9),(11,1,11),(12,2,12),(13,3,13),(14,35,14),(15,36,15),(16,37,16),(17,39,17),(18,38,18),(19,40,19),(20,41,20),(21,48,21),(22,49,22),(23,42,23),(24,45,24),(25,29,25),(26,23,26),(27,21,27),(28,27,28),(29,50,29),(30,1,30),(31,2,31),(32,20,32),(33,23,33),(34,34,34),(35,24,35),(36,8,36),(37,9,37),(38,13,38),(39,16,39),(40,18,40),(41,25,41),(42,5,42),(43,40,43),(44,49,44),(45,48,45),(46,3,46),(47,1,47),(48,31,48),(49,25,49),(50,36,50);
/*!40000 ALTER TABLE `гость/заселение` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `запись о выселении`
--

DROP TABLE IF EXISTS `запись о выселении`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `запись о выселении` (
  `idзапись о выселении` int unsigned NOT NULL AUTO_INCREMENT,
  `Комментарий` varchar(100) DEFAULT NULL,
  `Причина выселения` varchar(45) DEFAULT NULL,
  `Доп сумма к оплате` int DEFAULT NULL,
  `Дата выселения` date NOT NULL,
  `id администратора` int unsigned NOT NULL,
  PRIMARY KEY (`idзапись о выселении`),
  KEY `id администратора_idx` (`id администратора`),
  CONSTRAINT `id_администратора` FOREIGN KEY (`id администратора`) REFERENCES `администратор` (`idАдминистратор`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `запись о выселении`
--

LOCK TABLES `запись о выселении` WRITE;
/*!40000 ALTER TABLE `запись о выселении` DISABLE KEYS */;
INSERT INTO `запись о выселении` VALUES (1,NULL,NULL,NULL,'2019-10-06',2),(2,'Внесен в чс','Отказ оплаты минибара',4000,'2017-04-26',3),(3,NULL,NULL,1000,'2019-10-05',4),(4,'Внесен в чс','Драка',15000,'2019-07-25',5),(5,NULL,NULL,NULL,'2016-02-13',6),(6,NULL,NULL,1500,'2020-05-15',7),(7,'Уборка после питомца','Досрочный выезд',NULL,'2016-02-13',1),(8,NULL,NULL,NULL,'2015-06-24',2),(9,NULL,NULL,NULL,'2016-09-08',3),(10,NULL,NULL,2000,'2011-05-18',2),(11,NULL,'Отказ оплаты минибара',NULL,'2020-02-05',1),(12,NULL,NULL,NULL,'2020-02-05',2),(13,NULL,NULL,NULL,'2018-02-16',3),(14,'Уборка после питомца',NULL,NULL,'2016-05-21',4),(15,NULL,NULL,1000,'2009-08-14',5),(16,NULL,NULL,NULL,'2016-08-19',6),(17,NULL,NULL,2300,'2017-01-06',7),(18,'Уборка после питомца',NULL,NULL,'2012-08-14',8),(19,NULL,NULL,NULL,'2016-10-14',9),(20,NULL,NULL,NULL,'2020-05-21',10),(21,'Внесен в чс','Драка',5000,'2016-05-22',10),(22,NULL,NULL,NULL,'2016-08-17',9),(23,NULL,NULL,NULL,'2017-01-08',8),(24,NULL,NULL,NULL,'2017-03-06',5),(25,'Внесен в чс','Драка',NULL,'2017-11-06',7),(26,NULL,NULL,5000,'2015-03-29',6),(27,NULL,NULL,NULL,'2019-12-14',2),(28,NULL,NULL,NULL,'2019-03-14',4),(29,NULL,NULL,10000,'2020-03-14',3),(30,NULL,NULL,NULL,'2016-08-15',8),(31,'Внесен в чс','Отказ оплаты минибара',NULL,'2019-03-12',2),(32,NULL,NULL,NULL,'2019-03-31',1),(33,NULL,NULL,1000,'2016-08-14',2),(34,NULL,NULL,NULL,'2018-03-14',4),(35,NULL,NULL,NULL,'2013-03-15',5),(36,NULL,NULL,NULL,'2014-11-14',9),(37,'Внесен в чс','Отказ оплаты минибара',10000,'2018-11-30',8),(38,NULL,NULL,NULL,'2020-03-14',7),(39,NULL,NULL,2000,'2018-09-30',2),(40,NULL,NULL,NULL,'2017-01-06',10),(41,NULL,NULL,1500,'2018-09-30',2),(42,'Уборка после питомца',NULL,NULL,'2018-09-03',5),(43,NULL,NULL,NULL,'2020-09-30',4),(44,NULL,'Отказ оплаты минибара',NULL,'2020-01-06',6),(45,NULL,NULL,NULL,'2018-12-30',3),(46,NULL,NULL,NULL,'2019-08-07',5),(47,'Внесен в чс','Драка',15000,'2020-02-05',1),(48,NULL,NULL,NULL,'2017-01-06',5),(49,NULL,NULL,NULL,'2017-06-13',3),(50,'Уборка после питомца',NULL,1000,'2020-02-05',5),(51,NULL,NULL,NULL,'2020-02-05',2);
/*!40000 ALTER TABLE `запись о выселении` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `запись о заселении`
--

DROP TABLE IF EXISTS `запись о заселении`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `запись о заселении` (
  `idЗапись о заселении` int unsigned NOT NULL AUTO_INCREMENT,
  `Дата заезда` date NOT NULL,
  `Длительность проживания` int unsigned NOT NULL,
  `Есть ли домашние животнын` enum('есть','нет') NOT NULL,
  `Комментарий` varchar(100) DEFAULT NULL,
  `Кол-во гостей` int unsigned NOT NULL,
  `Способ оплаты` enum('карта','наличные') NOT NULL,
  `Номер` int unsigned NOT NULL,
  `id  админа` int unsigned NOT NULL,
  PRIMARY KEY (`idЗапись о заселении`),
  KEY `Номер_idx` (`Номер`),
  KEY `id администратора_idx` (`id  админа`),
  CONSTRAINT `id администратора` FOREIGN KEY (`id  админа`) REFERENCES `администратор` (`idАдминистратор`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `Номер` FOREIGN KEY (`Номер`) REFERENCES `номер` (`Номер`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `запись о заселении`
--

LOCK TABLES `запись о заселении` WRITE;
/*!40000 ALTER TABLE `запись о заселении` DISABLE KEYS */;
INSERT INTO `запись о заселении` VALUES (1,'2012-03-24',4,'нет','Доп подушка',2,'карта',1,2),(2,'2014-02-21',5,'есть',NULL,2,'наличные',2,4),(3,'2019-10-29',6,'есть',NULL,2,'карта',3,4),(4,'2020-02-29',7,'нет',NULL,3,'наличные',6,3),(5,'2015-05-01',8,'есть',NULL,4,'карта',5,4),(6,'2014-11-18',9,'нет','Уборка каждый день',3,'наличные',4,3),(7,'2018-11-30',10,'есть','Лоток для кота',3,'карта',7,10),(8,'2014-12-23',4,'нет',NULL,1,'наличные',8,2),(9,'2020-01-06',4,'нет','Чайник в номер',2,'карта',10,3),(10,'2020-02-06',2,'нет',NULL,1,'карта',10,5),(11,'2018-06-21',4,'нет',NULL,2,'наличные',11,1),(12,'2018-07-17',2,'нет',NULL,2,'наличные',23,2),(13,'2018-01-02',6,'нет',NULL,2,'наличные',2,3),(14,'2020-07-15',3,'нет',NULL,2,'карта',31,4),(15,'2019-07-15',7,'нет','Доп подушка',2,'карта',30,5),(16,'2018-06-15',8,'есть',NULL,3,'карта',14,6),(17,'2020-08-20',9,'есть',NULL,1,'карта',15,7),(18,'2018-12-15',10,'есть','Уборка каждый день',2,'карта',19,8),(19,'2019-06-11',11,'нет',NULL,1,'карта',18,10),(20,'2014-07-15',2,'нет',NULL,2,'карта',16,9),(21,'2015-08-15',5,'есть',NULL,1,'карта',20,4),(22,'2016-03-11',1,'есть',NULL,2,'карта',24,5),(23,'2020-05-15',3,'есть',NULL,1,'наличные',6,2),(24,'2020-05-15',5,'нет',NULL,2,'карта',2,3),(25,'2020-05-15',4,'нет',NULL,3,'карта',3,1),(26,'2020-05-16',8,'нет',NULL,1,'карта',24,4),(27,'2020-08-17',5,'нет',NULL,2,'наличные',23,5),(28,'2012-05-15',3,'нет',NULL,3,'карта',24,6),(29,'2013-05-15',5,'нет',NULL,5,'карта',10,8),(30,'2020-12-15',4,'нет',NULL,1,'карта',28,7),(31,'2020-09-14',5,'есть',NULL,4,'карта',15,9),(32,'2017-06-27',6,'есть','Уборка каждый день',2,'карта',3,6),(33,'2020-12-01',9,'нет',NULL,5,'наличные',14,2),(34,'2016-11-10',10,'нет','Доп подушка',2,'наличные',2,1),(35,'2016-11-10',11,'нет',NULL,3,'наличные',2,4),(36,'2016-11-12',14,'нет',NULL,1,'карта',3,5),(37,'2016-11-20',15,'нет',NULL,2,'наличные',4,6),(38,'2017-11-10',2,'есть',NULL,3,'карта',5,3),(39,'2016-12-10',6,'нет','Доп подушка',2,'наличные',31,1),(40,'2016-01-20',1,'нет','Уборка каждый день',1,'карта',8,4),(41,'2012-11-09',5,'есть',NULL,2,'наличные',19,5),(42,'2013-03-10',9,'нет',NULL,3,'карта',18,6),(43,'2020-12-10',4,'нет','Уборка каждый день',1,'наличные',17,3),(44,'2016-10-10',14,'нет',NULL,2,'карта',7,1),(45,'2012-03-16',6,'нет',NULL,3,'карта',8,4),(46,'2018-11-10',2,'нет','Уборка каждый день',3,'карта',9,5),(47,'2016-11-17',6,'нет',NULL,3,'наличные',10,2),(48,'2016-11-10',3,'нет',NULL,1,'карта',10,3),(49,'2014-11-10',4,'нет',NULL,3,'карта',1,1),(50,'2020-05-15',8,'есть',NULL,2,'наличные',2,4),(51,'2018-07-15',1,'нет','Доп подушка',2,'наличные',5,5),(52,'2020-05-15',1,'нет',NULL,3,'карта',3,2);
/*!40000 ALTER TABLE `запись о заселении` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `категория номера`
--

DROP TABLE IF EXISTS `категория номера`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `категория номера` (
  `idКатегория номера` int unsigned NOT NULL AUTO_INCREMENT,
  `Наименование` varchar(45) NOT NULL,
  `Кол-во мест без доп платы` tinyint unsigned NOT NULL,
  `Кол-во доп мест за доп платы` tinyint unsigned NOT NULL,
  PRIMARY KEY (`idКатегория номера`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `категория номера`
--

LOCK TABLES `категория номера` WRITE;
/*!40000 ALTER TABLE `категория номера` DISABLE KEYS */;
INSERT INTO `категория номера` VALUES (1,'Стандарт',1,1),(2,'Аппартаменты',1,1),(3,'Стандарт+',1,2),(4,'Семейный',2,1),(5,'Аппартаменты с бассейном',2,2),(6,'Люкс',1,2),(7,'Люкс+',2,2),(8,'Дюплекс',4,3),(9,'Президентский',5,3),(10,'Королевский',8,4);
/*!40000 ALTER TABLE `категория номера` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `набор особенностей`
--

DROP TABLE IF EXISTS `набор особенностей`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `набор особенностей` (
  `idНабор особенностей` int unsigned NOT NULL AUTO_INCREMENT,
  `Кухня` enum('есть','нет') NOT NULL,
  `Бассейн` enum('есть','нет') NOT NULL,
  `Ванная` enum('ванная','душ') NOT NULL,
  `Кондиционер` enum('есть','нет') NOT NULL,
  `Напольное покрытие` enum('плитка','ковролин') NOT NULL,
  `Вид` enum('на море','на сад','на улицу') NOT NULL,
  `Спальные места` enum('совместные','раздельные') NOT NULL,
  `Животные` enum('можно','нельзя') NOT NULL,
  PRIMARY KEY (`idНабор особенностей`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `набор особенностей`
--

LOCK TABLES `набор особенностей` WRITE;
/*!40000 ALTER TABLE `набор особенностей` DISABLE KEYS */;
INSERT INTO `набор особенностей` VALUES (1,'есть','есть','ванная','есть','ковролин','на море','совместные','можно'),(2,'нет','нет','душ','есть','ковролин','на улицу','совместные','нельзя'),(3,'нет','есть','ванная','есть','плитка','на море','раздельные','можно'),(4,'есть','нет','душ','есть','ковролин','на улицу','раздельные','можно'),(5,'нет','есть','ванная','есть','плитка','на море','раздельные','нельзя'),(6,'есть','нет','душ','есть','ковролин','на сад','совместные','можно'),(7,'нет','есть','душ','есть','плитка','на море','раздельные','нельзя'),(8,'есть','нет','ванная','есть','ковролин','на сад','раздельные','нельзя'),(9,'нет','есть','душ','нет','плитка','на море','совместные','можно'),(10,'есть','нет','ванная','есть','ковролин','на улицу','совместные','нельзя');
/*!40000 ALTER TABLE `набор особенностей` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `номер`
--

DROP TABLE IF EXISTS `номер`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `номер` (
  `Номер` int unsigned NOT NULL AUTO_INCREMENT,
  `Состояние` enum('на ремонте','готов','уборка','забронирован','другое') NOT NULL,
  `Цена за ночь` int unsigned NOT NULL,
  `Оценка номера` int unsigned NOT NULL,
  `id_набора особенностей` int unsigned NOT NULL,
  PRIMARY KEY (`Номер`),
  KEY `id набора_idx` (`id_набора особенностей`),
  KEY `Состояние` (`Состояние`),
  CONSTRAINT `id набора` FOREIGN KEY (`id_набора особенностей`) REFERENCES `набор особенностей` (`idНабор особенностей`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=325556 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `номер`
--

LOCK TABLES `номер` WRITE;
/*!40000 ALTER TABLE `номер` DISABLE KEYS */;
INSERT INTO `номер` VALUES (1,'на ремонте',1200,2,1),(2,'готов',1450,2,2),(3,'забронирован',1500,2,3),(4,'готов',2000,3,7),(5,'на ремонте',2400,4,5),(6,'готов',3000,5,6),(7,'уборка',3500,4,7),(8,'на ремонте',3700,5,8),(9,'уборка',4000,5,9),(10,'готов',20000,5,10),(11,'на ремонте',1500,2,4),(12,'готов',1000,4,5),(13,'готов',2000,5,6),(14,'на ремонте',6000,3,2),(15,'готов',6500,3,7),(16,'забронирован',5000,3,8),(17,'на ремонте',5100,2,2),(18,'уборка',3000,2,6),(19,'забронирован',7000,4,3),(20,'готов',1500,4,1),(21,'забронирован',1700,5,4),(22,'готов',3000,5,7),(23,'на ремонте',3100,5,8),(24,'уборка',3500,3,2),(25,'забронирован',1000,5,3),(26,'готов',1500,3,10),(27,'уборка',2000,3,1),(28,'на ремонте',2600,2,1),(29,'забронирован',2800,4,3),(30,'готов',2000,5,10),(31,'на ремонте',3000,2,2),(333,'уборка',2121,1,9);
/*!40000 ALTER TABLE `номер` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `номер/горничная`
--

DROP TABLE IF EXISTS `номер/горничная`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `номер/горничная` (
  `idНомер/горничная` int unsigned NOT NULL AUTO_INCREMENT,
  `id_номера` int unsigned NOT NULL,
  `id_горничной` int unsigned NOT NULL,
  PRIMARY KEY (`idНомер/горничная`),
  KEY `id_номера_idx` (`id_номера`),
  KEY `id_горничная_idx` (`id_горничной`),
  CONSTRAINT `id_горничная` FOREIGN KEY (`id_горничной`) REFERENCES `горничная` (`idГорничная`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `id_номер` FOREIGN KEY (`id_номера`) REFERENCES `номер` (`Номер`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `номер/горничная`
--

LOCK TABLES `номер/горничная` WRITE;
/*!40000 ALTER TABLE `номер/горничная` DISABLE KEYS */;
INSERT INTO `номер/горничная` VALUES (1,7,1),(2,10,4),(3,8,2),(4,1,4),(5,9,3),(6,3,6),(7,6,8),(8,2,7),(9,4,9),(10,5,10),(11,11,1),(12,12,2),(13,13,3),(14,14,5),(15,15,2),(16,16,5),(17,17,2),(18,18,4),(19,19,2),(20,20,3);
/*!40000 ALTER TABLE `номер/горничная` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `номер/категория`
--

DROP TABLE IF EXISTS `номер/категория`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `номер/категория` (
  `idномер/категория` int unsigned NOT NULL AUTO_INCREMENT,
  `id_категории` int unsigned NOT NULL,
  `id_номера` int unsigned NOT NULL,
  PRIMARY KEY (`idномер/категория`),
  KEY `id_номера_idx` (`id_номера`),
  KEY `id_категории_idx` (`id_категории`),
  CONSTRAINT `id_категории` FOREIGN KEY (`id_категории`) REFERENCES `категория номера` (`idКатегория номера`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `id_номера` FOREIGN KEY (`id_номера`) REFERENCES `номер` (`Номер`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `номер/категория`
--

LOCK TABLES `номер/категория` WRITE;
/*!40000 ALTER TABLE `номер/категория` DISABLE KEYS */;
INSERT INTO `номер/категория` VALUES (1,4,6),(2,2,9),(3,3,8),(4,6,7),(5,5,4),(6,7,1),(7,9,5),(8,10,3),(9,8,2),(10,1,10),(11,10,11),(12,10,12),(13,3,13),(14,4,14),(15,5,15),(16,8,16),(17,9,17),(18,7,18),(19,6,19),(20,3,20),(21,4,21),(22,5,22),(23,6,23),(24,1,24),(25,2,25),(26,3,26),(27,4,27),(28,8,28),(29,5,29),(30,6,30),(31,9,31);
/*!40000 ALTER TABLE `номер/категория` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `номера`
--

DROP TABLE IF EXISTS `номера`;
/*!50001 DROP VIEW IF EXISTS `номера`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `номера` AS SELECT 
 1 AS `Номер`,
 1 AS `Наименование`,
 1 AS `Цена за ночь`,
 1 AS `Оценка номера`,
 1 AS `Кухня`,
 1 AS `Бассейн`,
 1 AS `Ванная`,
 1 AS `Кондиционер`,
 1 AS `Напольное покрытие`,
 1 AS `Вид`,
 1 AS `Спальные места`,
 1 AS `Животные`,
 1 AS `Кол-во мест без доп платы`,
 1 AS `Кол-во доп мест за доп платы`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `самые свежие брони`
--

DROP TABLE IF EXISTS `самые свежие брони`;
/*!50001 DROP VIEW IF EXISTS `самые свежие брони`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `самые свежие брони` AS SELECT 
 1 AS `idБронь`,
 1 AS `Кол-во гостей`,
 1 AS `Дата начала`,
 1 AS `Дата конца`,
 1 AS `ФИО`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `черный список`
--

DROP TABLE IF EXISTS `черный список`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `черный список` (
  `Причина` varchar(100) NOT NULL,
  `id_гостя` int unsigned NOT NULL,
  PRIMARY KEY (`id_гостя`),
  KEY `id_гостя_idx` (`id_гостя`),
  CONSTRAINT `id_гостя` FOREIGN KEY (`id_гостя`) REFERENCES `гость` (`idГость`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `черный список`
--

LOCK TABLES `черный список` WRITE;
/*!40000 ALTER TABLE `черный список` DISABLE KEYS */;
INSERT INTO `черный список` VALUES ('Драка',1),('Порча иммущества',2),('Драка',3),('Порча иммущества',4),('Драка',5),('Порча иммущества',6),('Порча иммущества  (холодильник в номере)',7),('Драка',8),('Порча иммущества',9),('Драка',10),('Домогательство до соседок',11),('Драка',17),('Драка',18),('Драка',23),('Драка',25),('Порча иммущества',50);
/*!40000 ALTER TABLE `черный список` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'hotel_db'
--
/*!50003 DROP FUNCTION IF EXISTS `CountPribil` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CountPribil`(num INT) RETURNS varchar(100) CHARSET utf8mb4
    READS SQL DATA
    DETERMINISTIC
BEGIN
	DECLARE isFound VARCHAR(45) default 'Номер не принес прибыли';
    DECLARE counter int default 0;
	
    SELECT SUM(`Длительность проживания`*`Цена за ночь`) INTO counter 
    FROM `номер`
    JOIN  `запись о заселении`
    ON `запись о заселении`.`Номер`=`номер`.`Номер`
    WHERE `номер`.`Номер` = num ;
    
	IF counter > 0
		THEN SET isFound=CONCAT('Номер',' ', num,' ','принес',' ',counter,' ','рублей');
    END IF;
    RETURN isFound;
    
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `HouseKeeping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `HouseKeeping`(nameHKM VARCHAR(255)) RETURNS varchar(255) CHARSET utf8mb4
    READS SQL DATA
    DETERMINISTIC
BEGIN
	DECLARE CHECKHKP VARCHAR(255) default 'Нет данных';
    DECLARE counter int default 0;
    
    SELECT COUNT(*) INTO counter 
    FROM `горничная`
	JOIN  `номер/горничная`
    ON `номер/горничная`.`id_горничной`=`горничная`.`idГорничная`
    WHERE `горничная`.`ФИО` LIKE nameHKM ;
    IF counter > 0
		THEN    
        SET CHECKHKP=CONCAT('Количество номеров, закрепленных за данной горничной = ',counter);
    END IF;
    RETURN CHECKHKP;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `Privilegii` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `Privilegii`() RETURNS varchar(255) CHARSET utf8mb4
    READS SQL DATA
    DETERMINISTIC
BEGIN
	DECLARE isFound VARCHAR(45) default 'Нет привилегий';
    DECLARE counter int default 0;
    
    SELECT COUNT(*) INTO counter 
    FROM `гость/заселение`
    GROUP BY `гость`
    ORDER BY count(*) DESC;
    IF counter > 0
		THEN SET isFound=CONCAT('Найдено',' ',counter);
    END IF;
    RETURN isFound;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `SearchForGuest` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `SearchForGuest`(nameforsearch VARCHAR(255)) RETURNS varchar(255) CHARSET utf8mb4
    READS SQL DATA
    DETERMINISTIC
BEGIN
	DECLARE isFound VARCHAR(45) default 'Не найдено';
    DECLARE counter int default 0;
    
    SELECT COUNT(*) INTO counter 
    FROM `гость`
    WHERE `гость`.`ФИО` LIKE nameforsearch;
    IF counter > 0
		THEN SET isFound=CONCAT('Найдено',' ',counter);
    END IF;
    RETURN isFound;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `SearchForNum` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `SearchForNum`(State VARCHAR (50), Price INT, Pets VARCHAR (25), vid VARCHAR (25)) RETURNS varchar(255) CHARSET utf8mb4
    READS SQL DATA
    DETERMINISTIC
BEGIN
	DECLARE isFound VARCHAR(45) default 'Не найдено';
    DECLARE counter int default 0;
    
    SELECT COUNT(*) INTO counter 
    FROM `номер`
    JOIN  `набор особенностей`
    ON `номер`.`id_набора особенностей`=`набор особенностей`.`idНабор особенностей`
    WHERE `номер`.`состояние` LIKE State and `номер`.`Цена за ночь` < Price and
    `набор особенностей`.`Животные` LIKE Pets and `набор особенностей`.`вид` LIKE vid ;
    IF counter > 0
		THEN SET isFound=CONCAT('Найдено',' ',counter);
    END IF;
    RETURN isFound;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ages` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ages`(IN a int)
    READS SQL DATA
    DETERMINISTIC
BEGIN
	SELECT `ФИО`,(YEAR(CURRENT_DATE) - YEAR(`Дата рождения`)) -                         
    (DATE_FORMAT(CURRENT_DATE, '%m%d') < DATE_FORMAT(`Дата рождения`, '%m%d')) 
	AS Возраст
    FROM `гость` 
    WHERE ((YEAR(CURRENT_DATE) - YEAR(`Дата рождения`)) -                         
    (DATE_FORMAT(CURRENT_DATE, '%m%d') < DATE_FORMAT(`Дата рождения`, '%m%d'))) >=a;
        END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Blacklist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Blacklist`()
    READS SQL DATA
    DETERMINISTIC
BEGIN
	SELECT `ФИО`,`Причина`
    FROM `гость` 
    JOIN `черный список`
    ON `черный список`.`id_гостя`=`гость`.`idГость`;
    END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `free` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `free`(sostoyanie varchar(255))
    READS SQL DATA
    DETERMINISTIC
BEGIN
	SELECT * FROM `номер`
	WHERE `Состояние`= sostoyanie;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `номера`
--

/*!50001 DROP VIEW IF EXISTS `номера`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `номера` AS select `номер`.`Номер` AS `Номер`,`категория номера`.`Наименование` AS `Наименование`,`номер`.`Цена за ночь` AS `Цена за ночь`,`номер`.`Оценка номера` AS `Оценка номера`,`набор особенностей`.`Кухня` AS `Кухня`,`набор особенностей`.`Бассейн` AS `Бассейн`,`набор особенностей`.`Ванная` AS `Ванная`,`набор особенностей`.`Кондиционер` AS `Кондиционер`,`набор особенностей`.`Напольное покрытие` AS `Напольное покрытие`,`набор особенностей`.`Вид` AS `Вид`,`набор особенностей`.`Спальные места` AS `Спальные места`,`набор особенностей`.`Животные` AS `Животные`,`категория номера`.`Кол-во мест без доп платы` AS `Кол-во мест без доп платы`,`категория номера`.`Кол-во доп мест за доп платы` AS `Кол-во доп мест за доп платы` from (((`номер` join `номер/категория` on((`номер`.`Номер` = `номер/категория`.`id_номера`))) join `категория номера` on((`номер/категория`.`id_категории` = `категория номера`.`idКатегория номера`))) join `набор особенностей` on((`набор особенностей`.`idНабор особенностей` = `номер`.`id_набора особенностей`))) where ((`номер`.`Состояние` = 'готов') and (`категория номера`.`Кол-во мест без доп платы` >= 4)) order by `номер`.`Цена за ночь` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `самые свежие брони`
--

/*!50001 DROP VIEW IF EXISTS `самые свежие брони`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `самые свежие брони` AS select `бронь`.`idБронь` AS `idБронь`,`бронь`.`Кол-во гостей` AS `Кол-во гостей`,`бронь`.`Дата начала` AS `Дата начала`,`бронь`.`Дата конца` AS `Дата конца`,`гость`.`ФИО` AS `ФИО` from (`бронь` join `гость` on((`бронь`.`id гостя` = `гость`.`idГость`))) order by `бронь`.`Дата начала` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-29 21:26:25
