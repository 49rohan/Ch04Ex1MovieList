using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MovieListCh04Ex01.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<MovieContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("MovieContext")));
    }
}