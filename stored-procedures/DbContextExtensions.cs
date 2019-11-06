using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace stored_procedures
{
    public static class DbContextExtensions
    {
        private static readonly IStoredProcedureExecutor SpExecutor = new StoredProcedureExecutor();

        public static async Task ExecuteStoredProcAsync(this DbCommand command)
        {
            await SpExecutor.ExecuteStoredProcAsync(command);
        }

        public static async Task<IList<T>> ExecuteStoredProcAsync<T>(this DbCommand command)
        {
            return await SpExecutor.ExecuteStoredProcAsync<T>(command);
        }

        public static DbCommand LoadStoredProc(this DbContext context, string storedProcName)
        {
            return SpExecutor.LoadStoredProc(context, storedProcName);
        }

        public static DbCommand WithSqlParam(this DbCommand cmd, string paramName, object paramValue)
        {
            return SpExecutor.WithSqlParam(cmd, paramName, paramValue);
        }
    }
}