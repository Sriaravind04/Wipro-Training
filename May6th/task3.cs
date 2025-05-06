using system;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter the 5 arr element: ");
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Mehtod(arr);
    }
    public static void Method(int[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("the 2nd Largest element : "+ arr[arr.Lemgth -2]);
    }
}
