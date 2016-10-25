using System.IO;

namespace VmfCat.UnitTests
{
   public class DummyTests
   {
      public void Driver()
      {
         var p0 = new Vector3( -128, -128, 0 );
         var p1 = new Vector3( 128, -128, 0 );
         var p2 = new Vector3( 128, 128, 0 );
         var p3 = new Vector3( 128, -128, 128 );

         var plane1 = new Plane( p0, p1, p2 );  // Bottom
         var plane2 = new Plane( p0, p2, p3 );  // Angled face
         var plane3 = new Plane( p0, p1, p3 );  // Back face #1
         var plane4 = new Plane( p1, p2, p3 );  // Back face #2

         var sideFactory = new SideFactory();
         var side1 = sideFactory.Create( plane1 );
         var side2 = sideFactory.Create( plane2 );
         var side3 = sideFactory.Create( plane3 );
         var side4 = sideFactory.Create( plane4 );

         var solidFactory = new SolidFactory();
         var solid = solidFactory.Create( side1, side2, side3, side4 );
         var world = new World( solid );

         using ( var stringWriter = new StringWriter() )
         {
            var vmfWriter = new VmfWriter( new Writer( stringWriter ) );
            vmfWriter.Save( world, @"C:\Temp\VmfCat.vmf" );

            string vmf = stringWriter.ToString();
         }
      }
   }
}
