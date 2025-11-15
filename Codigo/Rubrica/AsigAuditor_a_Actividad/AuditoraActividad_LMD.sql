INSERT INTO tbl_proyecto (Pk_id_proyecto, Fk_id_proyecto_estado, nombre_proyecto, descripcion) 
VALUES (1, 1, 'Proyecto Auditoría Interna', 'Auditoría del sistema de calidad');
INSERT INTO tbl_auditor 
(Pk_id_auditor, nombre_auditor, telefono_auditor, email_auditor, carnet_auditor, Estado, 
 Fk_id_perfil_auditor, Fk_id_proyecto)
VALUES
(1, 'Carlos Pérez', '5555-1234', 'carlos@example.com', 'AUD001', 'A', 1, 1),
(2, 'María Gómez', '5555-5678', 'maria@example.com', 'AUD002', 'A', 2, 1);
INSERT INTO tbl_actividades_proyecto 
(Pk_id_actividad_proyecto, Fk_id_proyecto, nombre_actividad, descripcion)
VALUES
(1, 1, 'Revisión de Documentos', 'Revisar políticas y procedimientos'),
(2, 1, 'Entrevistas', 'Realizar entrevistas al personal'),
(3, 1, 'Evaluación de Controles', 'Analizar controles internos');