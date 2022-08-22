using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace ExtractEmbededRessources
{
    public class ExtractEmbededResouces
    {
        //Ref youtube https://youtu.be/_61pLVH2qPk  C# How To Extract an Embedded Resource from an Assembly
        public static  void ExtractEmbededFiles (string nameSpace,
            string outDirectory, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly ();


            using Stream? stream = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName);

            if (stream is not null)
            {
                using BinaryReader reader = new(stream);
                using FileStream fileStream = new(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
                using BinaryWriter writer = new(fileStream);
                writer.Write(reader.ReadBytes((int)stream.Length));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The rescources file where not found.");
            }



        }

        public static void ExtractExternalFiles(
           string outDirectory, string externalFilePath, string resourceName)
        {
                       // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(AssemblyDirectory + "\\" + externalFilePath, resourceName);
            string destFile = System.IO.Path.Combine(outDirectory, resourceName);
            System.IO.File.Copy(sourceFile, destFile, true);


        }
        public static string AssemblyDirectory
        {
            get
            {
                
                string path = Environment.CurrentDirectory;
                return path;
            }
        }
        public static void CreateDirctory(string directoryPath)
        {
            // If directory does not exist, create it
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

        }

    }
}
