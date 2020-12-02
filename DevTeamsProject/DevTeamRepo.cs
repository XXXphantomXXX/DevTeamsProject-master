using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {

        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public void AddTeam(DevTeam information)
        {
            _devTeams.Add(information);
        }

        //DevTeam Read
        public List<DevTeam> GetTeam()
        {
            return _devTeams;
        }

        //DevTeam Update
        public void UpdateTeam(string orginalID, DevTeam newID)
        {
            //find the id
            DevTeam oldID = GetTeamById(orginalID);

            //update the id
            if (oldID != null)
            {
                oldID.TeamMember = newID.TeamMember;
                oldID.Id = newID.Id;

                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Delete
        public bool RemoveTeam(string id)
        {
            DevTeam information = GetTeamById(id);

            if (information == null)
            {
                return false;
            }

            int initialCount = _devTeams;
            _devTeam.Remove(information);

            if (initialCount > _devTeams)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Helper (Get Team by ID)
        private DevTeam GetTeamById(string id)
        {
            foreach (DevTeam information in _devTeams)
            {
                if (information.Id == id)
                {
                    return information;
                }
            }

            return null;

        }
    }
}
