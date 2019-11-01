using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class LogBusiness
    {
        Database.LogDatabase db = new Database.LogDatabase();

        public void InserirLog(tb_log modelo)
        {
            db.InserirLog(modelo);
        }

        public List<tb_log> ConsultarLog()
        {
            List<tb_log> lista = db.ConsultarLog();

            return lista;
        }
        public tb_log Listar(int id)
        {
            tb_log modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarLog(tb_log modelo)
        {
            db.AlterarLog(modelo);
        }
        public void RemoverLog(int id)
        {
            db.RemoverLog(id);
        }
    }
}
