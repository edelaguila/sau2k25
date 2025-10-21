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
-- Table structure for table `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_aplicaciones` (
  `Pk_id_aplicacion` int NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint DEFAULT '0',
  PRIMARY KEY (`Pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `tbl_asignacion_modulo_aplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacion_modulo_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignacion_modulo_aplicacion` (
  `Fk_id_modulos` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_asignaciones_perfils_usuario`
--

DROP TABLE IF EXISTS `tbl_asignaciones_perfils_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_asignaciones_perfils_usuario` (
  `PK_id_Perfil_Usuario` int NOT NULL,
  `Fk_id_usuario` int NOT NULL,
  `Fk_id_perfil` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacora` (
  `Pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `Fk_id_usuario` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(200) NOT NULL,
  PRIMARY KEY (`Pk_id_bitacora`),
  KEY `Fk_id_usuario` (`Fk_id_usuario`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  CONSTRAINT `tbl_bitacora_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`Pk_id_usuario`),
  CONSTRAINT `tbl_bitacora_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `tbl_consultainteligente`
--

DROP TABLE IF EXISTS `tbl_consultainteligente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_consultainteligente` (
  `Pk_consultaID` int NOT NULL,
  `nombre_consulta` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `tipo_consulta` int NOT NULL,
  `consulta_SQLE` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `consulta_estatus` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_modulos` (
  `Pk_id_modulos` int NOT NULL,
  `nombre_modulo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_modulo` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_modulo` tinyint DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_perfiles` (
  `Pk_id_perfil` int NOT NULL,
  `nombre_perfil` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_perfil` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_perfil` tinyint DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_permisos_aplicacion_perfil`
--

DROP TABLE IF EXISTS `tbl_permisos_aplicacion_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisos_aplicacion_perfil` (
  `PK_id_Aplicacion_Perfil` int NOT NULL,
  `Fk_id_perfil` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_permisos_aplicaciones_usuario`
--

DROP TABLE IF EXISTS `tbl_permisos_aplicaciones_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_permisos_aplicaciones_usuario` (
  `PK_id_Aplicacion_Usuario` int NOT NULL,
  `Fk_id_usuario` int NOT NULL,
  `Fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_usuarios` (
  `Pk_id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `ultima_conexion_usuario` datetime DEFAULT NULL,
  `estado_usuario` tinyint NOT NULL DEFAULT '0',
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  PRIMARY KEY (`Pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping routines for database 'auditoria'
--
/*!50003 DROP PROCEDURE IF EXISTS `cambiarContraModulo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarContraModulo`(IN `p_usuario` INT, IN `p_nueva_contrasenia` VARCHAR(100))
BEGIN
    -- Actualizar la contraseña del usuario
    UPDATE tbl_usuarios
    SET password_usuario = p_nueva_contrasenia
    WHERE pk_id_usuario = p_usuario;

    -- Confirmar que el cambio se realizó
    IF ROW_COUNT() > 0 THEN
        SELECT 'Contraseña actualizada con éxito' AS resultado;
    ELSE
        SELECT 'Usuario no encontrado' AS resultado;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `cambiarContrasenia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `cambiarContrasenia`(IN `usuario` VARCHAR(255), IN `nuevaContrasenia` VARCHAR(255), IN `respuestaSeguridad` VARCHAR(255))
BEGIN
    DECLARE respuestaGuardada VARCHAR(255);
    DECLARE usuarioExiste INT;

    -- Verificar si el usuario existe
    SELECT COUNT(*) INTO usuarioExiste 
    FROM tbl_usuarios 
    WHERE username_usuario = usuario;

    IF usuarioExiste = 0 THEN
        -- Si el usuario no existe, devolver mensaje de error
        SELECT 'Usuario no encontrado' AS resultado;
    ELSE
        -- Obtener la respuesta de seguridad desde la base de datos
        SELECT respuesta INTO respuestaGuardada 
        FROM tbl_usuarios 
        WHERE username_usuario = usuario;

        -- Verificar si la respuesta ingresada coincide con la guardada
        IF LOWER(respuestaGuardada) = LOWER(respuestaSeguridad) THEN
            -- Actualizar la contraseña
            UPDATE tbl_usuarios
            SET password_usuario = nuevaContrasenia
            WHERE username_usuario = usuario;
            
            -- Devolver el resultado exitoso
            SELECT 'Contraseña actualizada con éxito' AS resultado;
        ELSE
            -- Devolver resultado si la respuesta de seguridad es incorrecta
            SELECT 'Respuesta de seguridad incorrecta' AS resultado;
        END IF;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `cambioContrasenia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `cambioContrasenia`(IN `p_usuario` VARCHAR(20))
BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN        
        SELECT 'Usuario encontrado' AS resu;
    ELSE
        SELECT 'Usuario no encontrado' AS resu;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `procedimientoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin`(IN `p_usuario` VARCHAR(20), IN `p_clave` VARCHAR(100))
BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario AND password_usuario = p_clave AND estado_usuario = 1;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN
        UPDATE tbl_usuarios
        SET ultima_conexion_usuario = NOW()
        WHERE username_usuario = p_usuario AND password_usuario = p_clave;
        
        SELECT 'Inicio de sesión exitoso' AS resultado;
    ELSE
        SELECT 'Inicio de sesión fallido' AS resultado;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-16  9:49:29
