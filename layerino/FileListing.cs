using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace layerino
{
    struct Info
    {
        public string path;
        public bool isFile;
    }

    class FileListing
    {
        private Dictionary<string,Info> files;

        public FileListing()
        {
            files = new Dictionary<string, Info>();
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
                files = new Dictionary<string, Info>();
            foreach (FileInfo fi in fileInfos)
            {
                string n = fi.Name.Split('.')[0].ToLowerInvariant();
                Info i = new Info();
                i.path = fi.FullName;
                i.isFile = true;
                if (files.Keys.Contains(n))
                {
                    files[n] = i;
                }
                    
                else
                    files.Add(n, i);
            }
        }

        public List<string> GetFileNames()
        {
            return files.Keys.ToList<string>();
        }

        public void Add(string name, string path, bool isFile)
        {
            string n = name.Split('.')[0].ToLowerInvariant();
            Info i = new Info();
            i.path = path;
            i.isFile = isFile;
            if (files.Keys.Contains(n))
            {
                files[n] = i;
            }
            else
                files.Add(n, i);
        }

        public Info GetFilePath(string name, string def = "")
        {
            string key = name == String.Empty ? def : name.ToLowerInvariant();
            if (files.Keys.Contains(key))
                return files[key];
            else
            {
                Info i = new Info();
                i.path = "";
                i.isFile = true;
                return i;
            }
        }
    }
}
