using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FileTraversals
{
    public class Folder
    {
        public string Name { get; set; }
        public List<File> files { get; set; }
        public List<Folder> childFolders { get; set; }

        public Folder(string name)
        {
            this.Name = name;
            this.files = new List<File>();
            this.childFolders = new List<Folder>();
        }
    }
}
