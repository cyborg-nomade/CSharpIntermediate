using System.Diagnostics.SymbolStore;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbmigrator.Migrate();
            installer.Install();
        }
    }
}
