using NUnit.Framework;
using NoteApp;
using System;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test] // Проверка заголовка
        public void Test_Title_Set_CorrectValue()
        {
            Note note = new Note();
            note.Title = "Test note";
            Assert.AreEqual("Test note", note.Title);
        }

        [Test] // Заголовок по умолчанию
        public void Test_Title_Set_EmptyValue()
        {
            Note note = new Note();
            note.Title = "";                                            // Пустой заголовок
            Assert.IsTrue(note.Title.StartsWith("Заметка"));
        }

        [Test] // Ограничение допустимой длины заголовка (50 символов)
        public void Test_Title_Set_ExceedsMaxLength()
        {
            Note note = new Note();
            string longTitle = new string('1', 51);
            note.Title = longTitle;
            Assert.AreEqual(longTitle.Substring(0, 50), note.Title);
        }

        [Test] // Проверка текста заметки
        public void Test_Text_Set_CorrectValue()
        {
            Note note = new Note();
            note.Text = "Test text.";
            Assert.AreEqual("Test text.", note.Text);
        }

        [Test] // Текст по умолчанию
        public void Test_Text_Set_EmptyValue()
        {
            Note note = new Note();
            note.Text = "";                                             // Пустой текст
            Assert.AreEqual("Введите текст заметки", note.Text);
        }
        [Test] // Проверка установки категории
        public void Test_Category_Set_CorrectValue()
        {
            Note note = new Note();
            note.Category = NoteCategory.Work;
            Assert.AreEqual(NoteCategory.Work, note.Category);
        }
        [Test] // Проверка времени создания
        public void Test_CreationTime_Set_CorrectValue()
        {
            Note note = new Note();
            DateTime now = DateTime.Now;
            note.CreationTime = now;
            Assert.AreEqual(now, note.CreationTime);
        }
        [Test] // Проверка времени последнего изменения
        public void Test_LastModified_Set_CorrectValue()
        {
            Note note = new Note();
            DateTime now = DateTime.Now;
            note.LastModified = now;
            Assert.AreEqual(now, note.LastModified);
        }
    }
}