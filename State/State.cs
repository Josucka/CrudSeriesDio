using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjto.State
{
    class State
    {
        Stack<State> states;
        public State(Stack<State> states)
        {
            this.states = states;
        }
       
    }
}
