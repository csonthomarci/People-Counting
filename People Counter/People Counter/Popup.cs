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
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            if (is_correct(helyi_fel_textbox.Text.ToString()))
            {
                helyi_fel_char = helyi_fel_textbox.Text;
                
            }
            if (is_correct(helyi_le_textbox.Text.ToString()))
            {
                helyi_le_char = helyi_le_textbox.Text;
            }
            if (is_correct(kulfoldi_fel_textbox.Text.ToString()))
            {

                kulfoldi_fel_char = kulfoldi_fel_textbox.Text;
            }
            if (is_correct(kulfoldi_le_textbox.Text.ToString()))
            {

                kulfoldi_le_char = kulfoldi_le_textbox.Text;
            }
            this.Dispose();
            
        }
        private bool is_correct(String input)
        {
            List<String> a = new List<String>();
            a.Add(helyi_fel_char);
            a.Add(helyi_le_char);
            a.Add(kulfoldi_fel_char);
            a.Add(kulfoldi_le_char);
            if(input.Length == 1)
            {
                if (a.IndexOf(input) != -1)
                {
                    MessageBox.Show("Ez a billentyű már használatban van, így nem lesz elmentve:" + input);
                    return false;

                }
                return true;
            }
            return false;
        }
    }
}
