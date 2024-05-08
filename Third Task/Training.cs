using Homework2.Third_Task.Contacts;

namespace Homework2.Third_Task;

public class Training : ITraning
{
    public ITrainingComponent[] components;

    public Training(int capacity)
    {
        components = new ITrainingComponent[capacity];
    }
    public string Description { get; set; }
                                                     
    public void Add(ITrainingComponent component)
    {
        for (int i = 0; i < components.Length; i++)
        {
            if (components[i] == null)
            {
                components[i] = component;
                return;
            }
        }
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
        var clone = new Training(components.Length);
        for (int i = 0; i < components.Length; i++)
        {
            if (components[i] != null)
            {
                clone.components[i] = (ITrainingComponent)components[i].Clone();
            }
        }
        clone.Description = Description;
        return clone;
    }
}
