using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenealogyVer1.Model;

namespace GenealogyVer1.Data
{
    public interface IRepository
    {
        List<Person> LoadPeople();
        void Save();
    }
}
