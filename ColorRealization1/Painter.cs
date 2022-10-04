using System;
namespace ColorRealization
{
    public class Painter
    {
        static public void Repaint()
        {
            Console.Title = "Pwrsh (NO LICENCE)";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}