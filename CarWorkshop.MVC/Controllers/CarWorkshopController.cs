using CarWorkshop.Aplication.Services;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.Aplication.CarWorkshop;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController: Controller 
    {
        private readonly ICarWorkshopService _carWorkshopService;
        public CarWorkshopController(ICarWorkshopService carWorkshopService) 
        {
            _carWorkshopService = carWorkshopService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CarWorkshopDto carWorkshop) 
        {
            if (ModelState.IsValid == false) 
            {
                return View();
            }
            await _carWorkshopService.Create(carWorkshop);
            return RedirectToAction(nameof(Create));
        }

        public IActionResult Create() 
        {
            return View();
        }

    }
}
