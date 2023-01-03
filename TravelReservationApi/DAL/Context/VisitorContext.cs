using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationApi.Entities;

namespace TravelReservationApi.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server = ASUS-PC\MSSQLSERVER01; initial catalog = TravelReservationApiDb;integrated security=true;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
