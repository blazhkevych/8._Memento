﻿namespace task
{
    /// <summary>
    ///                   Memento (Хранитель)
    /// С использованием паттерна Memento реализовать консольный 
    /// текстовый редактор с возможностью выполнения операций Undo/Redo. 
    /// При нажатии клавиши «Enter» в объекте Memento сохраняются изменения, 
    /// которые пользователь производит в процессе изменения текста в 
    /// текстовом редакторе. Программа должна предоставить пользователю 
    /// возможность отменять изменения Undo, а также восстанавливать ранее 
    /// отмененные изменения Redo.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}