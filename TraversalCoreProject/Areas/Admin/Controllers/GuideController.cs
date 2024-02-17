using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult validationResult = validationRules.Validate(guide);
            if (validationResult.IsValid)
            {
                guide.Status = true;
                _guideService.TAdd(guide);
                return RedirectToAction("Guide", "Admin");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            _guideService.TDelete(values);
            return RedirectToAction("Guide", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Guide", "Admin");
        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Guide", "Admin");
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Guide", "Admin");
        }
    }
}
