namespace VmfCat
{
   public static class SideExtensions
   {
      public static void Serialize( this Side s, IWriter writer )
      {
         writer.WriteLine( "side" );
         writer.WriteLine( "{" );

         writer.Indent();
         {
            writer.WritePairLine( "id", s.Id );

            writer.Write( "\"plane\" \"" );
            s.Plane.Serialize( writer );
            writer.Write( "\"" );

            writer.WriteLine();

            writer.WritePairLine( "material", s.Material );

            writer.WritePairLine( "uaxis", "[1 0 0 0] 0.25" );
            writer.WritePairLine( "vaxis", "[0 0 -1 0] 0.25" );

            writer.WritePairLine( "rotation", s.Rotation );
            writer.WritePairLine( "lightmapscale", s.LightMapScale );
            writer.WritePairLine( "smoothing_groups", s.SmoothingGroups );
         }

         writer.Exdent();
         writer.WriteLine( "}" );
      }
   }
}
