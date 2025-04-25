//using System;

class Program
{
    static void Main(string[] args)
    {
        string message = "This is never used1";

        string apiKey = "sk-123456789abcdef1";

        Console.WriteLine("Hello Utkarsh1");

        try
        {
            int num = int.Parse("oops11");
        }
        catch (Exception)
        {
            // ignored
        }

        Console.WriteLine("User: " + "utkarsh11" + " logged in.");
    }

    public static int Add(int a, int c)
    {
        return a + c;
    }
}

