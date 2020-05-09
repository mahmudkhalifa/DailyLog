using System.Threading.Tasks;
using DailyLog.Core;
using DailyLog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class NewModel : PageModel
    {
        private readonly IProjectService _projectService;

        public NewModel(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [BindProperty]
        public Project Project { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }
       
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                RedirectToPage("AddProject");

            Project.ImagePath = await _projectService.FileUpload(Photo);
            await _projectService.AddProject(Project);
            return RedirectToPage("../Project");
        }
    }
}