using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DailyLog.Services;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class LogModel : PageModel
    {
        private readonly ILogService _logService;
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int TotalLogsCounter { get; set; }
        public int PageSize { get; set; } = 3;
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalLogsCounter, PageSize));
       
        public LogModel(ILogService logService)
        {
            _logService = logService;
        }
        public EntityCollection<LogEntity> LogEntities { get; set; }
        public async Task OnGet()
        {
            var principal = HttpContext.User as ClaimsPrincipal;
            var accessUserIdClaim = principal?.Claims.FirstOrDefault(c => c.Type == "Id");

            var currentLoginUserId = int.Parse(accessUserIdClaim.Value);

            TotalLogsCounter = await _logService.GetLogsCount(currentLoginUserId);
            LogEntities = await _logService.GetCurrentUserLogs(currentLoginUserId,CurrentPage,PageSize);
        }

        public async Task<IActionResult> OnGetDeleteLog(int id)
        {
            await _logService.DeleteLogById(id);
            return RedirectToPage("/log");

        }

    }
}