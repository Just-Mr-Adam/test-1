//интерфейс
public interface Database
{
    void query(String sql);
}

//Реальный класс базы данных
public class RealDatabase : Database
{
    public void query(String sql)
    {
        Console.WriteLine("Executing query: " + sql);
    }
}

//Прокси с проверкой доступа
public class DatabaseProxy : Database
{
    private RealDatabase realDatabase;
    private bool hasAccess;

    public DatabaseProxy(bool hasAccess)
    {
        this.realDatabase = new RealDatabase();
        this.hasAccess = hasAccess;
    }

    public void query(String sql)
    {
        if (hasAccess)
            realDatabase.query(sql);
        else
            Console.WriteLine("Запрос не может быть выполнен");
    }
}
