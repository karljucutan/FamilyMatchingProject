using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenealogyVer1.Controller;
using GenealogyVer1.Model;

namespace GenealogyVer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string firstPerson = "Kealu Rullamas", secondPerson = "Khirvey Rullamas"; // change to name inputted from the textbox
                                                                                      //Khirvey Rullamas
            GenealogyController gn = new GenealogyController();
            gn.KealuFamily();                                                                          //Patoy Jr.

            PersonController pc = new PersonController();
            var listOfPerson = pc.RetrieveListOfPerson();
            foreach (Person p in listOfPerson)
            {
                comboBox_Person1.Items.Add(p.name);
                comboBox_Person2.Items.Add(p.name);
            }

      
            var listlevelandperson = gn.ReturnCommonLevelAndPerson(gn.SupplyFamilyTree(firstPerson), gn.SupplyFamilyTree(secondPerson));
            if (listlevelandperson[0].Key > listlevelandperson[1].Key) //level[0] is first person level[1] is second person
            {
             //   Console.WriteLine(listlevelandperson[1].Value.name + "'s " + gn.INDIRECTFAMILYRELATIONFEMALE[ listlevelandperson[0].Key , listlevelandperson[1].Key ] + " is " + listlevelandperson[0].Value.name);
            }
            else
            {
                //  Console.WriteLine(firstPerson + "'s " + gn.INDIRECTFAMILYRELATIONFEMALE[level[0], level[1]] + " is " + secondPerson);
               // Console.WriteLine(listlevelandperson[0].Value.name + "'s " + gn.INDIRECTFAMILYRELATIONFEMALE[listlevelandperson[0].Key, listlevelandperson[1].Key] + " is " + listlevelandperson[1].Value.name);
            }
           
            
            
        }

        private void button_Match_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n\nNew List");
            foreach(Person p in PersonController.ListofPerson)
            {
                Console.WriteLine(p.name);
            }
            
        }
    }
}
