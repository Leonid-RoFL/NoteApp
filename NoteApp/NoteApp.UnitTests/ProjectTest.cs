using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test] // Создание заметки
        public void Test_Project_AddNote()
        {
            Project project = new Project();
            Note note = new Note { Title = "Test note", Category = NoteCategory.Documents, Text = "Test note" };

            project.AddNote(note);

            Assert.AreEqual(1, project.Notes.Count);
            Assert.AreEqual("Test note", project.Notes[0].Title);
        }

        [Test] // Удаление заметок
        public void Test_Project_RemoveNote()
        {
            var project = new Project();
            var note = new Note { Title = "Test note", Category = NoteCategory.Documents, Text = "Test note" };

            project.AddNote(note);
            project.RemoveNote(note.Id);

            Assert.AreEqual(0, project.Notes.Count);
        }

        [Test] // Редактирование заметок
        public void Test_Project_UpdateNote()
        {
            var project = new Project();
            var note = new Note { Title = "Old note", Category = NoteCategory.Documents, Text = "Old text" };

            // Изменяем заголовок и текст
            note.Title = "New note";
            note.Text = "New text";
            note.Category = NoteCategory.Home;

            Assert.AreEqual("New note", note.Title);
            Assert.AreEqual("New text", note.Text);
            Assert.AreEqual(NoteCategory.Home, note.Category);
        }
    }
}