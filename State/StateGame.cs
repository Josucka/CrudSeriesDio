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
            Gui.MenuTitle(0, "Game State");
            Gui.MenuOption(1, "Create Character");
            Gui.MenuOption(-1, "Exit");

            Gui.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
