using Microsoft.EntityFrameworkCore;
using MyMvcProject.Areas.Admin.Models;

namespace MyMvcProject.Areas.Admin.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
}