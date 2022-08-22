
// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Press Enter to Extract Sample files.");
Console.ReadLine();
CreateDirctory(ApplicationLocalDirectory);
// ExtractFiles("ExtractEmbededRessources", "c:\\temp2", "EmbededRes", "RichText.rtf");

foreach (var item in SampleFilesNames)
{
    ExtractExternalFiles(ApplicationLocalDirectory,
                        "ExternalRes",
                        item);
}

foreach (var item in EmbededFilesNames)
{
    ExtractEmbededFiles("ExtractEmbededRessources",
                        ApplicationLocalDirectory,
                        "EmbededRes",
                        item);
}