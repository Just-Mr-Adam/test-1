// 1. Интерфейс
public interface Logger
{
    void Log(string message);
}

// 2. Конкретный продукт
public class FileLogger : Logger
{
    public void Log(string message)
        => Console.WriteLine($"File: {message}");
}

public class ConsoleLogger : Logger
{
    public void Log(string message)
        => Console.WriteLine($"Console: {message}");
}

// 3. Создатель с фабричным методом
public abstract class LoggerFactory
{
    // Фабричный метод
    public abstract Logger CreateLogger();

    public void LogMessage(string message)
    {
        var logger = CreateLogger();
        logger.Log(message);
    }
}

// 4. Конкретные создатели
public class FileLoggerFactory : LoggerFactory
{
    public override Logger CreateLogger()
        => new FileLogger();
}

public class ConsoleLoggerFactory : LoggerFactory
{
    public override Logger CreateLogger()
        => new ConsoleLogger();
}
