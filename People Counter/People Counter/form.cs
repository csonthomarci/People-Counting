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
        public static string helyi_fel_char = "8";
        public static string helyi_le_char = "5";
        public static string kulfoldi_fel_char = "w";
        public static string kulfoldi_le_char = "s";
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
            if (e.KeyChar.ToString().Equals(helyi_fel_char))
            {
                helyi_fel_c++;
                helyi_fel.Text = helyi_fel_c.ToString();
            }

            if (e.KeyChar.ToString().Equals(helyi_le_char))
            {
                helyi_le_c++;
                helyi_le.Text = helyi_le_c.ToString();
            }

            if (e.KeyChar.ToString().Equals(kulfoldi_fel_char))
            {
                kulfoldi_fel_c++;
                kulfoldi_fel.Text = kulfoldi_fel_c.ToString();
            }

            if (e.KeyChar.ToString().Equals(kulfoldi_le_char))
            {
                kulfoldi_le_c++;
                kulfoldi_le.Text = kulfoldi_le_c.ToString();
            }

            //MessageBox.Show("Key pressed:" + e.KeyChar);
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

        

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form dlg1 = new Popup();
            dlg1.ShowDialog();
            this.KeyPress -= keyPress;
            this.Refresh();
            this.KeyPress += keyPress;
            MessageBox.Show("Elmentetted a következőket:\n  Helyi Fel: <" + helyi_fel_char + ">\n  Helyi le: <" + helyi_le_char + ">\n  Külföldi fel: <" + kulfoldi_fel_char + ">\n  Külföldi le:<" + kulfoldi_le_char+ ">");


        }
    }
}
