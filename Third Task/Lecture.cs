using Homework2.Third_Task.Contacts;

namespace Homework2.Third_Task;

public class Lecture : ITrainingComponent
{
    public string Description { get; set; }
    public string Topic { get; set; }

    public object Clone()
    {
        return new Lecture { Description = Description, Topic = Topic };
    }
}

