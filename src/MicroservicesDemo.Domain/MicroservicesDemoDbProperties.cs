namespace MicroservicesDemo
{
    public static class MicroservicesDemoDbProperties
    {
        public static string DbTablePrefix { get; set; } = "MicroservicesDemo";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "MicroservicesDemo";
    }
}
