using System.Threading.Tasks;

using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ApiIsolated
{
  public class Program
  {
    public static void Main()
    {
      var host = new HostBuilder()
          .ConfigureFunctionsWorkerDefaults()
          .Build();

      host.Run();
    }
  }
}