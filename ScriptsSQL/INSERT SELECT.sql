-- INSERT SELECT 
USE BibliotecaDB;
GO
INSERT INTO Usuarios (NombreUsuario, Contrase�aHash)
VALUES ('Admin', 'qiV2cjniGJTfHrjB4zSLGE0BzhQGDgSDjphUGwfBKQM=');


--Insercion de Socios
INSERT INTO Socios (NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email) VALUES
('Juan P�rez', '1234567', 'Calle 1', '0981123456', 'juanp@gmail.com'),
('Ana G�mez', '2345678', 'Calle 2', '0981223456', 'anag@gmail.com'),
('Carlos L�pez', '3456789', 'Calle 3', '0981323456', 'carlosl@gmail.com'),
('Laura Torres', '4567890', 'Calle 4', '0981423456', 'laurat@gmail.com'),
('Miguel Rojas', '5678901', 'Calle 5', '0981523456', 'miguelr@gmail.com'),
('Sandra D�az', '6789012', 'Calle 6', '0981623456', 'sandrad@gmail.com'),
('Pedro Ram�rez', '7890123', 'Calle 7', '0981723456', 'pedror@gmail.com'),
('Luc�a Fern�ndez', '8901234', 'Calle 8', '0981823456', 'luciaf@gmail.com'),
('Jorge Acosta', '9012345', 'Calle 9', '0981923456', 'jorgea@gmail.com'),
('Mar�a Vera', '0123456', 'Calle 10', '0981023456', 'mariav@gmail.com'),
('Rub�n Villalba', '1123456', 'Calle 11', '0981051234', 'ruben.v@gmail.com'),
('Valeria Ayala', '1223456', 'Calle 12', '0981087654', 'valeria.a@gmail.com'),
('Dami�n Duarte', '1323456', 'Calle 13', '0981012121', 'damian.d@gmail.com'),
('Sof�a Rivas', '1423456', 'Calle 14', '0981098765', 'sofia.r@gmail.com'),
('Enrique Godoy', '1523456', 'Calle 15', '0981030303', 'enrique.g@gmail.com'),
('Julia Bogado', '1623456', 'Calle 16', '0981040404', 'julia.b@gmail.com'),
('Ricardo Sosa', '1723456', 'Calle 17', '0981050505', 'ricardo.s@gmail.com'),
('Nadia Esp�nola', '1823456', 'Calle 18', '0981060606', 'nadia.e@gmail.com'),
('Esteban Ruiz', '1923456', 'Calle 19', '0981070707', 'esteban.r@gmail.com'),
('Paola Gim�nez', '2023456', 'Calle 20', '0981080808', 'paola.g@gmail.com');


--Insercion de Autores
INSERT INTO Autores (NombreAutor, Nacionalidad) VALUES
('Mario Benedetti', 'Uruguaya'),
('Gabriel Garc�a M�rquez', 'Colombiana'),
('Jorge Luis Borges', 'Argentina'),
('Isabel Allende', 'Chilena'),
('Julio Cort�zar', 'Argentina'),
('Laura Esquivel', 'Mexicana'),
('Carlos Fuentes', 'Mexicana'),
('Pablo Neruda', 'Chilena'),
('Federico Garc�a Lorca', 'Espa�ola'),
('Miguel de Cervantes', 'Espa�ola'),
('J.K. Rowling', 'Brit�nica'),
('George Orwell', 'Brit�nica'),
('Franz Kafka', 'Alemana'),
('Ernest Hemingway', 'Estadounidense'),
('Mark Twain', 'Estadounidense'),
('Virginia Woolf', 'Brit�nica'),
('Jane Austen', 'Brit�nica'),
('William Faulkner', 'Estadounidense'),
('Albert Camus', 'Francesa'),
('Antoine de Saint-Exup�ry', 'Francesa');



--Insercion de Categorias
INSERT INTO Categorias (NombreCategoria) VALUES
('Ficci�n'),
('Ciencia Ficci�n'),
('Fantas�a'),
('Misterio'),
('Terror'),
('Romance'),
('Aventura'),
('Hist�rica'),
('Biograf�a'),
('Ensayo'),
('Poes�a'),
('Drama'),
('Humor'),
('Infantil'),
('Educativo');

--Insecion de Editoriales
INSERT INTO Editoriales (NombreEditorial) VALUES
('Alfaguara'),
('Planeta'),
('Sudamericana'),
('Anagrama'),
('Santillana');


SELECT * FROM Socios;
SELECT * FROM Autores;
SELECT * FROM Editoriales;
SELECT * FROM Historial;
SELECT * FROM Categorias;
SELECT * FROM Multas;
SELECT * FROM Prestamos;
SELECT * FROM Reservas;
SELECT * FROM Usuarios;
SELECT * FROM Libros;














USE BibliotecaDB;
GO

-- Eliminar tablas que dependen de otras por claves for�neas
DROP TABLE IF EXISTS Historial;
DROP TABLE IF EXISTS Reservas;
DROP TABLE IF EXISTS Prestamos;

-- Eliminar las tablas principales
DROP TABLE IF EXISTS Libros;
DROP TABLE IF EXISTS Socios;
DROP TABLE IF EXISTS Usuarios;
DROP TABLE IF EXISTS Categorias;
DROP TABLE IF EXISTS Autores;
DROP TABLE IF EXISTS Editoriales;
