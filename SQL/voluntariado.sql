CREATE DATABASE VOLUNTARIADO_G2
GO
USE VOLUNTARIADO_G2
GO

CREATE TABLE CURSO(
	ID SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	DESCRIPCION VARCHAR(50) NOT NULL
);
GO

CREATE TABLE DIA(
	DESCRIPCION CHAR(9) PRIMARY KEY
);
GO

CREATE TABLE HORA(
	DIA CHAR(9) FOREIGN KEY REFERENCES DIA(DESCRIPCION) NOT NULL,
	HORA_INICIO TIME NOT NULL,
	HORA_FIN TIME NOT NULL,
	CONSTRAINT PK_HORA PRIMARY KEY (DIA, HORA_INICIO, HORA_FIN)
);
GO

CREATE TABLE ORGANIZACION(
	ID SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	NOMBRE NVARCHAR(30) NOT NULL,
	NOMBRE_RESPONSABLE NVARCHAR(40) NOT NULL,
	APELLIDO1_RESPONSABLE NVARCHAR(40) NOT NULL,
	APELLIDO2_RESPONSABLE NVARCHAR(40),
	FECHA_REGISTRO DATE CHECK (FECHA_REGISTRO <= GETDATE()) DEFAULT GETDATE() NOT NULL
);
CREATE UNIQUE INDEX IX_ORGANIZACION_NOMBRE ON ORGANIZACION(NOMBRE);
GO

CREATE TABLE TIPO(
	ID SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	DESCRIPCION VARCHAR(20) NOT NULL
);
GO

CREATE TABLE ODS(
	ID SMALLINT PRIMARY KEY,
	DESCRIPCION NVARCHAR(50) UNIQUE NOT NULL
);
GO

CREATE TABLE ACTIVIDAD(
	ID SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	NOMBRE NVARCHAR(35) NOT NULL,
	DESCRIPCION NVARCHAR(100) NOT NULL,
	ESTADO CHAR(1) CHECK (lower(ESTADO) IN ('a', 'f', 'p', 'c', 'r')) NOT NULL,
	CONVOCADA_POR SMALLINT FOREIGN KEY REFERENCES ORGANIZACION(ID) NOT NULL,
	FECHA_INICIO DATE NOT NULL,
	FECHA_FIN DATE NOT NULL,
	HORA_INICIO TIME NOT NULL,
	HORA_FIN TIME NOT NULL,
	TECNICO_DE SMALLINT FOREIGN KEY REFERENCES CURSO(ID),
    CONSTRAINT CK_FECHAS_ACTIVIDAD CHECK (FECHA_INICIO <= FECHA_FIN)
);
CREATE INDEX IX_ACTIVIDAD_NOMBREYESTADO ON ACTIVIDAD(NOMBRE, ESTADO);
GO

CREATE TABLE VOLUNTARIO(
	NIF CHAR(10) CHECK (UPPER(NIF) LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]' OR UPPER(NIF) LIKE '[A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]') PRIMARY KEY,
	NOMBRE NVARCHAR(40) NOT NULL,
	APELLIDO1 NVARCHAR(40) NOT NULL,
	APELLIDO2 NVARCHAR(40),
	TELEFONO CHAR(9) CHECK (TELEFONO LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CORREO VARCHAR(50) CHECK (CORREO LIKE '%@%.%') NOT NULL,
	EXPERIENCIA NVARCHAR(300),
	ESTUDIA SMALLINT FOREIGN KEY REFERENCES CURSO(ID) NOT NULL
);
CREATE INDEX IX_VOLUNTARIO_NOMBRECOMPLETO ON VOLUNTARIO(APELLIDO1, APELLIDO2, NOMBRE);
GO

CREATE TABLE INTERES(
	ID_TIPO SMALLINT FOREIGN KEY REFERENCES TIPO(ID) NOT NULL,
	NIF_VOLUNTARIO CHAR(10) FOREIGN KEY REFERENCES VOLUNTARIO(NIF) NOT NULL,
	CONSTRAINT PK_INTERES PRIMARY KEY (ID_TIPO, NIF_VOLUNTARIO)
);
GO

CREATE TABLE ES_DE_TIPO(
	ID_TIPO SMALLINT FOREIGN KEY REFERENCES TIPO(ID) NOT NULL,
	ID_ACTIVIDAD SMALLINT FOREIGN KEY REFERENCES ACTIVIDAD(ID) NOT NULL,
	CONSTRAINT PK_ES_DE_TIPO PRIMARY KEY (ID_TIPO, ID_ACTIVIDAD)
);
GO

CREATE TABLE REALIZA(
	ID_ACTIVIDAD SMALLINT FOREIGN KEY REFERENCES ACTIVIDAD(ID) NOT NULL,
	NIF_VOLUNTARIO CHAR(10) FOREIGN KEY REFERENCES VOLUNTARIO(NIF) NOT NULL,
	CONSTRAINT PK_REALIZA PRIMARY KEY (ID_ACTIVIDAD, NIF_VOLUNTARIO)
);
GO

CREATE TABLE DISPONE_DE(
	NIF_VOLUNTARIO CHAR(10) FOREIGN KEY REFERENCES VOLUNTARIO(NIF) NOT NULL,
	DIA CHAR(9) NOT NULL,
	HORA_INICIO TIME NOT NULL,
	HORA_FIN TIME NOT NULL,
	CONSTRAINT PK_DISPONE_DE PRIMARY KEY (NIF_VOLUNTARIO, DIA, HORA_INICIO, HORA_FIN),
	CONSTRAINT FK_DISPONE_DE_HORA FOREIGN KEY (DIA, HORA_INICIO, HORA_FIN) REFERENCES HORA(DIA, HORA_INICIO, HORA_FIN)
);
GO

CREATE TABLE CUMPLE_CON(
	ID_ACTIVIDAD SMALLINT FOREIGN KEY REFERENCES ACTIVIDAD(ID) NOT NULL,
	ID_ODS SMALLINT FOREIGN KEY REFERENCES ODS(ID) NOT NULL,
	CONSTRAINT PK_CUMPLE_CON PRIMARY KEY (ID_ACTIVIDAD, ID_ODS)
);
GO

CREATE RULE CK_DIAS_VALIDOS AS @CAMPO IN ('lunes', 'martes', 'miercoles', 'jueves', 'viernes', 'sabado', 'domingo');
GO

EXEC sp_bindrule 'CK_DIAS_VALIDOS', 'DIA.DESCRIPCION';
EXEC sp_bindrule 'CK_DIAS_VALIDOS', 'HORA.DIA';
EXEC sp_bindrule 'CK_DIAS_VALIDOS', 'DISPONE_DE.DIA';
GO

INSERT INTO dbo.DIA (DESCRIPCION) VALUES
('lunes'), ('martes'), ('miercoles'), ('jueves'), ('viernes'), ('sabado'), ('domingo');

INSERT INTO dbo.CURSO (DESCRIPCION) VALUES
('1ºDAM'), ('1ºASIR'), ('1ºTL'), ('1ºGVE');

INSERT INTO dbo.ODS (ID, DESCRIPCION) VALUES
(1, 'Fin de la pobreza'),(2, 'Hambre cero'),(3, 'Salud y bienestar'),
(4, 'Educación de calidad'),(5, 'Igualdad de género'),(6, 'Agua limpia y saneamiento'),
(7, 'Energía asequible y no contaminante'),(8, 'Trabajo decente y crecimiento económico'),
(9, 'Industria, innovación e infraestructura'),(10, 'Reducción de las desigualdades'),
(11, 'Ciudades y comunidades sostenibles'),(12, 'Producción y consumo responsables'),
(13, 'Acción por el clima'),(14, 'Vida submarina'),(15, 'Vida de ecosistemas terrestres'),
(16, 'Paz, justicia e instituciones sólidas'),(17, 'Alianzas para lograr los objetivos');

INSERT INTO dbo.TIPO (DESCRIPCION) VALUES
('Medio Ambiente'), ('Social'), ('Educación'), ('Salud'), ('Cultura'),
('Deporte'), ('Protección Animal'), ('Tecnológico'), ('Emergencias');

INSERT INTO dbo.HORA (DIA, HORA_INICIO, HORA_FIN) VALUES
('lunes', '09:00:00', '14:00:00'),
('lunes', '10:00:00', '12:00:00'), ('lunes', '16:00:00', '18:00:00'), ('lunes', '18:00:00', '20:00:00'),
('martes', '09:00:00', '11:00:00'), ('martes', '11:00:00', '14:00:00'),
('martes', '17:00:00', '19:00:00'), ('martes', '19:00:00', '21:00:00'),
('miercoles', '09:00:00', '11:00:00'),
('miercoles', '10:00:00', '12:00:00'), ('miercoles', '11:00:00', '13:00:00'),
('miercoles', '16:30:00', '18:30:00'), ('miercoles', '18:00:00', '20:00:00'),
('jueves', '10:00:00', '12:00:00'), ('jueves', '16:00:00', '18:00:00'),
('jueves', '17:00:00', '19:00:00'), ('jueves', '18:00:00', '20:00:00'),
('jueves', '19:00:00', '21:00:00'),
('viernes', '10:00:00', '13:00:00'), ('viernes', '16:00:00', '19:00:00'),
('viernes', '17:00:00', '18:00:00'), ('viernes', '18:00:00', '19:30:00'), ('viernes', '18:00:00', '20:00:00'),
('sabado', '09:00:00', '12:00:00'), ('sabado', '10:00:00', '13:00:00'),
('sabado', '10:00:00', '14:00:00'), ('sabado', '11:00:00', '14:00:00'),
('sabado', '16:00:00', '19:00:00'), ('sabado', '17:00:00', '20:00:00'), ('sabado', '17:00:00', '23:00:00'),
('domingo', '10:00:00', '13:00:00'), ('domingo', '11:00:00', '13:00:00'), ('domingo', '11:00:00', '14:00:00');

INSERT INTO dbo.ORGANIZACION (NOMBRE, NOMBRE_RESPONSABLE, APELLIDO1_RESPONSABLE, APELLIDO2_RESPONSABLE, FECHA_REGISTRO) VALUES
('Acción Verde', 'Elena', 'García', 'Pérez', '2022-03-15'),
('Comedor Social Centro', 'Carlos', 'Martínez', 'Sánchez', '2021-11-01'),
('Cultura Viva Barrio', 'Sofía', 'López', 'Jiménez', '2023-01-20'),
('Refugio "Amigo Fiel"', 'Javier', 'Ruiz', NULL, '2020-06-10'),
('Educa Sin Fronteras', 'Ana', 'Fernández', 'Gómez', '2022-09-05'),
('Cruz Roja Local', 'David', 'Sanz', 'Martín', '2019-05-20'),
('Banco de Alimentos Prov.', 'Lucía', 'Moreno', 'Vázquez', '2020-02-15');

INSERT INTO dbo.VOLUNTARIO (NIF, NOMBRE, APELLIDO1, APELLIDO2, TELEFONO, CORREO, EXPERIENCIA, ESTUDIA) VALUES
('00000001A', 'Juan', 'García', 'López', '611111111', 'juan.garcia@email.com', 'Voluntariado deportivo', 1),
('00000002B', 'María', 'Rodríguez', 'Pérez', '622222222', 'maria.rguez@email.es', NULL, 2),
('00000003C', 'Pedro', 'Sánchez', 'Martín', '633333333', 'pedro.sanchez@email.net', 'Cuidado ancianos', 1),
('00000004D', 'Laura', 'Martínez', 'Gómez', '644444444', 'laura.m@email.org', 'Apoyo escolar', 3),
('00000005E', 'David', 'López', 'Fernández', '655555555', 'david.lopez@email.com', NULL, 4),
('00000006F', 'Sofía', 'Hernández', 'Ruiz', '666666666', 'sofia.h@email.es', 'Recogida alimentos', 2),
('00000007G', 'Daniel', 'González', 'Jiménez', '677777777', 'dani.gz@email.com', NULL, 1),
('00000008H', 'Carmen', 'Pérez', 'Moreno', '688888888', 'carmen.perez@email.net', 'Monitora tiempo libre', 3),
('00000009J', 'Javier', 'Gómez', 'Alonso', '699999999', 'javier.gomez@email.org', 'Refugio animales', 4),
('00000010K', 'Ana', 'Díaz', 'Gutiérrez', '610101010', 'ana.diaz@email.com', NULL, 2),
('00000011L', 'Carlos', 'Muñoz', 'Santos', '612345678', 'carlos.munoz@email.es', 'Protección civil', 1),
('00000012M', 'Elena', 'Romero', 'Iglesias', '623456789', 'elena.romero@email.net', NULL, 3),
('00000013N', 'Miguel', 'Navarro', 'Vázquez', '634567890', 'miguel.navarro@email.org', 'Eventos culturales', 4),
('00000014P', 'Isabel', 'Torres', 'Domínguez', '645678901', 'isabel.t@email.com', 'Biblioteca', 2),
('00000015Q', 'Sergio', 'Ramírez', 'Blanco', '656789012', 'sergio.r@email.es', NULL, 1),
('00000016R', 'Raquel', 'Gil', 'Sanz', '667890123', 'raquel.gil@email.net', 'ONG ambiental', 3),
('00000017S', 'Mario', 'Molina', 'Pastor', '678901234', 'mario.molina@email.org', 'Acompañamiento mayores', 4),
('00000018T', 'Lucía', 'Ortega', 'Serrano', '689012345', 'lucia.ortega@email.com', NULL, 1),
('00000019V', 'Adrián', 'Castro', 'Marín', '690123456', 'adrian.castro@email.es', 'Monitor deportivo', 2),
('00000020W', 'Fátima', 'Benavides', 'Cruz', '611234567', 'fatima.b@email.net', 'Apoyo inmigrantes', 3),
('00000021X', 'Iván', 'Reyes', 'Flores', '622345678', 'ivan.reyes@email.org', NULL, 4),
('00000022Y', 'Beatriz', 'Herrera', 'Cabrera', '633456789', 'beatriz.h@email.com', 'Primeros auxilios', 1),
('00000023Z', 'Rubén', 'Medina', 'Campos', '644556677', 'ruben.medina@email.es', NULL, 2),
('00000024A', 'Natalia', 'Vega', 'Fuentes', '655667788', 'natalia.vega@email.net', 'Voluntariado internacional', 3),
('00000025B', 'Óscar', 'León', 'Soler', '666778899', 'oscar.leon@email.org', 'Reforestaciones', 4),
('00000026C', 'Silvia', 'Pascual', 'Núñez', '677889900', 'silvia.p@email.com', NULL, 1),
('00000027D', 'Marcos', 'Santana', 'Estévez', '688990011', 'marcos.s@email.es', 'Apoyo logístico', 2),
('00000028E', 'Cristina', 'Lorenzo', 'Herrero', '699001122', 'cristina.l@email.net', 'Personas con discapacidad', 3),
('00000029F', 'Jorge', 'Montero', 'Gallego', '600112233', 'jorge.m@email.org', NULL, 4),
('00000030G', 'Marta', 'Arias', 'Prieto', '611223344', 'marta.arias@email.com', 'Animadora sociocultural', 1),
('00000031H', 'Álvaro', 'Calvo', 'Vicente', '622334455', 'alvaro.c@email.es', 'Huertos urbanos', 2),
('00000032J', 'Andrea', 'Rivas', 'Méndez', '633445566', 'andrea.r@email.net', NULL, 3),
('00000033K', 'Samuel', 'Peña', 'Suárez', '644556677', 'samuel.p@email.org', 'Reparación PC', 2),
('00000034L', 'Clara', 'Aguilar', 'Pardo', '655667788', 'clara.a@email.com', 'Clases español extran.', 4),
('00000035M', 'Víctor', 'Salas', 'Bravo', '666778899', 'victor.s@email.es', NULL, 2),
('00000036N', 'Eva', 'Blázquez', 'Ramos', '677889900', 'eva.b@email.net', 'Protectora animales', 1),
('00000037P', 'Hugo', 'Guerrero', 'Mora', '688990011', 'hugo.g@email.org', 'Torneos deportivos', 3),
('00000038Q', 'Paula', 'Collado', 'Ferrer', '699001122', 'paula.c@email.com', NULL, 4),
('00000039R', 'Alejandro', 'Esteban', 'Cano', '600112233', 'alejandro.e@email.es', 'Brigadas limpieza', 1),
('00000040S', 'Verónica', 'Redondo', 'Vidal', '611223344', 'veronica.r@email.net', 'Comedor social', 2),
('00000041T', 'Manuel', 'Carmona', 'Bernal', '622334455', 'manuel.c@email.org', NULL, 3),
('00000042V', 'Nerea', 'Bueno', 'Jurado', '633445566', 'nerea.b@email.com', 'Actividades niños', 4),
('00000043W', 'Francisco', 'Parra', 'Luque', '644556677', 'francisco.p@email.es', 'Logística almacén', 1),
('00000044X', 'Ainhoa', 'Saiz', 'Gallardo', '655667788', 'ainhoa.s@email.net', NULL, 2),
('00000045Y', 'Borja', 'Merino', 'Cuenca', '666778899', 'borja.m@email.org', 'Radio comunitaria', 3),
('00000046Z', 'Rocío', 'Delgado', 'Franco', '677889900', 'rocio.d@email.com', 'Guía senderismo', 4),
('00000047A', 'Iker', 'Blanco', 'Pascual', '688990011', 'iker.b@email.es', NULL, 1),
('00000048B', 'Alba', 'Soria', 'Marquez', '699001122', 'alba.soria@email.net', 'Eventos benéficos', 2),
('00000049C', 'Mateo', 'Iglesias', 'Flores', '601234567', 'mateo.i@email.com', 'Apoyo informático ONG', 2),
('00000050D', 'Valeria', 'Giménez', 'Ortiz', '612345678', 'valeria.g@email.org', NULL, 3);

INSERT INTO dbo.ACTIVIDAD (NOMBRE, DESCRIPCION, ESTADO, CONVOCADA_POR, FECHA_INICIO, FECHA_FIN, HORA_INICIO, HORA_FIN, TECNICO_DE) VALUES
('Reforestación Monte Bajo', 'Plantación de especies autóctonas en zona afectada por incendio', 'p', 1, '2023-10-21', '2023-10-21', '09:00:00', '12:00:00', NULL),
('Servicio Comida Mediodía', 'Ayuda en preparación y servicio de comidas en comedor social', 'a', 2, '2023-01-09', '2024-06-30', '11:00:00', '14:00:00', NULL),
('Club Lectura Juvenil', 'Dinamización de club de lectura para adolescentes (14-17 años)', 'a', 3, '2023-09-14', '2023-12-14', '18:00:00', '20:00:00', NULL),
('Paseo y Socialización Perros', 'Pasear, jugar y socializar con perros del refugio', 'a', 4, '2023-01-07', '2024-12-28', '11:00:00', '14:00:00', NULL),
('Apoyo Escolar Primaria', 'Clases de refuerzo (mates, lengua) para niños de primaria', 'a', 5, '2023-09-12', '2024-06-11', '17:00:00', '19:00:00', NULL),
('Limpieza Playa Urbana', 'Recogida de plásticos y residuos en la playa principal', 'p', 1, '2023-09-17', '2023-09-17', '10:00:00', '13:00:00', NULL),
('Gran Recogida Alimentos', 'Participación en campaña anual de recogida de alimentos', 'f', 7, '2023-11-25', '2023-11-25', '10:00:00', '14:00:00', NULL),
('Taller Teatro Aficionado', 'Montaje y representación de obra corta con grupo local', 'a', 3, '2023-10-06', '2024-01-26', '18:00:00', '20:00:00', NULL),
('Cuidado Colonia Felina', 'Alimentación y seguimiento sanitario de colonia de gatos callejeros', 'a', 4, '2022-05-04', '2024-12-18', '09:00:00', '11:00:00', NULL),
('Taller Informática Básica', 'Enseñar uso básico de PC e internet a adultos desempleados', 'a', 5, '2023-09-11', '2023-11-27', '10:00:00', '12:00:00', 2),
('Mantenimiento Huerto Urbano', 'Siembra, riego y cosecha en huerto comunitario', 'a', 1, '2023-03-01', '2023-11-29', '16:30:00', '18:30:00', NULL),
('Clasificación Ropa Invierno', 'Organización de ropa de abrigo donada para ropero solidario', 'p', 2, '2023-10-05', '2023-11-02', '10:00:00', '12:00:00', 3),
('Cineforum Derechos Humanos', 'Organización y moderación de ciclo de cine sobre DDHH', 'a', 3, '2023-10-10', '2023-11-28', '19:00:00', '21:00:00', NULL),
('Jornada Adopción Mixta', 'Evento para fomentar adopción de perros y gatos', 'p', 4, '2023-10-29', '2023-10-29', '11:00:00', '14:00:00', NULL),
('Ayuda Deberes Online', 'Soporte online para realización de tareas escolares (ESO)', 'c', 5, '2023-09-14', '2024-06-13', '16:00:00', '18:00:00', NULL),
('Apoyo Campamento Urbano', 'Colaboración como monitor en campamento de verano', 'p', 6, '2024-07-01', '2024-07-12', '09:00:00', '14:00:00', NULL),
('Clasificación Almacén BA', 'Ayuda en la organización del almacén del Banco de Alimentos', 'a', 7, '2023-05-05', '2024-05-31', '10:00:00', '13:00:00', 4),
('Reparación Juguetes Navidad', 'Arreglo de juguetes donados para campaña navideña', 'p', 2, '2023-11-04', '2023-12-16', '10:00:00', '13:00:00', 2),
('Acompañamiento Hospitalario', 'Visitas y acompañamiento a pacientes solos en hospital', 'a', 6, '2023-02-01', '2024-06-26', '11:00:00', '13:00:00', NULL),
('Digitalización Archivo ONG', 'Ayuda en escanear y organizar documentos de archivo', 'a', 5, '2023-11-09', '2024-02-29', '10:00:00', '12:00:00', 1);

INSERT INTO dbo.INTERES (ID_TIPO, NIF_VOLUNTARIO) VALUES
(1, '00000001A'), (6, '00000001A'), (2, '00000002B'), (7, '00000002B'), (2, '00000003C'), (4, '00000003C'),
(3, '00000004D'), (5, '00000004D'), (1, '00000005E'), (3, '00000005E'), (2, '00000006F'), (1, '00000006F'),
(6, '00000007G'), (8, '00000007G'), (3, '00000008H'), (2, '00000008H'), (7, '00000009J'), (1, '00000009J'),
(3, '00000010K'), (8, '00000010K'), (9, '00000011L'), (2, '00000011L'), (5, '00000012M'), (3, '00000012M'),
(5, '00000013N'), (6, '00000013N'), (3, '00000014P'), (8, '00000014P'), (1, '00000015Q'), (6, '00000015Q'),
(1, '00000016R'), (3, '00000016R'), (2, '00000017S'), (4, '00000017S'), (1, '00000018T'), (7, '00000018T'),
(6, '00000019V'), (2, '00000019V'), (2, '00000020W'), (3, '00000020W'), (1, '00000021X'), (5, '00000021X'),
(4, '00000022Y'), (9, '00000022Y'), (8, '00000023Z'), (2, '00000023Z'), (2, '00000024A'), (3, '00000024A'),
(1, '00000025B'), (7, '00000025B'), (5, '00000026C'), (3, '00000026C'), (2, '00000027D'), (8, '00000027D'),
(2, '00000028E'), (4, '00000028E'), (1, '00000029F'), (3, '00000029F'), (5, '00000030G'), (2, '00000030G'),
(1, '00000031H'), (2, '00000031H'), (3, '00000032J'), (5, '00000032J'), (8, '00000033K'), (1, '00000033K'),
(3, '00000034L'), (2, '00000034L'), (8, '00000035M'), (6, '00000035M'), (7, '00000036N'), (2, '00000036N'),
(6, '00000037P'), (5, '00000037P'), (3, '00000038Q'), (1, '00000038Q'), (1, '00000039R'), (9, '00000039R'),
(2, '00000040S'), (7, '00000040S'), (5, '00000041T'), (6, '00000041T'), (5, '00000042V'), (3, '00000042V'),
(2, '00000043W'), (8, '00000043W'), (4, '00000044X'), (8, '00000044X'), (5, '00000045Y'), (2, '00000045Y'),
(1, '00000046Z'), (6, '00000046Z'), (1, '00000047A'), (7, '00000047A'), (2, '00000048B'), (5, '00000048B'),
(8, '00000049C'), (2, '00000049C'), (5, '00000050D'), (3, '00000050D');

INSERT INTO dbo.ES_DE_TIPO (ID_TIPO, ID_ACTIVIDAD) VALUES
(1, 1), (1, 6), (1, 11), (2, 2), (2, 7), (2, 10), (2, 11), (2, 12), (2, 17), (2, 18), (2, 19),
(3, 3), (3, 5), (3, 8), (3, 10), (3, 14), (3, 16), (4, 9), (4, 19), (5, 3), (5, 8), (5, 13),
(6, 16), (7, 4), (7, 9), (7, 14), (8, 10), (8, 20), (9, 16);

INSERT INTO dbo.REALIZA (ID_ACTIVIDAD, NIF_VOLUNTARIO) VALUES
(1, '00000001A'), (1, '00000005E'), (1, '00000018T'), (1, '00000025B'), (1, '00000039R'), (1, '00000047A'),
(2, '00000002B'), (2, '00000003C'), (2, '00000006F'), (2, '00000017S'), (2, '00000040S'),
(3, '00000004D'), (3, '00000008H'), (3, '00000012M'), (3, '00000016R'), (3, '00000032J'), (3, '00000042V'),
(4, '00000009J'), (4, '00000018T'), (4, '00000025B'), (4, '00000036N'), (4, '00000047A'),
(5, '00000004D'), (5, '00000010K'), (5, '00000020W'), (5, '00000024A'), (5, '00000034L'), (5, '00000038Q'),
(6, '00000001A'), (6, '00000006F'), (6, '00000011L'), (6, '00000021X'), (6, '00000039R'),
(8, '00000013N'), (8, '00000026C'), (8, '00000030G'), (8, '00000041T'), (8, '00000045Y'), (8, '00000050D'),
(9, '00000009J'), (9, '00000036N'), (9, '00000040S'),
(10, '00000010K'), (10, '00000014P'), (10, '00000019V'), (10, '00000023Z'), (10, '00000033K'), (10, '00000049C'),
(11, '00000005E'), (11, '00000021X'), (11, '00000031H'), (11, '00000039R'),
(12, '00000002B'), (12, '00000006F'), (12, '00000017S'), (12, '00000028E'), (12, '00000040S'),
(13, '00000013N'), (13, '00000020W'), (13, '00000030G'), (13, '00000048B'),
(14, '00000009J'), (14, '00000018T'), (14, '00000025B'), (14, '00000036N'), (14, '00000047A'),
(16, '00000008H'), (16, '00000011L'), (16, '00000019V'), (16, '00000037P'), (16, '00000046Z'),
(17, '00000006F'), (17, '00000027D'), (17, '00000043W'), (17, '00000048B'),
(18, '00000007G'), (18, '00000015Q'), (18, '00000027D'), (18, '00000033K'), (18, '00000043W'),
(19, '00000003C'), (19, '00000017S'), (19, '00000022Y'), (19, '00000028E'), (19, '00000044X'),
(20, '00000010K'), (20, '00000014P'), (20, '00000035M'), (20, '00000044X'), (20, '00000049C');

INSERT INTO dbo.DISPONE_DE (NIF_VOLUNTARIO, DIA, HORA_INICIO, HORA_FIN) VALUES
('00000001A', 'sabado', '09:00:00', '12:00:00'), ('00000001A', 'domingo', '10:00:00', '13:00:00'), ('00000001A', 'lunes', '16:00:00', '18:00:00'),
('00000002B', 'martes', '11:00:00', '14:00:00'), ('00000002B', 'jueves', '10:00:00', '12:00:00'), ('00000002B', 'sabado', '11:00:00', '14:00:00'),
('00000003C', 'lunes', '18:00:00', '20:00:00'), ('00000003C', 'miercoles', '11:00:00', '13:00:00'), ('00000003C', 'viernes', '16:00:00', '19:00:00'),
('00000004D', 'martes', '17:00:00', '19:00:00'), ('00000004D', 'jueves', '18:00:00', '20:00:00'),
('00000005E', 'miercoles', '16:30:00', '18:30:00'), ('00000005E', 'sabado', '09:00:00', '12:00:00'), ('00000005E', 'viernes', '10:00:00', '13:00:00'),
('00000006F', 'martes', '11:00:00', '14:00:00'), ('00000006F', 'jueves', '10:00:00', '12:00:00'), ('00000006F', 'domingo', '10:00:00', '13:00:00'), ('00000006F', 'viernes', '10:00:00', '13:00:00'),
('00000007G', 'sabado', '10:00:00', '13:00:00'), ('00000007G', 'lunes', '16:00:00', '18:00:00'),
('00000008H', 'jueves', '18:00:00', '20:00:00'), ('00000008H', 'lunes', '09:00:00', '14:00:00'), ('00000008H', 'sabado', '16:00:00', '19:00:00'),
('00000009J', 'sabado', '11:00:00', '14:00:00'), ('00000009J', 'domingo', '11:00:00', '14:00:00'), ('00000009J', 'miercoles', '09:00:00', '11:00:00'),
('00000010K', 'martes', '17:00:00', '19:00:00'), ('00000010K', 'lunes', '10:00:00', '12:00:00'), ('00000010K', 'jueves', '10:00:00', '12:00:00'),
('00000011L', 'domingo', '10:00:00', '13:00:00'), ('00000011L', 'lunes', '09:00:00', '14:00:00'),
('00000012M', 'jueves', '18:00:00', '20:00:00'), ('00000012M', 'viernes', '16:00:00', '19:00:00'),
('00000013N', 'martes', '19:00:00', '21:00:00'), ('00000013N', 'viernes', '18:00:00', '20:00:00'), ('00000013N', 'sabado', '17:00:00', '20:00:00'),
('00000014P', 'lunes', '10:00:00', '12:00:00'), ('00000014P', 'jueves', '10:00:00', '12:00:00'),
('00000015Q', 'sabado', '10:00:00', '13:00:00'), ('00000015Q', 'domingo', '11:00:00', '13:00:00'),
('00000016R', 'jueves', '18:00:00', '20:00:00'), ('00000016R', 'sabado', '16:00:00', '19:00:00'),
('00000017S', 'martes', '11:00:00', '14:00:00'), ('00000017S', 'miercoles', '11:00:00', '13:00:00'), ('00000017S', 'jueves', '10:00:00', '12:00:00'),
('00000018T', 'sabado', '09:00:00', '12:00:00'), ('00000018T', 'sabado', '11:00:00', '14:00:00'), ('00000018T', 'domingo', '11:00:00', '14:00:00'),
('00000019V', 'lunes', '09:00:00', '14:00:00'), ('00000019V', 'lunes', '10:00:00', '12:00:00'),
('00000020W', 'martes', '17:00:00', '19:00:00'), ('00000020W', 'martes', '19:00:00', '21:00:00'), ('00000020W', 'jueves', '17:00:00', '19:00:00'),
('00000021X', 'domingo', '10:00:00', '13:00:00'), ('00000021X', 'miercoles', '16:30:00', '18:30:00'),
('00000022Y', 'miercoles', '11:00:00', '13:00:00'), ('00000022Y', 'viernes', '16:00:00', '19:00:00'),
('00000023Z', 'lunes', '10:00:00', '12:00:00'), ('00000023Z', 'miercoles', '18:00:00', '20:00:00'),
('00000024A', 'martes', '17:00:00', '19:00:00'), ('00000024A', 'jueves', '17:00:00', '19:00:00'),
('00000025B', 'sabado', '09:00:00', '12:00:00'), ('00000025B', 'sabado', '11:00:00', '14:00:00'), ('00000025B', 'domingo', '11:00:00', '14:00:00'),
('00000026C', 'viernes', '18:00:00', '20:00:00'), ('00000026C', 'domingo', '11:00:00', '13:00:00'),
('00000027D', 'viernes', '10:00:00', '13:00:00'), ('00000027D', 'sabado', '10:00:00', '13:00:00'),
('00000028E', 'jueves', '10:00:00', '12:00:00'), ('00000028E', 'miercoles', '11:00:00', '13:00:00'),
('00000029F', 'martes', '09:00:00', '11:00:00'), ('00000029F', 'jueves', '16:00:00', '18:00:00'),
('00000030G', 'martes', '19:00:00', '21:00:00'), ('00000030G', 'viernes', '18:00:00', '20:00:00'),
('00000031H', 'miercoles', '16:30:00', '18:30:00'), ('00000031H', 'sabado', '16:00:00', '19:00:00'),
('00000032J', 'jueves', '18:00:00', '20:00:00'), ('00000032J', 'lunes', '16:00:00', '18:00:00'),
('00000033K', 'lunes', '10:00:00', '12:00:00'), ('00000033K', 'sabado', '10:00:00', '13:00:00'),
('00000034L', 'martes', '17:00:00', '19:00:00'), ('00000034L', 'jueves', '17:00:00', '19:00:00'),
('00000035M', 'jueves', '10:00:00', '12:00:00'), ('00000035M', 'sabado', '17:00:00', '20:00:00'),
('00000036N', 'sabado', '11:00:00', '14:00:00'), ('00000036N', 'domingo', '11:00:00', '14:00:00'), ('00000036N', 'miercoles', '09:00:00', '11:00:00'),
('00000037P', 'lunes', '09:00:00', '14:00:00'), ('00000037P', 'sabado', '17:00:00', '23:00:00'),
('00000038Q', 'martes', '17:00:00', '19:00:00'), ('00000038Q', 'jueves', '16:00:00', '18:00:00'),
('00000039R', 'sabado', '09:00:00', '12:00:00'), ('00000039R', 'domingo', '10:00:00', '13:00:00'), ('00000039R', 'miercoles', '16:30:00', '18:30:00'),
('00000040S', 'martes', '11:00:00', '14:00:00'), ('00000040S', 'miercoles', '09:00:00', '11:00:00'), ('00000040S', 'jueves', '10:00:00', '12:00:00'),
('00000041T', 'viernes', '18:00:00', '20:00:00'), ('00000041T', 'sabado', '17:00:00', '23:00:00'),
('00000042V', 'jueves', '18:00:00', '20:00:00'), ('00000042V', 'domingo', '11:00:00', '13:00:00'),
('00000043W', 'viernes', '10:00:00', '13:00:00'), ('00000043W', 'sabado', '10:00:00', '13:00:00'),
('00000044X', 'miercoles', '11:00:00', '13:00:00'), ('00000044X', 'jueves', '10:00:00', '12:00:00'),
('00000045Y', 'viernes', '18:00:00', '20:00:00'), ('00000045Y', 'lunes', '18:00:00', '20:00:00'),
('00000046Z', 'sabado', '09:00:00', '12:00:00'), ('00000046Z', 'lunes', '09:00:00', '14:00:00'),
('00000047A', 'sabado', '11:00:00', '14:00:00'), ('00000047A', 'domingo', '11:00:00', '14:00:00'), ('00000047A', 'miercoles', '09:00:00', '11:00:00'),
('00000048B', 'martes', '19:00:00', '21:00:00'), ('00000048B', 'viernes', '10:00:00', '13:00:00'), ('00000048B', 'sabado', '17:00:00', '20:00:00'),
('00000049C', 'lunes', '10:00:00', '12:00:00'), ('00000049C', 'miercoles', '10:00:00', '12:00:00'), ('00000049C', 'jueves', '10:00:00', '12:00:00'),
('00000050D', 'viernes', '18:00:00', '20:00:00'), ('00000050D', 'martes', '09:00:00', '11:00:00'), ('00000050D', 'jueves', '19:00:00', '21:00:00');

INSERT INTO dbo.CUMPLE_CON (ID_ACTIVIDAD, ID_ODS) VALUES
(1, 13), (1, 15), (2, 1), (2, 2), (2, 10), (3, 4), (3, 11), (4, 3), (4, 15), (5, 4), (5, 10),
(6, 11), (6, 14), (6, 15), (7, 2), (7, 12), (8, 4), (8, 11), (8, 16), (9, 3), (9, 15), (10, 4),
(10, 8), (10, 10), (11, 11), (11, 12), (11, 15), (12, 1), (12, 10), (12, 12), (13, 4), (13, 10),
(13, 16), (14, 12), (14, 15), (16, 3), (16, 4), (16, 11), (17, 2), (17, 12), (18, 11), (18, 12),
(19, 3), (19, 10), (20, 9), (20, 16);
GO