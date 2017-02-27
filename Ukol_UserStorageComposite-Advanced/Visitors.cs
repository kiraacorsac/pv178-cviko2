using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_UserStorageComposite_Advanced
{
    public interface IStorageVisitor
    {
        void VisitFile(StorageFile storageFile);

        void VisitFolder(StorageFolder storageFolder);

        void VisitDrive(StorageDrive storageDrive);
    }

    public class ParentResolver : IStorageVisitor
    {
        public void VisitFile(StorageFile storageFile)
        {
            SetParent(storageFile);
        }

        public void VisitFolder(StorageFolder storageFolder)
        {
            SetParent(storageFolder);
        }

        public void VisitDrive(StorageDrive storageDrive)
        {
            SetParent(storageDrive);
        }

        public void SetParent(StorageItem item)
        {
            foreach (var child in item.GetChildren())
            {
                child.Parent = item;
            }
        }
    }

    public class TreePrinter : IStorageVisitor
    {
        public void VisitFile(StorageFile storageFile)
        {
            Console.WriteLine($"{GetSpacing(storageFile)}-{storageFile.Name}: {storageFile.RealPath}");
        }

        public void VisitFolder(StorageFolder storageFolder)
        {
            Console.WriteLine($"{GetSpacing(storageFolder)}+{storageFolder.Name}");
        }

        public void VisitDrive(StorageDrive storageDrive)
        {
            Console.WriteLine($"{GetSpacing(storageDrive)}@{storageDrive.Name}");
        }

        private string GetSpacing(StorageItem storageItem)
        {
            var spacingBuilder = new StringBuilder();
            var currentItem = storageItem;

            while (currentItem.Parent != null)
            {
                currentItem = currentItem.Parent;
                spacingBuilder.Append("  ");
            }

            return spacingBuilder.ToString();
        }
    }
}
