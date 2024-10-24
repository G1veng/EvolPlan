using EvolPlan.EDA.Events.Models;

namespace EvolPlan.EDA.Events.Implementations
{
    public class QuestionAddedEvent : IEvent<QuestionAddedModel>
    {
        public QuestionAddedModel Message { get; set; } = null!;
    }
}
