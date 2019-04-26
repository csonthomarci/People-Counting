using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Counter
{
    public partial class Form : System.Windows.Forms.Form
    {
        public const string helyi_fel_char = "8";
        public const string helyi_le_char = "5";
        public const string kulfoldi_fel_char = "w";
        public const string kulfoldi_le_char = "s";
        protected int helyi_fel_c = 0;
        protected int helyi_le_c = 0;
        protected int kulfoldi_fel_c = 0;
        protected int kulfoldi_le_c = 0;

        public Form()
        {
            InitializeComponent();
            this.KeyPress += keyPress;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case helyi_fel_char:
                    helyi_fel_c++;
                    helyi_fel.Text = helyi_fel_c.ToString();
                    break;
                case helyi_le_char:
                    helyi_le_c++;
                    helyi_le.Text = helyi_le_c.ToString();
                    break;
                case kulfoldi_fel_char:
                    kulfoldi_fel_c++;
                    kulfoldi_fel.Text = kulfoldi_fel_c.ToString();
                    break;
                case kulfoldi_le_char:
                    kulfoldi_le_c++;
                    kulfoldi_le.Text = kulfoldi_le_c.ToString();
                    break;

            }
            Console.WriteLine("Key pressed:" + e.KeyChar);
        }

        private void helyi_fel_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helyi_fel_c = helyi_le_c = kulfoldi_fel_c = kulfoldi_le_c = 0;
            helyi_fel.Text = helyi_fel_c.ToString();
            helyi_le.Text = helyi_le_c.ToString();
            kulfoldi_fel.Text = kulfoldi_fel_c.ToString();
            kulfoldi_le.Text = kulfoldi_le_c.ToString();
        }
    }
}
