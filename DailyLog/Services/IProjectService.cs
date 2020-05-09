using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyLog.Core;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;
using Microsoft.AspNetCore.Http;

namespace DailyLog.Services
{
    public interface IProjectService
    {
        Task<ProjectEntity> GetProjectById(int id);
        Task<EntityCollection<ProjectEntity>> GetProjects();
        Task AddProject(Project project);
        Task UpdateProject(ProjectEntity project);
        Task<string> FileUpload(IFormFile photo);
        Task DeleteProjectById(int id);
        void DeleteOldPhoto(ProjectEntity project);
    }
}
