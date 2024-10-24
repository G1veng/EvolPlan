namespace EvolPlan.EDA.Handlers
{
    public interface IHandler
    {

    }

    public interface IHandler<T> : IHandler where T : class
    {
        public Task Execute(T message);
    }
}
