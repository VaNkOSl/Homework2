using Homework2.Third_Task.Contacts;

namespace Homework2.Third_Task
{
    public abstract class TrainingComponentBase : ITrainingComponent
    {
        public string Description { get; set; }


        public abstract object Clone();
    }
}
