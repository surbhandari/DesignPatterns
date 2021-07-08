using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myNotePad.Interface;

namespace myNotePad.Behaviours
{
    class SavingOnDB : ISaving
    {
        public void Saving(string filename, string richTextBox)
        {

            //TODO: After DB setup, login should be done before inserting file to db.

            DialogResult dr = MessageBox.Show("We are saving " + filename + " on Database ", "Database saving", MessageBoxButtons.OK);
        }
    }
}
