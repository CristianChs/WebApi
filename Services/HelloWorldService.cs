
namespace WebApi.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public string GetHelloWorld()
        {
            return "HOLA MUNDO";
        }
    }
}