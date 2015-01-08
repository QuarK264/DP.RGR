namespace DAA.DP.RGR
{
    using System;

    abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }        

        public abstract void HandleRequest(ConsoleKeyInfo request);
    }
}
