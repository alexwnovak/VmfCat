using System.IO;

namespace VmfCat
{
   public class VmfWriter
   {
      private readonly IWriter _writer;

      public VmfWriter( IWriter writer )
      {
         _writer = writer;
      }

      private void WriteViewSettings()
      {
         _writer.WriteLine( "viewsettings" );
         _writer.WriteLine( "{" );

         _writer.Indent();

         _writer.WritePairLine( "bSnapToGrid", 1 );
         _writer.WritePairLine( "bShowGrid", 1 );
         _writer.WritePairLine( "bShowLogicalGrid", 0 );
         _writer.WritePairLine( "nGridSpacing", 64 );
         _writer.WritePairLine( "bShow3DGrid", 0 );

         _writer.Exdent();

         _writer.WriteLine( "}" );
      }

      public void Save( World world, string fileName )
      {
         var versionInfo = new VersionInfo();
         versionInfo.Serialize( _writer );

         _writer.WriteLine( "visgroups" );
         _writer.WriteLine( "{" );
         _writer.WriteLine( "}" );

         WriteViewSettings();

         foreach ( var solid in world.Solids )
         {
            solid.Serialize( _writer );
         }
      }
   }
}
