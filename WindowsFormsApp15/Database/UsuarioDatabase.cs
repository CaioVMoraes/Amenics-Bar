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
        Model.amenicsEntities db = new Model.amenicsEntities();

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
        public void RemoverUsuario(int id)
        {
            tb_usuario deletar = db.tb_usuario.FirstOrDefault(x => x.id_usuario == x.id_usuario);
            db.tb_usuario.Remove(deletar);
        }
        public void alterarusuario(tb_usuario modelo)
        {
            tb_usuario alterar = db.tb_usuario.FirstOrDefault(x => x.id_usuario == x.id_usuario);

            modelo.nm_usuario = alterar.nm_usuario;
            modelo.ds_senha = alterar.ds_senha;

            db.SaveChanges();
        }
    }
}
