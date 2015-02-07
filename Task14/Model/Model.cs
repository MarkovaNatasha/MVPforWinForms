using System.Collections.Generic;
using System.IO;

namespace Task14.Model
{
    class Model
    {
        public List<FileInfo> FirstFilesFolder { get; set; }
        public List<FileInfo> SecondFilesFolder { get; set; }
        public string FirstPathFolder { get; set; }
        public string SecondPathFolder { get; set; }

        public Model()
        {
            FirstFilesFolder = new List<FileInfo>();
            SecondFilesFolder = new List<FileInfo>();
            FirstPathFolder = string.Empty;
            SecondPathFolder = string.Empty;
        }
    }
}
