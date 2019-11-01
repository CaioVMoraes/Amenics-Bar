using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class EstoqueBusiness
    {
        Model.tb_estoque modelo = new tb_estoque();
        Database.EstoqueDatabase db = new Database.EstoqueDatabase();
        public void CadastrarEstoque(tb_estoque modelo)
        {
            if (modelo.id_produto == 0)
            {
                throw new ArgumentException("Produto Invalido");
            }
            if (modelo.dt_entrada == null)
            {
                throw new ArgumentException("O campo data de entrada é obrigatório");
            }

            db.CadastrarEstoque(modelo);
        }
        public List<tb_estoque> ConsultarEstoque()
        {
            List<tb_estoque> lista = db.ConsultarEstoque();

            return lista;
        }

        public List<tb_estoque> ConsultarEstoqueId(int id)
        {
            List<tb_estoque> lista = db.ConsultarEstoqueId(id);

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueVendidoSim(bool vendido)
        {
            List<tb_estoque> lista = db.ConsultarEstoqueVendidoSim(vendido);

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueVendidoNao(bool vendido)
        {
            List<tb_estoque> lista = db.ConsultarEstoqueVendidoNao(vendido);

            return lista;
        }
        public List<tb_estoque> ConsultarEstoqueData(DateTime data)
        {
            List<tb_estoque> lista = db.ConsultarEstoqueData(data);

            return lista;
        }
        public Model.tb_estoque Listar(int id)
        {
            Model.tb_estoque modelo = db.Listar(id);

            return modelo;
        }

        public tb_estoque ListarAlterarNaoVendidos(int id)
        {
            tb_estoque modelo = db.ListarAlterarNaoVendidos(id);

            if(modelo == null)
            {
                throw new ArgumentException("Produto Indisponível");
            }

            return modelo;
        }

        public void AlterarEstoque(tb_estoque modelo)
        {
            if (modelo.id_estoque == 0)
            {
                throw new ArgumentException("Id inválido");
            }
            if (modelo.dt_entrada == null)
            {
                throw new ArgumentException("O campo data de entrada é obrigatório");
            }

            db.AlterarEstoque(modelo);
        }
        public void RemoverEstoque(int id)
        {
            db.RemoverEstoque(id);
        }
    }
}
