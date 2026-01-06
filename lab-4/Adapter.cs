//Сторонний класс библиотеки
public class ExternalLogger
{
    public void logMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}

//Целевой интерфейс
public interface Logger
{
    void log(String message);
}

//Адаптер для интеграции
public class LoggerAdapter : Logger
{
    private ExternalLogger externalLogger;

    public LoggerAdapter(ExternalLogger externalLogger) => this.externalLogger = externalLogger;

    public void log(String message)
    {
        externalLogger.logMessage(message); // Адаптируем метод
    }
}
