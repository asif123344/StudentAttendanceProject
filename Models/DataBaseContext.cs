using Microsoft.EntityFrameworkCore;

namespace StudentAttendanceProject.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }
        public DbSet<AttendanceModel> Attendances { get; set; }
    }
}
