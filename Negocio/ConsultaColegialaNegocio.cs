using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class ConsultaColegialaNegocio
    {
        ConsultaColegialaDatos ccd = new ConsultaColegialaDatos();
        private ConsultaColegialaDatos _datos;

        
        public ConsultaColegialaNegocio()
        {
            _datos = new Datos.ConsultaColegialaDatos();
        }
        public List<Colegiala> listacolegialan()
        {
          

            var colegialasnegocio = ccd.listacolegiala();
            return colegialasnegocio;

        }

        public bool GuardaNuevaPanocha(string nombre, int edad, int nivelcaliente, int estado, string tragona)
        {

            var guardadanueva = ccd.guardadoExitoso(nombre, edad,nivelcaliente,estado, tragona);
            return guardadanueva;
        }

        public List<Colegiala> busquedaNegocio(int id)
        {
            var busquedaN = ccd.Busqueda(id);
            return busquedaN;



        }

        public bool actualizaNegocio(int id,string Nombre, int edad, int nivelcaliente, int estado, string Tragona)
        {
            var seactualizo = ccd.actualizardatos(id,Nombre,edad,nivelcaliente,estado,Tragona);
            return seactualizo;
        }

        public bool eliminanegocio(int id)
        {
            bool eliminadoexitoso = ccd.eliminaRegistro(id);

            return eliminadoexitoso;

        }

        //public int colegialnn( )
        //{

        //    int retornnn = 0;

        //   return retornnn = _datos.guardaColegiala(col);



        //}
    }
}
