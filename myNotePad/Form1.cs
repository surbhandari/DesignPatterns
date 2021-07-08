using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myNotePad.Interface;
using myNotePad.Behaviours;


namespace myNotePad
{
    public partial class form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        ColorDialog colorDialog = new ColorDialog();
        FontDialog fontDialog = new FontDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        ISaving Saving;

        public ISaving whereToSave;
        private string FileName = string.Empty;

        public form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FileName = string.Empty;
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                this.FileName = openFileDialog.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FileName))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                save(this.FileName);
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Title = "Save As ";
            saveFileDialog.FileName = "Test";
            saveFileDialog.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.FileName = saveFileDialog.FileName;
                save(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Do you want to save the file ? ", "Confirmation", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }


        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            StatusBarChange();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/surbhandari");
        }

        private void aboutMyNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This is a application similar to notepad developed by Surya Bhandari while learning c#. \n Email: bhnsurya200@gmail.com. \n Github : https://github.com/surbhandari ", "About myNotePad", MessageBoxButtons.OK);
        }

        private void todayDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(DateTime.Now.ToString(), "Date and Time", MessageBoxButtons.OK);
            DateTime.Now.ToString();
        }


        //Logic for status bar to show and hide.
        private void StatusBarChange()
        {
            if (statusStrip1.Visible)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }

    
        //To display current date , time and cursor poistion on status bar. 
        private void timer1_Tick(object sender, EventArgs e)
        {
            int statusBarLine = richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine())+1;
            int statusBarColumn = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();

            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            position.Text = string.Format("Line: " + statusBarLine + ", Col: " + statusBarColumn);

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void save(string name)
        {
            File.WriteAllText(name, richTextBox1.Text);
        }

        private void saveOnDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saving = new SavingOnDB();
            saveNotepadText();

        }

        private void saveOnCloudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saving = new SavingOnCloud();
            saveNotepadText();

        }

        private void saveLocallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saving = new SavingOnLocal();
            saveNotepadText();

        }

        private void saveNotepadText()
        {
            Saving.Saving(this.FileName, richTextBox1.Text);
        }

    }
}
