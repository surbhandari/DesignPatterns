using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myNotePad.Interface
{

    public interface ISaving
    {
        /// <summary>
        /// This is test summary.
        /// </summary>
        /// <param name="filename">This is filename</param>
        /// <param name="richTextBox"></param>
        void Saving(string filename, string richTextBox);
    }
}
