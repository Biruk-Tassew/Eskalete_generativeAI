

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
    public class CheckListConfiguration : IEntityTypeConfiguration<CheckList>
    {
        public void Configure(EntityTypeBuilder<CheckList> builder)
        {
            builder.HasData(
                new CheckList
                {
                    Id = 1,
                    Title = "Test",
                     Description = "Test",
                     TaskId = 2,
                },

                 new CheckList
                 {
                    Id = 2,
                     Title = "Test 2",
                     Description = "Test 2",
                     TaskId = 2,
                 }
                ); 
        }


    }
}