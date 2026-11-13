using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WF1.Models
{
    public class Usuarios
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public bool Activo { get; set; }

        public string Permiso { get; set; }

    }


    public class DvgUsuarios1
    {
        public string Usuario { get; set; }

        public bool Activo { get; set; }

        public string Permiso { get; set; }
    }
}
