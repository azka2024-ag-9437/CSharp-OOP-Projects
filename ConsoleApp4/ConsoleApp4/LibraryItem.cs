using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementsystem
{
    internal abstract class LibraryItem
    {
        private int id;            // Encapsulation
        private string title;

        public void SetData(int i, string t)
        {
            id = i;
            title = t;
        }

        public int GetId()
        {
            return id;
        }

        public string GetTitle()
        {
            return title;
        }

        public abstract void DisplayInfo();
    }

}