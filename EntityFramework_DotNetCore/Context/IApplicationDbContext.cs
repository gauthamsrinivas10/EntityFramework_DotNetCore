using EntityFramework_DotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_DotNetCore.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}