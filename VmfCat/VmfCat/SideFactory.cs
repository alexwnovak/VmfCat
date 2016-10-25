namespace VmfCat
{
   public class SideFactory
   {
      private int _idCounter = 1;

      public Side Create( Plane plane )
      {
         return new Side( plane )
         {
            Id = _idCounter++
         };
      }
   }
}
