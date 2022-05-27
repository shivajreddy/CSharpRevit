namespace CSharpPro1
{
    public class DbMigrator
    {
        // Fields
        private readonly Logger _logger;

        // Constructor
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        // Methods
        public void Migrate()
        {
            _logger.Log("we are migrating");
        }
        
    }
}