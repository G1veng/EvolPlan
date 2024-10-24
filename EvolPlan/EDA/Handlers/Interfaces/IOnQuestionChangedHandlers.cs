using EvolPlan.EDA.Events.Models;

namespace EvolPlan.EDA.Handlers.Interfaces
{
    public interface IOnQuestionChangedHandlers : IHandler<QuestionChangedModel>
    {
        new Task Execute(QuestionChangedModel action);
    }
}
