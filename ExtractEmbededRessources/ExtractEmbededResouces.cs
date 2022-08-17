using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ExtractEmbededRessources
{
    internal class ExtractEmbededResouces
    {
        public static  void ExtractFiles (string nameSpace,
            string outDirectory,string internalFilePath,string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly ();
            using Stream stream = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName);
            using BinaryReader reader = new(stream);
                    using FileStream fileStream = new(resourceName + "\\" + outDirectory, FileMode.OpenOrCreate);
                        using BinaryWriter writer = new(fileStream);
            writer.Write(reader.ReadBytes((int)stream.Length));
        }

    }
}
