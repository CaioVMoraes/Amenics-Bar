using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class VendaBusiness
    {
        Database.VendaDatabase db = new Database.VendaDatabase();

        public void InserirVenda(tb_venda modelo)
        {
            db.InserirVenda(modelo);
        }
        public void InserirVendaItem(tb_venda_item modelo)
        {
            db.InserirVendaitem(modelo);
        }

        public List<tb_venda> ConsultarVenda()
        {
            List<tb_venda> lista = db.ConsultarVenda();

            return lista;
        }
        public tb_venda Listar(int id)
        {
            tb_venda modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarVenda(tb_venda modelo)
        {
            db.AlterarVenda(modelo);
        }
        public void RemoverVenda(int id)
        {
            db.RemoverVenda(id);
        }
    }
}
