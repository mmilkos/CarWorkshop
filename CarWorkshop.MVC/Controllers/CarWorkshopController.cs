using Microsoft.AspNetCore.Mvc;
using CarWorkshop.Aplication.CarWorkshop;
using MediatR;
using CarWorkshop.Aplication.Queries;
using CarWorkshop.Aplication.CarWorkshop.Commands.createWorkshop;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController: Controller 
    {
        private readonly IMediator _mediator;
        public CarWorkshopController(IMediator mediator) 
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCarWorkshopCommand command) 
        {
            if (ModelState.IsValid == false) 
            {
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create() 
        {
            return View();
        }
        //
        public async Task<IActionResult> Index() 
        {
            var carWorksops = await _mediator.Send(new GetAllCarWorkshopQuery());
            return View(carWorksops);

        }

    }
}
