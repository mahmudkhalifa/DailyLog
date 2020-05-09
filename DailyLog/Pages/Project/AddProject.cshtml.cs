using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DailyLog.Core;
using DailyLog.Services;
using Data.DailyLog.EntityClasses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class AddProjectModel : PageModel
    {
        private readonly IProjectService _projectService;

        public AddProjectModel(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [BindProperty]
        public Project Project { get; set; }
        
        [BindProperty]
        public IFormFile photo { get; set; }
        public void OnGet()
        {
          
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                RedirectToPage("AddProject");

            Project.imagePath = _projectService.FileUpload(photo);
            _projectService.AddProject(Project);
            return RedirectToPage("../Project");
        }

    }
}