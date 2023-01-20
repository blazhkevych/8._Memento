using task.task;

namespace task
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
            var originator = new Originator();
            var caretaker = new Caretaker();
            originator.Text = "Hello, World!";
            caretaker.Memento = originator.CreateMemento();
            originator.Text = "Hello, World! Hello, World!";
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine(originator.Text);
        }
    }

    /*
    Memento (Хранитель). 
    С использованием паттерна Memento реализовать консольный текстовый редактор с возможностью выполнения операций Undo/Redo.
    При нажатии клавиши «Enter» в объекте Memento сохраняются изменения, которые пользователь производит в процессе изменения текста в текстовом редакторе. 
    Программа должна предоставить пользователю возможность отменять изменения Undo, а также восстанавливать ранее отмененные изменения Redo.
    */

    // Path: Memento.cs
    namespace task
    {
        public class Memento
        {
            public string Text { get; set; }
            public Memento(string text)
            {
                Text = text;
            }
        }
    }

    // Path: Caretaker.cs
    namespace task
    {
        public class Caretaker
        {
            public Memento Memento { get; set; }
        }
    }

    // Path: Originator.cs
    namespace task
    {
        public class Originator
        {
            public string Text { get; set; }
            public Memento CreateMemento()
            {
                return new Memento(Text);
            }
            public void SetMemento(Memento memento)
            {
                Text = memento.Text;
            }
        }
    }

    // Path: Program.cs
    namespace task
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                var originator = new Originator();
                var caretaker = new Caretaker();
                originator.Text = "Hello, World!";
                caretaker.Memento = originator.CreateMemento();
                originator.Text = "Hello, World! Hello, World!";
                originator.SetMemento(caretaker.Memento);
                Console.WriteLine(originator.Text);
            }
        }
    }
    
    
    

}