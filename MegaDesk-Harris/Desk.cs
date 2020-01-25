using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MegaDesk_Harris
{
                
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        RoseWood,
        Veneer
    }

    public enum RushOrderSpecs
    {
        Three,
        Five,
        Seven,
        None
    }

    public class Desk
    {
        public Desk()
        {
            DesktopMaterials = new Hashtable() { 
            {"Oak", 200},
            {"Laminate", 100},
            {"Pine", 50},
            {"RoseWood", 300},
            {"Veneer", 125},
        };
            foreach (DictionaryEntry item in DesktopMaterials)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);


           /* BindingSource bindingSource = new BindingSource(DesktopMaterials.Keys, null);

            ComboBox materialTypeHash.DataSource = bindingSource;

            materialTypeHash.SelectedIndexChanged += materialTypeHash_SelectedIndexChanged;*/

            ProductionTime = new Hashtable() {
            {"Rush.3>1k", 60},
            {"Rush.3>2k", 70},
            {"Rush.3<2k", 80},
            {"Rush.5>1k", 40},
            {"Rush.5>2k", 50},
            {"Rush.5<2k", 60},
            {"Rush.7>1k", 30},
            {"Rush.7>2k", 35},
            {"Rush.7<2k", 40},
            {"Rush.14", 0},
        };
            foreach (DictionaryEntry item in ProductionTime)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);


        }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }

        public int NumberOfDrawers { get; set; }

        public int SurfaceArea { get; set; }

        public Hashtable DesktopMaterials;
        public Hashtable ProductionTime;


    }
}

/*
 this.Width = 100;
 this.Depth = 100;
 this.SurfaceArea = this.width * this.Depth;

 */