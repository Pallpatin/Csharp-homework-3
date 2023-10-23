using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        int tasknumber = 1;
        goto here;
        /*Задание 1
         * Напишите метод, который отображает квадрат из 
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.*/
        Console.Clear();
        Console.WriteLine("Задание №"+tasknumber++);
        Console.WriteLine("Напишите метод, который отображает квадрат из \r\nнекоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.");
        Console.WriteLine("введите сторону квадрата");
        int sidesize = int.Parse(Console.ReadLine());
        Console.WriteLine("введите символ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Sqare(sidesize,ch);
        Console.WriteLine("нажмите любую кнопку");
        Console.ReadKey(true);
        /*Задфние 2
         * Напишите метод, который проверяет является ли 
переданное число «палиндромом». Число передаётся в 
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как 
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром*/
        Console.Clear();
        Console.WriteLine("Задание №"+tasknumber++);
        Console.WriteLine("Напишите метод, который проверяет является ли \r\nпереданное число «палиндромом». Число передаётся в \r\nкачестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.\r\nПалиндром — число, которое читается одинаково как \r\nсправа налево, так и слева направо. Например:\r\n1221 — палиндром;\r\n3443 — палиндром;\r\n7854 — не палиндром");
        Console.WriteLine("введите число для проверки на полиндром");
        string str = Console.ReadLine();
        if (Palindrome(str))
        {
            Console.WriteLine("палиндром");
        }else Console.WriteLine("не палиндром");
        Console.WriteLine("нажмите любую кнопку");
        Console.ReadKey(true);
        /*Задание 3
         Напишите метод, фильтрующий массив на основании 
переданных параметров. Метод принимает параметры: 
оригинальный_массив, массив_с_данными_для_фильтрации.
1
Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 -1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 -1 — результат работы метода.*/

        Console.Clear();
        Console.WriteLine("Задание №" + tasknumber++);
        Console.WriteLine("Напишите метод, фильтрующий массив на основании \r\nпереданных параметров. Метод принимает параметры: \r\nоригинальный_массив, массив_с_данными_для_фильтрации.\r\n1\r\nМетод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.\r\nНапример:\r\n1 2 6 -1 88 7 6 — оригинальный массив;\r\n6 88 7 — массив для фильтрации;\r\n1 2 -1 — результат работы метода.");
        int[] toclear = new int[100];
        for(int i = 0; i < toclear.Length; i++) { toclear[i] = i; }
        int[] filter = new int[] {-15,2,4,8,16,32,62,128 };
        int[] cleared=clearer(ref toclear,ref filter);
        for(int i = 0;i < cleared.Length; i++)
        {
            Console.Write(" "+ cleared[i]);
        }
        Console.WriteLine();
        Console.WriteLine("нажмите любую кнопку");
        Console.ReadKey(true);
        here:


        /*Задание 4
         * Создайте класс «Веб-сайт». Необходимо хранить в 
полях класса: название сайта, путь к сайту, описание 
сайта, ip адрес сайта. Реализуйте методы класса для ввода 
данных, вывода данных, реализуйте доступ к отдельным 
полям через методы класса. */
        Console.Clear();
        Console.WriteLine("Задание №" + tasknumber++);
        Console.WriteLine("Создайте класс «Веб-сайт». Необходимо хранить в \r\nполях класса: название сайта, путь к сайту, описание \r\nсайта, ip адрес сайта. Реализуйте методы класса для ввода \r\nданных, вывода данных, реализуйте доступ к отдельным \r\nполям через методы класса.");
        WebSite site = new WebSite("ютуб", "https://www.youtube.com", "просмотр видеолент", new IPAddress(new byte[] { 95, 25, 55, 242 }));
        site.Show();
        Console.WriteLine();
        Console.WriteLine("нажмите любую кнопку");
        Console.ReadKey(true);
    }
    private static void Sqare(int length,char symbol)
    {
        for (int i = 0; i < length; i++)
        {
            for(int j = 0; j < length; j++)
            {
                Console.Write(" "+symbol );
            }
            Console.WriteLine();
        }
    }
    private static bool Palindrome(string str)
    {
        bool flag = true;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }
    private static int[] clearer(ref int[] cleared,ref int[] filter)
    {
        int size = 0;
        for(int i = 0;i < cleared.Length; i++)
        {
            for(int j = 0; j < filter.Length; j++)
            {
                if (cleared[i] == filter[j])
                {
                    size++;
                    break;
                }
            }
        }
        int[] result = new int[cleared.Length-size];
        bool flag;
        int place = 0;
        for (int i = 0; i < cleared.Length; i++)
        {
            flag = true;
            for (int j = 0; j < filter.Length; j++)
            {
                if (cleared[i] == filter[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag) result[place++] = cleared[i];
        }
        return result;
    }
    class WebSite
    {
        string Name { get; set; }
        string Path { get; set; }
        string Opisanie { get; set; }
        IPAddress IP { get; set; }
        public void Show()
        {
            Console.WriteLine("Name - "+Name);
            Console.WriteLine("Path - "+Path);
            Console.WriteLine("Описание сайта - " + Opisanie);
            Console.WriteLine("IO - "+ IP.ToString());
        }
        public WebSite(string Name,string Path,string Opisanie,IPAddress IP)
        {
            this.Name = Name;
            this.Path = Path;
            this.Opisanie = Opisanie;
            this.IP = IP;
        }
    }
}