using System;
using System.Collections.Generic;
using System.Text;
using WF1.Data;
using WF1.Models;
using Dapper;

namespace WF1.Repositories
{
    public class VentaRepository
    {
        public int InsertVenta(Venta venta)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
                INSERT INTO Ventas
                (
                    Fecha,
                    Total
                )
                VALUES
                (
                    @Fecha,
                    @Total
                );

                SELECT last_insert_rowid();
            ";

            return connection.ExecuteScalar<int>(sql, venta);
        }

        public void InsertDetalle(VentaDetalle detalle)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
        INSERT INTO VentaDetalles
        (
            VentaId,
            ProductoId,
            Cantidad,
            PrecioUnitario,
            Subtotal
        )
        VALUES
        (
            @VentaId,
            @ProductoId,
            @Cantidad,
            @PrecioUnitario,
            @Subtotal
        )";

            connection.Execute(sql, detalle);
        }
    }
}
