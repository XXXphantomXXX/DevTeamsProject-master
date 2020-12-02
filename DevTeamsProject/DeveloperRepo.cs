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
        //Void methods can't return either make a bool or remove the returns.
        public UpdateDeveloper(string orginalID, Developer newID)
        {
            //find the id
            Developer oldID = GetDeveloperById(orginalID);

            //update the id
            if(oldID != null)
            {
                oldID.Name = newID.Name;
                oldID.Id = newID.Id;
                oldID.HasPluralSight = newID.HasPluralSight;

                return true;
            }
            else
            {
                return false;
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
            //trying to return a field rather than an integer check streaming content update method and compare what might be missing after the _develeoperDirectory field
            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(information);

            if(initialCount > _developerDirectory.Count)
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
