using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;
using System.Collections;

namespace OrientacaoObjto.State
{
    class StateGame : State
    {
        ArrayList characterList;

        public StateGame(Stack<State> states, ArrayList character_list) : base(states)
        {
            this.characterList = character_list;
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                default:
                    break;
            }
        }

        public override void Update()
        {
            Console.WriteLine(Gui.MenuTitle(0, "Game State"));
            Console.WriteLine(Gui.MenuOption(0, "Create Character"));
            Console.WriteLine(Gui.MenuOption(-1, "Create Character"));

            Gui.GetInput("Input");
            Console.WriteLine("Write a number (Game): ");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
