using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace layerino
{
    class FileListing
    {
        private Dictionary<string,string> files;

        public FileListing()
        {
            files = new Dictionary<string, string>();
        }

        public FileListing(string directory)
        {
            ParseDirectory(directory);
        }

        public void ParseDirectory(string directory)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            FileInfo[] fileInfos = dir.GetFiles("*.*");
            if (files == null)
                files = new Dictionary<string, string>();
            foreach (FileInfo fi in fileInfos)
            {
                string n = fi.Name.Split('.')[0].ToLowerInvariant();
                if (files.Keys.Contains(n))
                    files[n] = fi.FullName;
                else
                    files.Add(n, fi.FullName);
            }
        }

        public List<string> GetFileNames()
        {
            return files.Keys.ToList<string>();
        }


        public string GetFilePath(string name, string def = "")
        {
            string key = name == String.Empty ? def : name.ToLowerInvariant();
            if (files.Keys.Contains(key))
                return files[key];
            else
                return "";
        }
    }
}
