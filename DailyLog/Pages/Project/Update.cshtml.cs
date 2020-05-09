using System.IO;
using System.Threading.Tasks;
using DailyLog.Services;
using Data.DailyLog.EntityClasses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace DailyLog
{
    public class UpdateModel : PageModel
    {
        private readonly IProjectService _projectService;
        

        public UpdateModel(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [BindProperty]
        public ProjectEntity Project { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            Project = await _projectService.GetProjectById(id);
            if (Project == null) return RedirectToPage("/project");

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (Project.ImagePath != null)
            {
                _projectService.DeleteOldPhoto(Project);
            }
            
            Project.ImagePath = await _projectService.FileUpload(Photo);
            await _projectService.UpdateProject(Project);
            return RedirectToPage("../Project");
        }


    }
}