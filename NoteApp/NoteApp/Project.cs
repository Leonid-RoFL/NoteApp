using System;
using System.Collections.Generic;
using System.Linq;

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

        public void RemoveNote(Guid id)
        {
            var noteToRemove = Notes.FirstOrDefault(n => n.Id == id);
            if (noteToRemove != null)
            {
                Notes.Remove(noteToRemove);
            }
        }
    }
}