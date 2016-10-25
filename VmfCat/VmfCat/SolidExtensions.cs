namespace VmfCat
{
   public static class SolidExtensions
   {
      public static void Serialize( this Solid s, IWriter writer )
      {
         writer.WriteLine( "solid" );
         writer.WriteLine( "{" );

         writer.Indent();

         writer.WritePairLine( "id", s.Id );

         foreach ( var side in s.Sides )
         {
            side.Serialize( writer );
         }

         writer.Exdent();

         writer.WriteLine( "}" );
      }
   }
}
