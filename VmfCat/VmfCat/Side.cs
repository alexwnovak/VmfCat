namespace VmfCat
{
   public struct Side
   {
      public int Id
      {
         get;
      }

      public Plane Plane
      {
         get;
      }

      public string Material
      {
         get;
      }

      public int LightMapScale
      {
         get;
      }

      public Side( Plane plane )
      {
         Id = 0;
         Plane = plane;
         Material = "customdev/dev_measuregeneric01red";
         LightMapScale = 16;
      }
   }
}
