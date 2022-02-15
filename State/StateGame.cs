using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjto.State
{
    class StateGame : State
    {
        public StateGame(Stack<State> states) : base(states)
        {

        }

        public override void Update()
        {
            Console.WriteLine(Gui.MenuTitle(0, "Game State"));
            Console.WriteLine(Gui.MenuOption(0, "Create Character"));
            Console.WriteLine(Gui.MenuOption(-1, "Create Character"));

            Console.WriteLine("Write a number (Game): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                this.end = true;
        }
    }
}
