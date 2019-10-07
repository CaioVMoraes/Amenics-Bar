using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class UsuarioBusiness
    {
        Database.UsuarioDatabase database = new Database.UsuarioDatabase();

        public tb_usuario ModeloUsuario(string nome, string senha)
        {
            tb_usuario usuario = database.usuario(nome, senha);

            return usuario;
        }

        public bool Usuario(string nome, string senha)
        {
            tb_usuario usuario = database.usuario(nome, senha);

            if (usuario == null)
            {
                throw new ArgumentException("Credenciais incorretos");
            }

            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void inserirUsuario(tb_usuario usuario, string confiSenha)
        {
            List<tb_usuario> lista = database.ListaDeUsuarios();

            bool nomeExiste = lista.Exists(x => x.nm_usuario == usuario.nm_usuario);

            if (nomeExiste == true)
            {
                throw new ArgumentException("Usúario já existe");
            }

            if (usuario.ds_senha == string.Empty)
            {
                throw new ArgumentException("Insira uma senha válida");
            }

            if (confiSenha == string.Empty)
            {
                throw new ArgumentException("Confirme a sua senha");
            }

            if (usuario.nm_usuario == string.Empty)
            {
                throw new ArgumentException("Informe o seu nome de usúario");
            }

            if (usuario.ds_senha != confiSenha)
            {
                throw new ArgumentException("Senhas não compatíveis");
            }

            if (usuario.ds_senha.Length < 8)
            {
                throw new ArgumentException("Senha deve ter pelo menos 8 caractéres");
            }

            if (confiSenha.Length < 8)
            {
                throw new ArgumentException("Senha deve ter pelo menos 8 caractéres");
            }

            database.inserirUsuario(usuario);
        }

    }
}
