using System.IO;

namespace VmfCat
{
   public class Writer : IWriter
   {
      private readonly TextWriter _textWriter;
      private int _indentLevel;
      private int _indentationSpacing = 4;
      private bool _hasIndentedLine;

      public Writer( TextWriter textWriter )
      {
         _textWriter = textWriter;
      }

      public void Exdent()
      {
         _indentLevel--;
      }

      public void Indent()
      {
         _indentLevel++;
      }

      private void Prepend()
      {
         if ( _indentLevel > 0 && !_hasIndentedLine )
         {
            _textWriter.Write( new string( ' ', _indentationSpacing * _indentLevel ) );
            _hasIndentedLine = true;
         }
      }

      public void Write( string s )
      {
         Prepend();
         _textWriter.Write( s );
      }

      public void WriteLine()
      {
         _textWriter.WriteLine();
         _hasIndentedLine = false;
      }

      public void WriteLine( string line )
      {
         if ( _indentLevel == 0 )
         {
            _textWriter.WriteLine( line );
         }
         else
         {
            string indent = new string( ' ', _indentationSpacing * _indentLevel );
            _textWriter.WriteLine( indent + line );
         }

         _hasIndentedLine = false;
      }

      public void WritePairLine( string property, object value )
      {
         if ( _indentLevel == 0 )
         {
            _textWriter.WriteLine( $"\"{property}\" \"{value}\"" );
         }
         else
         {
            string indent = new string( ' ', _indentationSpacing * _indentLevel );
            _textWriter.WriteLine( indent + $"\"{property}\" \"{value}\"" );
         }

         _hasIndentedLine = false;
      }
   }
}
