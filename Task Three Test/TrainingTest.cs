using Homework2.Third_Task;

namespace UnitTest.Task_Three_Test;

[TestClass]
public class TrainingTest
{
    [TestMethod]
    public void CloneTest()
    {
        Training originalTraining = new Training(3);
        Lecture lecture = new Lecture { Topic = "Test", Description = "Test" };
        originalTraining.Add(lecture);
        originalTraining.Description = "description";

        Training cloneTraining = (Training)originalTraining.Clone();

        Assert.IsNotNull(cloneTraining);
        Assert.AreEqual(originalTraining.components.Count, cloneTraining.components.Count);
        Assert.AreEqual(originalTraining.Description, cloneTraining.Description);

        for (int i = 0; i < originalTraining.components.Count; i++)
        {
            Assert.AreNotSame(originalTraining.components[i], cloneTraining.components[i]);

            Assert.IsInstanceOfType(cloneTraining.components[i], typeof(Lecture));

            Lecture originalLecture = (Lecture)originalTraining.components[i];
            Lecture cloneLecture = (Lecture)cloneTraining.components[i];
            Assert.AreEqual(originalLecture.Description, cloneLecture.Description);
            Assert.AreEqual(originalLecture.Topic, cloneLecture.Topic);
        }
    }
}

