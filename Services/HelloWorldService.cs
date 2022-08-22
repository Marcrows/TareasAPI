public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld()
    {
        return "Hello World!";
    }

    public string GetByeWorld()
    {
        return "Bye World! I'll miss you";
    }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
    string GetByeWorld();
}