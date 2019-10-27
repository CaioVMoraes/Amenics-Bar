using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class ProdutoDatabase
    {
        Model.amenicsEntities db = new Model.amenicsEntities();

        public void CadastrarProduto(tb_produto produto)
        {
            db.tb_produto.Add(produto);
            db.SaveChanges();

        }
        public List<tb_produto> ConsultarProdutoNome(string Produtonome)
        {
            List<tb_produto> lista = db.tb_produto.Where(x=> x.nm_produto == Produtonome).ToList();

            return lista;
        }
        public List<tb_produto> ConsultarProdutoCategoria(int idcategoria)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.id_categoria == idcategoria).ToList();

            return lista;
        }
        public List<tb_produto> ConsultarProdutoFornecedor(int idFornecedor)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.id_fornecedor == idFornecedor).ToList();

            return lista;
        }

        public List<tb_produto> ConsultarTodosProdutos()
        {
            List<tb_produto> lista = db.tb_produto.ToList();

            return lista;
        }

        public List<tb_produto> ConsultarProdutoID(int id)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.id_produto == id).ToList();

            return lista;
        }

        public tb_produto Listar(int id)
        {
            tb_produto modelo = db.tb_produto.FirstOrDefault(x => x.id_produto == id);

            return modelo;
        }

        public void AlterarProduto(tb_produto modelo)
        {
            tb_produto alterar = db.tb_produto.FirstOrDefault(x => x.id_produto == x.id_produto);

            modelo.nm_produto = alterar.nm_produto;
            modelo.id_categoria = alterar.id_categoria;
            modelo.id_fornecedor = alterar.id_fornecedor;
            modelo.img_produto = alterar.img_produto;
            
            db.SaveChanges();
          
        }
        public void RemoverProduto(int id)
        {
           tb_produto deletar = db.tb_produto.FirstOrDefault(x => x.id_produto == x.id_produto);

            db.tb_produto.Remove(deletar);

            db.SaveChanges();

        }





    }
}
