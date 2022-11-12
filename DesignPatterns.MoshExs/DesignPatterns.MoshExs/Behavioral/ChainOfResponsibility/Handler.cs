

namespace DesignPatterns.MoshExs.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler _Next;
        public Handler()
        {

        }
        public Handler(Handler next)
        {
            _Next = next;
        }
        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;
            
            if(_Next != null)
                _Next.Handle(request);
        }
        protected abstract bool DoHandle(HttpRequest request);


    }
}
