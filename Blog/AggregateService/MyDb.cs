using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregateService
{
    public class MyDb : DbContext
    {

        public MyDb(DbContextOptions option) : base(option)
        {

        }
        //public DbSet<Team> Team { get; set; }

        //public void Configure(EntityTypeBuilder<Team> bulider)
        //{

        //}
    }
}
