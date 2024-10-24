using EvolPlan.EDA.Events;
using EvolPlan.EDA.Events.Implementations;
using EvolPlan.EDA.Handlers;
using EvolPlan.EDA.Handlers.Interfaces;

namespace EvolPlan.EDA
{
    public class EvenRouter : IEventRouter
    {
        public List<IHandler> Handlers = new();

        public async Task OnEvent<T>(IEvent<T> eventInfo)
            where T : class
        {
            if (!Handlers.Any())
                return;

            List<Task> tasks = new List<Task>();
            tasks.AddRange(eventInfo switch
            {
                QuestionChangedEvent => ExecuteHandlers(typeof(IOnQuestionChanged), eventInfo.Message),
                QuestionAddedEvent => ExecuteHandlers(typeof(IOnQuestionAdded), eventInfo.Message),
                _ => Enumerable.Empty<Task>(),
            });

            if (tasks.Any())
                await Task.WhenAll(tasks.ToArray());
        }

        private IEnumerable<Task> ExecuteHandlers<T>(Type handlerType, T message) 
            where T : class
            => Handlers.Where(x => handlerType.IsAssignableFrom(x.GetType()))
                    .Select(handler =>
                    {
                        var temp = (IHandler<T>)handler;
                        return temp.Execute(message);
                    });
    }
}
