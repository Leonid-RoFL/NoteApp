using System;
using System.IO;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private static string TestFilePath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents\NoteApp");

        [SetUp]
        public void Setup()
        {
            if (File.Exists(TestFilePath))
                File.Delete(TestFilePath);
        }

        [Test]
        public void Test_ProjectManager_SaveLoad()
        {
            ProjectManager manager = new ProjectManager();
            Project project = new Project();

            project.AddNote(new Note { Title = "Test note", Category = NoteCategory.Work, Text = "Text note" });

            manager.SaveProject(project);

            Project loadedProject = manager.LoadProject();

            Assert.AreEqual(1, loadedProject.Notes.Count);
            Assert.AreEqual("Test note", loadedProject.Notes[0].Title);
        }
    }
}