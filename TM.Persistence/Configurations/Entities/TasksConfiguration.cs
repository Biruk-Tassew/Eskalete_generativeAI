

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
       new Tasks
       {
           Id = 1,
           Title = "Test",
           OwnerId = "fb8656da-2b94-474f-8709-85e0cd7ea903",
           Description = "Test",
           StartDate = new DateTime(2022, 1, 1),
           EndDate = new DateTime(2022, 1, 10)
       },

       new Tasks
       {
           Id = 2,
           Title = "Test 2",
           OwnerId = "e6c52d57-24b6-4524-be10-eb7bce4d3217",
           Description = "Test 2",
           StartDate = new DateTime(2022, 1, 1),
           EndDate = new DateTime(2022, 1, 10)
       }
   );
        }


    }
}