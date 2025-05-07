{
    static void Main() {
        Console.WriteLine("Enter the string input : ");
        string input = Console.ReadLine();
        string[] splits = input.Split(' ');
        answer(splits);
    }
    static void answer(string[] splits)
    {
        for (int i = 0; i < splits.Length; i++) {
            splits[i].ToCharArray();
        }
    }
}