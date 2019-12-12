/***************************************************************
* Name        : AddAnimalForm
* Author      : Tori Kelly
* Created     : 12/12/2019
***************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZooManagement
{
    public partial class AddAnimalForm : Form
    {
        //form reference
        public ManageAnimalsForm form1;

        //List Data Structure
        public static List<Animal> animals = new List<Animal>();

        //Hashmap Data Structure for holding location values
        Dictionary<int, string> map = new Dictionary<int, string>();

        //adds locations to combo box
        public void addLocations()
        {
            map.Add(1, "North");
            map.Add(2, "East");
            map.Add(3, "South");
            map.Add(4, "West");

            locationComboBx.DataSource = new BindingSource(map, null);
            locationComboBx.DisplayMember = "Value";
            locationComboBx.ValueMember = "Key";
        }
        
        //initializes the form
        public AddAnimalForm()
        {
            InitializeComponent();
            addLocations();
        }

        // gets user input to create a new animal object
        // also assigns a number based on park location with the combo box
        // location is appended, adding 3 digits on the end to serve as a unique ID
        // adds the new animal object to the list
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtBx.Text;
            string species = speciesTxtBx.Text;
            var comboVal = ((KeyValuePair<int, string>)locationComboBx.SelectedItem).Value;
            int location;

            char sex;

            if (femaleRadio.Checked)
                sex = 'F';
            else if (maleRadio.Checked)
                sex = 'M';
            else sex = '_';

            if (comboVal.Equals("North"))
                location = 1;
            else if (comboVal.Equals("East"))
                location = 2;
            else if (comboVal.Equals("South"))
                location = 3;
            else location = 4;

            Animal a = new Animal(name, species, sex, location);
            animals.Add(a);
        }

        //exits the form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
