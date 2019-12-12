/***************************************************************
* Name        : ManageAnimalsForm
* Author      : Tori Kelly
* Created     : 12/12/2019
***************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ZooManagement
{
    public partial class ManageAnimalsForm : Form
    {
        // form reference
        private AddAnimalForm form2;

        //gets the existing list from form2
        private readonly List<Animal> animals = AddAnimalForm.animals;

        // initializes form with some pre-made animal objects
        public ManageAnimalsForm()
        {
            InitializeComponent();
            AddAnimals();
            foreach (Animal a in animals)
            {
                animalListBx.Items.Add(a);
            }
        }

        // shows the second fomr to add a new animal object
        private void addBtn_Click(object sender, EventArgs e)
        {
            form2 = new AddAnimalForm();
            form2.Show();
        }

        //exits the main form thus closing the application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // updates the list by clearing the current list and 
        // grabbing the updated animal list from form2
        private void updateBtn_Click(object sender, EventArgs e)
        {
            animalListBx.Items.Clear();
            foreach(Animal a in animals)
            {
                animalListBx.Items.Add(a);
            }
        }

        // deletes an animal object and remoes it from the listbox
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = animalListBx.SelectedIndex;
            animalListBx.Items.RemoveAt(index);
            animals.RemoveAt(index);
        }

        // void function to initialize list with a few animal objects
        public void AddAnimals()
        {
            Animal a = new Animal("Ginger", "Giraffe", 'F', 2); animals.Add(a);
            Animal b = new Animal("Leonard", "Lizard", 'M', 3); animals.Add(b);
            Animal c = new Animal("Harry", "Hippopotomus", 'M', 2); animals.Add(c);
            Animal d = new Animal("Sara", "Snow Leopard", 'F', 1); animals.Add(d);
            Animal e = new Animal("Birtha", "Brown Bear", 'F', 4); animals.Add(e);
            Animal f = new Animal("Maxwell", "Moose", 'M', 1); animals.Add(f);
            Animal g = new Animal("Allan", "Alligator", 'M', 4); animals.Add(g);
            Animal h = new Animal("Tara", "Turtle", 'F', 2); animals.Add(h);
            Animal i = new Animal("Pingu", "Penguin", 'M', 3); animals.Add(i);
        }

        //sorts the animals by location and outputs the sorted list into a message box
        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<Animal> SortedByLocation = animals.OrderBy(o => o.Location).ToList();
            string str = "ANIMALS SORTED BY LOCATION\n\n";

            foreach(Animal a in SortedByLocation)
            {
                str += a.ToStringByLocation() + "\n";
            }
            MessageBox.Show(str);
        }
    }
}
