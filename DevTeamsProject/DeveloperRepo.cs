using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void Adddeveloper(Developer information)
        {
            _developerDirectory.Add(information); 
        }
        
        //Developer Read
        public List<Developer> GetDevelopers()
        {
            return _developerDirectory;
        }

        //Developer Update
        public void UpdateDeveloper(string orginalID, Developer newID)
        {
            //find the id
            Developer oldID = GetDeveloperById(orginalID);

            //update the id
            if(oldID != null)
            {
                oldID.Name = newID.Name;
                oldID.Id = newID.Id;
                oldID.HasPluralSight = newID.HasPluralSight;

            }
        }
        //Developer Delete
        public bool RemoveInformation(string id)
        {
            Developer information = GetDeveloperById(id);

            if (information == null)
            {
                return false;
            }

            int initialCount = _developerDirectory;
            _developerDirectory.Remove(information);

            if(initialCount > _developerDirectory)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Helper (Get Developer by ID)
        private  Developer GetDeveloperById(string id)
        {
            foreach (Developer information in _developerDirectory)
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
