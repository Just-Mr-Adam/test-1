public class Singleton
{
    private static Singleton _instance;

    private Singleton()
    {
        Console.WriteLine("Singleton создан");
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public void SomeMethod()
    {
        Console.WriteLine("Выполняется метод");
    }
}
