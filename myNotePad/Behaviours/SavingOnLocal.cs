using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using myNotePad.Interface;

namespace myNotePad.Behaviours
{
    public class SavingOnLocal : ISaving
    {
        public void Saving(string filename, string richTextBox)
        {
            DialogResult dr = MessageBox.Show("We are saving "+ filename + " locally", "Local saving", MessageBoxButtons.OK);
            File.WriteAllText(filename, richTextBox);
        }
    }
}
