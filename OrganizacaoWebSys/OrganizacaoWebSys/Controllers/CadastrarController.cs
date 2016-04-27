using OrganizacaoWebSys.Models;
using System.Web.Mvc;

namespace OrganizacaoWebSys.Controllers {
    public class CadastrarController : Controller {
        // GET: Cadastrar
        public ActionResult Cadastrar() {
            return View();
        }

        public ActionResult Area() {
            return View();
        }
        [HttpPost]
        public ActionResult Area(Area area) {
            if (ModelState.IsValid) {
                Dbase.Salvar(area);
                return RedirectToAction("Area");
            }
            return View();
        }

        public ActionResult Colaborador() {
            return View();
        }
        [HttpPost]
        public ActionResult Colaborador(Colaborador colaborador) {
            if (ModelState.IsValid) {
                Dbase.Salvar(colaborador);
                return RedirectToAction("Colaborador");
            }
            return View();
        }

        public ActionResult TipoProjeto() {
            return View();
        }
        [HttpPost]
        public ActionResult TipoProjeto(TipoProjeto tipoProjeto) {
            if (ModelState.IsValid) {
                Dbase.Salvar(tipoProjeto);
                return RedirectToAction("TipoProjeto");
            }
            return View();
        }

        public ActionResult Projeto() {
            return View();
        }
        [HttpPost]
        public ActionResult Projeto(Projeto projeto) {
            if (ModelState.IsValid) {
                Dbase.Salvar(projeto);
                return RedirectToAction("Projeto");
            }
            return View();
        }
    }
}