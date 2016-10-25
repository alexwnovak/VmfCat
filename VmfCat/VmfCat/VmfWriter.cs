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
         foreach ( var solid in world.Solids )
         {
            solid.Serialize( _writer );
         }
      }
   }
}
