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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            form.saveToolStripMenuItem_Click(sender,e);
            MessageBox.Show("Вы сохранили файл");
            Application.Exit();


        }
    }
}
