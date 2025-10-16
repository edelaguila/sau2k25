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
-- Dumping data for table `tbl_actividades`
--

LOCK TABLES `tbl_actividades` WRITE;
/*!40000 ALTER TABLE `tbl_actividades` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_actividades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_actividades_proyecto`
--

LOCK TABLES `tbl_actividades_proyecto` WRITE;
/*!40000 ALTER TABLE `tbl_actividades_proyecto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_actividades_proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_aplicaciones`
--

LOCK TABLES `tbl_aplicaciones` WRITE;
/*!40000 ALTER TABLE `tbl_aplicaciones` DISABLE KEYS */;
INSERT INTO `tbl_aplicaciones` VALUES (1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(2000,'MDI LOGISTICA','PARA LOGISTICA',1),(3000,'MDI COMPRAS Y VENTAS','PARA COMPRAS Y VENTAS',1),(5000,'MDI PRODUCCIÓN','PARA PRODUCCIÓN',1),(6000,'MDI NOMINAS','PARA NOMINAS',1),(6001,'Mant. Trabajadores','PARA NOMINAS',1),(6002,'Mant. Puestos de Trabajo','PARA NOMINAS',1),(6003,'Mant. Departamentos','PARA NOMINAS',1),(6004,'Mant. Contratos','PARA NOMINAS',1),(6005,'Mant. Percepciones','PARA NOMINAS',1),(6006,'Mant. Horas Extras','PARA NOMINAS',1),(6007,'Mant. Faltas','PARA NOMINAS',1),(6101,'Asgn. Puesto - Depto.','PARA NOMINAS',1),(6102,'Asgn. Puesto - Trabajador','PARA NOMINAS',1),(6103,'Asgn. Contrato Trabajador','PARA NOMINAS',1),(6104,'Asgn. Prestaciones Contrato','PARA NOMINAS',1),(6105,'Asgn. Prestaciones Individual','PARA NOMINAS',1),(6106,'Prcs. Nomina','PARA NOMINAS',1),(6201,'Rpt. Planillas','PARA NOMINAS',1),(6202,'Rpt. Contratos','PARA NOMINAS',1),(6203,'Rpt. Trabajadores','PARA NOMINAS',1),(6301,'ACCESO SEGURIDAD','PARA NOMINAS',1),(7000,'MDI BANCOS','PARA BANCOS',1),(8000,'MDI CONTRABILIDAD','PARA CONTRABILIDAD',1),(9000,'MDI CUENTAS CORRIENTES','PARA CUENTAS CORRIENTES',1);
/*!40000 ALTER TABLE `tbl_aplicaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_areas`
--

LOCK TABLES `tbl_areas` WRITE;
/*!40000 ALTER TABLE `tbl_areas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_areas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_asignacion`
--

LOCK TABLES `tbl_asignacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_asignacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_asignacion_modulo_aplicacion`
--

LOCK TABLES `tbl_asignacion_modulo_aplicacion` WRITE;
/*!40000 ALTER TABLE `tbl_asignacion_modulo_aplicacion` DISABLE KEYS */;
INSERT INTO `tbl_asignacion_modulo_aplicacion` VALUES (1000,1000),(1000,1001),(1000,1002),(1000,1003),(1000,1004),(1000,1102),(1000,1103),(1000,1201),(1000,1301),(2000,2000),(3000,3000),(5000,5000),(6000,6000),(6000,6001),(6000,6002),(6000,6003),(6000,6004),(6000,6005),(6000,6006),(6000,6007),(6000,6101),(6000,6102),(6000,6103),(6000,6104),(6000,6105),(6000,6106),(6000,6201),(6000,6202),(6000,6203),(6000,6301),(7000,7000),(8000,8000),(9000,9000);
/*!40000 ALTER TABLE `tbl_asignacion_modulo_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_asignaciones_perfils_usuario`
--

LOCK TABLES `tbl_asignaciones_perfils_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_asignaciones_perfils_usuario` DISABLE KEYS */;
INSERT INTO `tbl_asignaciones_perfils_usuario` VALUES (1,1,1);
/*!40000 ALTER TABLE `tbl_asignaciones_perfils_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_auditados`
--

LOCK TABLES `tbl_auditados` WRITE;
/*!40000 ALTER TABLE `tbl_auditados` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_auditados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_auditor`
--

LOCK TABLES `tbl_auditor` WRITE;
/*!40000 ALTER TABLE `tbl_auditor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_auditor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_bitacora`
--

LOCK TABLES `tbl_bitacora` WRITE;
/*!40000 ALTER TABLE `tbl_bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_checklist`
--

LOCK TABLES `tbl_checklist` WRITE;
/*!40000 ALTER TABLE `tbl_checklist` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_checklist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_consultainteligente`
--

LOCK TABLES `tbl_consultainteligente` WRITE;
/*!40000 ALTER TABLE `tbl_consultainteligente` DISABLE KEYS */;
INSERT INTO `tbl_consultainteligente` VALUES (1,'',0,'SELECT id_venta FROM venta;',1),(2,'',0,'SELECT SELECT id_venta FROM venta;id_venta AS * FROM venta;',1),(3,'',0,'SELECT * FROM venta;',1),(4,'',0,'SELECT * FROM venta;',1),(5,'',0,'SELECT * FROM venta;',1),(6,'',0,'SELECT * FROM venta;',1),(7,'dsf',0,'SELECT * FROM venta;',1),(8,'',0,'SELECT * FROM venta;',1),(9,'',0,'SELECT * FROM venta;',1),(10,'viccccccccc',0,'SELECT * FROM venta;',1),(11,'consultaaaaa',0,'SELECT * FROM factura;',1),(12,'',0,'SELECT * FROM factura;',1),(13,'jkjkkjk',0,'SELECT * FROM factura;',1);
/*!40000 ALTER TABLE `tbl_consultainteligente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_criterios`
--

LOCK TABLES `tbl_criterios` WRITE;
/*!40000 ALTER TABLE `tbl_criterios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_criterios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_cronograma`
--

LOCK TABLES `tbl_cronograma` WRITE;
/*!40000 ALTER TABLE `tbl_cronograma` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cronograma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_descripcion_criterio`
--

LOCK TABLES `tbl_descripcion_criterio` WRITE;
/*!40000 ALTER TABLE `tbl_descripcion_criterio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_descripcion_criterio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_escala_descripcion`
--

LOCK TABLES `tbl_escala_descripcion` WRITE;
/*!40000 ALTER TABLE `tbl_escala_descripcion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_escala_descripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_estado_asignacion`
--

LOCK TABLES `tbl_estado_asignacion` WRITE;
/*!40000 ALTER TABLE `tbl_estado_asignacion` DISABLE KEYS */;
INSERT INTO `tbl_estado_asignacion` VALUES (1,'Pendiente','Auditor asignado, pendiente de inicio'),(2,'En Curso','Auditor realizando las actividades asignadas'),(3,'Completada','Auditor finalizó la revisión'),(4,'Rechazada','Asignación anulada o devuelta');
/*!40000 ALTER TABLE `tbl_estado_asignacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_estado_informe`
--

LOCK TABLES `tbl_estado_informe` WRITE;
/*!40000 ALTER TABLE `tbl_estado_informe` DISABLE KEYS */;
INSERT INTO `tbl_estado_informe` VALUES (1,'Borrador','Informe en proceso de redacción'),(2,'Revisión','Informe en revisión por supervisor'),(3,'Aprobado','Informe final aprobado'),(4,'Archivado','Informe cerrado y almacenado');
/*!40000 ALTER TABLE `tbl_estado_informe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_grafica`
--

LOCK TABLES `tbl_grafica` WRITE;
/*!40000 ALTER TABLE `tbl_grafica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_grafica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_informe`
--

LOCK TABLES `tbl_informe` WRITE;
/*!40000 ALTER TABLE `tbl_informe` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_informe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_modulos`
--

LOCK TABLES `tbl_modulos` WRITE;
/*!40000 ALTER TABLE `tbl_modulos` DISABLE KEYS */;
INSERT INTO `tbl_modulos` VALUES (1000,'SEGURIDAD','Seguridad',1),(2000,'LOGISTICA','Logistica',1),(3000,'COMPRAS Y VENTAS','Compras y Ventas',1),(5000,'PRODUCCIÓN','Produccion',1),(6000,'NOMINAS','Nominas',1),(7000,'BANCOS','Bancos',1),(8000,'CONTABILIDAD','Contabilidad',1),(9000,'CUENTAS CORRIENTES','Cuentas Corrientes',1);
/*!40000 ALTER TABLE `tbl_modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_perfil_auditor`
--

LOCK TABLES `tbl_perfil_auditor` WRITE;
/*!40000 ALTER TABLE `tbl_perfil_auditor` DISABLE KEYS */;
INSERT INTO `tbl_perfil_auditor` VALUES (1,'Jefe Auditor','Responsable de la planificación general de las auditorías, supervisión de equipos y aprobación de informes finales.'),(2,'Auditor Administrador','Encargado de coordinar la asignación de auditores, controlar el avance de las auditorías y administrar los recursos del proyecto.'),(3,'Auditor','Profesional encargado de ejecutar las actividades de revisión, evaluación de criterios y elaboración de reportes técnicos.');
/*!40000 ALTER TABLE `tbl_perfil_auditor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_perfiles`
--

LOCK TABLES `tbl_perfiles` WRITE;
/*!40000 ALTER TABLE `tbl_perfiles` DISABLE KEYS */;
INSERT INTO `tbl_perfiles` VALUES (1,'ADMINISTRADOR','contiene todos los permisos del programa',1),(2,'SEGURIDAD','contiene todos los permisos de seguridad',1),(3,'LOGISTICA','contiene todos los permisos de logistica',1),(4,'COMPRAS Y VENTAS','contiene todos los permisos de compras y ventas',1),(5,'PRODUCCIÓN','contiene todos los permisos de producción',1),(6,'NOMINAS','contiene todos los permisos de nominas',1),(7,'BANCOS','contiene todos los permisos de bancos',1),(8,'CONTABILIDAD','contiene todos los permisos de contabilidad',1),(9,'AUDITOR','Permite la revisión y auditoría de actividades sin capacidad de modificar datos',1),(10,'SOporte Técnico','Permite brindar asistencia técnica sin acceso completo a la administración',1),(11,'ADMINISTRADOR','Acceso completo al sistema con ciertas restricciones según sea necesario',1),(12,'GESTOR DE PROYECTOS','Permite gestionar proyectos y coordinar actividades sin acceso completo a la administración',1),(13,'GESTOR DE DATOS','Permite gestionar y supervisar datos en distintos módulos sin acceso completo a la administración',1),(14,'CUENTAS CORRIENTES','contiene todos los permisos de cuentas corrientes',1);
/*!40000 ALTER TABLE `tbl_perfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_permisos_aplicacion_perfil`
--

LOCK TABLES `tbl_permisos_aplicacion_perfil` WRITE;
/*!40000 ALTER TABLE `tbl_permisos_aplicacion_perfil` DISABLE KEYS */;
INSERT INTO `tbl_permisos_aplicacion_perfil` VALUES (1,1,1000,1,1,1,1,1),(2,1,1001,1,1,1,1,1),(3,1,1002,1,1,1,1,1),(4,1,1003,1,1,1,1,1),(5,1,1004,1,1,1,1,1),(6,1,1101,1,1,1,1,1),(7,1,1102,1,1,1,1,1),(8,1,1103,1,1,1,1,1),(9,1,1201,1,1,1,1,1),(10,1,1301,1,1,1,1,1),(11,1,2000,1,1,1,1,1),(12,1,3000,1,1,1,1,1),(13,1,5000,1,1,1,1,1),(14,1,6000,1,1,1,1,1),(15,1,6001,1,1,1,1,1),(16,1,6002,1,1,1,1,1),(17,1,6003,1,1,1,1,1),(18,1,6004,1,1,1,1,1),(19,1,6005,1,1,1,1,1),(20,1,6006,1,1,1,1,1),(21,1,6007,1,1,1,1,1),(22,1,6101,1,1,1,1,1),(23,1,6102,1,1,1,1,1),(24,1,6103,1,1,1,1,1),(25,1,6104,1,1,1,1,1),(26,1,6105,1,1,1,1,1),(27,1,6106,1,1,1,1,1),(28,1,6201,1,1,1,1,1),(29,1,6202,1,1,1,1,1),(30,1,6203,1,1,1,1,1),(31,1,6301,1,1,1,1,1),(32,1,7000,1,1,1,1,1),(33,1,8000,1,1,1,1,1),(34,1,9000,1,1,1,1,1),(35,2,1000,1,1,1,1,1),(36,3,2000,1,1,1,1,1),(37,4,3000,1,1,1,1,1),(38,5,5000,1,1,1,1,1),(39,6,6000,1,1,1,1,1),(40,6,6001,1,1,1,1,1),(41,6,6002,1,1,1,1,1),(42,6,6003,1,1,1,1,1),(43,6,6004,1,1,1,1,1),(44,6,6005,1,1,1,1,1),(45,6,6006,1,1,1,1,1),(46,6,6007,1,1,1,1,1),(47,6,6101,1,1,1,1,1),(48,6,6102,1,1,1,1,1),(49,6,6103,1,1,1,1,1),(50,6,6104,1,1,1,1,1),(51,6,6105,1,1,1,1,1),(52,6,6106,1,1,1,1,1),(53,6,6201,1,1,1,1,1),(54,6,6202,1,1,1,1,1),(55,6,6203,1,1,1,1,1),(56,6,6301,1,1,1,1,1),(57,7,7000,1,1,1,1,1),(58,8,8000,1,1,1,1,1),(59,9,9000,1,1,1,1,1),(60,10,1000,1,1,1,1,1),(61,10,1001,1,1,1,1,1),(62,10,1002,1,1,1,1,1),(63,10,1003,1,1,1,1,1),(64,10,1004,1,1,1,1,1),(65,10,1101,1,1,1,1,1),(66,10,1102,1,1,1,1,1),(67,10,1103,1,1,1,1,1),(68,10,1201,1,1,1,1,1),(69,10,1301,1,1,1,1,1),(70,10,2000,1,1,1,1,1),(71,10,3000,1,1,1,1,1),(72,10,5000,1,1,1,1,1),(73,10,6000,1,1,1,1,1),(74,10,6001,1,1,1,1,1),(75,10,6002,1,1,1,1,1),(76,10,6003,1,1,1,1,1),(77,10,6004,1,1,1,1,1),(78,10,6005,1,1,1,1,1),(79,10,6006,1,1,1,1,1),(80,10,6007,1,1,1,1,1),(81,10,6101,1,1,1,1,1),(82,10,6102,1,1,1,1,1),(83,10,6103,1,1,1,1,1),(84,10,6104,1,1,1,1,1),(85,10,6105,1,1,1,1,1),(86,10,6106,1,1,1,1,1),(87,10,6201,1,1,1,1,1),(88,10,6202,1,1,1,1,1),(89,10,6203,1,1,1,1,1),(90,10,6301,1,1,1,1,1),(91,10,7000,1,1,1,1,1),(92,10,8000,1,1,1,1,1),(93,10,9000,1,1,1,1,1),(94,11,1000,1,1,1,1,1),(95,11,1001,1,1,1,1,1),(96,11,1002,1,1,1,1,1),(97,11,1003,1,1,1,1,1),(98,11,1004,1,1,1,1,1),(99,11,1101,1,1,1,1,1),(100,11,1102,1,1,1,1,1),(101,11,1103,1,1,1,1,1),(102,11,1201,1,1,1,1,1),(103,11,1301,1,1,1,1,1),(104,11,2000,1,1,1,1,1),(105,11,3000,1,1,1,1,1),(106,11,5000,1,1,1,1,1),(107,11,6000,1,1,1,1,1),(108,11,6001,1,1,1,1,1),(109,11,6002,1,1,1,1,1),(110,11,6003,1,1,1,1,1),(111,11,6004,1,1,1,1,1),(112,11,6005,1,1,1,1,1),(113,11,6006,1,1,1,1,1),(114,11,6007,1,1,1,1,1),(115,11,6101,1,1,1,1,1),(116,11,6102,1,1,1,1,1),(117,11,6103,1,1,1,1,1),(118,11,6104,1,1,1,1,1),(119,11,6105,1,1,1,1,1),(120,11,6106,1,1,1,1,1),(121,11,6201,1,1,1,1,1),(122,11,6202,1,1,1,1,1),(123,11,6203,1,1,1,1,1),(124,11,6301,1,1,1,1,1),(125,11,7000,1,1,1,1,1),(126,11,8000,1,1,1,1,1),(127,11,9000,1,1,1,1,1),(128,12,1000,1,1,1,1,1),(129,12,1001,1,1,1,1,1),(130,12,1002,1,1,1,1,1),(131,12,1003,1,1,1,1,1),(132,12,1004,1,1,1,1,1),(133,12,1101,1,1,1,1,1),(134,12,1102,1,1,1,1,1),(135,12,1103,1,1,1,1,1),(136,12,1201,1,1,1,1,1),(137,12,1301,1,1,1,1,1),(138,12,2000,1,1,1,1,1),(139,12,3000,1,1,1,1,1),(140,12,5000,1,1,1,1,1),(141,12,6000,1,1,1,1,1),(142,12,6001,1,1,1,1,1),(143,12,6002,1,1,1,1,1),(144,12,6003,1,1,1,1,1),(145,12,6004,1,1,1,1,1),(146,12,6005,1,1,1,1,1),(147,12,6006,1,1,1,1,1),(148,12,6007,1,1,1,1,1),(149,12,6101,1,1,1,1,1),(150,12,6102,1,1,1,1,1),(151,12,6103,1,1,1,1,1),(152,12,6104,1,1,1,1,1),(153,12,6105,1,1,1,1,1),(154,12,6106,1,1,1,1,1),(155,12,6201,1,1,1,1,1),(156,12,6202,1,1,1,1,1),(157,12,6203,1,1,1,1,1),(158,12,6301,1,1,1,1,1),(159,12,7000,1,1,1,1,1),(160,12,8000,1,1,1,1,1),(161,12,9000,1,1,1,1,1),(162,13,1000,1,1,1,1,1),(163,13,1001,1,1,1,1,1),(164,13,1002,1,1,1,1,1),(165,13,1003,1,1,1,1,1),(166,13,1004,1,1,1,1,1),(167,13,1101,1,1,1,1,1),(168,13,1102,1,1,1,1,1),(169,13,1103,1,1,1,1,1),(170,13,1201,1,1,1,1,1),(171,13,1301,1,1,1,1,1),(172,13,2000,1,1,1,1,1),(173,13,3000,1,1,1,1,1),(174,13,5000,1,1,1,1,1),(175,13,6000,1,1,1,1,1),(176,13,6001,1,1,1,1,1),(177,13,6002,1,1,1,1,1),(178,13,6003,1,1,1,1,1),(179,13,6004,1,1,1,1,1),(180,13,6005,1,1,1,1,1),(181,13,6006,1,1,1,1,1),(182,13,6007,1,1,1,1,1),(183,13,6101,1,1,1,1,1),(184,13,6102,1,1,1,1,1),(185,13,6103,1,1,1,1,1),(186,13,6104,1,1,1,1,1),(187,13,6105,1,1,1,1,1),(188,13,6106,1,1,1,1,1),(189,13,6201,1,1,1,1,1),(190,13,6202,1,1,1,1,1),(191,13,6203,1,1,1,1,1),(192,13,6301,1,1,1,1,1),(193,13,7000,1,1,1,1,1),(194,13,8000,1,1,1,1,1),(195,13,9000,1,1,1,1,1),(196,14,1000,1,1,1,1,1),(197,14,1001,1,1,1,1,1),(198,14,1002,1,1,1,1,1),(199,14,1003,1,1,1,1,1),(200,14,1004,1,1,1,1,1),(201,14,1101,1,1,1,1,1),(202,14,1102,1,1,1,1,1),(203,14,1103,1,1,1,1,1),(204,14,1201,1,1,1,1,1),(205,14,1301,1,1,1,1,1),(206,14,2000,1,1,1,1,1),(207,14,3000,1,1,1,1,1),(208,14,5000,1,1,1,1,1),(209,14,6000,1,1,1,1,1),(210,14,6001,1,1,1,1,1),(211,14,6002,1,1,1,1,1),(212,14,6003,1,1,1,1,1),(213,14,6004,1,1,1,1,1),(214,14,6005,1,1,1,1,1),(215,14,6006,1,1,1,1,1),(216,14,6007,1,1,1,1,1),(217,14,6101,1,1,1,1,1),(218,14,6102,1,1,1,1,1),(219,14,6103,1,1,1,1,1),(220,14,6104,1,1,1,1,1),(221,14,6105,1,1,1,1,1),(222,14,6106,1,1,1,1,1),(223,14,6201,1,1,1,1,1),(224,14,6202,1,1,1,1,1),(225,14,6203,1,1,1,1,1),(226,14,6301,1,1,1,1,1),(227,14,7000,1,1,1,1,1),(228,14,8000,1,1,1,1,1),(229,14,9000,1,1,1,1,1);
/*!40000 ALTER TABLE `tbl_permisos_aplicacion_perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_permisos_aplicaciones_usuario`
--

LOCK TABLES `tbl_permisos_aplicaciones_usuario` WRITE;
/*!40000 ALTER TABLE `tbl_permisos_aplicaciones_usuario` DISABLE KEYS */;
INSERT INTO `tbl_permisos_aplicaciones_usuario` VALUES (1,1,1002,1,1,1,1,0),(2,1,2000,0,0,0,0,0),(3,1,1000,1,1,1,1,1),(4,1,8000,0,0,0,0,0),(6,1,1000,1,1,1,1,1),(7,1,1000,0,0,0,0,1),(8,1,9000,0,0,0,0,0);
/*!40000 ALTER TABLE `tbl_permisos_aplicaciones_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_planificacion`
--

LOCK TABLES `tbl_planificacion` WRITE;
/*!40000 ALTER TABLE `tbl_planificacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_planificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_proyecto`
--

LOCK TABLES `tbl_proyecto` WRITE;
/*!40000 ALTER TABLE `tbl_proyecto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_proyecto_estado`
--

LOCK TABLES `tbl_proyecto_estado` WRITE;
/*!40000 ALTER TABLE `tbl_proyecto_estado` DISABLE KEYS */;
INSERT INTO `tbl_proyecto_estado` VALUES (1,'Planificado','Proyecto definido pero no iniciado'),(2,'En Ejecución','Proyecto de auditoría en desarrollo'),(3,'Finalizado','Proyecto completado y cerrado'),(4,'Cancelado','Proyecto suspendido o no ejecutado');
/*!40000 ALTER TABLE `tbl_proyecto_estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_recursos`
--

LOCK TABLES `tbl_recursos` WRITE;
/*!40000 ALTER TABLE `tbl_recursos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recursos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_reporte`
--

LOCK TABLES `tbl_reporte` WRITE;
/*!40000 ALTER TABLE `tbl_reporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_rubrica`
--

LOCK TABLES `tbl_rubrica` WRITE;
/*!40000 ALTER TABLE `tbl_rubrica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_rubrica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_tabla_ponderacion`
--

LOCK TABLES `tbl_tabla_ponderacion` WRITE;
/*!40000 ALTER TABLE `tbl_tabla_ponderacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tabla_ponderacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbl_usuarios`
--

LOCK TABLES `tbl_usuarios` WRITE;
/*!40000 ALTER TABLE `tbl_usuarios` DISABLE KEYS */;
INSERT INTO `tbl_usuarios` VALUES (1,'admin','admin','admin','52c88f064ed5ed9161d01f634f5e3bfcf5c77fec94fb398b6690e1b41178eb6c','esduardo@gmail.com','2024-09-21 00:55:40',1,'COLOR FAVORITO','ROJO');
/*!40000 ALTER TABLE `tbl_usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-16 10:12:24
