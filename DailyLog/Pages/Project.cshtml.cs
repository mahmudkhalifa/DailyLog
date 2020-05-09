using System.Threading.Tasks;
using DailyLog.Services;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyLog
{
    public class ProjectModel : PageModel
    {
        private readonly IProjectService _projectService;
        public ProjectModel(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public EntityCollection<ProjectEntity> ProjectEntities { get; set; }
        public async Task OnGet()
        {
            ProjectEntities = await _projectService.GetProjects();
        }
        public async Task<ActionResult> OnGetDeleteProject(int id)
        {
             await _projectService.DeleteProjectById(id);
            return RedirectToPage("Project");
        }

    }
}