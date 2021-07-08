using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myNotePad.Behaviours
{
    class SavingOnTest
    {
        public void Saving(string filename, string text)
        {
            DialogResult dr = MessageBox.Show("We are saving  locally", "Local saving", MessageBoxButtons.OK);
        }
    }
}
