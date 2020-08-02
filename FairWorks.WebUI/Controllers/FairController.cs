using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using FairWorks.WebUI.Models.Fair;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Controllers
{
    public class FairController : Controller
    { 
    private readonly IFairClient _fairClient;
    private readonly ISectorClient _sectorClient;
    public FairController(IFairClient fairClient, ISectorClient sectorClient)
    {
        _fairClient = fairClient;
        _sectorClient = sectorClient;
    }
    [HttpGet]
    public async Task<ActionResult> Index()
    {
        
        var fairList = await _fairClient.GetAllFairs();
        var sectorList = await _sectorClient.GetAllAsync();
        FairViewModel vm = new FairViewModel()
        {
           
            Fairs = fairList,
            Sectors = sectorList
        };
        return View(vm);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddFair(FairDTO fairDTO)
    {
        var fair = _fairClient.AddFair(fairDTO);
        return Ok();
    }
}
}