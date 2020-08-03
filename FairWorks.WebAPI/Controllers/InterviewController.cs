using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.BLL;
using FairWorks.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewService _interviewService;
        private readonly ISalesPersonService _salesPersonService;
        private readonly IInterviewerService _interviewerService;
        private readonly IInterviewFairService _interviewFairService;
        private readonly ICompanyService _companyService;
        private readonly IFairService _fairService;
        public InterviewController(IInterviewService interviewService, ISalesPersonService salesPersonService, ICompanyService companyService, IInterviewerService interviewerService, IInterviewFairService interviewFairService, IFairService fairService)
        {
            _interviewService = interviewService;
            _salesPersonService = salesPersonService;
            _companyService = companyService;
            _interviewerService = interviewerService;
            _interviewFairService = interviewFairService;
            _fairService = fairService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<InterviewDTO>>> GetAll()
        {
            var result = await _interviewService.GetAllWithIncludesAsync();
            return result;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<InterviewDTO>> GetById(string Id)
        {
            var result = await _interviewService.GetAllWithIncludesAsyncById(Guid.Parse(Id));
            return result;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> Add(InterviewDTO interviewDTO)
        {
            interviewDTO.SalesPerson = await _salesPersonService.GetByNameAndEmailAsync(interviewDTO.SalesPerson);
            var company = await _companyService.GetByNameAsync(interviewDTO.Company.Name);
            if(company == null)
            {
                company = await _companyService.AddAsync(interviewDTO.Company,true);
            }
            interviewDTO.Company = company;

            var interviewer = await _interviewerService.GetByNameAndEmailAsync(interviewDTO.Interviewer);
            if(interviewer == null)
            {
                interviewDTO.Interviewer.Company = company;
                interviewer = await _interviewerService.AddAsync(interviewDTO.Interviewer);
            }
            interviewDTO.Interviewer = interviewer;
            var interview = await _interviewService.AddAsync(interviewDTO);

            foreach (var fairId in interviewDTO.FairIds)
            {
                await _interviewFairService.AddAsync(new InterviewFairDTO
                {
                    Name = "GörüşmeKaydıFuar" + fairId,
                    Interview = interview,
                    Company = interviewDTO.Company,
                    Fair = _fairService.Get(Guid.Parse(fairId))
                });
            }
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<InterviewDTO> Update(InterviewDTO interviewDTO)
        {
            return await _interviewService.UpdateAsync(interviewDTO);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<bool> Delete(string Id)
        {
            return await _interviewService.DeleteInterviewAsync(Guid.Parse(Id));
        }
    }
}