using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Objetos
{
    class Usuario
    {
        public static class UsuarioLogado
        {
            public static int ID { get; set; }

            public static string Usuario { get; set; }

            public static string Senha { get; set; }

            public static string Email { get; set; }

            public static string Cargo { get; set; }
        }
    }
}
