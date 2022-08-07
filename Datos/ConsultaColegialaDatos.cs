using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class ConsultaColegialaDatos
    {
        // solo agregamos un pinche comentario
        // solo agregamos otro pinche comentario
        // comentario de cobranza0
        //comentario de cobranza1
        // comentario de la nueva rama de cobranza
        //otra perrita
        // cambios francois
        public List<Colegiala> listacolegiala()
        {
            List<Colegiala> Colegiala = null;

            try
            {
                Panocha vulva = new Panocha();
                using (vulva)
                {
                    Colegiala = (from x in vulva.Colegiala select x).ToList();
                
                }

            }
            catch (Exception ex)
            {

                Colegiala = null;
            }
            return Colegiala;

        }

        public List<Colegiala> Busqueda(int id)
        {
            List<Colegiala> busquedapanocha = null;

            Panocha conchita = new Panocha();
            using (conchita)
            {
                busquedapanocha = (from x in conchita.Colegiala where x.id == id select x).ToList();
            }

            return busquedapanocha;
           


        }

        public bool guardadoExitoso(string nombre, int edad, int nivelcaliente, int estado, string tragona)
        {
            Panocha humedad = new Panocha();
            bool guardado = false;

            using (humedad)
            {
                var NuevaColegiala = new Colegiala {
                    Nombre = nombre,
                    edad = edad,
                    nivelcaliente = nivelcaliente,
                    estado = estado,
                    Tragona=tragona
                    
                };

                humedad.Colegiala.Add(NuevaColegiala);
                humedad.SaveChanges();
                guardado = true;

            }

            return guardado;
        }

        public bool actualizardatos(int id,string Nombre,int edad,int nivelcaliente,int estado, string Tragona)
        {
            bool actualizado = false;
            Panocha actualizar = new Panocha();
            using (actualizar)
            {
                var entidadactualizar = (from x in actualizar.Colegiala where x.id == id select x).FirstOrDefault();


                if (entidadactualizar != null)
                {
                    entidadactualizar.Nombre = Nombre;
                    entidadactualizar.edad = edad;
                    entidadactualizar.nivelcaliente = nivelcaliente;
                    entidadactualizar.estado = estado;
                    entidadactualizar.Tragona = Tragona;

                    actualizar.SaveChanges();
                    actualizado = true;
                }
                
            }

            return actualizado;


        }

        public bool eliminaRegistro(int id)
        {

            Panocha del = new Panocha();
            bool eliminada = false;

            try
            {
                using (del)
                {
                    var eliminarcolegiala = (from x in del.Colegiala where x.id == id select x).FirstOrDefault();

                    if (eliminarcolegiala != null)
                    {

                        del.Colegiala.Remove(eliminarcolegiala);
                        del.SaveChanges();
                        eliminada = true;
                    }
                }
            }
            catch (Exception ret)
            {
                eliminada = false;
            }

            return eliminada;
            
        }

        public int guardaColegiala(Colegiala registro )
        {

            int registron = 0;
            try
            {
                using (var db = new Panocha())
                {
                    db.Colegiala.Add(registro);
                    db.SaveChanges();
                    registron = 1;
                }
            }
            catch (Exception)
            {

                registron = 0;
            }

            return registron;



        }
    }
}
