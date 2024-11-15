create database Seguridad
go
use Seguridad

-- Tabla Usuarios

CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY, -- Hacemos autoincrementable el ID
    NombreUsuario VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    PrimerNombre VARCHAR(50),
    SegundoNombre VARCHAR(50),
    PrimerApellido VARCHAR(50),
    SegundoApellido VARCHAR(50),
	Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    Clave VARCHAR(255), 
    FechaRegistro DATETIME DEFAULT GETDATE() -- Fecha de registro para el usuario
);

-- Tabla Menus
CREATE TABLE Menus (
    MenuID INT PRIMARY KEY,
    NombreMenu VARCHAR(50) NOT NULL
);

-- Tabla Roles
CREATE TABLE Roles (
    RolID INT PRIMARY KEY,
    NombreRol VARCHAR(50) NOT NULL
);

-- Tabla Permisos
CREATE TABLE Permisos (
    PermisoID INT PRIMARY KEY, -- identity
    NombrePermiso VARCHAR(50) NOT NULL
);

-- Tabla UsuariosMenus 
CREATE TABLE UsuariosMenus (
    UsuarioID INT,
    MenuID INT,
    PRIMARY KEY (UsuarioID, MenuID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    FOREIGN KEY (MenuID) REFERENCES Menus(MenuID)
);

-- Tabla MenusRoles 
CREATE TABLE MenusRoles (
    MenuID INT,
    RolID INT,
    PRIMARY KEY (MenuID, RolID),
    FOREIGN KEY (MenuID) REFERENCES Menus(MenuID),
    FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);

-- Tabla UsuariosRoles 
CREATE TABLE UsuariosRoles (
    UsuarioID INT,
    RolID INT,
    PRIMARY KEY (UsuarioID, RolID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);

-- Tabla RolesPermisos 
CREATE TABLE RolesPermisos (
    RolID INT,
    PermisoID INT,
    PRIMARY KEY (RolID, PermisoID),
    FOREIGN KEY (RolID) REFERENCES Roles(RolID),
    FOREIGN KEY (PermisoID) REFERENCES Permisos(PermisoID)
);

-- Tabla PermisosAcciones 
CREATE TABLE PermisosAcciones (
    PermisoID INT PRIMARY KEY,
    Lectura BIT DEFAULT 0,
    Escritura BIT DEFAULT 0,
    Modificacion BIT DEFAULT 0,
    Eliminacion BIT DEFAULT 0,
    FOREIGN KEY (PermisoID) REFERENCES Permisos(PermisoID)
);

-- Tabla HistorialUsuarios 
CREATE TABLE HistorialUsuarios (
    HistorialID INT PRIMARY KEY,
    UsuarioID INT,
    Accion VARCHAR(255),
    FechaAccion DATETIME,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);


 
 
