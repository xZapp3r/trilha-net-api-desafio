dotnet add package Microsoft.EntityFrameworkCore;
dotnet add package Microsoft.EntityFrameworkCore.SqlServer;
dotnet add package Microsoft.EntityFrameworkCore.Design;

dotnet-ef migrations add AddTaskTable;

dotnet-ef database update;