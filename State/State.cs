using System.Collections.Generic;

namespace OrientacaoObjto.State
{
    class State
    {
        protected Stack<State> states;
        protected bool end = false;

        public State(Stack<State> states)
        {
            this.states = states;
        }

        public bool RequestEnd()
        {
            return this.end;
        }
       
        virtual public void Update()
        {

        }
    }
}
