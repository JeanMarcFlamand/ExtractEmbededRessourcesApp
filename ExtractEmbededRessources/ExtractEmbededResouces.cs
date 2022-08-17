using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ExtractEmbededRessources
{
    public class ExtractEmbededResouces
    {
        public static  void ExtractFiles (string nameSpace,
            string outFile,string internalFilePath,string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly ();
            using Stream? stream = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName);
            
            if (stream is not null)
            {
                using BinaryReader reader = new(stream);
                using FileStream fileStream = new(outFile + "\\" + resourceName, FileMode.OpenOrCreate);
                using BinaryWriter writer = new(fileStream);
                writer.Write(reader.ReadBytes((int)stream.Length));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The rescources file where not found.");
            }
            
                        
        }

    }
}
