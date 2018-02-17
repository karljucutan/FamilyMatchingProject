using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenealogyVer1.Model
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string father { get; set; }
        public string mother { get; set; }
        public string spouse { get; set; }
        public Person()
        {
            name = "";
            gender = "";
            father = "";
            mother = "";
            spouse = "";
        }
    }
}
