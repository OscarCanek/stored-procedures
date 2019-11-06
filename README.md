# stored-procedures
Stored procedure executors for C#

```
var newFav = await _context.LoadStoredProc("sp_with_return_data")
                .WithSqlParam("param_name", paramValue)
                .ExecuteStoredProcAsync<TResult>();
```
```
await _context.LoadStoredProc("sp_without_return_data")
    .WithSqlParam("param_name", paramValue)
    .ExecuteStoredProcAsync();
```
