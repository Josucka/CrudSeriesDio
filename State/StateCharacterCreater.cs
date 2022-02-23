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

        private void CreateCharacter()
        {
            String name = "";
            String description = "";
            Gui.GetInput("Input character name: ");
            name = Console.ReadLine();
            Gui.GetInput("Input description character: ");
            description = Console.ReadLine();
            this.characterList.Add(new Character(name, description));

            Gui.Announcement("Character created");

        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.CreateCharacter();
                    break;
                default:
                    break;
            }
        }

        override public void Update()
        {
            Gui.MenuTitle(0, "Character Create");
            Gui.MenuOption(1, "new Character");
            Gui.MenuOption(2, "Edit Character");
            Gui.MenuOption(3, "Delete Character");
            Gui.MenuOption(-1, "Exit");

            int input = Gui.GetInputInt("Input");

            this.ProcessInput(input);
        }
    }
}
