--Query que Crea de la tabla de usuarios
CREATE TABLE Usuarios (
IdUser INT PRIMARY KEY IDENTITY(1,1),
NombreUsuario NVARCHAR(50) NOT NULL,
ContraseñaHash NVARCHAR(256) NOT NULL
);

--Query que crea la tabla de categorias

CREATE TABLE Categorias (
IdCategoria INT PRIMARY KEY IDENTITY (1,1),
NombreCategoria NVARCHAR(100) NOT NULL
);

--Query que crea la tabla de autores
CREATE TABLE Autores (
    IdAutor INT PRIMARY KEY IDENTITY(1,1),
    NombreAutor NVARCHAR(100) NOT NULL,
    Nacionalidad NVARCHAR(100)
);

--Query que crea la tabla de Editoriales
CREATE TABLE Editoriales (
    IdEditorial INT PRIMARY KEY IDENTITY(1,1),
    NombreEditorial NVARCHAR(100) NOT NULL
);

--Query que crea la tabla de Libros
CREATE TABLE Libros (
    IdLibro INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200) NOT NULL,
    AutorId INT FOREIGN KEY REFERENCES Autores(IdAutor),
    EditorialId INT FOREIGN KEY REFERENCES Editoriales(IdEditorial),
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(IdCategoria),
    Estado INT NOT NULL,
    Cantidad INT NOT NULL
);


--Query que crea la tabla se Socio
CREATE TABLE Socios (
    IdSocio INT PRIMARY KEY IDENTITY(1,1),
    NombreSocio NVARCHAR(100) NOT NULL,
    CedulaSocio NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(150),
    TelefonoSocio NVARCHAR(20),
    Email NVARCHAR(100)
);

--Query que crea la tabla de prestamos
CREATE TABLE Prestamos (
    IdPrestamo INT PRIMARY KEY IDENTITY(1,1),
    LibroId  INT FOREIGN KEY REFERENCES Libros(IdLibro),
    UsuarioId INT FOREIGN KEY REFERENCES Usuarios(IdUser),
    SocioId INT FOREIGN KEY REFERENCES Socios(IdSocio), 
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE,
    Devuelto BIT DEFAULT 0  --Tipo boolean por defecto es 0
);





