using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;
using System.Collections;

namespace OrientacaoObjto.State
{
    class StateGame : State
    {
        protected Character character;

        public StateGame(Stack<State> states, Character activeCharacter) : base(states)
        {
            this.character = activeCharacter;
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.character.ToString(); //Console.WriteLine();   / Debug
                    break;

                default:
                    break;
            }
        }

        public override void Update()
        {
            Gui.MenuTitle(0, "Game State");
            Gui.MenuOption(1, "Character Stats");
            Gui.MenuOption(-1, "Exit");

            int input = Gui.GetInputInt("Input");

            this.ProcessInput(input);
        }
    }
}
