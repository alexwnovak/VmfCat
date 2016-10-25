namespace VmfCat
{
   public class World
   {
      public Solid[] Solids
      {
         get;
      }

      public World( params Solid[] solids )
      {
         Solids = solids;
      }
   }
}
