using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult AppBrandPartial()
        {
            return PartialView();
        }

        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
