using OrientacaoObjto.GUI;
using OrientacaoObjto.State;
using System;
using System.Collections.Generic;

namespace OrientacaoObjto.Classe
{
    class Game
    {
        private bool end;

        public bool End 
        {
            get { return this.end; }
            set { this.end = value; }
        }

        private Stack<State> states;

        private void InitVariables()
        {
            this.end = false;
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            this.states.Push(new StateMainMenu(this.states));
        }

        public Game()
        {
            this.InitVariables();
            this.InitStates();
        }

        public void Run()
        {
            while (this.states.Count > 0)
            {
                if (this.states.Count > 0)
                {
                    this.states.Peek().Update();

                    if(this.states.Peek().RequestEnd())
                        this.states.Pop();
                }
            }
            Console.WriteLine("ending game");
        }
    }
}
