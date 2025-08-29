using EF_Home_Work_Three.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Home_Work_Three.Context
{
    internal class EducationDataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WINDOWS_11_ONUR\\MSSQLSERVER01;Initial Catalog=EducationDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        DbSet<Authors> Authors { get; set; }
        DbSet<Books> Books { get; set; }
        DbSet<Categories> Categories { get; set; }
        DbSet<Departments> Departments { get; set; }
        DbSet<Faculties> Faculties { get; set; }
        DbSet<Groups> Groups { get; set; }
        DbSet<Libs> Libs { get; set; }
        DbSet<Press> Press { get; set; }
        DbSet<S_Cards> S_Cards { get; set; }
        DbSet<Students> Students { get; set; }
        DbSet<T_Cards> T_Cards { get; set; }
        DbSet<Teachers> Teachers { get; set; }
        DbSet<Themes> Themes { get; set; }
    }
}
