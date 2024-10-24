// See https://aka.ms/new-console-template for more information
using EvolPlan.EDA;
using EvolPlan.EDA.Events;
using EvolPlan.EDA.Events.Implementations;
using EvolPlan.EDA.Events.Models;
using EvolPlan.EDA.Handlers;
using EvolPlan.EDA.Handlers.Implementations;
using EvolPlan.EDA.Handlers.Interfaces;

Console.WriteLine("Hello, World!");

var eventRouter = new EvenRouter();
eventRouter.Handlers = new List<IHandler>()
{
    new OnQuestionChangedFirstHandler() { },
    new OnQuestionChangedSecondHandler() { },
    new OnQuestionAddedFirstHandler() { },
};
await eventRouter.OnEvent(new QuestionAddedEvent()
{
    Message = new QuestionAddedModel()
    {
        Id = 1,
    }
});