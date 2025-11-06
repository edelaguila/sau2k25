Use auditoria;

INSERT INTO tbl_estado_asignacion VALUES (1,'Pendiente','Auditor asignado, pendiente de inicio'),(2,'En Curso','Auditor realizando las actividades asignadas'),(3,'Completada','Auditor finalizó la revisión'),(4,'Rechazada','Asignación anulada o devuelta');

INSERT INTO tbl_estado_informe VALUES (1,'Borrador','Informe en proceso de redacción'),(2,'Revisión','Informe en revisión por supervisor'),(3,'Aprobado','Informe final aprobado'),(4,'Archivado','Informe cerrado y almacenado');

INSERT INTO tbl_perfil_auditor VALUES (1,'Jefe Auditor','Responsable de la planificación general de las auditorías, supervisión de equipos y aprobación de informes finales.'),(2,'Auditor Administrador','Encargado de coordinar la asignación de auditores, controlar el avance de las auditorías y administrar los recursos del proyecto.'),(3,'Auditor','Profesional encargado de ejecutar las actividades de revisión, evaluación de criterios y elaboración de reportes técnicos.');

INSERT INTO tbl_proyecto_estado VALUES (1,'Planificado','Proyecto definido pero no iniciado'),(2,'En Ejecución','Proyecto de auditoría en desarrollo'),(3,'Finalizado','Proyecto completado y cerrado'),(4,'Cancelado','Proyecto suspendido o no ejecutado');

-- =======================
-- TABLAS BASE / CATÁLOGOS
-- =======================

-- tbl_proyecto_estado (ya insertado arriba)
-- tbl_estado_asignacion (ya insertado arriba)
-- tbl_estado_informe (ya insertado arriba)
-- tbl_perfil_auditor (ya insertado arriba)


-- =======================
-- PROYECTOS
-- =======================
INSERT INTO tbl_proyecto (Pk_id_proyecto, Fk_id_proyecto_estado, nombre_proyecto, descripcion, fecha_inicio, fecha_fin, objetivo, estado)
VALUES 
(1, 1, 'Auditoría Interna ISO 9001', 'Evaluar el cumplimiento de procesos con la norma ISO 9001:2015', '2025-01-10', '2025-03-30', 'Garantizar la mejora continua y la conformidad del sistema de gestión de calidad.', 1),
(2, 2, 'Auditoría de Seguridad Informática', 'Revisión de vulnerabilidades en la infraestructura TI', '2025-02-15', '2025-05-20', 'Reducir los riesgos de ciberseguridad mediante controles internos.', 1),
(3, 3, 'Auditoría de Recursos Humanos', 'Evaluación de procesos de contratación y retención de personal', '2024-09-01', '2024-11-15', 'Asegurar la equidad y cumplimiento de políticas laborales.', 1);

-- =======================
-- ÁREAS
-- =======================
INSERT INTO tbl_areas (Pk_id_area, Fk_id_proyecto, nombre_area, descripcion, estado_area, estado)
VALUES
(1, 1, 'Producción', 'Área encargada de la manufactura y control de calidad', 'Activa', 1),
(2, 1, 'Compras', 'Gestión de proveedores y adquisiciones', 'Activa', 1),
(3, 2, 'Sistemas', 'Departamento responsable de la infraestructura TI', 'Activa', 1),
(4, 3, 'Recursos Humanos', 'Gestión del personal y relaciones laborales', 'Activa', 1);

-- =======================
-- AUDITORES
-- =======================
INSERT INTO tbl_auditor 
(Pk_id_auditor, nombre_auditor, telefono_auditor, email_auditor, carnet_auditor, Estado, Fk_id_perfil_auditor, Fk_id_proyecto) 
VALUES 
(1, 'Carlos Gómez', '5551-1234', 'carlos.gomez@empresa.com', 'AUD-001', 'A', 1, 1),
(2, 'María López', '5552-5678', 'maria.lopez@empresa.com', 'AUD-002', 'A', 2, 2),
(3, 'Juan Pérez', '5553-9012', 'juan.perez@empresa.com', 'AUD-003', 'A', 3, 1),
(4, 'Ana Rodríguez', '5554-3456', 'ana.rodriguez@empresa.com', 'AUD-004', 'A', 3, 3);

-- =======================
-- AUDITADOS
-- =======================
INSERT INTO tbl_auditados (Pk_id_auditado, Fk_id_proyecto, nombre_auditado, cargo_o_area, correo, telefono, observaciones, estado)
VALUES
(1, 1, 'Luis Martínez', 'Jefe de Producción', 'luis.martinez@empresa.com', '5556-1111', 'Participa en auditoría de control de calidad.', 1),
(2, 1, 'Sofía Herrera', 'Compras', 'sofia.herrera@empresa.com', '5556-2222', 'Encargada de documentación de compras.', 1),
(3, 2, 'Pedro Ramírez', 'Administrador de Redes', 'pedro.ramirez@empresa.com', '5556-3333', 'Responsable de servidores y seguridad.', 1),
(4, 3, 'Claudia Méndez', 'RRHH', 'claudia.mendez@empresa.com', '5556-4444', 'Encargada de procesos de selección.', 1);

-- =======================
-- ACTIVIDADES DE PROYECTO
-- =======================
INSERT INTO tbl_actividades_proyecto (Pk_id_actividad_proyecto, Fk_id_proyecto, nombre_actividad, descripcion, observaciones, estado)
VALUES
(1, 1, 'Revisión documental', 'Análisis de procedimientos ISO 9001', '', 1),
(2, 1, 'Visita a planta', 'Verificación de cumplimiento de controles operativos', '', 1),
(3, 2, 'Prueba de penetración', 'Test de seguridad a la red interna', '', 1),
(4, 3, 'Entrevistas al personal', 'Revisión de procesos de contratación y capacitación', '', 1);

-- =======================
-- PLANIFICACIÓN Y CRONOGRAMA
-- =======================
INSERT INTO tbl_planificacion (Pk_id_planificacion, Fk_id_proyecto, nombre_plan, descripcion, fecha_inicio, fecha_fin, observaciones, estado)
VALUES
(1, 1, 'Plan ISO9001 2025', 'Plan de auditoría para procesos de calidad', '2025-01-10', '2025-03-30', '', 1),
(2, 2, 'Plan Ciberseguridad 2025', 'Plan de evaluación de seguridad TI', '2025-02-15', '2025-05-20', '', 1);

INSERT INTO tbl_cronograma (Pk_id_cronograma, Fk_id_planificacion, Fk_id_actividad_proyecto, nombre_tarea, descripcion, fecha_inicio, fecha_fin, responsable_tarea, estado_tarea, estado)
VALUES
(1, 1, 1, 'Revisión de documentos', 'Analizar políticas internas de calidad', '2025-01-12', '2025-01-20', 'Carlos Gómez', 'En curso', 1),
(2, 1, 2, 'Auditoría en planta', 'Revisar registros y procedimientos', '2025-01-22', '2025-02-05', 'Juan Pérez', 'Pendiente', 1),
(3, 2, 3, 'Evaluación de firewall', 'Pruebas de seguridad perimetral', '2025-03-10', '2025-03-20', 'María López', 'Pendiente', 1);

-- =======================
-- RUBRICAS Y CRITERIOS
-- =======================
INSERT INTO tbl_rubrica (Pk_id_rubrica, Fk_id_cronograma, nombre_rubrica, descripcion, objetivo, estado)
VALUES
(1, 1, 'Cumplimiento documental', 'Evalúa si los procedimientos cumplen ISO 9001', 'Verificar estandarización', 1),
(2, 3, 'Seguridad de red', 'Evalúa robustez de medidas de ciberseguridad', 'Garantizar integridad de la red', 1);

INSERT INTO tbl_criterios (Pk_id_criterio, Fk_id_rubrica, nombre_criterio, porcentaje_criterio, descripcion, nivel_importancia, estado)
VALUES
(1, 1, 'Actualización de manuales', 30, 'Los documentos deben estar actualizados y aprobados.', 'Alta', 1),
(2, 1, 'Control de registros', 40, 'Los registros deben estar completos y disponibles.', 'Media', 1),
(3, 2, 'Configuración segura de servidores', 50, 'Los servidores deben seguir estándares de seguridad.', 'Alta', 1),
(4, 2, 'Monitoreo activo', 50, 'Existencia de herramientas de detección de intrusiones.', 'Alta', 1);

-- =======================
-- ESCALA DE DESCRIPCIÓN
-- =======================
INSERT INTO tbl_escala_descripcion (Pk_id_escala, porcentaje, nombre_nivel, descripcion_general, color_referencia, estado)
VALUES
(1, 0, 'Deficiente', 'No cumple los requisitos mínimos.', 'Rojo', 1),
(2, 40, 'Regular', 'Cumple parcialmente los requisitos.', 'Naranja', 1),
(3, 60, 'Aceptable', 'Cumple los requisitos esenciales.', 'Amarillo', 1),
(4, 80, 'Bueno', 'Cumple la mayoría de los requisitos de manera sólida.', 'Verde', 1),
(5, 100, 'Excelente', 'Cumple totalmente los requisitos establecidos.', 'Azul', 1);

-- =======================
-- INFORMES Y CHECKLIST
-- =======================
INSERT INTO tbl_informe (Pk_id_informe, Fk_id_auditor, Fk_id_estado_informe, titulo_informe, descripcion_general, conclusiones, fecha_actualizacion, estado)
VALUES
(1, 1, 2, 'Informe de Auditoría ISO 9001', 'Resultados preliminares de la auditoría de calidad.', 'Cumplimiento general del 85%.', '2025-03-28 14:00:00', 1),
(2, 2, 1, 'Informe de Seguridad Informática', 'Análisis inicial de vulnerabilidades.', 'Se identificaron áreas críticas a reforzar.', '2025-04-10 09:00:00', 1);

INSERT INTO tbl_checklist (Pk_id_checklist, Fk_id_informe, Fk_id_criterio, estado)
VALUES
(1, 1, 1, 1),
(2, 1, 2, 1),
(3, 2, 3, 1);

-- =======================
-- RECURSOS
-- =======================
INSERT INTO tbl_recursos (Pk_id_recurso, Fk_id_proyecto, nombre_recurso, tipo_recurso, cantidad, estado)
VALUES
(1, 1, 'Laptop Dell', 'Equipo de cómputo', 3, 1),
(2, 2, 'Software Nessus', 'Herramienta de escaneo de vulnerabilidades', 1, 1),
(3, 3, 'Cuestionarios de entrevista', 'Material impreso', 10, 1);

-- =======================
-- TABLA DE PONDERACIÓN
-- =======================
INSERT INTO tbl_tabla_ponderacion (Fk_id_auditado, Fk_id_cronograma, Fk_id_rubrica, Fk_id_criterio, Fk_id_escala, calificacion_porcentaje, calificacion_ponderada, comentarios_auditor, estado)
VALUES
(1, 1, 1, 1, 5, 100.00, 30.00, 'Documentos totalmente actualizados.', 1),
(1, 1, 1, 2, 4, 80.00, 32.00, 'Registros completos pero con retrasos.', 1),
(3, 3, 2, 3, 3, 60.00, 30.00, 'Configuraciones aceptables pero sin automatización.', 1);

ALTER TABLE tbl_actividades_proyecto ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_areas ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_asignacion ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_auditados ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_checklist ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_criterios ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_cronograma ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_descripcion_criterio ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_escala_descripcion ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_estado_asignacion ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_estado_informe ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_grafica ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_informe ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_perfil_auditor ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_planificacion ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_proyecto ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_proyecto_auditado ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_proyecto_estado ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_recursos ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_reporte ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_rubrica ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_tabla_ponderacion ADD COLUMN estado TINYINT(1) DEFAULT 1;
ALTER TABLE tbl_auditor MODIFY email_auditor varchar(100) DEFAULT NULL;

-- For MySQL
ALTER TABLE tbl_tabla_ponderacion
MODIFY COLUMN fecha_evaluacion DATETIME;

-- For SQL Server
ALTER TABLE tbl_tabla_ponderacion 
MODIFY COLUMN fecha_evaluacion DATETIME;

ALTER TABLE tbl_recursos
MODIFY COLUMN fecha_registro DATETIME NULL;

select* from tbl_auditor;