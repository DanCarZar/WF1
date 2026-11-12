using Dapper;
using WF1.Data;
using WF1.Models;

namespace WF1.Repositories
{
    public class ProductoRepository
    {
        public List<Producto> GetAll()
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
                SELECT
                    Id,
                    CodigoBarra,
                    Nombre,
                    PrecioCosto,
                    PrecioVenta,
                    Stock,
                    Activo
                FROM Productos
                ORDER BY Nombre";

            return connection.Query<Producto>(sql).ToList();
        }

        public void Insert(Producto producto)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
                INSERT INTO Productos
                (
                    CodigoBarra,
                    Nombre,
                    PrecioCosto,
                    PrecioVenta,
                    Stock,
                    Activo
                )
                VALUES
                (
                    @CodigoBarra,
                    @Nombre,
                    @PrecioCosto,
                    @PrecioVenta,
                    @Stock,
                    @Activo
                )";

            connection.Execute(sql, producto);
        }

        public Producto? GetByCodigoBarra(string codigoBarra)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
        SELECT *
        FROM Productos
        WHERE CodigoBarra = @codigoBarra
        LIMIT 1";

            return connection.QueryFirstOrDefault<Producto>(
                sql,
                new { codigoBarra });
        }
        public List<Producto> Search(string texto)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
        SELECT *
        FROM Productos
        WHERE Nombre LIKE @texto
           OR CodigoBarra LIKE @texto
        ORDER BY Nombre";

            return connection.Query<Producto>(
                sql,
                new { texto = "%" + texto + "%" })
                .ToList();
        }

        public void Update(Producto producto)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
        UPDATE Productos
        SET
            CodigoBarra = @CodigoBarra,
            Nombre = @Nombre,
            PrecioCosto = @PrecioCosto,
            PrecioVenta = @PrecioVenta,
            Stock = @Stock
        WHERE Id = @Id";

            connection.Execute(sql, producto);
        }

        public void DescontarStock(int productoId, decimal cantidad)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
        UPDATE Productos
        SET Stock = Stock - @cantidad
        WHERE Id = @productoId";

            connection.Execute(sql, new
            {
                productoId,
                cantidad
            });
        }

        public Producto? GetById(int id)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
        SELECT *
        FROM Productos
        WHERE Id = @id";

            return connection.QueryFirstOrDefault<Producto>(
                sql,
                new { id });
        }
    }
}