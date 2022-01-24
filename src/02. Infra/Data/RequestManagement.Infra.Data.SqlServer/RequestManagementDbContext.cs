using Microsoft.EntityFrameworkCore;
using System;

namespace RequestManagement.Infra.Data.SqlServer
{
    public class RequestManagementDbContext : DbContext
    {
        public RequestManagementDbContext(DbContextOptions<RequestManagementDbContext> options) : base(options)
        {
        }
    }
}
