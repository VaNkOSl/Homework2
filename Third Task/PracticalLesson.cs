using Homework2.Third_Task.Contacts;

namespace Homework2.Third_Task
{
    public class PracticalLesson : TrainingComponentBase
    {
        public string Description { get; set; }
        public string TaskLink { get; set; }

        public string SolutionLink { get; set; }

        public override object Clone()
        {
            return new PracticalLesson { Description = Description, TaskLink = TaskLink, SolutionLink = SolutionLink };

        }
    }
}
