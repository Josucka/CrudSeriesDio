using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;


namespace OrientacaoObjto.State
{
    class StateMainMenu : State
    {
        public StateMainMenu(Stack<State> states) : base(states)
        {

        }

        override public void Update()
        {
            Console.WriteLine(Gui.MenuTitle(0, "Main Menu"));
            Console.WriteLine(Gui.MenuOption(0, "Create Character"));
            Console.WriteLine(Gui.MenuOption(-1, "Create Character"));

            Console.WriteLine("Write a number (Main Menu): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                this.end = true;
        }

    }
}
