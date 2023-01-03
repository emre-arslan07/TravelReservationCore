using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationDal.Concrete
{
   public class TravelReservationDbContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server = ASUS-PC\MSSQLSERVER01; Database = TravelReservationDb; uid = admin; pwd = 123456789;");
        }

        public DbSet<About> About { get; set; }
        public DbSet<About2> About2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
    }
}
