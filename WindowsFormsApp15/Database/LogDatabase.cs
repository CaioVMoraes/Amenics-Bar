using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class LogDatabase
    {
        Model.amenicsEntities db = new Model.amenicsEntities();
        public void InserirLog(tb_log modelo)
        {
            db.tb_log.Add(modelo);
            db.SaveChanges();
        }

        public List<tb_log> ConsultarLog()
        {
            List<tb_log> lista = db.tb_log.ToList();

            return lista;
        }
        public tb_log Listar(int id)
        {
            tb_log modelo = db.tb_log.FirstOrDefault(x => x.id_log == id);

            return modelo;
        }

        public void AlterarLog(tb_log modelo)
        {
            tb_log alterar = db.tb_log.FirstOrDefault(x => x.id_log == x.id_log);

            modelo.ds_oqFez = alterar.ds_oqFez;
            modelo.ds_telaEntrou = alterar.ds_telaEntrou;
            modelo.dt_dataLogin = alterar.dt_dataLogin;

            db.SaveChanges();
        }
        public void RemoverLog(int id)
        {
            tb_log deletar = db.tb_log.FirstOrDefault(x => x.id_log ==  id);
            db.tb_log.Remove(deletar);
            db.SaveChanges();
        }
    }
}
