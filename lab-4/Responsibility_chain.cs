public enum RequestType
{
    TYPE_A, TYPE_B, UNKNOWN
}

public class Request
{
    public RequestType Type { get; }

    public Request(RequestType type)
    {
        Type = type;
    }
}

// интерфейс
interface Handler
{
    void handleRequest(Request request);
    void setNextHandler(Handler nextHandler);
}

// Конкретный обработчик A
class ConcreteHandlerA : Handler
{
    private Handler nextHandler;


    public void handleRequest(Request request)
    {
        if (request.Type == RequestType.TYPE_A)
            Console.WriteLine("ConcreteHandlerA handled the request.");
        
        else if (nextHandler != null)
            nextHandler.handleRequest(request);
    }

    
    public void setNextHandler(Handler nextHandler) => this.nextHandler = nextHandler;
}

// Конкретный обработчик B
class ConcreteHandlerB : Handler
{
    private Handler nextHandler;

    public void handleRequest(Request request)
    {
        if (request.Type == RequestType.TYPE_B)
            Console.WriteLine("ConcreteHandlerB handled the request.");
        
        else if (nextHandler != null)
            nextHandler.handleRequest(request);
    }

    public void setNextHandler(Handler nextHandler) => this.nextHandler = nextHandler;
}
