using System;
using System.IO;

namespace FilesandFolders;

public class Program
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\MuthukumarNadiMuthu\OneDrive - Syncfusion\Desktop";
        string folderpath=path+"/Muthu";
        string filepath=path+"/newFile.txt";
        if(!Directory.Exists(folderpath))
        {
            System.Console.WriteLine("Folder not found creating folder");
            string folder=path+"/muthu";
            Directory.CreateDirectory(folderpath);
        }
        else{
            System.Console.WriteLine("directory found");

        }

        if(!File.Exists(filepath))
        {
            System.Console.WriteLine("File not found");
            File.Create(filepath);
        }
        else
        {
            System.Console.WriteLine("File already exixts");
          
            System.Console.WriteLine("Select your option\n 1.create folder\n 2.create File\n 3.Delete Folder\n 4.Delete File"); 
              int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {

                    System.Console.WriteLine("enter folder name you want to create");
                    string name1=Console.ReadLine();
                    string newPath=path+"\\"+name1;
                    if(!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }
                    else
                    {
                         System.Console.WriteLine("Directory name already exists");
                    }
                  
                   break; 
                }
                case 2:
                {
                    System.Console.WriteLine("Enter file name you want to create");
                    string name1=Console.ReadLine();
                    System.Console.WriteLine("Enter file extention you want to crate");
                    string extention=Console.ReadLine();
                    string newPath=path+"\\"+name1+"."+extention;
                    if (!File.Exists(newPath))
                    {
                        File.Create(newPath);

                    }
                    else
                    {
                        System.Console.WriteLine("file name already exists");
                    }
                    break;
                }
                case 3:
                {
                    foreach(string name in Directory.GetDirectories(path))  //it is like file manager
                    {System.Console.WriteLine(name);}
                    System.Console.WriteLine("Select the folder you want to delete");
                    string name1=Console.ReadLine();
                    string newPath=path+"\\"+name1;

                    foreach (string name in Directory.GetDirectories(path))
                    {
                        if(name==newPath)
                        {
                            try{
                            Directory.Delete(newPath);
                            System.Console.WriteLine("fOLDER DELETED");
                            }
                            catch(FileNotFoundException e)
                            {
                                System.Console.WriteLine("Folder not found"+e.Message);
                            }

                        }
                    }
                    break;
                }

                case 4:
                {
                    foreach (string  name in Directory.GetFiles(path))
                    {
                        System.Console.WriteLine(name);
                    }
                    System.Console.WriteLine("select file to Delete");
                    string name1=Console.ReadLine();
                    System.Console.WriteLine("Enter extension");

                    string name2=Console.ReadLine();
                    string newPath=path+"\\"+name1+"."+name2;
                    foreach (string name in Directory.GetFiles(path))
                    {
                        if(name==newPath)
                        {
                            try{
                            File.Delete(newPath);
                            System.Console.WriteLine("File Deleted");
                            }
                            catch(FileNotFoundException e)
                            {
                                System.Console.WriteLine("filenot found"+e.Message);
                            }
                        }
                        
                    }
                     break;
                }
                  
                default:
                    break;
            }
            
        }
    }
}
