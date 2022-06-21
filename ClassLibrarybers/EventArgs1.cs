
namespace CafeLibrarybers
{
    public class EventArgs1
    {
        public List<String> ToDoList = new List<String>();

        // делегат
        public delegate void ToDoHandler(String text);
        // событие
        public event ToDoHandler OnAddToDo;
        // метод 'Добавление дел'
        public void AddDo(String ToDoName)
        {
            ToDoList.Add(ToDoName);
            // вызываем событие
            if (OnAddToDo != null)
                OnAddToDo("Сегодня вам нужно" + ToDoName);
        }


    }
}
