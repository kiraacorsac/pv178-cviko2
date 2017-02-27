using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_UserStorageComposite_Advanced
{
    //Uzivatel, ktory spravuje ulozisko
    public class User
    {
        public string UserName { get; set; }
    }

    //Spolocny zaklad pre vsetky polozky v ulozisti
    class StorageItem
    {
    }

    //Pripadne dalsie triedy

    class StorageFolder
    {
        //Vlastnost: Content obsahuje vsetky polozky ktore su priamo v precinku
        
        //Vlastnost: text Name
        //Vlastnost: Parent obsahuje predka uzlu v strome
        //Funkcia: GetChildren vrati vsetkych priamich potomkov
        //Funkcia: Accept zavola spravnu funkciu visitora a a postará sa abty visitora priali potomkovia
    }

    class StorageDrive
    {
        //Vlastnost: uzivatel Admin
        //Vlastnost: text Tags

        //Vlastnost: Content obsahuje vsetky polozky ktore su priamo v precinku

        //Vlastnost: text Name
        //Vlastnost: Parent obsahuje predka uzlu v strome
        //Funkcia: GetChildren vrati vsetkych priamich potomkov
        //Funkcia: Accept zavola spravnu funkciu visitora a a postará sa abty visitora priali potomkovia
    }

    class StorageFile
    {
        //Vlastnost: text RealPath 

        //Vlastnost: text Name
        //Vlastnost: Parent obsahuje predka uzlu v strome
        //Funkcia: GetChildren vrati vsetkych priamich potomkov
        //Funkcia: Accept zavola spravnu funkciu visitora a a postará sa abty visitora priali potomkovia
    }


}
