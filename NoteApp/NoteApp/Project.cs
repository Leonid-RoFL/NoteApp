using System.Collections.Generic;

namespace NoteApp
{
    public class Project
    {
        // Список заметок, которые находятся в проекте

        public List<Note> Notes { get; set; }

        // Конструктор класса, который вызывается при создании нового экземпляра проекта

        public Project()
        {
            Notes = new List<Note>();
        }

        // Метод позволяет добавлять новую заметку в проект

        public void AddNote(Note note)
        {
            Notes.Add(note);
        }

        // Метод позволяет удалять существующую заметку из проекта

        public void RemoveNote(Note note)
        {
            Notes.Remove(note);
        }
    }
}