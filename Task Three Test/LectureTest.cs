using Homework2.Third_Task;

namespace UnitTest.Task_Three_Test
{
    [TestClass]
    public class LectureTest
    {
        [TestMethod]

        public void CloneTest()
        {
            Lecture originalLecture = new Lecture { Description = "Test", Topic = "Test" };

            Lecture cloneLecture = (Lecture)originalLecture.Clone();

            Assert.IsNotNull(cloneLecture);
            Assert.AreEqual(originalLecture.Description, cloneLecture.Description);
            Assert.AreEqual(originalLecture.Topic, cloneLecture.Topic);
        }
    }
}
