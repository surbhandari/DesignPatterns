using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myNotePad.Interface;

namespace myNotePad.Behaviours
{
    class SavingOnCloud : ISaving
    {
        public void Saving(string filename, string richTextBox)
        {
            DialogResult dr = MessageBox.Show("We are trying to save " + filename + " on cloud , but today seems very hot :)", "Cloud saving", MessageBoxButtons.OK);
        }
    }
}
