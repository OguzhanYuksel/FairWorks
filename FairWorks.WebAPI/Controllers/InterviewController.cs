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
        private readonly ICompanyService _companyService;
        public InterviewController(IInterviewService interviewService, ISalesPersonService salesPersonService, ICompanyService companyService)
        {
            _interviewService = interviewService;
            _salesPersonService = salesPersonService;
            _companyService = companyService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<InterviewDTO>> Add(InterviewDTO interviewDTO)
        {
            interviewDTO.SalesPerson = await _salesPersonService.GetByNameAndEmailAsync(interviewDTO.SalesPerson);
            var company = await _companyService.GetByNameAsync(interviewDTO.Company.Name);
            if(company == null)
            {
                company = await _companyService.AddAsync(interviewDTO.Company);
                interviewDTO.Company = company;
            }
            var interviewer = await _interviewerService.GetByNameAndEmailAsync(interviewDTO.Interviewer);
            if(interviewer == null)
            {
                interviewer = await _interviewerService.AddAsync(interviewDTO.Interviewer);
                interviewDTO.Interviewer = interviewer;
            }
            var interview = await _interviewService.AddAsync(interviewDTO);
            return interview;
        }
    }
}