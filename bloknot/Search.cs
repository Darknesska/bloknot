using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bloknot
{
    public partial class Search : Form
    {
        private Form1 form1;
        public Search()
        {
            InitializeComponent();
            
        }

        private void Search_Load(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
                
        }
    }
}
