using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_UserStorageComposite_Advanced
{
    public class Program
    {
        public static StorageDrive CreateSampleTree()
        {
            return new StorageDrive
            {
                Name = "Johns Storage",
                Tags = "Hi There",
                Admin = new User {UserName = "john@adm.com"},
                Content = new StorageItem[]
                {
                    new StorageFolder
                    {
                        Name = "Photos",
                        Content = new StorageItem[]
                        {
                            new StorageFile {Name = "photo1.jpg", RealPath = "X:\\Sys\\Storage\\John\\photo1.jpg"},
                            new StorageFile {Name = "photo2.jpg", RealPath = "X:\\Sys\\Storage\\John\\photo2.jpg"}
                        }
                    },
                    new StorageFolder()
                    {
                        Name = "Music",
                        Content = new StorageItem[]
                        {
                            new StorageFolder
                            {
                                Name = "Jazz",
                                Content = new StorageItem[]
                                {
                                    new StorageFile
                                    {
                                        Name = "track1.mp3",
                                        RealPath = "X:\\Sys\\Storage\\John\\track1.mp3"
                                    }
                                }
                            }
                        }
                    },
                    new StorageFile
                    {
                        Name = "Readme.txt",
                        RealPath = "X:\\Sys\\Storage\\John\\Readme.txt"
                    }
                }
            };
        }

        static void Main(string[] args)
        {
            var tree = CreateSampleTree();

            var parentResolver = new ParentResolver();
            var printer = new TreePrinter();

            tree.Accept(parentResolver);
            tree.Accept(printer);

            Console.ReadKey();
        }
    }
}
