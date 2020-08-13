using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VixDigital.Models;

namespace VixDigital.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceResponse> ServiceResponse { get; set; }
    }
}
