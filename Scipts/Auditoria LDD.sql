-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: auditoria
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
-- Table structure for table `tbl_actividades`
--

DROP TABLE IF EXISTS `tbl_actividades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_actividades` (
  `Pk_id_actividad` int NOT NULL,
  `Fk_id_asignacion` int NOT NULL,
  `nombre_actividad` varchar(100) NOT NULL,
  `descripcion` text,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `observaciones` text,
  `evidencia` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_actividad`),
  KEY `Fk_id_asignacion` (`Fk_id_asignacion`),
  CONSTRAINT `tbl_asignacion_ibfk_1` FOREIGN KEY (`Fk_id_asignacion`) REFERENCES `tbl_asignacion` (`Pk_id_asignacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_actividades`
--

LOCK TABLES `tbl_actividades` WRITE;
/*!40000 ALTER TABLE `tbl_actividades` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_actividades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_actividades_proyecto`
--

DROP TABLE IF EXISTS `tbl_actividades_proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_actividades_proyecto` (
  `Pk_id_actividad_proyecto` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  `nombre_actividad` varchar(100) NOT NULL,
  `descripcion` text,
  `observaciones` text,
  PRIMARY KEY (`Pk_id_actividad_proyecto`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_actividades_proyecto_ibfk_1` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_actividades_proyecto`
--

LOCK TABLES `tbl_actividades_proyecto` WRITE;
/*!40000 ALTER TABLE `tbl_actividades_proyecto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_actividades_proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_areas`
--

DROP TABLE IF EXISTS `tbl_areas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_areas` (
  `Pk_id_area` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  `nombre_area` varchar(100) NOT NULL,
  `descripcion` text,
  `estado_area` varchar(100) NOT NULL,
  PRIMARY KEY (`Pk_id_area`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_areas_ibfk_1` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_areas`
--

LOCK TABLES `tbl_areas` WRITE;
/*!40000 ALTER TABLE `tbl_areas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_areas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asignacion`
--

DROP TABLE IF EXISTS `tbl_asignacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacion` (
  `Pk_id_asignacion` int NOT NULL,
  `Fk_id_auditor` int NOT NULL,
  `Fk_id_estado_asignacion` int NOT NULL,
  `fecha_asignacion` date NOT NULL,
  `fecha_finalizacion` date DEFAULT NULL,
  `observaciones` text,
  PRIMARY KEY (`Pk_id_asignacion`),
  KEY `Fk_id_auditor` (`Fk_id_auditor`),
  KEY `Fk_id_estado_asignacion` (`Fk_id_estado_asignacion`),
  CONSTRAINT `tbl_auditor_ibfk_1` FOREIGN KEY (`Fk_id_auditor`) REFERENCES `tbl_auditor` (`Pk_id_auditor`),
  CONSTRAINT `tbl_estado_asignacion_ibfk_2` FOREIGN KEY (`Fk_id_estado_asignacion`) REFERENCES `tbl_estado_asignacion` (`Pk_id_estado_asignacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asignacion`
--

LOCK TABLES `tbl_asignacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_asignacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_auditados`
--

DROP TABLE IF EXISTS `tbl_auditados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_auditados` (
  `Pk_id_auditado` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  `nombre_auditado` varchar(100) NOT NULL,
  `cargo_o_area` varchar(100) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `observaciones` text,
  PRIMARY KEY (`Pk_id_auditado`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_proyecto_ibfk_1` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_auditados`
--

LOCK TABLES `tbl_auditados` WRITE;
/*!40000 ALTER TABLE `tbl_auditados` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_auditados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_auditor`
--

DROP TABLE IF EXISTS `tbl_auditor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_auditor` (
  `Pk_id_auditor` int NOT NULL,
  `nombre_auditor` varchar(45) DEFAULT NULL,
  `telefono_auditor` varchar(45) DEFAULT NULL,
  `email_auditor` varchar(20) DEFAULT NULL,
  `carnet_auditor` varchar(15) NOT NULL,
  `Estado` varchar(1) DEFAULT NULL,
  `Fk_id_perfil_auditor` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  PRIMARY KEY (`Pk_id_auditor`),
  KEY `Fk_id_perfil_auditor` (`Fk_id_perfil_auditor`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_perfil_auditor_ibfk_1` FOREIGN KEY (`Fk_id_perfil_auditor`) REFERENCES `tbl_perfil_auditor` (`Pk_id_perfil_auditor`),
  CONSTRAINT `tbl_proyecto_ibfk_2` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_auditor`
--

LOCK TABLES `tbl_auditor` WRITE;
/*!40000 ALTER TABLE `tbl_auditor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_auditor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_checklist`
--

DROP TABLE IF EXISTS `tbl_checklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_checklist` (
  `Pk_id_checklist` int NOT NULL,
  `Fk_id_informe` int NOT NULL,
  `Fk_id_criterio` int NOT NULL,
  `entregado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`Pk_id_checklist`),
  KEY `Fk_id_informe` (`Fk_id_informe`),
  KEY `Fk_id_criterio` (`Fk_id_criterio`),
  CONSTRAINT `tbl_checklists_ibfk_1` FOREIGN KEY (`Fk_id_informe`) REFERENCES `tbl_informe` (`Pk_id_informe`),
  CONSTRAINT `tbl_checklists_ibfk_2` FOREIGN KEY (`Fk_id_criterio`) REFERENCES `tbl_criterios` (`Pk_id_criterio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_checklist`
--

LOCK TABLES `tbl_checklist` WRITE;
/*!40000 ALTER TABLE `tbl_checklist` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_checklist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_criterios`
--

DROP TABLE IF EXISTS `tbl_criterios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_criterios` (
  `Pk_id_criterio` int NOT NULL,
  `Fk_id_rubrica` int NOT NULL,
  `nombre_criterio` varchar(100) NOT NULL,
  `porcentaje_criterio` int DEFAULT NULL,
  `descripcion` text,
  `nivel_importancia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_criterio`),
  KEY `Fk_id_rubrica` (`Fk_id_rubrica`),
  CONSTRAINT `tbl_criterios_ibfk_1` FOREIGN KEY (`Fk_id_rubrica`) REFERENCES `tbl_rubrica` (`Pk_id_rubrica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_criterios`
--

LOCK TABLES `tbl_criterios` WRITE;
/*!40000 ALTER TABLE `tbl_criterios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_criterios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cronograma`
--

DROP TABLE IF EXISTS `tbl_cronograma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cronograma` (
  `Pk_id_cronograma` int NOT NULL,
  `Fk_id_planificacion` int NOT NULL,
  `Fk_id_actividad_proyecto` int NOT NULL,
  `nombre_tarea` varchar(100) NOT NULL,
  `descripcion` text,
  `fecha_inicio` date NOT NULL,
  `fecha_fin` date NOT NULL,
  `responsable_tarea` varchar(100) DEFAULT NULL,
  `estado_tarea` varchar(100) DEFAULT NULL,
  `observaciones` text,
  PRIMARY KEY (`Pk_id_cronograma`),
  KEY `tbl_cronograma_ibfk_1` (`Fk_id_planificacion`),
  KEY `tbl_cronograma_ibfk_2` (`Fk_id_actividad_proyecto`),
  CONSTRAINT `tbl_cronograma_ibfk_1` FOREIGN KEY (`Fk_id_planificacion`) REFERENCES `tbl_planificacion` (`Pk_id_planificacion`),
  CONSTRAINT `tbl_cronograma_ibfk_2` FOREIGN KEY (`Fk_id_actividad_proyecto`) REFERENCES `tbl_actividades_proyecto` (`Pk_id_actividad_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cronograma`
--

LOCK TABLES `tbl_cronograma` WRITE;
/*!40000 ALTER TABLE `tbl_cronograma` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cronograma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_descripcion_criterio`
--

DROP TABLE IF EXISTS `tbl_descripcion_criterio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_descripcion_criterio` (
  `Pk_id_descripcion_criterio` int NOT NULL,
  `Fk_id_criterio` int NOT NULL,
  `Fk_id_escala` int NOT NULL,
  `descripcion_detallada` text NOT NULL,
  `evidencia_requerida` text,
  `observaciones` text,
  PRIMARY KEY (`Pk_id_descripcion_criterio`),
  KEY `Fk_id_criterio` (`Fk_id_criterio`),
  KEY `Fk_id_escala` (`Fk_id_escala`),
  CONSTRAINT `tbl_descripcion_criterio_ibfk_1` FOREIGN KEY (`Fk_id_criterio`) REFERENCES `tbl_criterios` (`Pk_id_criterio`),
  CONSTRAINT `tbl_descripcion_criterio_ibfk_2` FOREIGN KEY (`Fk_id_escala`) REFERENCES `tbl_escala_descripcion` (`Pk_id_escala`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_descripcion_criterio`
--

LOCK TABLES `tbl_descripcion_criterio` WRITE;
/*!40000 ALTER TABLE `tbl_descripcion_criterio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_descripcion_criterio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_escala_descripcion`
--

DROP TABLE IF EXISTS `tbl_escala_descripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_escala_descripcion` (
  `Pk_id_escala` int NOT NULL,
  `porcentaje` int NOT NULL,
  `nombre_nivel` varchar(50) NOT NULL,
  `descripcion_general` text,
  `color_referencia` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_escala`),
  CONSTRAINT `tbl_escala_descripcion_chk_1` CHECK ((`porcentaje` in (0,20,40,60,80,100)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_escala_descripcion`
--

LOCK TABLES `tbl_escala_descripcion` WRITE;
/*!40000 ALTER TABLE `tbl_escala_descripcion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_escala_descripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estado_asignacion`
--

DROP TABLE IF EXISTS `tbl_estado_asignacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_estado_asignacion` (
  `Pk_id_estado_asignacion` int NOT NULL,
  `estado_asignacion` varchar(50) NOT NULL,
  `descripcion_estado_asignacion` text,
  PRIMARY KEY (`Pk_id_estado_asignacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_estado_asignacion`
--

LOCK TABLES `tbl_estado_asignacion` WRITE;
/*!40000 ALTER TABLE `tbl_estado_asignacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_estado_asignacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estado_informe`
--

DROP TABLE IF EXISTS `tbl_estado_informe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_estado_informe` (
  `Pk_id_estado_informe` int NOT NULL,
  `nombre_estado` varchar(50) NOT NULL,
  `descripcion` text,
  PRIMARY KEY (`Pk_id_estado_informe`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_estado_informe`
--

LOCK TABLES `tbl_estado_informe` WRITE;
/*!40000 ALTER TABLE `tbl_estado_informe` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_estado_informe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_grafica`
--

DROP TABLE IF EXISTS `tbl_grafica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_grafica` (
  `Pk_id_grafica` int NOT NULL,
  `Fk_id_informe` int NOT NULL,
  `tipo_grafica` varchar(50) NOT NULL,
  `descripcion` text,
  `datos_json_grafica` json DEFAULT NULL,
  PRIMARY KEY (`Pk_id_grafica`),
  KEY `Fk_id_informe` (`Fk_id_informe`),
  CONSTRAINT `tbl_grafica_ibfk_1` FOREIGN KEY (`Fk_id_informe`) REFERENCES `tbl_informe` (`Pk_id_informe`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_grafica`
--

LOCK TABLES `tbl_grafica` WRITE;
/*!40000 ALTER TABLE `tbl_grafica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_grafica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_informe`
--

DROP TABLE IF EXISTS `tbl_informe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_informe` (
  `Pk_id_informe` int NOT NULL,
  `Fk_id_auditor` int NOT NULL,
  `Fk_id_estado_informe` int NOT NULL,
  `titulo_informe` varchar(150) NOT NULL,
  `descripcion_general` text,
  `conclusiones` text,
  `fecha_creacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `fecha_actualizacion` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`Pk_id_informe`),
  KEY `Fk_id_auditor` (`Fk_id_auditor`),
  KEY `Fk_id_estado_informe` (`Fk_id_estado_informe`),
  CONSTRAINT `tbl_informe_ibfk_1` FOREIGN KEY (`Fk_id_auditor`) REFERENCES `tbl_auditor` (`Pk_id_auditor`),
  CONSTRAINT `tbl_informe_ibfk_2` FOREIGN KEY (`Fk_id_estado_informe`) REFERENCES `tbl_estado_informe` (`Pk_id_estado_informe`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_informe`
--

LOCK TABLES `tbl_informe` WRITE;
/*!40000 ALTER TABLE `tbl_informe` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_informe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulos` (
  `Pk_id_modulo` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  `nombre_modulo` varchar(100) NOT NULL,
  `descripcion` text,
  `estado_modulo` varchar(100) NOT NULL,
  PRIMARY KEY (`Pk_id_modulo`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_modulos_ibfk_1` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_modulos`
--

LOCK TABLES `tbl_modulos` WRITE;
/*!40000 ALTER TABLE `tbl_modulos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_perfil_auditor`
--

DROP TABLE IF EXISTS `tbl_perfil_auditor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfil_auditor` (
  `Pk_id_perfil_auditor` int NOT NULL,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` text,
  PRIMARY KEY (`Pk_id_perfil_auditor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_perfil_auditor`
--

LOCK TABLES `tbl_perfil_auditor` WRITE;
/*!40000 ALTER TABLE `tbl_perfil_auditor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_perfil_auditor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_planificacion`
--

DROP TABLE IF EXISTS `tbl_planificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_planificacion` (
  `Pk_id_planificacion` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  `nombre_plan` varchar(100) NOT NULL,
  `descripcion` text,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `observaciones` text,
  PRIMARY KEY (`Pk_id_planificacion`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_planificacion_ibfk_1` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_planificacion`
--

LOCK TABLES `tbl_planificacion` WRITE;
/*!40000 ALTER TABLE `tbl_planificacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_planificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proyecto`
--

DROP TABLE IF EXISTS `tbl_proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proyecto` (
  `Pk_id_proyecto` int NOT NULL,
  `Fk_id_proyecto_estado` int NOT NULL,
  `nombre_proyecto` varchar(100) NOT NULL,
  `descripcion` text,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `objetivo` text,
  PRIMARY KEY (`Pk_id_proyecto`),
  KEY `Fk_id_proyecto_estado` (`Fk_id_proyecto_estado`),
  CONSTRAINT `tbl_proyecto_estado_ibfk_1` FOREIGN KEY (`Fk_id_proyecto_estado`) REFERENCES `tbl_proyecto_estado` (`Pk_id_proyecto_estado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proyecto`
--

LOCK TABLES `tbl_proyecto` WRITE;
/*!40000 ALTER TABLE `tbl_proyecto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proyecto_estado`
--

DROP TABLE IF EXISTS `tbl_proyecto_estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_proyecto_estado` (
  `Pk_id_proyecto_estado` int NOT NULL,
  `nombre_estado` varchar(50) NOT NULL,
  `descripcion_estado` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_proyecto_estado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proyecto_estado`
--

LOCK TABLES `tbl_proyecto_estado` WRITE;
/*!40000 ALTER TABLE `tbl_proyecto_estado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proyecto_estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recursos`
--

DROP TABLE IF EXISTS `tbl_recursos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_recursos` (
  `Pk_id_recurso` int NOT NULL,
  `Fk_id_proyecto` int NOT NULL,
  `nombre_recurso` varchar(100) NOT NULL,
  `tipo_recurso` varchar(100) NOT NULL,
  `cantidad` int DEFAULT '1',
  `fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Pk_id_recurso`),
  KEY `Fk_id_proyecto` (`Fk_id_proyecto`),
  CONSTRAINT `tbl_recursos_ibfk_1` FOREIGN KEY (`Fk_id_proyecto`) REFERENCES `tbl_proyecto` (`Pk_id_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_recursos`
--

LOCK TABLES `tbl_recursos` WRITE;
/*!40000 ALTER TABLE `tbl_recursos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recursos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reporte`
--

DROP TABLE IF EXISTS `tbl_reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_reporte` (
  `Pk_id_reporte` int NOT NULL,
  `Fk_id_informe` int NOT NULL,
  `Fk_id_criterio` int NOT NULL,
  `Fk_id_auditor` int NOT NULL,
  `aspectos_positivos` text,
  `correcciones` text,
  `recomendaciones` text,
  PRIMARY KEY (`Pk_id_reporte`),
  KEY `Fk_id_informe` (`Fk_id_informe`),
  KEY `Fk_id_criterio` (`Fk_id_criterio`),
  KEY `Fk_id_auditor` (`Fk_id_auditor`),
  CONSTRAINT `tbl_reporte_ibfk_1` FOREIGN KEY (`Fk_id_informe`) REFERENCES `tbl_informe` (`Pk_id_informe`),
  CONSTRAINT `tbl_reporte_ibfk_2` FOREIGN KEY (`Fk_id_criterio`) REFERENCES `tbl_criterios` (`Pk_id_criterio`),
  CONSTRAINT `tbl_reporte_ibfk_3` FOREIGN KEY (`Fk_id_auditor`) REFERENCES `tbl_auditor` (`Pk_id_auditor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_reporte`
--

LOCK TABLES `tbl_reporte` WRITE;
/*!40000 ALTER TABLE `tbl_reporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_rubrica`
--

DROP TABLE IF EXISTS `tbl_rubrica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_rubrica` (
  `Pk_id_rubrica` int NOT NULL,
  `Fk_id_cronograma` int NOT NULL,
  `nombre_rubrica` varchar(100) NOT NULL,
  `descripcion` text,
  `objetivo` text,
  PRIMARY KEY (`Pk_id_rubrica`),
  KEY `Fk_id_cronograma` (`Fk_id_cronograma`),
  CONSTRAINT `tbl_rubrica_ibfk_1` FOREIGN KEY (`Fk_id_cronograma`) REFERENCES `tbl_cronograma` (`Pk_id_cronograma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_rubrica`
--

LOCK TABLES `tbl_rubrica` WRITE;
/*!40000 ALTER TABLE `tbl_rubrica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_rubrica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tabla_ponderacion`
--

DROP TABLE IF EXISTS `tbl_tabla_ponderacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_tabla_ponderacion` (
  `Pk_id_ponderacion` int NOT NULL AUTO_INCREMENT,
  `Fk_id_auditado` int NOT NULL,
  `Fk_id_cronograma` int NOT NULL,
  `Fk_id_rubrica` int NOT NULL,
  `Fk_id_criterio` int NOT NULL,
  `Fk_id_escala` int NOT NULL,
  `calificacion_porcentaje` decimal(5,2) NOT NULL,
  `calificacion_ponderada` decimal(6,2) NOT NULL,
  `comentarios_auditor` text,
  `fecha_evaluacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Pk_id_ponderacion`),
  KEY `Fk_id_auditado` (`Fk_id_auditado`),
  KEY `Fk_id_cronograma` (`Fk_id_cronograma`),
  KEY `Fk_id_rubrica` (`Fk_id_rubrica`),
  KEY `Fk_id_criterio` (`Fk_id_criterio`),
  KEY `Fk_id_escala` (`Fk_id_escala`),
  CONSTRAINT `tbl_tabla_ponderacion_ibfk_1` FOREIGN KEY (`Fk_id_auditado`) REFERENCES `tbl_auditados` (`Pk_id_auditado`),
  CONSTRAINT `tbl_tabla_ponderacion_ibfk_2` FOREIGN KEY (`Fk_id_cronograma`) REFERENCES `tbl_cronograma` (`Pk_id_cronograma`),
  CONSTRAINT `tbl_tabla_ponderacion_ibfk_3` FOREIGN KEY (`Fk_id_rubrica`) REFERENCES `tbl_rubrica` (`Pk_id_rubrica`),
  CONSTRAINT `tbl_tabla_ponderacion_ibfk_4` FOREIGN KEY (`Fk_id_criterio`) REFERENCES `tbl_criterios` (`Pk_id_criterio`),
  CONSTRAINT `tbl_tabla_ponderacion_ibfk_5` FOREIGN KEY (`Fk_id_escala`) REFERENCES `tbl_escala_descripcion` (`Pk_id_escala`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tabla_ponderacion`
--

LOCK TABLES `tbl_tabla_ponderacion` WRITE;
/*!40000 ALTER TABLE `tbl_tabla_ponderacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tabla_ponderacion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-14 10:20:26
