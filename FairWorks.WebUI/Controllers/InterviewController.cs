using System;
using System.Collections.Generic;
using System.Linq;
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
            var interviewList = await _interviewClient.GetAllAsync();
            var salonList = new List<SalonDTO>();
            foreach (var activeFair in activeFairList)
            {
                salonList.AddRange(activeFair.Salons);
            }

            InterviewViewModel vm = new InterviewViewModel()
            {
                Sectors = sectorList,
                CompanyProfiles = companyProfileList,
                Fairs = activeFairList,
                Salons = salonList,
                Interviews = interviewList
            };
            return View(vm);
        }

        [HttpGet]
        public async Task<ActionResult<InterviewDTO>> InterviewUpdate(string Id)
        {
            InterviewEditViewModel vm = new InterviewEditViewModel();
            vm.Interview = await _interviewClient.GetById(Id);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult> InterviewUpdate(InterviewDTO interviewDTO)
        {
            var result = await _interviewClient.UpdateAsync(interviewDTO);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<ActionResult> AddInterview(InterviewDTO interviewDTO)
        {
            await _interviewClient.AddInterview(interviewDTO);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public async Task<ActionResult> InterviewDelete(string Id)
        {
            await _interviewClient.DeleteAsync(Id);
            return RedirectToAction("Index");
        }

    }
}