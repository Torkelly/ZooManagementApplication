/***************************************************************
* Name        : ManageAnimalsForm
* Author      : Tori Kelly
* Created     : 12/12/2019
***************************************************************/
namespace ZooManagement
{
    public class Animal
    {
        private string name;
        private string species;
        private char sex;
        private int location;

        private static int counter = 0;

        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public char Sex { get => sex; set => sex = value; }
        public int Location { get => location; set => location = value; }

        /**************************************************************
         * Constructors
         ***************************************************************/
        /**************************************************************
        * Name: Animal
        * Description: default, no-arg constructor
        * Input parameters: -
        ***************************************************************/
 
        public Animal()
        {
            this.Name = null;
            this.Species = null;
            this.Sex = '_';
            this.Location = 0;
        }

        /**************************************************************
        * Name: Animal
        * Description: creates animal object and generates ID(appended to location)
        * Input parameters: string, string, char, int
        ***************************************************************/

        public Animal(string name, string species, char sex, int location)
        {
            this.Name = name;
            this.Species = species;
            this.Sex = sex;

            // Also serves as an Id, and key for Map.
            // First number indicates location, last 3 create a
            // generated id. Generated dynamically and sequentially
            this.Location = (location * 1000) + counter;

            counter++;
        }
       
        // string method for unsorted list
        public override string ToString()
        {
            return Name + " the " + Species + ", " + Sex + ", Loc-" + Location ;
        }

        //string method for sorted list
        public string ToStringByLocation()
        {
            return "Loc-" + Location + ", " + Name + " the " + Species;
        }
    }
}
