using ASK.Demo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASK.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = new TestModel
            {
                createId = "12321",
                persons = new List<Person> {
                    new Person { Name = "Jim", Age = "18" },
                    new Person { Name = "tim", Age = "20" }
                }
            };

            var s = JsonConvert.SerializeObject(test);
            Console.WriteLine(s);

            var model = JsonConvert.DeserializeObject<TestModel>(s);
        }
    }
}
