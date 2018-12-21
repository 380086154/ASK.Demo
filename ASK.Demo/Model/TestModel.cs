using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Demo.Model
{
    public class TestModel
    {
        public string createId { get; set; }
        public List<Person> persons = new List<Person>();
    }
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
