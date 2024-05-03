namespace Homework2.Third_Task.Contacts;

public interface ITraining
{
    void Add(ITrainingComponent component);
    bool IsPractical();
    object Clone();
}

