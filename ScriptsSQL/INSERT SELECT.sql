-- INSERT SELECT 
USE BibliotecaDB;
GO
INSERT INTO Usuarios (NombreUsuario, ContraseñaHash)
VALUES ('Admin', 'qiV2cjniGJTfHrjB4zSLGE0BzhQGDgSDjphUGwfBKQM=');



INSERT INTO Autores (NombreAutor)
VALUES ('Autor de Ejemplo');

INSERT INTO Editoriales (NombreEditorial)
VALUES ('Editorial de Ejemplo');

INSERT INTO Categorias (NombreCategoria)
VALUES ('Categoría de Ejemplo');

INSERT INTO Libros (Titulo, AutorId, EditorialId, CategoriaId, Estado, Cantidad)
VALUES ('Libro de Prueba', 1, 1, 1, 1, 10);

INSERT INTO Socios (NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email)
VALUES ('Juan Pérez', '12345678', 'Calle Falsa 123', '0981122334', 'juanperez@email.com');

SELECT * FROM Libros;

SELECT * FROM Autores;
UPDATE Autores
SET Nacionalidad = 'PY'
WHERE Nacionalidad IS NULL;