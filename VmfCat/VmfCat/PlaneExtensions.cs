namespace VmfCat
{
   public static class PlaneExtensions
   {
      public static void Serialize( this Plane p, IWriter writer )
      {
         writer.Write( "(" );
         p.P1.Serialize( writer );

         writer.Write( ") (" );

         p.P2.Serialize( writer );

         writer.Write( ") (" );

         p.P3.Serialize( writer );
         writer.Write( ")" );
      }
   }
}
