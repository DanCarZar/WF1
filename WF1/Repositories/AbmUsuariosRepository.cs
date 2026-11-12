using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using WF1.Data;
using WF1.Models;

namespace WF1.Repositories
{
    public class AbmUsuariosRepository
    {

        public List<Usuarios> GetAll()
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
                SELECT
                    Id,
                    Usuario,
                    Activo,
                    Permiso
                FROM Usuarios";

            return connection.Query<Usuarios>(sql).ToList();
        }

        public void Crear_Usuario(Usuarios Usuario)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
                INSERT INTO Usuarios
                (
                    Usuario,
                    Password,
                    Activo,
                    Permiso
                )
                VALUES
                (
                    @Usuario,
                    @Password,
                    @Activo,
                    @Permiso
                )";

            connection.Execute(sql, Usuario);
        }

        public void Delete_Usuario(Usuarios Usuario)
        {
            using var connection = DbConnectionFactory.Create();

            string sql = @"
                delete Usuarios
                where usuario = @usuario
                ";

            connection.Execute(sql, Usuario);
        }
    }
}
