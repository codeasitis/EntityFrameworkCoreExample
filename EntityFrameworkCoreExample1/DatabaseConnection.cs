namespace EntityFrameworkCoreExample1
{
    public class DatabaseConnection
    {
        public static string ConnectionString
        {
            get
            {
                return ($"Server=localhost;Database=Dummy;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }
    }
}
