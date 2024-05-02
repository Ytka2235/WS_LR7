
internal class Program
{
    private static void Main(string[] args)
    {
        MyArray<int> ints = new();
        ints.Add(1);
        ints.Add(5);
        ints.Add(100);
        ints.Add(37);
        ints.Add(857);
        ints.Add(2342);
        ints.Del(5);
        ints.Del(0);
        for (int i = 0; i < ints.GetLenght(); i++) Console.WriteLine(ints.GetItem(i));
        Console.WriteLine();
        MyArray<double> myArray = new MyArray<double>();
        myArray.Add((double)1.123);
        myArray.Add((double)81.23);
        myArray.Add((double)90.6);
        myArray.Add((double)10767.9);
        myArray.Add((double)-0.89);
        myArray.Add((double)1.8799);
        for (int i = 0; i < myArray.GetLenght(); i++) Console.WriteLine(myArray.GetItem(i));
        Console.WriteLine();
        MyArray<string> strings = new();
        strings.Add("jvvvmm");
        strings.Add("Hello World");
        strings.Add("09");
        strings.Add("good");
        strings.Add("wolf");
        strings.Add("cat");
        for (int i = 0; i < strings.GetLenght(); i++) Console.WriteLine(strings.GetItem(i));
    }
}


class MyArray<T>
{
    T[] array;
    public MyArray() { array = new T[0]; }
    public MyArray(params T[] array)
    {
        this.array = array;
    }

    public void Add(T t)
    {
        T[] array = new T[this.array.Length + 1];
        for (int i = 0; i < this.array.Length; i++) array[i] = this.array[i];
        array[this.array.Length] = t;
        this.array = array;
    }

    public void Del(int id)
    {
        if (this.array.Length > id)
        {
            T[] array = new T[this.array.Length - 1];
            for (int i = 0; i < id; i++) array[i] = this.array[i];
            for (int i = id; i < this.array.Length - 1; i++) array[i] = this.array[i + 1];

            this.array = array;
        }
    }
    public T GetItem(int i)
    {
        return this.array[i];
    }
    public int GetLenght()
    {
        return this.array.Length;
    }

}



