namespace VmfCat
{
   public struct Plane
   {
      public Vector3 P1
      {
         get;
      }

      public Vector3 P2
      {
         get;
      }

      public Vector3 P3
      {
         get;
      }

      public Plane( Vector3 p1, Vector3 p2, Vector3 p3 )
      {
         P1 = p1;
         P2 = p2;
         P3 = p3;
      }
   }
}
