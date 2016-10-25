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

            var u = new Vector3f( s.Plane.P2.X - s.Plane.P1.X, s.Plane.P2.Y - s.Plane.P1.Y, s.Plane.P2.Z - s.Plane.P1.Z );
            var v = new Vector3f( s.Plane.P3.X - s.Plane.P2.X, s.Plane.P3.Y - s.Plane.P2.Y, s.Plane.P3.Z - s.Plane.P2.Z );

            var nu = Vector3f.Normalize( u );
            var nv = Vector3f.Normalize( v );

            writer.WritePairLine( "uaxis", $"[{nu.X} {nu.Y} {nu.Z} 0] 0.25" );
            writer.WritePairLine( "vaxis", $"[{nu.X} {nu.Y} {nu.Z} 0] 0.25" );

            writer.WritePairLine( "rotation", s.Rotation );
            writer.WritePairLine( "lightmapscale", s.LightMapScale );
            writer.WritePairLine( "smoothing_groups", s.SmoothingGroups );
         }

         writer.Exdent();
         writer.WriteLine( "}" );
      }
   }
}
