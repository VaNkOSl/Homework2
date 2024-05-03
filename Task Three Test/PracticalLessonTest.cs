using Homework2.Third_Task;

namespace UnitTest.Task_Three_Test;

[TestClass]
public class PracticalLessonTest
{
    [TestMethod]
    public void CloneTest()
    {
        PracticalLesson originalPractical = new PracticalLesson { Description = "Test", TaskLink = "Test.com", SolutionLink = "Test.com" };

        PracticalLesson clonePractical = (PracticalLesson)originalPractical.Clone();

        Assert.IsNotNull(clonePractical);
        Assert.AreEqual(originalPractical.Description, clonePractical.Description);
        Assert.AreEqual(originalPractical.TaskLink, clonePractical.TaskLink);
        Assert.AreEqual(originalPractical.SolutionLink, clonePractical.SolutionLink);

    }
}
                                   
