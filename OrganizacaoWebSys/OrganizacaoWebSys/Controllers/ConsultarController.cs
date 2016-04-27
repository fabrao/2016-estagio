using OrganizacaoWebSys.Models;
using System.Web.Mvc;

namespace OrganizacaoWebSys.Controllers {
    public class ConsultarController : Controller {
        // GET: Consultar
        public ActionResult Consultar() {
            return View();
        }
        public ActionResult Colaborador() {
            return View(Dbase.ListarColaboradores());
        }
        public ActionResult Area() {
            return View(Dbase.ListarAreas());
        }
        public ActionResult TipoProjeto() {
            return View(Dbase.ListarTiposProjetos());
        }
        public ActionResult Projeto() {
            return View(Dbase.ListarProjetos());
        }

        
         public ActionResult ExcluirArea(int id) {
            Area area = Dbase.GetArea(id);
            if (area == null)
                return HttpNotFound();
            return View(area);
        }

        [HttpPost, ActionName("ExcluirArea")]
        public ActionResult ExcluirAreaConfirmacao(int id) {
            Area area = Dbase.GetArea(id);
            Dbase.Remove(area);
            return RedirectToAction("Consultar");
        }
    }
}