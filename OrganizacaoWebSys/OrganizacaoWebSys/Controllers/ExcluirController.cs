using OrganizacaoWebSys.Models;
using System.Web.Mvc;

namespace OrganizacaoWebSys.Controllers
{
    public class ExcluirController : Controller
    {
        public ActionResult DelArea(int id) {
            Area area = Dbase.GetArea(id);
            if (area == null)
                return HttpNotFound();
            return View(area);
        }

        [HttpPost, ActionName("DelArea")]
        public ActionResult DelAreaConfirm(int id) {
            Area area = Dbase.GetArea(id);
            Dbase.Remove(area);
            return RedirectToAction("Consultar");
        }
    }
}