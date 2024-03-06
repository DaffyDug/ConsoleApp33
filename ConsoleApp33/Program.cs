using System;


class Program
{
    static void Main(string[] args)
    {
        Test test = new Test();
        test.Swap("DADADADAD", "NETNETNETNET");
    }
}
public class Test
{
    public event Action<int> Name;
    public event Action Name2;
    public event Action<float, DateTime> Name3;
    public event Action<string, float, TimeSpan, DayOfWeek> Name4;
    public void Central_Test_Panel()
    {
        Name += Metod;
        Name2 += Metod2;
        Name3 += Metod3;
        Name4 += Metod4;
    }
    public void Central_Test_Panel2()
    {
        Name -= Metod;
        Name2 -= Metod2;
        Name3 -= Metod3;
        Name4 -= Metod4;
    }
    private void Metod(int intvalue)
    {

    }
    private void Metod2()
    {

    }
    private void Metod3(float a, DateTime dateTime)
    {

    }
    private void Metod4(string stringvalue, float floatvalue, TimeSpan timeSpan, DayOfWeek dayOfWeek)
    {

    }

    public void Swap<T>(T second, T first)
    {
        Console.Write(second + "\t");
        Console.Write(first + "\n");
        T a = second;
        second = first;
        first = a;
        Console.Write(second + "\t");
        Console.Write(first);
    }
}

public class MyCollection<T>
{
    private T[] Ts;
    public MyCollection(T[] ts)
    {
        Ts = ts;
    }
    public void AddElements(T a)
    {
        T[] ts2 = new T[Ts.Length + 1];
        for (int i = 0; i < Ts.Length; i++)
        {
            ts2[i] = Ts[i];
        }
        ts2[ts2.Length - 1] = a;
    }
    public void RemuveElements(int index)
    {
        if (Ts.Length >= index)
        {

        }
    }
}