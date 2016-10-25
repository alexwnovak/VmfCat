namespace VmfCat
{
   public interface IWriter
   {
      void Write( string s );
      void WriteLine();
      void WriteLine( string line );
      void WritePairLine( string property, object value );
      void Indent();
      void Exdent();
   }
}
