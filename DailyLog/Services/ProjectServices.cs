    using System;
    using System.IO;
    using DailyLog.Core;
    using Data.DailyLog.DatabaseSpecific;
    using Data.DailyLog.EntityClasses;
    using Data.DailyLog.FactoryClasses;
    using Data.DailyLog.HelperClasses;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Hosting;
    using SD.LLBLGen.Pro.QuerySpec;
    using SD.LLBLGen.Pro.QuerySpec.Adapter;

    namespace DailyLog.Services
{
    public class ProjectServices
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProjectServices(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public static EntityCollection<ProjectEntity> GetProjects()
        {
            var projects = new EntityCollection<ProjectEntity>();
            using var adapter = new DataAccessAdapter("Server=127.0.0.1;Database=DailyLog;Port=5432;User Id=postgres;Password=MC@khalifa017945965;");
            var qf = new QueryFactory();
            var q = qf.Project;

            return adapter.FetchQuery(q, projects);
        }

        public static ProjectEntity GetProjectById(int id)
        {
            using var adapter = new DataAccessAdapter("Server=127.0.0.1;Database=DailyLog;Port=5432;User Id=postgres;Password=MC@khalifa017945965;");
            var qf = new QueryFactory();
            var q = qf.Project.Where(ProjectFields.Id==id);
            return adapter.FetchSingle(q);
        }

        public static void AddProject(Project project)
        {
            using var adapter = new DataAccessAdapter("Server=127.0.0.1;Database=DailyLog;Port=5432;User Id=postgres;Password=MC@khalifa017945965;");
            adapter.SaveEntity(project.ToEntity(), true);
        }

        
    }
}
