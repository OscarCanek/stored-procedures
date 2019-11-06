using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace stored_procedures
{
    public interface IStoredProcedureExecutor
    {
        DbCommand LoadStoredProc(DbContext context, string storedProcName);
        DbCommand WithSqlParam(DbCommand cmd, string paramName, object paramValue);
        Task ExecuteStoredProcAsync(DbCommand command);
        Task<IList<T>> ExecuteStoredProcAsync<T>(DbCommand command);
        Task<Tuple<IList<T1>, IList<T2>>> ExecuteStoredProcAsync<T1, T2>(DbCommand command);
        Task<Tuple<IList<T1>, IList<T2>, IList<T3>>> ExecuteStoredProc<T1, T2, T3>(DbCommand command);
        Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>>> ExecuteStoredProc<T1, T2, T3, T4>(DbCommand command);
        Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>, IList<T5>>> ExecuteStoredProc<T1, T2, T3, T4, T5>(DbCommand command);
        Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>, IList<T5>, IList<T6>>> ExecuteStoredProc<T1, T2, T3, T4, T5, T6>(DbCommand command);
        Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>, IList<T5>, IList<T6>, IList<T7>>> ExecuteStoredProc<T1, T2, T3, T4, T5, T6, T7>(DbCommand command);
    }
}