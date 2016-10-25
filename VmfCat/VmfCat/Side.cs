namespace VmfCat
{
   public struct Side
   {
      public int Id
      {
         get;
         set;
      }

      public Plane Plane
      {
         get;
      }

      public string Material
      {
         get;
      }

      public int Rotation
      {
         get;
      }

      public int LightMapScale
      {
         get;
      }

      public int SmoothingGroups
      {
         get;
      }

      public Side( Plane plane )
      {
         Id = 0;
         Plane = plane;
         Material = "customdev/dev_measuregeneric01red";
         Rotation = 0;
         LightMapScale = 16;
         SmoothingGroups = 0;
      }
   }
}
