using System;
using System.ComponentModel.DataAnnotations;
using Data.DailyLog.EntityClasses;

namespace DailyLog.Core
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime TodayDate { get; set; } = DateTime.Now;
        [Required] 
        public int DurationInMinutes { get; set; } 
        [Required,StringLength(14)]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        public bool IsActive { get; set; } = true;
        public int CreatedByUserId { get; set; }
        public int? ProjectId { get; set; }
        public LogEntity ToEntity()
        {
            var logEntity = new LogEntity
            {
                Id = Id,
                DateCreatedGmt = TodayDate,
                DurationInMinutes = DurationInMinutes,
                Title = Title,
                Details = Details,
                IsActive = IsActive,
                CreatedByUserId = CreatedByUserId,
                ProjectId = ProjectId
            };
            return logEntity;
        }
    }
}
