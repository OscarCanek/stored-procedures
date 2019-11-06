using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace stored_procedures
{
    public class StoredProcedureExecutor : IStoredProcedureExecutor
    {
        public async Task ExecuteStoredProcAsync(DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<IList<T>> ExecuteStoredProcAsync<T>(DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    return this.MapToList<T>(reader);
                }
            }
        }

        public async Task<Tuple<IList<T1>, IList<T2>>> ExecuteStoredProcAsync<T1, T2>(DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    int count = 1;
                    IList<T1> result1 = new List<T1>();
                    IList<T2> result2 = new List<T2>();

                    do
                    {
                        switch (count)
                        {
                            case 1:
                                result1 = this.MapToList<T1>(reader);
                                break;
                            case 2:
                                result2 = this.MapToList<T2>(reader);
                                break;
                        }

                        count++;
                    } while (reader.NextResult());

                    return Tuple.Create(result1, result2);
                }
            }
        }

        public async Task<Tuple<IList<T1>, IList<T2>, IList<T3>>> ExecuteStoredProc<T1, T2, T3>(DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    int count = 1;
                    IList<T1> result1 = new List<T1>();
                    IList<T2> result2 = new List<T2>();
                    IList<T3> result3 = new List<T3>();

                    do
                    {
                        switch (count)
                        {
                            case 1:
                                result1 = this.MapToList<T1>(reader);
                                break;
                            case 2:
                                result2 = this.MapToList<T2>(reader);
                                break;
                            case 3:
                                result3 = this.MapToList<T3>(reader);
                                break;
                        }

                        count++;
                    } while (reader.NextResult());

                    return Tuple.Create(result1, result2, result3);
                }
            }
        }

        public async Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>>> ExecuteStoredProc<T1, T2, T3, T4>(
            DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    int count = 1;
                    IList<T1> result1 = new List<T1>();
                    IList<T2> result2 = new List<T2>();
                    IList<T3> result3 = new List<T3>();
                    IList<T4> result4 = new List<T4>();

                    do
                    {
                        switch (count)
                        {
                            case 1:
                                result1 = this.MapToList<T1>(reader);
                                break;
                            case 2:
                                result2 = this.MapToList<T2>(reader);
                                break;
                            case 3:
                                result3 = this.MapToList<T3>(reader);
                                break;
                            case 4:
                                result4 = this.MapToList<T4>(reader);
                                break;
                        }

                        count++;
                    } while (reader.NextResult());

                    return Tuple.Create(result1, result2, result3, result4);
                }
            }
        }

        public async Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>, IList<T5>>> ExecuteStoredProc<T1, T2, T3,
            T4, T5>(
            DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    int count = 1;
                    IList<T1> result1 = new List<T1>();
                    IList<T2> result2 = new List<T2>();
                    IList<T3> result3 = new List<T3>();
                    IList<T4> result4 = new List<T4>();
                    IList<T5> result5 = new List<T5>();

                    do
                    {
                        switch (count)
                        {
                            case 1:
                                result1 = this.MapToList<T1>(reader);
                                break;
                            case 2:
                                result2 = this.MapToList<T2>(reader);
                                break;
                            case 3:
                                result3 = this.MapToList<T3>(reader);
                                break;
                            case 4:
                                result4 = this.MapToList<T4>(reader);
                                break;
                            case 5:
                                result5 = this.MapToList<T5>(reader);
                                break;
                        }

                        count++;
                    } while (reader.NextResult());

                    return Tuple.Create(result1, result2, result3, result4, result5);
                }
            }
        }

        public async Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>, IList<T5>, IList<T6>>> ExecuteStoredProc<T1,
            T2,
            T3, T4, T5, T6>(DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    int count = 1;
                    IList<T1> result1 = new List<T1>();
                    IList<T2> result2 = new List<T2>();
                    IList<T3> result3 = new List<T3>();
                    IList<T4> result4 = new List<T4>();
                    IList<T5> result5 = new List<T5>();
                    IList<T6> result6 = new List<T6>();

                    do
                    {
                        switch (count)
                        {
                            case 1:
                                result1 = this.MapToList<T1>(reader);
                                break;
                            case 2:
                                result2 = this.MapToList<T2>(reader);
                                break;
                            case 3:
                                result3 = this.MapToList<T3>(reader);
                                break;
                            case 4:
                                result4 = this.MapToList<T4>(reader);
                                break;
                            case 5:
                                result5 = this.MapToList<T5>(reader);
                                break;
                            case 6:
                                result6 = this.MapToList<T6>(reader);
                                break;
                        }

                        count++;
                    } while (reader.NextResult());

                    return Tuple.Create(result1, result2, result3, result4, result5, result6);
                }
            }
        }

        public async Task<Tuple<IList<T1>, IList<T2>, IList<T3>, IList<T4>, IList<T5>, IList<T6>, IList<T7>>>
            ExecuteStoredProc<T1, T2, T3, T4, T5, T6, T7>(DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    int count = 1;
                    IList<T1> result1 = new List<T1>();
                    IList<T2> result2 = new List<T2>();
                    IList<T3> result3 = new List<T3>();
                    IList<T4> result4 = new List<T4>();
                    IList<T5> result5 = new List<T5>();
                    IList<T6> result6 = new List<T6>();
                    IList<T7> result7 = new List<T7>();

                    do
                    {
                        switch (count)
                        {
                            case 1:
                                result1 = this.MapToList<T1>(reader);
                                break;
                            case 2:
                                result2 = this.MapToList<T2>(reader);
                                break;
                            case 3:
                                result3 = this.MapToList<T3>(reader);
                                break;
                            case 4:
                                result4 = this.MapToList<T4>(reader);
                                break;
                            case 5:
                                result5 = this.MapToList<T5>(reader);
                                break;
                            case 6:
                                result6 = this.MapToList<T6>(reader);
                                break;
                            case 7:
                                result7 = this.MapToList<T7>(reader);
                                break;
                        }

                        count++;
                    } while (reader.NextResult());

                    return Tuple.Create(result1, result2, result3, result4, result5, result6, result7);
                }
            }
        }

        public DbCommand LoadStoredProc(DbContext context, string storedProcName)
        {
            var cmd = context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = storedProcName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            var parentTran = context.Database.CurrentTransaction;
            if (parentTran != null)
            {
                cmd.Transaction = parentTran.GetDbTransaction();
            }

            return cmd;
        }

        public DbCommand WithSqlParam(DbCommand cmd, string paramName, object paramValue)
        {
            if (string.IsNullOrEmpty(cmd.CommandText))
            {
                throw new InvalidOperationException("Call LoadStoredProc before using this method");
            }

            var param = cmd.CreateParameter();
            param.ParameterName = paramName;
            param.Value = paramValue;

            if (paramValue == null)
            {
                cmd.Parameters.Add(DBNull.Value);
            }
            else
            {
                cmd.Parameters.Add(param);
            }

            return cmd;
        }

        private IList<T> MapToList<T>(DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();

            if (props == null)
            {
                return objList;
            }

            var colMapping = dr.GetColumnSchema()
                .Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower()))
                .ToDictionary(key => key.ColumnName.ToLower());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        if (colMapping.ContainsKey(prop.Name.ToLower()))
                        {
                            var columnOrdinal = colMapping[prop.Name.ToLower()].ColumnOrdinal;
                            if (columnOrdinal == null) continue;
                            var val = dr.GetValue(columnOrdinal.Value);
                            prop.SetValue(obj, val == DBNull.Value ? null : val);
                        }
                    }

                    objList.Add(obj);
                }
            }

            return objList;
        }
    }
}