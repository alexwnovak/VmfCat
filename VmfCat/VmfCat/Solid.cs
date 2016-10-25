using System.Text;

namespace VmfCat
{
   public struct Solid
   {
      public int Id
      {
         get;
         internal set;
      }

      public Side[] Sides
      {
         get;
      }

      public Solid( params Side[] sides )
      {
         Id = 0;
         Sides = sides;
      }
   }
}
