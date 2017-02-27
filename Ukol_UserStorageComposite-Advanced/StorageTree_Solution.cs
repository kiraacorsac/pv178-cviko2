using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_UserStorageComposite_Advanced
{
    //TODO: povedat ze davat vsetky triedy do jedneho suboru je blee, ale pre prehladnost ich tu mam zoradene
    //TODO: Zmenit F4 properties "Build Action" tohoto suboru na "Compile"
    public class User
    {
        public string UserName { get; set; }
    }

    public abstract class StorageItem
    {
        public string Name { get; set; }

        public StorageItem Parent { get; set; }

        public abstract StorageItem [] GetChildren();

        public abstract void Accept(IStorageVisitor visitor);
    }

    public abstract class StorageContainer : StorageItem
    {
        public StorageItem[] Content { get; set; }

        public override StorageItem [] GetChildren()
        {
            return Content;
        }
    }

    public sealed class StorageFolder : StorageContainer
    {
        public override void Accept(IStorageVisitor visitor)
        {
            visitor.VisitFolder(this);
            foreach (var child in GetChildren())
            {
                child.Accept(visitor);
            }
        }
    }

    public sealed class StorageDrive : StorageContainer
    {
        public User Admin { get; set; }

        public IList<string> Tags { get; set; }

        public override void Accept(IStorageVisitor visitor)
        {
            visitor.VisitDrive(this);
            foreach (var child in GetChildren())
            {
                child.Accept(visitor);
            }
        }
    }

    public sealed class StorageFile : StorageItem
    {
        public string RealPath { get; set; }

        public override StorageItem [] GetChildren()
        {
            return new StorageItem[] {};
        }

        public override void Accept(IStorageVisitor visitor)
        {
            visitor.VisitFile(this);
            foreach (var child in GetChildren())
            {
                child.Accept(visitor);
            }
        }
    }


}
