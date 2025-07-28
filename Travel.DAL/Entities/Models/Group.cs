using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DAL.Entities.Enums;
namespace Travel.DAL.Entities.Models
{
	public class Group
	{
        public Group( string description, GroupPrivacy privacy, string? createdBy)
        {          
            Description = description;
            Privacy = privacy;
            CreatedBy = createdBy;
            CreatedOn = DateTime.Now;
        }

        public int Id { get;private set; }
        public string Description { get; private set; }
        public GroupPrivacy Privacy { get;private set; }
        public string? CreatedBy { get; private set; }
        public DateTime? CreatedOn { get; private set; }
        public string? ModfiedBy { get; private set; }
        public DateTime? ModfiedOn { get; private set; }
        public DateTime? DeletedOn { get; private set; }

        public bool IsDeleted { get; private set; }
        public List<GroupMembership> GroupMemberships { get; set; }
        public ICollection<Event> Events { get; set; }
        public void SoftDelete()
        {
            IsDeleted = true;
            DeletedOn = DateTime.Now;
        }
    }
}
