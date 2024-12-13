using System;
using System.Data;

namespace NoteApp
{
    public class Note : ICloneable

    {
        private string _title;
        private string _text;
        private NoteCategory _category;
        public Guid Id { get; set; } // Уникальный идентификатор



        /// <summary>
        /// Получает или устанавливает заголовок заметки
        /// 
        /// Ограничен первыми 50 символами. Если пустой, устанавливается "Заметка Текущая дата"
        /// </summary>
        ///

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value) || value == "")
                {
                    _title = "Заметка " + DateTime.Now.ToString("d") + " " + DateTime.Now.TimeOfDay.ToString("g");
                }
                else if (value.Length > 50)
                {
                    _title = value.Substring(0, 50);
                }
                else
                {
                    _title = value;
                }
                LastModified = DateTime.Now;
            }
        }

        // Получение категории заметки

        public NoteCategory Category
        {
            get => _category;
            set
            {
                _category = value;
                LastModified = DateTime.Now;
            }
        }

        // Получение или устанавка текста заметки

        public string Text
        {
            get => _text;
            set
            {
                if (string.IsNullOrEmpty(value) || value == "")
                {
                    _text = "Введите текст заметки";
                }
                else _text = value;
                LastModified = DateTime.Now;
            }
        }

        

        // Получение даты создания заметки

        public DateTime CreationTime { get; set; }
        public DateTime LastModified { get; set; }

        /// <summary> Инициализация нового экземпляра класса <see cref="Note"/> с значениями по умолчанию </summary>
        
        public Note()
        {
            Id = Guid.NewGuid(); // Генерация уникального
            Title = "Без названия";
            Category = NoteCategory.Other;
            Text = "";
            CreationTime = DateTime.Now;
            LastModified = CreationTime;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Note"/> с указанными значениями
        /// </summary>
        /// <param name="title">Заголовок заметки</param>
        /// <param name="category">Категория заметки</param>
        /// <param name="text">Текст заметки</param>
        
        public Note(string title, NoteCategory category, string text)
        {
            Title = title;
            Category = category;
            Text = text;
            CreationTime = DateTime.Now;
            LastModified = CreationTime;
        }

        /// <summary>
        /// Создает копию текущего объекта <see cref="Note"/>.
        /// </summary>
        /// <returns>Новый объект <see cref="Note"/>, являющийся копией текущего.</returns>
        
        public object Clone()
        {
            return new Note(Title, Category, Text)
            {
                CreationTime = this.CreationTime,
                LastModified = this.LastModified
            };
        }
    }
}