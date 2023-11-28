using Microsoft.AspNetCore.Mvc;
using CarWorkshop.Aplication.CarWorkshop;
using MediatR;
using CarWorkshop.Aplication.Queries;
using CarWorkshop.Aplication.CarWorkshop.Commands.createWorkshop;
using CarWorkshop.Aplication.CarWorkshop.Queries.GetCarWorkshopByEncodedName;
using AutoMapper;
using CarWorkshop.Aplication.CarWorkshop.Commands.EditCarWorkshop;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CarWorkshopController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
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

        [Route("CarWorkshop/{encodedName}/Details")]
        public async Task<IActionResult> Details(string encodedName)
        {
            var dto = await _mediator.Send(new GetCarWorkshopByEncodedNameQuery(encodedName));
            return View(dto);
        }

        [Route("CarWorkshop/{encodedName}/Edit")]
        public async Task<IActionResult> Edit(string encodedName)
        {
            var dto = await _mediator.Send(new GetCarWorkshopByEncodedNameQuery(encodedName));
            EditCarWorkshopCommand model = _mapper.Map<EditCarWorkshopCommand>(dto);
            return View(model);
        }
        [HttpPost]
        [Route("CarWorkshop/{encodedName}/Edit")]
        public async Task<IActionResult> Edit(string encodedName, EditCarWorkshopCommand command)
        {
            ModelState["Name"].ValidationState = ModelValidationState.Valid;
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
        public async Task<IActionResult> Index()
        {
            var carWorksops = await _mediator.Send(new GetAllCarWorkshopQuery());
            return View(carWorksops);

        }

    }

    
}
