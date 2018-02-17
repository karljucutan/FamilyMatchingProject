using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenealogyVer1;
using GenealogyVer1.Model;
using GenealogyVer1.Controller;


namespace Admin
{
    
    public partial class CRUD : Form
    {
        GenealogyController gn;
        PersonController pn;
        public CRUD()
        {
            InitializeComponent();
            gn = new GenealogyController();
            pn = new PersonController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            gn.KealuFamily();
            
            var list = PersonController.ListofPerson.Select(p => p.name).ToList();
            UpdateComboboxItems();

           
        }

        private void button_AddPerson_Click(object sender, EventArgs e)
        {
            if (textBox_Add_Name.Text != "")
            {
                var name = textBox_Add_Name.Text;
                var gender = "";
                if (radioButton_Add_Male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                //var father = textBox_Add_FatherName.Text;
                //var mother = textBox_Add_MotherName.Text;
                //var spouse = textBox_Add_SpouseName.Text;
                //pn.CreatePerson(father, "Male", null, null, mother);    // father
                //pn.CreatePerson(mother, "Female", null, null, father);  // mother         
                if (pn.CreatePerson(name, gender))
                {
                    MessageBox.Show("Person already exist!", "Add Person", MessageBoxButtons.OK);
                }
                else
                {

                    MessageBox.Show("Successfully Added!");
                    textBox_Add_Name.Text = "";
                    radioButton_Add_Male.Checked = false;
                    radioButton_Add_Female.Checked = false;
                    //textBox_Add_FatherName.Text = "";
                    //textBox_Add_MotherName.Text = "";
                    //textBox_Add_SpouseName.Text = "";
                    ClearComboboxItems();
                    UpdateComboboxItems();
                }
            }
           
        }


        private void button_Update_Click(object sender, EventArgs e)
        {
            var gender = "";
            if (radioButton_Update_Male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
                pn.UpdatePerson(comboBox_Update_Name.Text, gender, comboBox_Update_FatherName.Text, comboBox_Update_MotherName.Text, comboBox_Update_SpouseName.Text);
            
                comboBox_Update_Name.Text = "";
                radioButton_Update_Male.Checked = false;
                radioButton_Update_Female.Checked = false;
                comboBox_Update_FatherName.Text = "";
                comboBox_Update_MotherName.Text = "";
                comboBox_Update_SpouseName.Text = "";
                EnableDisableUpdateComponents(false);
                MessageBox.Show("Update Successful.", "Update Person", MessageBoxButtons.OK);
            
            
            ClearComboboxItems();
            UpdateComboboxItems();

        }

        private void EnableDisableUpdateComponents(bool enabled)
        {
            comboBox_Update_FatherName.Enabled = enabled;
            comboBox_Update_MotherName.Enabled = enabled;
            comboBox_Update_SpouseName.Enabled = enabled;
            radioButton_Update_Male.Enabled = enabled;
            radioButton_Update_Female.Enabled = enabled;
            button_Update.Enabled = enabled;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if(pn.DetelePerson(comboBox_Delete_Name.Text))
            {
                MessageBox.Show("Successfully deleted.", "Delete Person", MessageBoxButtons.OK);
                button_Delete.Enabled = false;
                comboBox_Delete_Name.Text = "";
                ClearComboboxItems();
                UpdateComboboxItems();
                foreach(Person p in PersonController.ListofPerson)
                {
                    Console.WriteLine(p.name);
                }
            }

        }

        private void comboBox_Update_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            var person = pn.SearchPerson(comboBox_Update_Name.Text);
            if (person is Person)
            {
                comboBox_Update_FatherName.Text = person.father;
                comboBox_Update_MotherName.Text = person.mother;
                comboBox_Update_SpouseName.Text = person.spouse;
                if (person.gender.Equals("Male"))
                {
                    radioButton_Update_Male.Checked = true;
                }
                else
                {
                    radioButton_Update_Female.Checked = true;
                }

                EnableDisableUpdateComponents(true);
            }
            else
            {
                MessageBox.Show("Person not found.", "Search Person", MessageBoxButtons.OK);
            }
        }

        private void comboBox_Delete_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Delete.Enabled = true;
        }

        private void UpdateComboboxItems()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (Person p in PersonController.ListofPerson)
            {
                data.Add(p.name);
                comboBox_Delete_Name.Items.Add(p.name);
                comboBox_Update_Name.Items.Add(p.name);
                comboBox_Update_FatherName.Items.Add(p.name);
                comboBox_Update_MotherName.Items.Add(p.name);
                comboBox_Update_SpouseName.Items.Add(p.name);

                //for matchtab na previously nasa other project
                comboBox_Person1.Items.Add(p.name);
                comboBox_Person2.Items.Add(p.name);

            }
            comboBox_Delete_Name.AutoCompleteCustomSource = data;
            comboBox_Update_Name.AutoCompleteCustomSource = data;
            comboBox_Update_FatherName.AutoCompleteCustomSource = data;
            comboBox_Update_MotherName.AutoCompleteCustomSource = data;
            comboBox_Update_SpouseName.AutoCompleteCustomSource = data;

            //for matchtab na previously nasa other project
            comboBox_Person1.AutoCompleteCustomSource = data;
            comboBox_Person2.AutoCompleteCustomSource = data;
        }
        private void ClearComboboxItems()
        {
            comboBox_Delete_Name.Items.Clear();
            comboBox_Delete_Name.AutoCompleteCustomSource = null;
            comboBox_Update_Name.Items.Clear();
            comboBox_Update_Name.AutoCompleteCustomSource = null;
            comboBox_Update_FatherName.Items.Clear();
            comboBox_Update_FatherName.AutoCompleteCustomSource = null;
            comboBox_Update_MotherName.Items.Clear();
            comboBox_Update_MotherName.AutoCompleteCustomSource = null;
            comboBox_Update_SpouseName.Items.Clear();
            comboBox_Update_SpouseName.AutoCompleteCustomSource = null;

            //for matchtab na previously nasa other project
            comboBox_Person1.Items.Clear();
            comboBox_Person1.AutoCompleteCustomSource = null;
            comboBox_Person2.Items.Clear();
            comboBox_Person2.AutoCompleteCustomSource = null;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            foreach (Person p in PersonController.ListofPerson)
            {
                Console.WriteLine("NON ADMIN" + p.name);
            }
        }

        private void button_Match_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("\n\nNew List");
            //foreach (Person p in PersonController.ListofPerson)
            //{
            //    Console.WriteLine(p.name);
            //}

            if (comboBox_Person1.Text != "" && comboBox_Person2.Text != "")
            {
                //formload for match tab
                string firstPerson = comboBox_Person1.Text, secondPerson = comboBox_Person2.Text;
                var tree1 = gn.SupplyFamilyTree(firstPerson);
                var tree2 = gn.SupplyFamilyTree(secondPerson);
                var listlevelperson = gn.ReturnCommonLevelAndPerson(tree1, tree2);
                var relationarrayLeftToRight = gn.GetRelationship(tree2[0][0].gender, listlevelperson[0].Key, listlevelperson[1].Key, listlevelperson[1].Value.name); // left person to right person relationship
                var relationarrayRightToLeft = gn.GetRelationship(tree1[0][0].gender, listlevelperson[1].Key, listlevelperson[0].Key, listlevelperson[1].Value.name); // right person to left person relationship
                                                                                                                                                                      //Console.WriteLine(tree1[0][0].name + "'s " + relationarrayLeftToRight + " is " + tree2[0][0].name);
                                                                                                                                                                      //Console.WriteLine(tree2[0][0].name + "'s " + relationarrayRightToLeft + " is " + tree1[0][0].name);
                label_FirstToSecondRelationship.Text = /*tree1[0][0].name + "'s " +*/ relationarrayLeftToRight /*+ " is " + tree2[0][0].name*/;
                label_SecondToFirstRelationship.Text = /*tree2[0][0].name + "'s " +*/ relationarrayRightToLeft /*+ " is " + tree1[0][0].name*/;
            }
        }

      
    }
}
