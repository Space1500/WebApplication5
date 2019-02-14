using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication5
{
    public class Program
    {
        public Program()
        {
        }

        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new System.ArgumentNullException(nameof(args));
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
