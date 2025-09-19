class Program
{
    static void Main(string[] args)
    {

        using (Game game = new Game(800, 600, "Setup"))
        {
            game.Run();
        }
    }
}