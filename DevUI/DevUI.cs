using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    class DevUI
    {

        //Need instances of DevTeamRepo and Developer Repo. Remove the Developer field
        private Developer _IDRepo = new Developer();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool KeepRunning = true;
            while (KeepRunning)
            {


                //Menu Options
                Console.WriteLine("Select a menu options:\n" +
                    "1. create New Developer\n" +
                    "2. Update developer\n" +
                    "3. Delete developer\n" +
                    "4. All developers\n" +
                    "5. See developers with pluralsight\n" +
                    "6. Create team\n" +
                    "7. Show teams\n" +
                    "8. update Team\n" +
                    "9. Delete Team\n " +
                    "10. Exit");

                //Input
                string input = Console.ReadLine();

                //Evaluate
                switch (input)
                {
                    case "1":
                        CreateNewDev();
                        break;

                    case "2":
                        UpdateDev();
                        break;

                    case "3":
                        DeleteDev();
                        break;

                    case "4":
                        ShowDev();
                        break;

                    case "5":
                        HasPluralsight();
                        break;

                    case "6":
                        CreateNewTeam();
                        break;

                    case "7":
                        ShowTeam();
                        break;

                    case "8":
                        UpdateTeam();
                        break;

                    case "9":
                        DeleteTeam();
                        break;
                    case "10":
                        KeepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Stop playing with me and enter a right number!");
                        break;

                }
                Console.WriteLine("please press a key...");
                Console.ReadKey();
                Console.Clear();

            }   
        }

        private void CreateNewDev()
        {

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter ID");
         
            int devId = int.Parse(Console.ReadLine());
            Console.WriteLine("does dev have pluralsight? (y/n)");
            //make has pluralsight a boolean and parse it like we did with the integer above
            string pluralAnswer = Console.ReadLine();
            bool hasPluralSight;
            if(pluralAnswer == "y")
            {
                hasPluralSight = true;
               //add to list of pluralsight
            }
            else
            {
                hasPluralSight = false;
                //add to other list without pluralsight 
            }
            Developer newID = new Developer(name, devId, hasPluralSight);
            //call Developerrepo field rather than developer field.
            _IDRepo.adddeveloper(newID);

            //Call developer repo field, call create method inside developer repo, pass newID as the parameter in the create method.
        }

        private void ShowDev()
        {
            //Call devRepo field call get all method. 
            List<Developer> listOfDevelopers = _developerDirectory.GetDevelopers();
        }

        private void UpdateDev()
        {

        }

        private void DeleteDev()
        {

        }

        private void CreateNewTeam()
        {

        }

        private void ShowTeam()
        {

        }

        private void UpdateTeam()
        {

        }

        private void DeleteTeam()
        {

        }

        private void HasPluralsight()
        {

        }

    }
}
