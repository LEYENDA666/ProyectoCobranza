using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Redencion.Models;
using Negocio;
namespace Redencion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        ConsultaColegialaNegocio ccn = new ConsultaColegialaNegocio();
        public ActionResult Index(ResumenColegiala rc)
        {
          
            rc.panocharica = ccn.listacolegialan();

            return View(rc);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(string Nombre, int edad, int nivelcaliente, int estado, string tragona)
        {
            var guardo = ccn.GuardaNuevaPanocha(Nombre, edad, nivelcaliente, estado, tragona);
            if (guardo)
            {
                ResumenColegiala rcg = new ResumenColegiala();
                rcg.panocharica = ccn.listacolegialan();

                return View("Index", rcg);
            }
            return View();
        }


        //    public ActionResult Create(Colegialan cole)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        cole.
        //        var guardo = ccn.colegialnn(cole);
        //        //    if (guardo)
        //        //    {
        //        //        ResumenColegiala rcg = new ResumenColegiala();
        //        //        rcg.panocharica = ccn.listacolegialan();

        //        //        return View("Index",rcg);
        //        //    }

        //    }



        //    return View();

        //}

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var editarnegocio = ccn.busquedaNegocio(id);

            Editar ed = new Editar();
            ed.id = editarnegocio.Where(x => x.id == id).FirstOrDefault().id;
            ed.Nombre = editarnegocio.Where(x => x.id == id).FirstOrDefault().Nombre;
            ed.edad= editarnegocio.Where(x => x.id == id).FirstOrDefault().edad;
            ed.nivelcaliente = editarnegocio.Where(x => x.id == id).FirstOrDefault().nivelcaliente;
            ed.estado = editarnegocio.Where(x => x.id == id).FirstOrDefault().estado;
            ed.Tragona= editarnegocio.Where(x => x.id == id).FirstOrDefault().Tragona;



            return View(ed);
        }
        [HttpPost]
        public ActionResult Edit(int id,string Nombre,int edad, int nivelcaliente, int estado, string Tragona)
        {

            var seactualizo = ccn.actualizaNegocio(id,Nombre,edad,nivelcaliente,estado, Tragona);

            if (seactualizo)
            {
                ResumenColegiala mostrar= new ResumenColegiala();
                mostrar.panocharica = ccn.listacolegialan();

                return View("Index", mostrar);
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            Deletete del = new Deletete();

            var busquedadelete = ccn.busquedaNegocio(id);

            del.id = busquedadelete.Where(x => x.id == id).FirstOrDefault().id;
            del.Nombre = busquedadelete.Where(x => x.id == id).FirstOrDefault().Nombre;
            del.edad = busquedadelete.Where(x => x.id == id).FirstOrDefault().edad;
            del.nivelcaliente = busquedadelete.Where(x => x.id == id).FirstOrDefault().nivelcaliente;
            del.estado = busquedadelete.Where(x => x.id == id).FirstOrDefault().estado;
            del.Tragona = busquedadelete.Where(x => x.id == id).FirstOrDefault().Tragona;


            return View(del);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed (int id)
        {
            bool resEliminacion = ccn.eliminanegocio(id);
            if (resEliminacion)
            {

                ResumenColegiala mostrar = new ResumenColegiala();
                mostrar.panocharica = ccn.listacolegialan();

                return View("Index", mostrar);
            }


            return View();
        }

    }
}