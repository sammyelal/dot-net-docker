namespace MyGitHubActionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                System.Console.WriteLine($"Hello, {args[0]}!");
                return;
            }
        }
    }
}   

