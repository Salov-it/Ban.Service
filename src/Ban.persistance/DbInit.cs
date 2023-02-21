
namespace Ban.persistance
{
    public class DbInit
    {
        public static void init(BanContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
