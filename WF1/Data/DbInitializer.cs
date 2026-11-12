using System;
using System.Collections.Generic;
using System.Text;

namespace WF1.Data
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            using var connection = DbConnectionFactory.Create();

            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Productos
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CodigoBarra TEXT,
                    Nombre TEXT NOT NULL,
                    PrecioCosto REAL NOT NULL,
                    PrecioVenta REAL NOT NULL,
                    Stock REAL NOT NULL,
                    Activo INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Ventas
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fecha TEXT NOT NULL,
                    Total REAL NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Usuarios
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Usuario TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Activo REAL NOT NULL,
                    Permiso TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS VentaDetalles
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    VentaId INTEGER NOT NULL,
                    ProductoId INTEGER NOT NULL,
                    Cantidad REAL NOT NULL,
                    PrecioUnitario REAL NOT NULL,
                    Subtotal REAL NOT NULL,

                    FOREIGN KEY(VentaId)
                        REFERENCES Ventas(Id),

                    FOREIGN KEY(ProductoId)
                        REFERENCES Productos(Id)
                );
            ";

            command.ExecuteNonQuery();
        }
    }
}
