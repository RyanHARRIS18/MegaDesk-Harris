/*
 BasePrice = 200
 IF SurfaceArea > 1000 then +1 for each 1 square inch over
 If NumberOfDrawers is != 0
 +50 for each */

namespace MegaDesk_Harris
{ 

  /*  public enum RushOrder
    {
        Rush-3-Day,
        Rush-5-Day,
        Rush-7-Day,
        Normal-14 Day
    }*/

public class DeskQuote

{
    public string CustomerName { get; set; }

    public decimal GetQuotePrice()
    {
        //TO DO: calculater Price

       /* var x = Desk.DesktopMaterials.Oak.Value;*/

        return 200;
    }
}
}