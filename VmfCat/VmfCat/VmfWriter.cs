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

      public void Save( World world, string fileName )
      {
         var versionInfo = new VersionInfo();
         versionInfo.Serialize( _writer );

         foreach ( var solid in world.Solids )
         {
            solid.Serialize( _writer );
         }
      }
   }
}
