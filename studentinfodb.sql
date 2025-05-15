CREATE DATABASE  IF NOT EXISTS `studentinfodb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `studentinfodb`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: studentinfodb
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `courses`
--

CREATE DATABASE IF NOT EXISTS studentinfodb;

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses` (
  `course_id` int NOT NULL,
  `course_name` varchar(100) DEFAULT NULL,
  `department_id` int DEFAULT NULL,
  PRIMARY KEY (`course_id`),
  KEY `department_id` (`department_id`),
  CONSTRAINT `courses_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `departments` (`department_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (1,'BS Information Technology',1),(2,'BS Computer Science',6),(3,'BS BIOLOGY',4),(4,'BS Chemistry',5),(5,'BS Electrical Engineering',3),(6,'BS Economics',7),(7,'BS Psychology',8),(8,'BS Nursing',9),(9,'BS Sport Science',2),(10,'BS Literature',10);
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departments` (
  `department_id` int NOT NULL,
  `department_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`department_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'Information Technology Department'),(2,'Sport Department'),(3,'Engineering Department'),(4,'Biology Department'),(5,'Chemistry Department'),(6,'Computer Science Department'),(7,'Economics Department'),(8,'Psychology Department'),(9,'Nursing Department'),(10,'Literature Department');
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enrollment_fees`
--

DROP TABLE IF EXISTS `enrollment_fees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enrollment_fees` (
  `enrollment_id` int NOT NULL AUTO_INCREMENT,
  `student_id` int DEFAULT NULL,
  `year_lvl` int DEFAULT NULL,
  `first_sem_fee` float DEFAULT NULL,
  `second_sem_fee` float DEFAULT NULL,
  `other_fee` float DEFAULT NULL,
  PRIMARY KEY (`enrollment_id`),
  KEY `student_fk1` (`student_id`),
  CONSTRAINT `student_fk1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrollment_fees`
--

LOCK TABLES `enrollment_fees` WRITE;
/*!40000 ALTER TABLE `enrollment_fees` DISABLE KEYS */;
INSERT INTO `enrollment_fees` VALUES (1,1,4,1000,1000,1000),(2,1,3,1000,1000,1000),(3,1,2,1000,1000,1000),(4,2,1,1000,1000,400),(5,3,1,1000,1000,350),(6,3,2,1000,1000,350),(7,22,1,1000,1000,300),(8,22,2,1000,1000,300),(9,18,1,1000,1000,300),(10,18,2,1000,1000,300),(11,4,1,200,300,100),(12,4,1,200,300,100),(13,4,2,100,100,100),(14,5,3,500,400,20),(15,12,1,200,200,200),(16,1,1,1000,1000,1000),(17,3,3,500,500,500),(19,22,3,500,500,500);
/*!40000 ALTER TABLE `enrollment_fees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enrollment_fees_archive`
--

DROP TABLE IF EXISTS `enrollment_fees_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enrollment_fees_archive` (
  `archive_id` int NOT NULL AUTO_INCREMENT,
  `student_id` int NOT NULL,
  `first_sem_fee` decimal(10,2) DEFAULT NULL,
  `second_sem_fee` decimal(10,2) DEFAULT NULL,
  `other_fee` decimal(10,2) DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrollment_fees_archive`
--

LOCK TABLES `enrollment_fees_archive` WRITE;
/*!40000 ALTER TABLE `enrollment_fees_archive` DISABLE KEYS */;
INSERT INTO `enrollment_fees_archive` VALUES (2,4,0.00,0.00,300.00,'2025-03-22 07:00:06'),(3,3,100.00,100.00,100.00,'2025-05-15 00:32:53');
/*!40000 ALTER TABLE `enrollment_fees_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enrollment_fees_log`
--

DROP TABLE IF EXISTS `enrollment_fees_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enrollment_fees_log` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `student_id` int NOT NULL,
  `first_sem_fee` decimal(10,2) DEFAULT NULL,
  `second_sem_fee` decimal(10,2) DEFAULT NULL,
  `other_fee` decimal(10,2) DEFAULT NULL,
  `changed_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrollment_fees_log`
--

LOCK TABLES `enrollment_fees_log` WRITE;
/*!40000 ALTER TABLE `enrollment_fees_log` DISABLE KEYS */;
INSERT INTO `enrollment_fees_log` VALUES (2,4,0.00,0.00,0.00,'2025-03-22 06:54:16'),(3,5,2555.00,400.00,50.00,'2025-05-08 10:10:03'),(4,5,500.00,400.00,50.00,'2025-05-08 10:14:43'),(5,5,500.00,400.00,566.00,'2025-05-08 10:16:15'),(6,5,500.00,400.00,100.00,'2025-05-08 10:16:53'),(7,5,500.00,400.00,50.00,'2025-05-08 10:24:35'),(8,5,500.00,400.00,100.00,'2025-05-08 10:29:46'),(9,5,500.00,400.00,50.00,'2025-05-08 10:30:45'),(10,5,500.00,400.00,10.00,'2025-05-08 10:35:31'),(11,12,100.00,100.00,100.00,'2025-05-09 14:36:39'),(12,1,1000.00,1000.00,300.00,'2025-05-09 14:45:43'),(13,1,1000.00,1000.00,300.00,'2025-05-09 14:45:43'),(14,1,1000.00,1000.00,1200.00,'2025-05-09 14:45:43'),(15,1,1000.00,1000.00,1000.00,'2025-05-09 14:55:04'),(16,1,1000.00,1000.00,1000.00,'2025-05-09 14:55:04');
/*!40000 ALTER TABLE `enrollment_fees_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evaluation`
--

DROP TABLE IF EXISTS `evaluation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evaluation` (
  `evaluation_id` int NOT NULL,
  `student_id` int DEFAULT NULL,
  `instructor_id` int DEFAULT NULL,
  `comments` text,
  `subject_id` int DEFAULT NULL,
  `Rate` int DEFAULT NULL,
  PRIMARY KEY (`evaluation_id`),
  KEY `student_id` (`student_id`),
  KEY `instructor_id` (`instructor_id`),
  KEY `fk_subject` (`subject_id`),
  CONSTRAINT `evaluation_ibfk_2` FOREIGN KEY (`instructor_id`) REFERENCES `instructors` (`instructor_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_students` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  CONSTRAINT `fk_subject` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evaluation`
--

LOCK TABLES `evaluation` WRITE;
/*!40000 ALTER TABLE `evaluation` DISABLE KEYS */;
INSERT INTO `evaluation` VALUES (1,1,1,'Great course, learned a lot!',1,4),(2,1,3,'Difficult material but engaging.',3,5),(3,1,2,'Very clear explanations.',2,5),(4,1,4,'The course was well-structured.',4,4),(5,1,5,'I found it hard to keep up with the lectures.',5,4),(6,1,1,'Interesting and insightful discussions.',6,3),(7,1,1,'The class was interactive and fun.',7,3),(8,8,8,'A bit boring but informative.',64,5),(9,9,9,'Excellent content and delivery.',36,4),(10,10,10,'The assignments were challenging but helpful.',35,3);
/*!40000 ALTER TABLE `evaluation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grades`
--

DROP TABLE IF EXISTS `grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grades` (
  `grade_id` int NOT NULL AUTO_INCREMENT,
  `student_id` int DEFAULT NULL,
  `subject_id` int DEFAULT NULL,
  `grade` float DEFAULT NULL,
  PRIMARY KEY (`grade_id`),
  KEY `student_id` (`student_id`),
  KEY `subject_id` (`subject_id`),
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `grades_ibk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=190 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
INSERT INTO `grades` VALUES (1,1,1,1.9),(2,1,2,2.3),(3,1,3,1.5),(4,1,4,1.9),(5,1,5,2),(6,1,6,2.1),(7,1,7,1.2),(8,2,8,1.5),(9,2,9,2.6),(10,2,10,2.1),(11,2,11,1.3),(12,2,12,2.3),(13,2,13,1.6),(14,2,14,1.8),(15,2,15,2.2),(16,3,16,1.2),(17,3,17,1.4),(18,3,18,1.5),(19,3,19,2.4),(20,3,20,2.7),(21,3,21,2.2),(22,3,22,1.4),(23,4,1,1.9),(24,4,2,2.3),(25,4,3,2.4),(26,4,4,2.6),(27,4,5,1.1),(28,4,6,1.2),(29,4,7,1.5),(30,5,16,1.6),(31,5,17,1.1),(32,5,18,1.2),(33,5,19,1.3),(34,5,20,1.4),(35,5,21,1.5),(36,5,22,1.6),(37,6,8,1.7),(38,6,9,1.8),(39,6,10,1.9),(40,6,11,2.1),(41,6,12,2.2),(42,6,13,2.3),(43,6,14,2.5),(44,6,15,2.4),(45,7,30,1.2),(46,7,31,1.5),(47,7,32,1.6),(48,7,33,1.9),(49,7,34,2.3),(50,7,35,2.6),(51,7,36,1.3),(52,8,23,1.5),(53,8,24,1.7),(54,8,25,2.5),(55,8,26,2.9),(56,8,27,1.2),(57,8,28,1.6),(58,8,29,1.8),(59,9,37,1.3),(60,9,38,2),(61,9,39,2.3),(62,9,40,2.6),(63,9,41,1.6),(64,9,42,1.7),(65,9,43,1.9),(66,10,44,2.5),(67,10,45,1.2),(68,10,46,1.1),(69,10,47,1.9),(70,10,48,2.7),(71,10,49,2.3),(72,10,50,1.2),(73,11,37,1.5),(74,11,38,1.6),(75,11,39,1.8),(76,11,40,1.3),(77,11,41,1.5),(78,11,42,1.6),(79,11,43,2.5),(80,12,30,1.7),(81,12,31,2.3),(82,12,32,1.5),(83,12,33,2),(84,12,34,1.8),(85,12,35,2.7),(86,12,36,1.6),(87,13,23,2.1),(88,13,24,1.9),(89,13,25,2.5),(90,13,26,1.4),(91,13,27,2.8),(92,13,28,1.2),(93,13,29,2.3),(94,14,44,1.6),(95,14,45,2.7),(96,14,46,2),(97,14,47,1.9),(98,14,48,1.5),(99,14,49,2.4),(100,14,50,1.8),(101,15,58,1.3),(102,15,59,2.9),(103,15,60,1.7),(104,15,61,2.1),(105,15,62,1.4),(106,15,63,2.5),(107,15,64,1.9),(108,16,37,2),(109,16,38,1.6),(110,16,39,2.8),(111,16,40,1.2),(112,16,41,2.3),(113,16,42,1.7),(114,16,43,2.6),(115,17,51,1.5),(116,17,52,2.2),(117,17,53,1.9),(118,17,54,2.7),(119,17,55,1.3),(120,17,56,2.4),(121,17,57,1.8),(122,18,1,2.5),(123,18,2,1.6),(124,18,3,2.1),(125,18,4,1.9),(126,18,5,2),(127,18,6,1.4),(128,18,7,2.3),(129,19,51,1.7),(130,19,52,2.6),(131,19,53,1.5),(132,19,54,2.8),(133,19,55,1.3),(134,19,56,2.2),(135,19,57,1.9),(136,20,58,2),(137,20,59,1.6),(138,20,60,2.4),(139,20,61,1.5),(140,20,62,2.7),(141,20,63,1.3),(142,20,64,2.5),(143,21,65,1.8),(144,21,66,2.2),(145,21,67,1.4),(146,21,68,2.9),(147,21,69,1.6),(148,21,70,2.3),(149,21,71,1.7),(150,22,1,2.1),(151,22,2,1.5),(152,22,3,2.8),(153,22,4,1.4),(154,22,5,2.6),(155,22,6,1.9),(156,22,7,2.3),(157,23,16,1.7),(158,23,17,2.5),(159,23,18,1.3),(160,23,19,2.2),(161,23,20,1.9),(162,23,21,2),(163,23,22,1.6),(164,24,1,2.4),(165,24,2,1.8),(166,24,3,2.7),(167,24,4,1.3),(168,24,5,2.5),(169,24,6,1.9),(170,24,7,2.1),(171,25,1,1.6),(172,25,2,2.9),(173,25,3,1.7),(174,25,4,2.3),(175,25,5,1.5),(176,25,6,2.6),(177,25,7,1.4),(178,26,1,2.2),(179,26,2,1.5),(180,26,3,2),(181,26,4,1.8),(182,26,5,2.5),(183,26,6,1.6),(184,26,7,2.7),(185,30,70,1.2),(186,3,1,0),(187,28,54,1.2),(188,30,66,1.5),(189,4,7,1.2);
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `instructors`
--

DROP TABLE IF EXISTS `instructors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `instructors` (
  `instructor_id` int NOT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `department_id` int DEFAULT NULL,
  PRIMARY KEY (`instructor_id`),
  KEY `department_id` (`department_id`),
  CONSTRAINT `instructors_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `departments` (`department_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `instructors`
--

LOCK TABLES `instructors` WRITE;
/*!40000 ALTER TABLE `instructors` DISABLE KEYS */;
INSERT INTO `instructors` VALUES (1,'Dr. Alice','Bond',1),(2,'Prof. Bob','Jones',1),(3,'Dr. Carol','Martinez',1),(4,'Prof. Daniel','Garcia',1),(5,'Dr. Emily','Rodriguez',1),(6,'Prof. Frank','Hernandez',2),(7,'Dr. Grace','Lopez',2),(8,'Prof. Henry','Scott',2),(9,'Dr. Ivy','Adams',3),(10,'Prof. Jack','Baker',3),(11,'Dr.Jerome','Sentavo',3),(12,'Dr. Jake','Pogi',4),(13,'Dr. Amelia','Rodriguez',4),(14,'Dr. Eduardo','Torres',4),(15,'Dr. Daniel','Fernandez',5),(16,'Dr. Angela','Morales',5),(17,'Dr. Roberto','Castillo',5),(18,'Dr. Nathan','Villanueva',6),(19,'Dr. Miguel','Reyes',6),(20,'Dr. Patricia','Mendoza',6),(21,'Dr. Sophia','Cruz',7),(22,'Dr. Victoria','Gonzalez',7),(23,'Dr. Carlos','Dela Cruz',7),(24,'Dr. Isabel','Santos',8),(25,'Dr. Elena','Garcia',8),(26,'Dr. Antonio','Ramos',8),(27,'Dr. Beatriz','Lopez',9),(28,'Dr. Samuel','Bautista',9),(29,'Dr. Cristina','Flores',9),(30,'Dr. Victor','Navarro',10),(31,'Dr. Maria','Ortega',10),(32,'Dr. Fernando','Hernandez',10),(33,'Dr. Julia','Martinez',2),(34,'Dr. Raymond','Aguilar',3),(35,'Dr. Sabrina','Velasquez',10),(36,'Dr. Ernesto','Delos Reyes',9),(37,'Dr. Bianca','Mendoza',8),(38,'Dr. Luis','Salvador',7),(39,'Dr. Teresa','Alvarez',6),(40,'Dr. Adrian','Dominguez',4),(41,'Dr. Marissa','Fuentes',6);
/*!40000 ALTER TABLE `instructors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `it_instructors`
--

DROP TABLE IF EXISTS `it_instructors`;
/*!50001 DROP VIEW IF EXISTS `it_instructors`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `it_instructors` AS SELECT 
 1 AS `first_name`,
 1 AS `last_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `it_subjects`
--

DROP TABLE IF EXISTS `it_subjects`;
/*!50001 DROP VIEW IF EXISTS `it_subjects`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `it_subjects` AS SELECT 
 1 AS `subject_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `student_grades`
--

DROP TABLE IF EXISTS `student_grades`;
/*!50001 DROP VIEW IF EXISTS `student_grades`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `student_grades` AS SELECT 
 1 AS `student_id`,
 1 AS `last_name`,
 1 AS `first_name`,
 1 AS `subject_name`,
 1 AS `grade`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `student_informations`
--

DROP TABLE IF EXISTS `student_informations`;
/*!50001 DROP VIEW IF EXISTS `student_informations`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `student_informations` AS SELECT 
 1 AS `ID`,
 1 AS `Last Name`,
 1 AS `First Name`,
 1 AS `Course`,
 1 AS `Year Level`,
 1 AS `DEPARTMENT`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `student_totalpayments`
--

DROP TABLE IF EXISTS `student_totalpayments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student_totalpayments` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `student_id` int DEFAULT NULL,
  `total_payment` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `students_fk1` (`student_id`),
  CONSTRAINT `students_fk1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_totalpayments`
--

LOCK TABLES `student_totalpayments` WRITE;
/*!40000 ALTER TABLE `student_totalpayments` DISABLE KEYS */;
INSERT INTO `student_totalpayments` VALUES (1,1,12000.00),(2,2,2400.00),(3,3,6200.00),(4,4,1500.00),(5,18,4600.00),(6,22,6100.00),(7,5,920.00),(8,12,600.00),(9,1,12000.00),(10,3,6200.00),(11,3,6200.00),(12,22,6100.00);
/*!40000 ALTER TABLE `student_totalpayments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student_yearlevels`
--

DROP TABLE IF EXISTS `student_yearlevels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student_yearlevels` (
  `id` int NOT NULL,
  `student_id` int DEFAULT NULL,
  `year_level` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `fk_students1` (`student_id`),
  CONSTRAINT `fk_students1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_yearlevels`
--

LOCK TABLES `student_yearlevels` WRITE;
/*!40000 ALTER TABLE `student_yearlevels` DISABLE KEYS */;
INSERT INTO `student_yearlevels` VALUES (1,1,4),(2,2,4),(3,3,1),(4,4,2),(5,5,3),(6,6,4),(7,7,2),(8,8,1),(9,9,2),(10,10,3),(11,11,4),(12,12,1),(13,13,1),(14,14,2),(15,15,3),(16,16,4),(17,17,3),(18,18,1),(19,19,2),(20,20,3),(21,21,4),(22,22,3),(23,23,1),(24,24,2),(25,25,3),(26,26,4),(27,27,3),(28,28,1),(29,29,2);
/*!40000 ALTER TABLE `student_yearlevels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `student_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `course_id` int DEFAULT NULL,
  `year_level` int DEFAULT NULL,
  PRIMARY KEY (`student_id`),
  KEY `fk_course` (`course_id`),
  CONSTRAINT `fk_course` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Jeron','Capro',1,4),(2,'Jane','Smith',2,4),(3,'Alice','Johnson',3,2),(4,'Bob','Brown',1,2),(5,'Charlie','Davis',3,3),(6,'David','Miller',2,4),(7,'Eva','Wilson',5,2),(8,'Frank','Taylor',4,1),(9,'Grace','Anderson',6,2),(10,'Hannah','Thomas',7,3),(11,'Jake','Morales',6,4),(12,'Dave','Gordon',5,1),(13,'James','McColumn',4,1),(14,'Kyrie','Irving',7,2),(15,'Krish','Oabina',9,3),(16,'Steph','Curry',6,4),(17,'Ruby','Canafe',1,4),(18,'Isa','Caudal',1,1),(19,'Necro','Matt',8,2),(20,'France','Caszer',9,3),(21,'Merly','Gin',10,4),(22,'Larwin','Oladipo',1,3),(23,'Miko','Doncic',3,2),(24,'Hero','Pakito',1,1),(25,'Bond','Roaman',1,3),(26,'Chico','Brown',1,4),(27,'jerome','morales',3,3),(28,'Kim','Doe',10,1),(29,'Ash','Borne',10,2),(30,'Ruby','Canafe',1,3),(31,'Jerom','Morales',1,2);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `students_average`
--

DROP TABLE IF EXISTS `students_average`;
/*!50001 DROP VIEW IF EXISTS `students_average`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `students_average` AS SELECT 
 1 AS `student_id`,
 1 AS `last_name`,
 1 AS `first_name`,
 1 AS `Average_Grade`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjects` (
  `subject_id` int NOT NULL,
  `subject_name` varchar(100) DEFAULT NULL,
  `course_id` int DEFAULT NULL,
  `instructor_id` int DEFAULT NULL,
  PRIMARY KEY (`subject_id`),
  KEY `course_id` (`course_id`),
  KEY `fk_instructor` (`instructor_id`),
  CONSTRAINT `fk_instructor` FOREIGN KEY (`instructor_id`) REFERENCES `instructors` (`instructor_id`),
  CONSTRAINT `subjects_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (1,'Computer Programming 1',1,1),(2,'Event Driven Programming 1',1,3),(3,'Object Oriented Programming 1',1,2),(4,'Path Fit 2',1,4),(5,'Physics for Computing',1,5),(6,'Discrete Mathematics',1,1),(7,'Intro to Computing',1,1),(8,'Machine Learning',2,18),(9,'Data Structures and Algorithms',2,19),(10,'Operating Systems',2,20),(11,'Database Management Systems',2,39),(12,'Computer Networks',2,41),(13,'Artificial Intelligence',2,18),(14,'Software Engineering',2,19),(15,'Cybersecurity',2,20),(16,'General Biology',3,12),(17,'Microbiology',3,13),(18,'Genetics',3,14),(19,'Ecology',3,40),(20,'Biochemistry',3,12),(21,'Human Anatomy and Physiology',3,13),(22,'Evolutionary Biology',3,14),(23,'Organic Chemistry',4,15),(24,'Inorganic Chemistry',4,16),(25,'Analytical Chemistry',4,17),(26,'Physical Chemistry',4,15),(27,'Biochemistry',4,16),(28,'Environmental Chemistry',4,17),(29,'Instrumental Chemistry',4,15),(30,'Circuit Analysis',5,9),(31,'Electromagnetics',5,10),(32,'Power Systems',5,11),(33,'Control Systems',5,34),(34,'Digital Electronics',5,9),(35,'Renewable Energy Systems',5,10),(36,'Microprocessors',5,11),(37,'Microeconomics',6,21),(38,'Macroeconomics',6,23),(39,'Econometrics',6,22),(40,'International Trade',6,38),(41,'Monetary Economics',6,21),(42,'Public Finance',6,22),(43,'Development Economics',6,23),(44,'General Psychology',7,24),(45,'Abnormal Psychology',7,25),(46,'Cognitive Psychology',7,26),(47,'Social Psychology',7,37),(48,'Psychological Testing',7,24),(49,'Clinical Psychology',7,25),(50,'Human Development',7,26),(51,'Fundamentals of Nursing',8,27),(52,'Pharmacology',8,28),(53,'Medical-Surgical Nursing',8,29),(54,'Community Health Nursing',8,36),(55,'Maternal and Child Nursing',8,28),(56,'Psychiatric Nursing',8,29),(57,'Geriatric Nursing',8,27),(58,'Exercise Physiology',9,6),(59,'Sports Psychology',9,7),(60,'Kinesiology',9,8),(61,'Biomechanics',9,33),(62,'Strength and Conditioning',9,6),(63,'Sports Nutrition',9,7),(64,'Injury Prevention and Rehabilitation',9,8),(65,'World Literature',10,30),(66,'Comparative Literature',10,31),(67,'Philippine Literature',10,32),(68,'Creative Writing',10,35),(69,'Literary Criticism',10,30),(70,'Drama and Poetry',10,31),(71,'Modern and Contemporary Literature',10,32);
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `total_student_per_dept`
--

DROP TABLE IF EXISTS `total_student_per_dept`;
/*!50001 DROP VIEW IF EXISTS `total_student_per_dept`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `total_student_per_dept` AS SELECT 
 1 AS `course_name`,
 1 AS `Total_students`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `security_question` varchar(255) DEFAULT NULL,
  `answer` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'John','Doe','johndoe','admin','What is your Favorite Color?','Green'),(2,'jake','morales','jake123','jake123','What is your Favorite Food?','Curry'),(3,'jake','morales','jake54','jake',NULL,NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `it_instructors`
--

/*!50001 DROP VIEW IF EXISTS `it_instructors`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `it_instructors` AS select `i`.`first_name` AS `first_name`,`i`.`last_name` AS `last_name` from `instructors` `i` where (`i`.`department_id` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `it_subjects`
--

/*!50001 DROP VIEW IF EXISTS `it_subjects`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `it_subjects` AS select `subjects`.`subject_name` AS `subject_name` from `subjects` where (`subjects`.`course_id` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `student_grades`
--

/*!50001 DROP VIEW IF EXISTS `student_grades`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `student_grades` AS select `s`.`student_id` AS `student_id`,`s`.`last_name` AS `last_name`,`s`.`first_name` AS `first_name`,`sub`.`subject_name` AS `subject_name`,`g`.`grade` AS `grade` from ((`students` `s` join `grades` `g` on((`s`.`student_id` = `g`.`student_id`))) join `subjects` `sub` on((`g`.`subject_id` = `sub`.`subject_id`))) order by `s`.`student_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `student_informations`
--

/*!50001 DROP VIEW IF EXISTS `student_informations`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `student_informations` AS select `s`.`student_id` AS `ID`,`s`.`last_name` AS `Last Name`,`s`.`first_name` AS `First Name`,`c`.`course_name` AS `Course`,`s`.`year_level` AS `Year Level`,`d`.`department_name` AS `DEPARTMENT` from ((`students` `s` join `courses` `c` on((`s`.`course_id` = `c`.`course_id`))) join `departments` `d` on((`c`.`department_id` = `d`.`department_id`))) order by `s`.`student_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `students_average`
--

/*!50001 DROP VIEW IF EXISTS `students_average`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `students_average` AS select `s`.`student_id` AS `student_id`,`s`.`last_name` AS `last_name`,`s`.`first_name` AS `first_name`,round(avg(`g`.`grade`),2) AS `Average_Grade` from (`students` `s` join `grades` `g` on((`s`.`student_id` = `g`.`student_id`))) group by `s`.`student_id`,`s`.`last_name`,`s`.`first_name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `total_student_per_dept`
--

/*!50001 DROP VIEW IF EXISTS `total_student_per_dept`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `total_student_per_dept` AS select `c`.`course_name` AS `course_name`,count(`s`.`student_id`) AS `Total_students` from (`students` `s` join `courses` `c` on((`s`.`course_id` = `c`.`course_id`))) group by `c`.`course_name` */;
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

-- Dump completed on 2025-05-15 10:38:31
