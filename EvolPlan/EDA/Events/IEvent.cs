namespace EvolPlan.EDA.Events
{
    public interface IEvent<T> where T : class
    {
        T Message { get; set; }
    }
}
