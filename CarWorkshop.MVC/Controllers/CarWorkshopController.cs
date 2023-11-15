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
            await _carWorkshopService.Create(carWorkshop);
            //nie mamy aktualnie żadnego widoku dlatego tymczasowo przekierujemy akcje
            //gdy dodamy później widoki to wrócimy do konkretnego redirect
            return RedirectToAction(nameof(Create));
        }

        public ActionResult Create() 
        {
            return View();
        }

    }
}
