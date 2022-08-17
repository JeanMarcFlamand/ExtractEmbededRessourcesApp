
// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Press Enter to Extract Sample files.");
Console.ReadLine();
ExtractFiles("ExtractEmbededRessources", "c:\\temp2", "EmbededRes", "RichText.rtf");
ExtractFiles("ExtractEmbededRessources", "c:\\temp2", "EmbededRes", "auguste.PNG");



//ExtractFiles1("ExtractEmbededRessources", "c:\\temp2", "EmbededRes", "auguste.PNG");

//static void ExtractFiles1(string nameSpace,
//            string outFile, string internalFilePath, string resourceName)
//{
//    Assembly assembly = Assembly.GetCallingAssembly();
//    using Stream? stream = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName);
   

//    if (stream is not null)
//    {
//        using BinaryReader reader = new(stream);
//        using FileStream fileStream = new(outFile + "\\" + resourceName, FileMode.OpenOrCreate);
//        using BinaryWriter writer = new(fileStream);
//        writer.Write(reader.ReadBytes((int)stream.Length));
//        Console.ReadLine();
//    }
//    Console.WriteLine("The rescources file where not found.");

//}