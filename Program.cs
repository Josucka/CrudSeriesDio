using OrientacaoObjto.Classe;
using OrientacaoObjto.GUI;
using System;

namespace CrudSeriesDio
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine(Gui.Title("Welcome!!"));
            game.Run();
        }
    }
}