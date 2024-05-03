using Homework2.Third_Task.Contacts;

namespace Homework2.Third_Task;

public class Training : ITraining
{
    public List<ITrainingComponent> components;

    public Training(int capacity)
    {
        components = new List<ITrainingComponent>(capacity);
    }
    public string Description { get; set; }
                                                     
    public void Add(ITrainingComponent component)
    {
        components.Add(component);
    }

    public bool IsPractical()
    {
        foreach(object component in components)
        {
            if(component is Lecture)
            {
                return false;
            }
        }

        return true;
    }

    public object Clone()
    {
        var clone = new Training(components.Count);
        foreach (var component in components)
        {
            clone.Add((ITrainingComponent)component.Clone());
        }
        clone.Description = Description;
        return clone;
    }
}

