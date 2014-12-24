namespace DAA.DP.RGR
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        public abstract void HandleRequest(ConsoleKeyInfo request);
        public abstract void HandleRequest(ConsoleKeyInfo request, List<char> list, StringBuilder str);
        public abstract void HandleRequest(ConsoleKeyInfo requst, StringBuilder str);
    }
}
