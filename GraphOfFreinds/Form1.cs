using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GraphOfFreinds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void bAddUserByID_Click(object sender, EventArgs e)
        {
            Thread threadWhoAskVK = new Thread(()
                => {
                    Global.graph.addNewPersonWithThimFreinds(textBoxIdNewPeople.Text);
                });

            threadWhoAskVK.Start();
            label1.Text = "fsdfsd";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //label1.Text = Convert.ToString(Global.graph._allPersonInGraph.Count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Кол-во человек в базе = " + Convert.ToString(Global.graph._allPersonInGraph.Count);
        }
    
    }
}
