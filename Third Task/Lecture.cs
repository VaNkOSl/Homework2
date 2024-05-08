namespace Homework2.Third_Task;

public class Lecture : TrainingComponentBase
{
    public string Description { get; set; }
    public string Topic { get; set; }

    public override object Clone()
    {
        return new Lecture { Description = Description, Topic = Topic };

    }
}

