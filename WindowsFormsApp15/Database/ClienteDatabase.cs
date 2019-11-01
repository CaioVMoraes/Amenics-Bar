using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class ClienteDatabase
    {

        Model.amenicsEntities db = new amenicsEntities();


        public void InserirCliente(tb_cliente modelo)
        {
            db.tb_cliente.Add(modelo);
            db.SaveChanges();
        }
        public List<tb_cliente> ConsultarCliente()
        {
            List<tb_cliente> lista = db.tb_cliente.ToList();

            return lista;
        }
        public List<tb_cliente> ConsultarClienteId(int id)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.id_cliente == id).ToList();

            return lista;
        }
        public List<tb_cliente> ConsultarClienteNome(string nome)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.nm_cliente == nome).ToList();

            return lista;
        }
         public List<tb_cliente> ConsultarClienteCpf(string cpf)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.ds_cpf == cpf).ToList();

            return lista;
        }
        public tb_cliente ListarClienteCpf(string cpf)
        {
            tb_cliente model = db.tb_cliente.FirstOrDefault(x => x.ds_cpf == cpf);

            return model;
        }
        public List<tb_cliente> ConsultarClienteRg(string RG)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.ds_rg == RG).ToList();

            return lista;
        }
        public List<tb_cliente> ConsultarClienteTelefone(string tel)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.ds_telefone == tel).ToList();

            return lista;
        }
        public List<tb_cliente> ConsultarClienteCelular(string cel)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.ds_celular == cel).ToList();

            return lista;
        }
        public List<tb_cliente> ConsultarClienteEmail(string email)
        {
            List<tb_cliente> lista = db.tb_cliente.Where(x => x.ds_email == email).ToList();

            return lista;
        }

        public void AlterarCliente(tb_cliente modelo)
        {
            tb_cliente alterar = db.tb_cliente.FirstOrDefault(x => x.id_cliente == x.id_cliente);

            modelo.ds_celular = alterar.ds_celular;
            modelo.ds_cpf = alterar.ds_cpf;
            modelo.ds_rg = alterar.ds_rg;
            modelo.ds_email = alterar.ds_email;
            modelo.ds_telefone = alterar.ds_telefone;
            modelo.nm_cliente = alterar.nm_cliente;

            db.SaveChanges();

        }
        public void RemoverCliente(int id)
        {
            tb_cliente modelo = db.tb_cliente.FirstOrDefault(x => x.id_cliente == id);
            db.tb_cliente.Remove(modelo);

            db.SaveChanges();
        }
    }
}
