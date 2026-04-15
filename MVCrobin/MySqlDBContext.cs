using Microsoft.EntityFrameworkCore;
using MVCrobin.Models;

namespace MVCrobin.Data;

public class MySqlDBContext : DbContext
{
    public MySqlDBContext(DbContextOptions<MySqlDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<Usuario> users { get; set; }  
}