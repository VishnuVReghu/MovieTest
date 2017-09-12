using System;

namespace HomeCinema.Entities
{
    public class Movie : IEntityBase
    {
        public Movie()
        {

        }
        public int ID { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
