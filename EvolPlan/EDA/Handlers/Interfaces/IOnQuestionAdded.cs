using EvolPlan.EDA.Events.Models;

namespace EvolPlan.EDA.Handlers.Interfaces
{
    public interface IOnQuestionAdded : IHandler<QuestionAddedModel>
    {
        new Task Execute(QuestionAddedModel action);
    }
}
