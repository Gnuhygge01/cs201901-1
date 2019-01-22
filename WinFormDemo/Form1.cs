using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Indkapsling.Person p = new Indkapsling.Person {
                Navn = "a",
                Fødselsdag = DateTime.Now,
                ErILive2 =true,
                Løn = 30000.24
            };
            propertyGrid1.SelectedObject = p;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Indkapsling.Person p = (Indkapsling.Person)propertyGrid1.SelectedObject;
        }
    }
}
