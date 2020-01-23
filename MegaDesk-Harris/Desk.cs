using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class Desk
    {

        public int DeskWidth { get; set; }

        public int DeskDepth { get; set; }

        public int NumberOfDrawers { get; set; }

        public int SurfaceArea { get; set; }

        public DesktopMaterial MaterialType { get; set; }

    }
}

/*
 this.Width = 100;
 this.Depth = 100;
 this.SurfaceArea = this.width * this.Depth;

 */