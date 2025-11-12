use auditoria;

-- creación de la tabla para Brandon Boch-----------------------------------------------------------------------------------------
DROP TABLE IF EXISTS nota_actividad;
CREATE TABLE nota_actividad (
  pk_id_nota_actividad INT NOT NULL AUTO_INCREMENT,
  fk_auditado INT NOT NULL,
  fk_auditor INT NOT NULL,
  fk_actividad INT NOT NULL,
  nota INT NOT NULL,
  PRIMARY KEY (pk_id_nota_actividad),
  KEY fk_auditado (fk_auditado),
  KEY fk_auditor (fk_auditor),
  KEY fk_actividad (fk_actividad),
  CONSTRAINT nota_actividad_ibfk_1 FOREIGN KEY (fk_auditado) REFERENCES tbl_auditados (Pk_id_auditado),
  CONSTRAINT nota_actividad_ibfk_2 FOREIGN KEY (fk_auditor) REFERENCES tbl_auditor (Pk_id_auditor),
  CONSTRAINT nota_actividad_ibfk_3 FOREIGN KEY (fk_actividad) REFERENCES tbl_actividades_proyecto (Pk_id_actividad_proyecto)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Alter Table para agregar el estado a las tablas que lo necesitan (se revisó con Daniel Moscoso el 11-11-2025 en clase)--
-- Alter para estado
use auditoria;

ALTER TABLE tbl_proyecto
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_auditados
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_asignacion
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_cronograma
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_recursos
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_tabla_ponderacion
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_actividades_proyecto
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';

ALTER TABLE tbl_proyecto_auditado
ADD estado VARCHAR(1) NOT NULL DEFAULT 'A';


