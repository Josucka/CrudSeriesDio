using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjto.State
{
    class StateCharacterCreater : State
    {
        ArrayList characterList;
     
        public StateCharacterCreater(Stack<State> states, ArrayList character_list) : base(states)
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
                    this.characterList.Add(new Character("MeadTurma"));
                    this.characterList.Add(new Character("Bob"));
                    this.characterList.Add(new Character("Svan"));
                    Console.Write(Gui.Announcement("Character created"));
                    break;
                default:
                    break;
            }
        }

        override public void Update()
        {
            Console.WriteLine(Gui.MenuTitle(0, "Character Create"));
            Console.WriteLine(Gui.MenuOption(0, "new Character"));
            Console.WriteLine(Gui.MenuOption(1, "Edit Character"));
            Console.WriteLine(Gui.MenuOption(2, "Delete Character"));
            Console.WriteLine(Gui.MenuOption(-1, "Exit"));

            Gui.GetInput("Input");
            Console.WriteLine("Write a number (Game): ");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
