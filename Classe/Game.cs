using OrientacaoObjto.State;
using System;
using System.Collections.Generic;

namespace OrientacaoObjto.Classe
{
    class Game
    {
        private bool end 
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
            while (this.end == false)
            {
                Console.WriteLine("Write a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.end = true;
                else
                    Console.WriteLine($"You inputted: {number}");
            }
            Console.WriteLine("ending game");
        }
    }
}
