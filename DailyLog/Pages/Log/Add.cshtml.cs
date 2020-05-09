using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DailyLog.Core;
using DailyLog.Services;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DailyLog
{
    public class AddModel : PageModel
    {
        private readonly ILogService _logService;
        private readonly IProjectService _projectService;

        public AddModel(ILogService logService,IProjectService projectService)
        {
            _logService = logService;
            _projectService = projectService;
        }

        [BindProperty(SupportsGet = true)]
        public LogEntity Log { get; set; }

       
        public EntityCollection<ProjectEntity> ProjectEntities { get; set; }

        public List<SelectListItem> Numbers =>
            Enumerable.Range(15,46).Where(x=>x%15==0).Select(x =>
                    new SelectListItem { Value = x.ToString(), Text = x.ToString() })
                .ToList();
        public async Task OnGet(int? id)
        {
            ProjectEntities =await _projectService.GetProjects();

            if (id != null)
            {
                Log = await _logService.GetLogById(id);
            }
        }

        public async Task<IActionResult>OnPost()
        {
            var principal = HttpContext.User as ClaimsPrincipal;
            var accessUserIdClaim = principal?.Claims.FirstOrDefault(c => c.Type == "Id");
            
            if (accessUserIdClaim == null)
                return BadRequest();

            Log.CreatedByUserId= int.Parse(accessUserIdClaim.Value);
           
           await _logService.AddLog(Log);

            return RedirectToPage("../Log");
        }
    }
}