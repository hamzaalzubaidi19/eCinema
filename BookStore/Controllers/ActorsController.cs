using eCinema.Data;
using eCinema.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCinema.Controllers
{

    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task <IActionResult> Index()
        {
            var data = await  _service.GetAllAsync();
            return View(data);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
      public async Task<IActionResult> Create([Bind("FullName, ProfilePictureUrl, Bio")] Actor actor)
        {

            if(!ModelState.IsValid)
            {
                return View(actor);
            }
          await  _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalis(int id)
        {
            var actorDetalis = await _service.GetByIdAsync(id);
            if (actorDetalis == null) return View("NotFound");
            return View(actorDetalis);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
       public IActionResult Delete(int id)
        {
            var ActorItem = _service.GetByIdAsync(id);
            if (ActorItem == null) return View("NotFound");
            return View(ActorItem);
        }
        [HttpPost]

        public async Task<IActionResult> DeleteConform(int id)
        {
            var ActorItem = _service.GetByIdAsync(id);
            if (ActorItem == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));


        }





    }
}
