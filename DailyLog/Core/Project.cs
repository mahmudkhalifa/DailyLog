using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DailyLog.EntityClasses;

namespace DailyLog.Core
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }

        public ProjectEntity ToEntity()
        {
            var projectEntity = new ProjectEntity
            {
                Id = Id,
                Title = Title,
                ImagePath = ImagePath
            };
            return projectEntity;
        }
    }
}
