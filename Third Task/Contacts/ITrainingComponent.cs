namespace Homework2.Third_Task.Contacts
{
    public interface ITrainingComponent
    {
        string Description { get; set; }
        object Clone();
    }
}
