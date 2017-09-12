using HomeCinema.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Data.Configurations
{
    public class MovieConfiguration : EntityBaseConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(m => m.Title).IsRequired().HasMaxLength(50);
            Property(m => m.Description).IsRequired().HasMaxLength(100);
            Property(m => m.UserId).IsRequired();
            Property(m => m.State).IsRequired().HasMaxLength(2000);
            Property(m => m.CreatedDate).IsRequired();
            Property(m => m.ModifiedDate).IsRequired();
        }
    }
}
