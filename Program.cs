namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаём объект класса Student
            Student st = new Student();

            // 2. Задаём значения полям
            st.FIO = "Иванов";
            st.Ocenka1 = 3;
            st.Ocenka2 = 5;

            // 3. Выводим данные объекта на экран
            st.Show();

            // 4. Считаем среднюю оценку и выводим её
            float sred = st.SredOcenka();
            Console.WriteLine($"Средняя оценка = {sred}");

            Console.ReadKey();
        }
    }

    class Student
    {
        // Открытые поля: ФИО и две оценки
        public string FIO;
        public int Ocenka1;
        public int Ocenka2;

        // Метод: показать данные о студенте
        public void Show()
        {
            Console.WriteLine($"Студент: {FIO}");
            Console.WriteLine($"Оценка 1 = {Ocenka1}, оценка 2 = {Ocenka2}");
        }

        // Метод: подсчёт средней оценки
        public float SredOcenka()
        {
            return (Ocenka1 + Ocenka2) / 2f;
        }

    }
}