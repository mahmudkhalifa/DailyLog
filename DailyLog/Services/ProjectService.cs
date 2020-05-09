using System;
using System.IO;
using System.Threading.Tasks;
using DailyLog.Core;
using Data.DailyLog.DatabaseSpecific;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.FactoryClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace DailyLog.Services
{
    public class ProjectService:IProjectService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProjectService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<EntityCollection<ProjectEntity>> GetProjects()
        {
            var projects = new EntityCollection<ProjectEntity>();
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.Project.OrderBy(ProjectFields.Id.Ascending()); ;

            return await adapter.FetchQueryAsync(q, projects);
        }
        public async Task<ProjectEntity> GetProjectById(int id)
        {
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.Project.Where(ProjectFields.Id==id);
            return await adapter.FetchSingleAsync(q);
        }
        public async Task AddProject(Project project)
        {
            using var adapter = new DataAccessAdapter();
            await adapter.SaveEntityAsync(project.ToEntity(), true);
        }
        public async Task UpdateProject(ProjectEntity project)
        {
            using var adapter = new DataAccessAdapter();
            var qf=new QueryFactory();
            var q= qf.Project.Where(ProjectFields.Id == project.Id);
            var projectEntity =await adapter.FetchSingleAsync(q);
            projectEntity.ImagePath = project.ImagePath;
            projectEntity.Title= project.Title;
            await adapter.SaveEntityAsync(projectEntity);
        }
        public async Task<string> FileUpload(IFormFile photo)
        {
            var uniqueFileName = string.Empty;
            if (photo == null) return uniqueFileName;

            var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
            var filePath = Path.Combine(uploadFolder, uniqueFileName);
            await using var fileStream = new FileStream(filePath, FileMode.Create);
            photo.CopyTo(fileStream);
            return uniqueFileName;
        }

        public void DeleteOldPhoto(ProjectEntity project)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", project.ImagePath);
            File.Delete(filePath);
        }
        public async Task DeleteProjectById(int id)
        {
            using var adapter = new DataAccessAdapter();
            var projectToDelete = new ProjectEntity(id);
            await adapter.DeleteEntityAsync(projectToDelete);
        }

    }
}
