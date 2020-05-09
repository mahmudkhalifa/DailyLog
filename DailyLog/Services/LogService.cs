using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Data.DailyLog.DatabaseSpecific;
using Data.DailyLog.EntityClasses;
using Data.DailyLog.FactoryClasses;
using Data.DailyLog.HelperClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace DailyLog.Services
{
    public class LogService:ILogService
    {
        public async Task<EntityCollection<LogEntity>> GetCurrentUserLogs(int userId,int currentPage, int pageSize=3)
        {
            var logs = new EntityCollection<LogEntity>();
            using var adapter=new DataAccessAdapter();
            var qf=new QueryFactory();

            return await adapter.FetchQueryAsync(
                qf.Log.Where(LogFields.CreatedByUserId == userId)
                    .From(QueryTarget.InnerJoin(LogEntity.Relations.UserEntityUsingCreatedByUserId))
                    .WithPath(LogEntity.PrefetchPathUser)
                    .OrderBy(LogFields.Id.Descending())
                    .Offset((currentPage - 1) * pageSize)
                    .Limit(pageSize), logs);
        }

        public async Task<int> GetLogsCount(int userId)
        {
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.Create()
                .Select(LogFields.Id)
                .From(qf.Log.Where(LogFields.CreatedByUserId == userId));
            return await adapter.FetchScalarAsync<int>(qf.Create().Select(q.CountRow())); ;
        }

        public async Task<LogEntity> GetLogById(int? id)
        {
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.Log.Where(LogFields.Id == id);
            return await adapter.FetchSingleAsync(q);
        }

        public async Task<EntityCollection<LogEntity>> GetLogs()
        {
            var logs = new EntityCollection<LogEntity>();
            using var adapter = new DataAccessAdapter();
            var qf = new QueryFactory();
            var q = qf.Log.OrderBy(LogFields.Id.Descending());
            return await adapter.FetchQueryAsync(q, logs);
        }

        public async Task AddLog(LogEntity log)
        {
            using var adapter = new DataAccessAdapter();

            if (log.Id != 0)
            {
                var qf=new QueryFactory();
                var q = qf.Log.Where(LogFields.Id == log.Id);
                var logNeedToBeUpdated = await adapter.FetchSingleAsync(q);
                
                logNeedToBeUpdated.DurationInMinutes = log.DurationInMinutes;
                logNeedToBeUpdated.Title = log.Title;
                logNeedToBeUpdated.Details = log.Details;
                logNeedToBeUpdated.ProjectId = log.ProjectId;
                await adapter.SaveEntityAsync(logNeedToBeUpdated);
            }
            else
            {
                log.DateCreatedGmt = DateTime.Now;
                await adapter.SaveEntityAsync(log, true);
            }
        }

        public async Task DeleteLogById(int id)
        {
            using var adapter = new DataAccessAdapter();
            var qf=new QueryFactory();
            var logEntity=await adapter.FetchSingleAsync(qf.Log.Where(LogFields.Id == id));
            logEntity.IsActive = false;
            await adapter.SaveEntityAsync(logEntity);
        }

        public async Task<EntityCollection<LogEntity>> GetAllLogsWithUserAndProjectInfo()
        {
            var logs=new EntityCollection<LogEntity>();
            using var adapter = new DataAccessAdapter();
            var qf=new QueryFactory();
            var q = qf.Log.
                From(QueryTarget.
                    InnerJoin(LogEntity.Relations.ProjectEntityUsingProjectId)
                    .InnerJoin(LogEntity.Relations.UserEntityUsingCreatedByUserId))
                .OrderBy(LogFields.Id.Descending()).WithPath(LogEntity.PrefetchPathProject,LogEntity.PrefetchPathUser);

            return await adapter.FetchQueryAsync(q, logs);
        }
    }
}
