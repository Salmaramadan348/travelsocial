using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DAL.Entities.Models
{
	public class Event
	{
        public Event( string city, string country, string name, DateOnly date, string? createdBy=null)
        {         
            City = city;
            Country = country;
            Name = name;
            Date = date;
            CreatedBy = createdBy;
            CreatedOn = DateTime.Now;
        }

        public int Id { get;private set; }
        public string City { get;private set; }
        public string Country { get; private set; }
        public string Name { get; private set; }
        public DateOnly Date { get; private set; }
        public string? CreatedBy { get; private set; }
        public DateTime? CreatedOn { get; private set; }
        public string? ModfiedBy { get; private set; }
        public DateTime? ModfiedOn { get; private set; }
        public DateTime? DeletedOn { get; private set; }

        public bool IsDeleted { get; private set; }
        public int GroupId { get; private set; }
        public Group Group { get; private set; }
        public void SoftDelete()
        {
            IsDeleted = true;
            DeletedOn = DateTime.Now;
        }
    }
}
