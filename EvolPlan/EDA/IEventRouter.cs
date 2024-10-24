using EvolPlan.EDA.Events;

namespace EvolPlan.EDA
{
    public interface IEventRouter
    {
        Task OnEvent<T>(IEvent<T> eventInfo) where T : class;
    }
}
