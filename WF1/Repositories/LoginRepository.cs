using System;
using System.Collections.Generic;
using System.Text;
using WF1.Data;

namespace WF1.Repositories
{
    public class LoginRepository
    {
        public bool ValidarLogin(string usuario, string password)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                SELECT COUNT(*)
                FROM Usuarios
                WHERE Usuario = @Usuario
                  AND Password = @Password
                  AND Activo = 1";

            var parametroUsuario = command.CreateParameter();
            parametroUsuario.ParameterName = "@Usuario";
            parametroUsuario.Value = usuario;
            command.Parameters.Add(parametroUsuario);

            var parametroPassword = command.CreateParameter();
            parametroPassword.ParameterName = "@Password";
            parametroPassword.Value = password;
            command.Parameters.Add(parametroPassword);

            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }
    }
}
