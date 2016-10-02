using System;
using System.Windows.Forms;

namespace OfficeArrangement.Sandbox
{
    public static class FormHelpers
    {
        /// <summary>
        /// Checks the item under the given index and unchecks the remaining
        /// </summary>
        /// <param name="items">ToolStripMenuItem objects</param>
        /// <param name="index">Element's index to toggle its checked state</param>
        public static void CheckMenuItem(ToolStripMenuItem[] items, int index)
        {
            if (index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }

            // Check or uncheck every item depending on the given index
            for (int i = 0; i < items.Length; i++)
            {
                items[i].Checked = i == index;
            }
        }
    }
}
