

using TM.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM.Persistence.Configurations.Entities
{
    public class TasksConfiguration : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.HasData(
       new CheckList
       {
           Title = "Test",
           Description = "Test",
           StartDate = new DateTime(2022, 1, 1),
           EndDate = new DateTime(2022, 1, 10)
       },

       new CheckList
       {
           Title = "Test 2",
           Description = "Test 2",
           TaskId = 2,
       }
   );
        }


    }
}