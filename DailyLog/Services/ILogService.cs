using System.Threading.Tasks;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.HelperClasses;

namespace DailyLog.Services
{
    public interface ILogService
    {
        Task<EntityCollection<LogEntity>> GetCurrentUserLogs(int userId, int currentPage, int pageSize = 3);
        Task<int> GetLogsCount(int userId);
        Task<LogEntity> GetLogById(int? id);
        Task<EntityCollection<LogEntity>> GetLogs();
        Task AddLog(LogEntity log);
        Task DeleteLogById(int id);
        Task<EntityCollection<LogEntity>> GetAllLogsWithUserAndProjectInfo();
    }
}
