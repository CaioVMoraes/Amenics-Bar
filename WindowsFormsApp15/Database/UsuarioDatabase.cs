using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class UsuarioDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();

        public tb_usuario usuario(string nome, string senha)
        {
            tb_usuario usuario = db.tb_usuario.FirstOrDefault(x => x.nm_usuario == nome && x.ds_senha == senha);

            return usuario;
        }

        public void inserirUsuario(tb_usuario usuario)
        {
            db.tb_usuario.Add(usuario);
            db.SaveChanges();
        }

        public List<tb_usuario> ListaDeUsuarios()
        {
            List<tb_usuario> lista = db.tb_usuario.ToList();

            return lista;
        }
    }
}
