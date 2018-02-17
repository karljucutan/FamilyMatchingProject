using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenealogyVer1.Model;
using System.IO;

namespace GenealogyVer1.Data
{
    public class FileRepository : IRepository
    {
        List<Person> people;
        string path = "";
        string splitBy = ",";
        public FileRepository()
        {
            people = new List<Person>();
            path = @"\People.txt";
        }
        public List<Person> LoadPeople()
        {
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    people.Add(new Person() { name = data[0], gender = data[1] });
                }
            }
            return people;
        }

        public void Save()
        { }
    }
}
