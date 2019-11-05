using Microsoft.EntityFrameworkCore;
using System;

namespace AirPlaneControl.Repository
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public ApplicationDbContext() { }

    }
}
