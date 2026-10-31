--DDL
CREATE DATABASE Parcial2CMLA
GO
USE master
GO
CREATE LOGIN usrparcial2 WITH PASSWORD=N'12345678',
	DEFAULT_DATABASE=Parcial2CMLA,
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO
USE Parcial2CMLA
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE [db_owner] ADD MEMBER usrparcial2
GO

DROP TABLE HorarioPrograma;
DROP TABLE Canal;

CREATE TABLE Canal(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	frecuencia VARCHAR(20) NOT NULL,
	estado SMALLINT NOT NULL DEFAULT 1
);
CREATE TABLE HorarioPrograma(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idCanal INT NOT NULL,
	titulo VARCHAR(100) NOT NULL,
	horaInicio TIME NOT NULL,
	horaFin TIME NOT NULL,
	diaSemana VARCHAR(20) NOT NULL,
	conductorPrincipal VARCHAR(100) NOT NULL,
	tipo VARCHAR(30) NOT NULL,
	estado SMALLINT NOT NULL DEFAULT 1

	CONSTRAINT FK_HorarioPrograma_Canal FOREIGN KEY (idCanal)
    REFERENCES Canal(id)
);

DROP PROC IF EXISTS paProgramaListar;
GO
CREATE PROC paProgramaListar @parametro VARCHAR(50)
AS
  SELECT p.id, p.idCanal, p.titulo,p.tipo, p.horaInicio, p.horaFin, p.diaSemana, p.conductorPrincipal, c.nombre AS canal,
		 p.usuarioRegistro, p.fechaRegistro, p.estado
  FROM HorarioPrograma p
  INNER JOIN Canal c ON c.id = p.idCanal
  WHERE p.estado = 1 AND p.titulo+p.diaSemana+c.nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY p.titulo;
GO
EXEC paProgramaListar 'Noticiero casa';

ALTER TABLE Canal ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Canal ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();

ALTER TABLE HorarioPrograma ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE HorarioPrograma ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();

--DML

INSERT INTO Canal (nombre, frecuencia, estado)
VALUES ('ATB', 'Television', 1);

INSERT INTO Canal (nombre, frecuencia, estado)
VALUES ('Unitel', 'Television', 1);

INSERT INTO Canal (nombre, frecuencia, estado)
VALUES ('Bolivia TV', 'Television', 1);

INSERT INTO Canal (nombre, frecuencia, estado)
VALUES ('Red Uno', 'Television', 1);

INSERT INTO Canal (nombre, frecuencia, estado)
VALUES ('PAT', 'Television', 1);


INSERT INTO HorarioPrograma
(idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal,tipo, estado)
VALUES
(1, 'Noticiero Central', '09:00', '10:15', 'Lunes', 'Juan Perez','Farandula', 1);

INSERT INTO HorarioPrograma
(idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal, tipo, estado)
VALUES
(2, 'Deportes al Dia', '10:30', '11:30', 'Martes', 'Carlos Lopez','Deportes', 1);

INSERT INTO HorarioPrograma
(idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal, tipo, estado)
VALUES
(3, 'Noticias Bolivia', '12:00', '13:00', 'Miercoles', 'Maria Fernandez','Cocina', 1);

INSERT INTO HorarioPrograma
(idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal, tipo, estado)
VALUES
(4, 'Entretenimiento Total', '15:00', '16:30', 'Jueves', 'Luis Ramirez','Niños', 1);

INSERT INTO HorarioPrograma
(idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal, tipo, estado)
VALUES
(5, 'Cine en Casa', '20:00', '22:00', 'Viernes', 'Ana Morales','Accion', 1);

SELECT * FROM Canal;
SELECT * FROM HorarioPrograma;