using OrientacaoObjto.GUI;
using System;
using System.Collections.Generic;
using System.Collections;


namespace OrientacaoObjto.State
{
    class StateMainMenu : State
    {
        protected ArrayList characterList;
        protected Character activeCharacter;

        public StateMainMenu(Stack<State> states, ArrayList character_list) : base(states)
        {
            this.characterList = character_list;
            this.activeCharacter = null;
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.StartNewGame();
                    break;
                case 2:
                    this.states.Push(new StateCharacterCreater(this.states, this.characterList));
                    break;
                case 3:
                    this.SelectCharacter();
                    break;
                default:
                    break;
            }
        }
        override public void Update()
        {
            Gui.MenuTitle(0, "Main Menu");
            Gui.MenuOption(1, "New Game");
            Gui.MenuOption(2, "Character creator");
            Gui.MenuOption(3, "Select Character");
            Gui.MenuOption(-1, "Exit");

            int input = Gui.GetInputInt("input");

            this.ProcessInput(input);
        }

        public void StartNewGame()
        {
            //while the activeCharacter variable is null, one cannot start the game
            if(this.activeCharacter == null)
            {
                Gui.Announcement("There is no Active Character selected! Please select one before starting the game.");
            }
            else // Start gaeme
            {

            }
        }

        public void SelectCharacter()
        {
            //print al character to select
            for(int i = 0; i < this.characterList.Count; i++)
            {
                Console.WriteLine(i +": " + characterList[i].ToString());
            }

            int choice = Gui.GetInputInt("Characetr selection");


            try
            {
                this.activeCharacter = this.characterList[choice];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if(this.activeCharacter != null)
                Gui.Announcement($"The characeter {this.activeCharacter.ToString()} is selected.");
        }
    }
}
