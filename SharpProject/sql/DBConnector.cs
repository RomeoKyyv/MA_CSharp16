using System.Data;
using System.Data.Entity;

namespace SharpProject.sql
{
    public class DbConnector : DbContext
    {
        public DbSet<Plane> Planes;
        public DbSet<Passenger> Passengers;
    }
}