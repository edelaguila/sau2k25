Use auditoria;
CREATE TABLE tbl_asignacion_auditor_auditado (
  Pk_id_asignacion_auditor_auditado INT AUTO_INCREMENT PRIMARY KEY,
  Fk_id_auditor INT NOT NULL,
  Fk_id_auditado INT NOT NULL,
  Fk_id_proyecto INT NOT NULL,
  Fk_id_actividad_proyecto INT NULL,
  Fk_id_estado_asignacion INT DEFAULT 1, -- Pendiente por defecto
  fecha_asignacion DATETIME DEFAULT CURRENT_TIMESTAMP,
  fecha_finalizacion DATETIME NULL,
  observaciones TEXT,
  estado TINYINT(1) DEFAULT 1,
  CONSTRAINT fk_aaa_auditor FOREIGN KEY (Fk_id_auditor) REFERENCES tbl_auditor (Pk_id_auditor),
  CONSTRAINT fk_aaa_auditado FOREIGN KEY (Fk_id_auditado) REFERENCES tbl_auditados (Pk_id_auditado),
  CONSTRAINT fk_aaa_proyecto FOREIGN KEY (Fk_id_proyecto) REFERENCES tbl_proyecto (Pk_id_proyecto),
  CONSTRAINT fk_aaa_actividad FOREIGN KEY (Fk_id_actividad_proyecto) REFERENCES tbl_actividades_proyecto (Pk_id_actividad_proyecto),
  CONSTRAINT fk_aaa_estado FOREIGN KEY (Fk_id_estado_asignacion) REFERENCES tbl_estado_asignacion (Pk_id_estado_asignacion)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

USE Auditoria;

-- ======================================================
-- 0) CATÁLOGOS / ESTADOS / PERFILES (insert seguro para evitar duplicados)
-- ======================================================

-- Nuevo estado de proyecto solicitado
INSERT INTO tbl_proyecto_estado (Pk_id_proyecto_estado, nombre_estado, descripcion_estado, estado)
VALUES 
(1, 'Planificado', 'Proyecto definido pero no iniciado', 1),
(2, 'En Ejecución', 'Proyecto de auditoría en desarrollo', 1),
(3, 'Finalizado', 'Proyecto completado y cerrado', 1),
(4, 'Cancelado', 'Proyecto suspendido o no ejecutado', 1);


-- (Aseguramos que existan los estados y perfiles base; si ya existen no se duplican)
INSERT INTO tbl_estado_asignacion (Pk_id_estado_asignacion, estado_asignacion, descripcion_estado_asignacion, estado)
VALUES 
(1,'Pendiente','Auditor asignado, pendiente de inicio',1),
(2,'En Curso','Auditor realizando las actividades asignadas',1),
(3,'Completada','Auditor finalizó la revisión',1),
(4,'Rechazada','Asignación anulada o devuelta',1)
ON DUPLICATE KEY UPDATE Pk_id_estado_asignacion = Pk_id_estado_asignacion;

INSERT INTO tbl_estado_informe (Pk_id_estado_informe, nombre_estado, descripcion, estado)
VALUES 
(1,'Borrador','Informe en proceso de redacción',1),
(2,'Revisión','Informe en revisión por supervisor',1),
(3,'Aprobado','Informe final aprobado',1),
(4,'Archivado','Informe cerrado y almacenado',1)
ON DUPLICATE KEY UPDATE Pk_id_estado_informe = Pk_id_estado_informe;

INSERT INTO tbl_perfil_auditor (Pk_id_perfil_auditor, nombre_perfil, descripcion_perfil, estado)
VALUES
(1,'Jefe Auditor','Responsable de la planificación general de las auditorías, supervisión de equipos y aprobación de informes finales.',1),
(2,'Auditor Administrador','Encargado de coordinar la asignación de auditores, controlar el avance de las auditorías y administrar los recursos del proyecto.',1),
(3,'Auditor','Profesional encargado de ejecutar las actividades de revisión, evaluación de criterios y elaboración de reportes técnicos.',1)
ON DUPLICATE KEY UPDATE Pk_id_perfil_auditor = Pk_id_perfil_auditor;

INSERT INTO tbl_escala_descripcion (Pk_id_escala, porcentaje, nombre_nivel, descripcion_general, color_referencia, estado)
VALUES
(1, 0, 'Deficiente', 'No cumple los requisitos mínimos.', 'Rojo', 1),
(2, 40, 'Regular', 'Cumple parcialmente los requisitos.', 'Naranja', 1),
(3, 60, 'Aceptable', 'Cumple los requisitos esenciales.', 'Amarillo', 1),
(4, 80, 'Bueno', 'Cumple la mayoría de los requisitos de manera sólida.', 'Verde', 1),
(5, 100, 'Excelente', 'Cumple totalmente los requisitos establecidos.', 'Azul', 1)
ON DUPLICATE KEY UPDATE Pk_id_escala = Pk_id_escala;


-- ======================================================
-- 1) PROYECTO (contexto)
-- ======================================================
INSERT INTO tbl_proyecto (Pk_id_proyecto, Fk_id_proyecto_estado, nombre_proyecto, descripcion, fecha_inicio, fecha_fin, objetivo, estado)
VALUES 
(10, 1, 'Auditoría de Producción 2025', 
 'Evaluar el cumplimiento de los procedimientos de manufactura según ISO 9001:2015.',
 '2025-04-01', '2025-06-30',
 'Garantizar la trazabilidad de procesos y calidad de producto.', 1)
ON DUPLICATE KEY UPDATE Pk_id_proyecto = Pk_id_proyecto;


-- ======================================================
-- 2) ÁREA
-- ======================================================
INSERT INTO tbl_areas (Pk_id_area, Fk_id_proyecto, nombre_area, descripcion, estado_area, estado)
VALUES
(10, 10, 'Área de Empaque', 'Se revisará el cumplimiento de estándares de etiquetado y almacenamiento.', 'Activa', 1)
ON DUPLICATE KEY UPDATE Pk_id_area = Pk_id_area;


-- ======================================================
-- 3) ACTIVIDADES DEL PROYECTO
-- ======================================================
INSERT INTO tbl_actividades_proyecto (Pk_id_actividad_proyecto, Fk_id_proyecto, nombre_actividad, descripcion, observaciones, estado)
VALUES
(10, 10, 'Revisión de documentación de procesos', 'Verificación de procedimientos de empaque y control de calidad.', 'Actividad inicial para el levantamiento de información.', 1),
(11, 10, 'Visita técnica a planta de empaque', 'Evaluar cumplimiento operativo y registros en sitio.', 'Segunda fase de la auditoría.', 1)
ON DUPLICATE KEY UPDATE Pk_id_actividad_proyecto = Pk_id_actividad_proyecto;


-- ======================================================
-- 4) PLANIFICACIÓN Y CRONOGRAMA
-- ======================================================
INSERT INTO tbl_planificacion (Pk_id_planificacion, Fk_id_proyecto, nombre_plan, descripcion, fecha_inicio, fecha_fin, observaciones, estado)
VALUES
(10, 10, 'Plan Auditoría Empaque', 'Plan general para la auditoría del área de empaque.', '2025-04-01', '2025-06-30', '', 1)
ON DUPLICATE KEY UPDATE Pk_id_planificacion = Pk_id_planificacion;

INSERT INTO tbl_cronograma (Pk_id_cronograma, Fk_id_planificacion, Fk_id_actividad_proyecto, nombre_tarea, descripcion, fecha_inicio, fecha_fin, responsable_tarea, estado_tarea, estado)
VALUES
(10, 10, 10, 'Revisión de documentos', 'Analizar procedimientos de empaque y registros de control de calidad.', 
 '2025-04-05', '2025-04-15', 'Carlos Gómez', 'Pendiente', 1)
ON DUPLICATE KEY UPDATE Pk_id_cronograma = Pk_id_cronograma;


-- ======================================================
-- 5) RÚBRICA Y CRITERIOS
-- ======================================================
INSERT INTO tbl_rubrica (Pk_id_rubrica, Fk_id_cronograma, nombre_rubrica, descripcion, objetivo, estado)
VALUES
(10, 10, 'Cumplimiento de control documental', 'Verifica que los documentos estén actualizados y aprobados.', 
 'Garantizar documentación conforme a ISO 9001:2015.', 1)
ON DUPLICATE KEY UPDATE Pk_id_rubrica = Pk_id_rubrica;

INSERT INTO tbl_criterios (Pk_id_criterio, Fk_id_rubrica, nombre_criterio, porcentaje_criterio, descripcion, nivel_importancia, estado)
VALUES
(10, 10, 'Actualización de registros de calidad', 40, 'Los registros deben reflejar los cambios recientes del proceso.', 'Alta', 1),
(11, 10, 'Disponibilidad de manuales de empaque', 60, 'Los manuales deben estar accesibles para el personal operativo.', 'Media', 1)
ON DUPLICATE KEY UPDATE Pk_id_criterio = Pk_id_criterio;


-- ======================================================
-- 6) AUDITORES (asegurar perfil y proyecto referenciados existan)
-- ======================================================
INSERT INTO tbl_auditor (Pk_id_auditor, nombre_auditor, telefono_auditor, email_auditor, carnet_auditor, Estado, Fk_id_perfil_auditor, Fk_id_proyecto)
VALUES
(10, 'Roberto Castillo', '5566-1100', 'roberto.castillo@empresa.com', 'AUD-010', 'A', 3, 10)
ON DUPLICATE KEY UPDATE Pk_id_auditor = Pk_id_auditor;


-- ======================================================
-- 7) AUDITADOS
-- ======================================================
INSERT INTO tbl_auditados (Pk_id_auditado, Fk_id_proyecto, nombre_auditado, cargo_o_area, correo, telefono, observaciones, estado)
VALUES
(10, 10, 'Laura Martínez', 'Supervisora de Empaque', 'laura.martinez@empresa.com', '5566-2211', 'Responsable de los procesos documentales del área.', 1)
ON DUPLICATE KEY UPDATE Pk_id_auditado = Pk_id_auditado;


-- ======================================================
-- 8) ASIGNACIÓN DE AUDITOR AL PROYECTO (tbl_proyecto_auditado)
-- ======================================================
INSERT INTO tbl_proyecto_auditado (Pk_id_auditor_proyecto, Fk_id_auditor, Fk_id_proyecto, rol_en_proyecto, fecha_asignacion, observaciones, estado)
VALUES
(10, 10, 10, 'Auditor principal', CURDATE(), 'Asignado para revisión del área de empaque.', 1)
ON DUPLICATE KEY UPDATE Pk_id_auditor_proyecto = Pk_id_auditor_proyecto;


-- ======================================================
-- 9) ASIGNACIÓN DEL AUDITOR A UNA ACTIVIDAD (tbl_asignacion)
-- ======================================================
INSERT INTO tbl_asignacion (
  Pk_id_asignacion, Fk_id_auditor, Fk_id_estado_asignacion, Fk_id_actividad_proyecto, 
  nombre_asignacion, fecha_asignacion, fecha_finalizacion, descripcion, evidencia, observaciones, estado
)
VALUES
(10, 10, 1, 10, 'Revisión documental área empaque', CURDATE(), NULL, 
 'Verificación de manuales y registros ISO.', NULL, 'Asignación inicial.', 1)
ON DUPLICATE KEY UPDATE Pk_id_asignacion = Pk_id_asignacion;


-- ======================================================
-- 10) NUEVA TABLA: ASIGNACIÓN DIRECTA AUDITOR ↔ AUDITADO
--     (Inserta la relación que necesitas para el proceso 7)
-- ======================================================
-- Asegúrate de que la tabla tbl_asignacion_auditor_auditado existe en tu LDD.
INSERT INTO tbl_asignacion_auditor_auditado (
  Fk_id_auditor, Fk_id_auditado, Fk_id_proyecto, Fk_id_actividad_proyecto, Fk_id_estado_asignacion, fecha_asignacion, observaciones, estado
)
VALUES
(10, 10, 10, 10, 1, NOW(), 'Auditor Roberto Castillo asignado a revisar a Laura Martínez en la actividad de documentación.', 1)
ON DUPLICATE KEY UPDATE Fk_id_auditor = Fk_id_auditor;


-- ======================================================
-- 12) EJEMPLO DE TABLA DE PONDERACIÓN (resultado final / evaluaciones)
-- ======================================================
INSERT INTO tbl_tabla_ponderacion (Fk_id_auditado, Fk_id_cronograma, Fk_id_rubrica, Fk_id_criterio, Fk_id_escala, calificacion_porcentaje, calificacion_ponderada, comentarios_auditor, fecha_evaluacion, estado)
VALUES
(10, 10, 10, 10, 5, 100.00, 40.00, 'Registros totalmente actualizados.', NOW(), 1)
ON DUPLICATE KEY UPDATE Pk_id_ponderacion = Pk_id_ponderacion;


-- ======================================================
-- 13) INFORMES Y CHECKLIST (ejemplos mínimos)
-- ======================================================
INSERT INTO tbl_informe (Pk_id_informe, Fk_id_auditor, Fk_id_estado_informe, titulo_informe, descripcion_general, conclusiones, fecha_actualizacion, estado)
VALUES
(10, 10, 1, 'Informe - Empaque', 'Informe preliminar de auditoría de empaque.', 'Observaciones iniciales.', NOW(), 1)
ON DUPLICATE KEY UPDATE Pk_id_informe = Pk_id_informe;

INSERT INTO tbl_checklist (Pk_id_checklist, Fk_id_informe, Fk_id_criterio, estado)
VALUES
(10, 10, 10, 1)
ON DUPLICATE KEY UPDATE Pk_id_checklist = Pk_id_checklist;


-- ======================================================
-- 14) RECURSOS (opcional)
-- ======================================================
INSERT INTO tbl_recursos (Pk_id_recurso, Fk_id_proyecto, nombre_recurso, tipo_recurso, cantidad, fecha_registro, estado)
VALUES
(10, 10, 'Laptop Auditor', 'Equipo de cómputo', 1, NOW(), 1)
ON DUPLICATE KEY UPDATE Pk_id_recurso = Pk_id_recurso;


-- ======================================================
-- FIN - Confirmación
-- ======================================================
-- Si todo va bien, ahora tienes:
--  - Nuevo estado de proyecto (id = 5)
--  - Proyecto 10 + área 10 + actividades 10/11
--  - Auditor 10 y Auditado 10
--  - Asignaciones: proyecto_auditado, asignacion (actividad), tbl_asignacion_auditor_auditado (vínculo directo)
--  - Entrada en historial (si aplica) y una ponderación de ejemplo


select* from tbl_auditor;
select* from tbl_proyecto;
SELECT * FROM tbl_proyecto_estado;



