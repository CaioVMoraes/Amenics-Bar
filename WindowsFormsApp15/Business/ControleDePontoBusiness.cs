using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class ControleDePontoBusiness
    {

      Database.ControledePontoDatabase db = new Database.ControledePontoDatabase();
      public void CadastrarPonto(tb_controledeponto modelo)
       {
            db.CadastrarPonto(modelo);
       }
      public List<tb_controledeponto> ConsultarPonto()
        {
            List<tb_controledeponto> lista = db.ConsultarPonto();

            return lista;
        }
        public Model.tb_controledeponto Listar(int id)
        {
            Model.tb_controledeponto modelo = db.Listar(id);

            return modelo;
        }
        public void AlterarPonto(tb_controledeponto modelo)
        {
            db.AlterarPonto(modelo);
        }
        public void RemoverPonto(int id)
        {
            db.RemoverPonto(id);
        }
    }
}
