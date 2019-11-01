using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class CompraBusiness
    {
        Database.CompraDatabase db = new Database.CompraDatabase();

        public void InserirCompra(tb_compra modelo)
        {
            db.InserirCompra(modelo);

        }
        public void InserirCompraItem(tb_compra_item modelo)
        {
            db.InserirCompraitem(modelo);
        }

        public List<tb_compra> ConsultarCompra()
        {
            List<tb_compra> lista = db.ConsultarCompra();

            return lista;
        }
        public List<tb_compra_item> ConsultarCompraItem(DateTime data)
        {
            List<tb_compra_item> lista = db.ConsultarCompraItem(data);

            return lista;
        }
        public tb_compra Listar(int id)
        {
            tb_compra modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarCompra(tb_compra modelo)
        {
            db.AlterarCompra(modelo);
        }
        public void RemoverCompra(int id)
        {
            db.RemoverCompra(id);
        }
    }
}
