namespace VmfCat
{
   public static class Vector3Extensions
   {
      public static void Serialize( this Vector3 v, IWriter writer )
      {
         writer.Write( $"{v.X} {v.Y} {v.Z}" );
      }
   }
}
