using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmfCat
{
   public class SolidFactory
   {
      private int _idCounter = 2;

      public Solid Create( params Side[] sides )
      {
         return new Solid( sides )
         {
            Id = _idCounter++
         };
      }

   }
}
