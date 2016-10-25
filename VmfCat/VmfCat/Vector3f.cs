using System;

namespace VmfCat
{
   public struct Vector3f
   {
      public float X
      {
         get;
      }

      public float Y
      {
         get;
      }

      public float Z
      {
         get;
      }

      public Vector3f( float x, float y, float z )
      {
         X = x;
         Y = y;
         Z = z;
      }

      public static Vector3f CrossProuct( Vector3 v1, Vector3 v2 )
      {
         float x, y, z;
         x = v1.Y * v2.Z - v2.Y * v1.Z;
         y = ( v1.X * v2.Z - v2.X * v1.Z ) * -1;
         z = v1.X * v2.Y - v2.X * v1.Y;

         var crossVector = new Vector3f( x, y, z );

         return Normalize( crossVector );
      }

      public static Vector3f Normalize( Vector3f v )
      {
         float distance = (float) Math.Sqrt( v.X * v.X + v.Y * v.Y + v.Z * v.Z );
         return new Vector3f( v.X / distance, v.Y / distance, v.Z / distance );
      }
   }
}
