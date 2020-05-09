using System.Threading.Tasks;
using DailyLog.Services;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class CompanyModel : PageModel
    {
        private readonly ILogService _logService;

        public CompanyModel(ILogService logService)
        {
            _logService = logService;
        }
        [BindProperty]
        public EntityCollection<LogEntity> LogEntities { get; set; }
        public async Task OnGet()
        {
            LogEntities = await _logService.GetAllLogsWithUserAndProjectInfo();
        }
    }
}