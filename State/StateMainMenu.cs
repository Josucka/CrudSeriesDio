using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;
using System.Collections;


namespace OrientacaoObjto.State
{
    class StateMainMenu : State
    {
        protected ArrayList characterList;

        public StateMainMenu(Stack<State> states, ArrayList character_list) : base(states)
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
                case 1:
                    break;
                case 2:
                    this.states.Push(new StateCharacterCreater(this.states, this.characterList));
                    break;
                case 3:
                    Console.WriteLine(this.characterList.Count);
                    break;
                default:
                    break;
            }
        }
        override public void Update()
        {
            Console.WriteLine(Gui.MenuTitle(0, "Main Menu"));
            Console.WriteLine(Gui.MenuOption(1, "New Game"));
            Console.WriteLine(Gui.MenuOption(2, "Character creator"));
            Console.WriteLine(Gui.MenuOption(3, "List Character"));
            Console.WriteLine(Gui.MenuOption(-1, "Exit"));

            Console.WriteLine("Write a number (Main Menu): ");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }

    }
}
