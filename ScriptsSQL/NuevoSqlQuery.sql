
USE BibliotecaDB;
GO
-- Tabla de usuarios
CREATE TABLE Usuarios (
    IdUser INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(50) NOT NULL,
    ContraseñaHash NVARCHAR(256) NOT NULL
);

-- Tabla de categorías
CREATE TABLE Categorias (
    IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria NVARCHAR(100) NOT NULL
);

-- Tabla de autores
CREATE TABLE Autores (
    IdAutor INT PRIMARY KEY IDENTITY(1,1),
    NombreAutor NVARCHAR(100) NOT NULL,
    Nacionalidad NVARCHAR(100)
);

-- Tabla de editoriales
CREATE TABLE Editoriales (
    IdEditorial INT PRIMARY KEY IDENTITY(1,1),
    NombreEditorial NVARCHAR(100) NOT NULL
);

-- Tabla de libros
CREATE TABLE Libros (
    IdLibro INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200) NOT NULL,
    AutorId INT FOREIGN KEY REFERENCES Autores(IdAutor),
    EditorialId INT FOREIGN KEY REFERENCES Editoriales(IdEditorial),
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(IdCategoria),
    Estado INT NOT NULL,
    Cantidad INT NOT NULL
);

-- Tabla de socios
CREATE TABLE Socios (
    IdSocio INT PRIMARY KEY IDENTITY(1,1),
    NombreSocio NVARCHAR(100) NOT NULL,
    CedulaSocio NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(150),
    TelefonoSocio NVARCHAR(20),
    Email NVARCHAR(100)
);

-- Tabla de préstamos
CREATE TABLE Prestamos (
    IdPrestamo INT PRIMARY KEY IDENTITY(1,1),
    LibroId INT FOREIGN KEY REFERENCES Libros(IdLibro),
    UsuarioId INT FOREIGN KEY REFERENCES Usuarios(IdUser),
    SocioId INT FOREIGN KEY REFERENCES Socios(IdSocio),
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE,
    Devuelto BIT DEFAULT 0
);

-- Tabla de reservas
CREATE TABLE Reservas (
    IdReserva INT PRIMARY KEY IDENTITY(1,1),
    IdLibro INT FOREIGN KEY REFERENCES Libros(IdLibro),
    IdSocio INT FOREIGN KEY REFERENCES Socios(IdSocio),
    FechaReserva DATE NOT NULL,
    Activa BIT DEFAULT 1
);

-- Tabla de historial
CREATE TABLE Historial (
    IdHistorial INT PRIMARY KEY IDENTITY(1,1),
    IdPrestamo INT,
    IdLibro INT,
    IdSocio INT,
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE,
    Devuelto BIT NOT NULL
);


CREATE TABLE Multas (
    IdMulta INT PRIMARY KEY IDENTITY(1,1),
    IdSocio INT FOREIGN KEY REFERENCES Socios(IdSocio),
    Monto DECIMAL(10, 2) NOT NULL,
    FechaGeneracion DATE NOT NULL,
    Motivo NVARCHAR(200),
    Pagada BIT DEFAULT 0
);

SELECT * FROM Multas;