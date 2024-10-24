using EvolPlan.EDA.Events.Models;

namespace EvolPlan.EDA.Events.Implementations
{
    public class QuestionChangedEvent : IEvent<QuestionChangedModel>
    {
        public QuestionChangedModel Message { get; set; } = null!;
    }
}
