using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DAL.Entities.Enums;
using Travel.DAL.Entities.Models;

namespace Travel.DAL.Entities.Models
{
	public class GroupMembership
	{
        public int UserId { get;private set; }
        public User User { get; private set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
        public GroupRole GroupRole { get;private set; }
        public DateTime JoinDate { get; set; }
    }
}


