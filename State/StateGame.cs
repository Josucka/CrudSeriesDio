using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjto.State
{
    class StateGame : State
    {
        public StateGame(Stack<State> states) : base(states)
        {
            Console.WriteLine("Hello from Main Menu!");
            this.states.Push(new StateGame(this.states));

        }
    }
}
