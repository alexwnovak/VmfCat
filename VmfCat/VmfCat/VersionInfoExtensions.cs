namespace VmfCat
{
   public static class VersionInfoExtensions
   {
      public static void Serialize( this VersionInfo vi, IWriter writer )
      {
         writer.WriteLine( "versioninfo" );
         writer.WriteLine( "{" );

         writer.Indent();

         writer.WritePairLine( "editorversion", vi.EditorVersion );
         writer.WritePairLine( "editorbuild", vi.EditorBuild );
         writer.WritePairLine( "mapversion", vi.MapVersion );
         writer.WritePairLine( "formatversion", vi.FormatVersion );
         writer.WritePairLine( "prefab", vi.Prefab );

         writer.Exdent();

         writer.WriteLine( "}" );
      }
   }
}
