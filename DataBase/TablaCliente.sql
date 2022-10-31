create database TablaCliente

use TablaCliente

CREATE TABLE TABLA_CLIENTES (
IdCliente INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Nombres VARCHAR(40) NOT NULL,
Apellidos VARCHAR(40) NOT NULL,
Direccion TEXT NOT NULL
);