using System;
using System.Threading.Tasks;
using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using FairWorks.WebUI.Models.Interview;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IInterviewClient _interviewClient;
        private readonly ISectorClient _sectorClient;
        private readonly ICompanyClient _companyClient;
        private readonly IFairClient _fairClient;
        public InterviewController(IInterviewClient interviewClient, ISectorClient sectorClient, ICompanyClient companyClient, IFairClient fairClient)
        {
            _interviewClient = interviewClient;
            _sectorClient = sectorClient;
            _companyClient = companyClient;
            _fairClient = fairClient;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var sectorList = await _sectorClient.GetAllAsync();
            var companyProfileList = await _companyClient.GetAllCompanyProfiles();
            var activeFairList = await _fairClient.GetAllFairs();
            InterviewViewModel vm = new InterviewViewModel()
            {
                Sectors = sectorList,
                CompanyProfiles = companyProfileList,
                Fairs = activeFairList
            };
            return View(vm);
        }
        
        public async Task<ActionResult> AddInterview(InterviewDTO interviewDTO)
        {
            var interview = await _interviewClient.AddInterview(interviewDTO);
            return Ok(interview);
        }
    }
}