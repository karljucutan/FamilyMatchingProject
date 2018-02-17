using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenealogyVer1.Model;

namespace GenealogyVer1.Controller
{
    public class PersonController
    {
        public static List<Person> ListofPerson = new List<Person>();
        private Person searchedPerson;

        public bool CreatePerson(string name, string gender)
        {
            bool exist = false;
            var pe = ListofPerson.Where(p => p.name.Equals(name)).SingleOrDefault();
            if (pe is Person)
            {
                exist = true;
            }
            else
            {
                Person person = new Person()
                { name = name, gender = gender};
                ListofPerson.Add(person);
            }
            return exist;
        }

        public List<Person> RetrieveListOfPerson()
        {
            return ListofPerson;
        }
        public Person SearchPerson(string name)
        {
             searchedPerson = ListofPerson.Where(p => p.name.Equals(name)).SingleOrDefault();
            return searchedPerson;
        }
        public void UpdatePerson(string name, string gender, string father, string mother, string spouse)
        {
            var findFather = ListofPerson.Where(p => p.name.Equals(father)).SingleOrDefault();
            var findMother = ListofPerson.Where(p => p.name.Equals(mother)).SingleOrDefault();
            var findSpouse = ListofPerson.Where(p => p.name.Equals(spouse)).SingleOrDefault();
            int index = ListofPerson.FindIndex(p => p.name.Equals(searchedPerson.name));

            if (findFather is Person)
            {
                if (index >= 0)
                {
                    ListofPerson[index].father = findFather.name;
                }
            }
            else
            {
                ListofPerson[index].father = null;
            }

            if (findMother is Person)
            {
                if(index >= 0)
                {
                    ListofPerson[index].mother = findMother.name;
                }
            }
            else
            {
                ListofPerson[index].mother = null;
            }

            if (findSpouse is Person)
            {
                if(index >= 0)
                {
                    ListofPerson[index].spouse = findSpouse.spouse;
                }
            }
            else
            {
                ListofPerson[index].spouse = null;
            }

            //if (findFather is Person && findMother is Person)
            //{
                
            //    if (index >= 0)
            //    {
            //        ListofPerson[index].name = name;
            //        ListofPerson[index].gender = gender;
            //        ListofPerson[index].father = gender;
            //        ListofPerson[index].mother = findMother.name;
            //        ListofPerson[index].spouse = findSpouse.name;
            //        updated = true;
            //    }
            //}
        
        }

        public bool DetelePerson(string person)
        {
            bool deleted = false;
            int index = ListofPerson.FindIndex(p => p.name.Equals(person));
            if (index >= 0)
            {
                ListofPerson.RemoveAt(index);
                deleted = true;
            } 
            return deleted;
        }
    }

    
}
