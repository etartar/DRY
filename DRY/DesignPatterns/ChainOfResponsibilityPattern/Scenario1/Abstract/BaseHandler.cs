namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;
        public abstract ITransportObject Handle(ITransportObject transportObject);

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        protected ITransportObject NextChain(ITransportObject transportObject)
        {
            if (_nextHandler == null)
            {
                return transportObject;
            }

            return _nextHandler.Handle(transportObject);
        }
    }
}
