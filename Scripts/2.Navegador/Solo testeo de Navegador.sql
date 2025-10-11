use Auditoria;

-- Para testeo de navegador
CREATE TABLE `tbl_empleados` (
  `pk_clave` int NOT NULL AUTO_INCREMENT,
  `empleados_nombre` varchar(50) NOT NULL,
  `empleados_apellido` varchar(50) DEFAULT NULL,
  `empleados_fecha_nacimiento` date DEFAULT NULL,
  `empleados_no_identificacion` varchar(50) NOT NULL,
  `empleados_codigo_postal` varchar(50) DEFAULT NULL,
  `empleados_fecha_alta` date DEFAULT NULL,
  `empleados_fecha_baja` date DEFAULT NULL,
  `empleados_causa_baja` varchar(50) DEFAULT NULL,

  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_clave`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `tbl_horas_extra` (
  `pk_registro_horas` int NOT NULL AUTO_INCREMENT,
  `horas_mes` varchar(25) DEFAULT NULL,
  `horas_cantidad_horas` int DEFAULT NULL,
  `fk_clave_empleado` int NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_horas`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  CONSTRAINT `tbl_horas_extra_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
