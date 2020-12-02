using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        //Make this a List<Developer> rather than a string
        public string  TeamMember{ get; set; }
        public string Id { get; set; }


        //Should be DevTeam Constructor 
        public Devteam(string teamMember, string id)
        {
            TeamMember = teamMember;
            Id = id;
        }
    }
}
