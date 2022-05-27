using System;

namespace CSharpPro1
{
    public class Program
    {
        static void Main(string[] args)
        {


            //var circle = new PresentationObject();

            //var myText = new Text();

            //myText.Width = 100;
            //myText.Copy();


            var logger = new Logger();
            var migrator = new DbMigrator(logger);

            migrator.Migrate();

            var myInstaller = new Installer(logger);
            myInstaller.Install();



        }
    }
}
