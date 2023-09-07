using System;


namespace Firstdz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string g = "Мир Труд Май";
            string z = @"Мир
                Труд
                    Май";
            Console.WriteLine("Задание номер 1:");
            Console.Write("Часть a = ");
            Console.WriteLine(g);
            Console.Write("Часть b = ");
            Console.WriteLine(z);
            Console.WriteLine("/////////////////////////");




            Console.WriteLine("Задание номер 2:");
            Console.Write("Введите первое число = ");
            string num1 = Console.ReadLine();
            Console.Write("Введите второе число = ");
            string num2 = Console.ReadLine();
            (num1, num2) = (num2, num1);
            Console.WriteLine($"Первая переменная = {num1}");
            Console.WriteLine($"Вторая переменная = {num2}");
            Console.WriteLine("////////////////////////");



            Console.WriteLine("Задание номер 3:");
            Console.Write("Введите Радиус = ");
            string v = Console.ReadLine();
            double R = Convert.ToDouble(v);
            double S, l;
            l = 2 * Math.PI * R;
            S = Math.PI * R * R;
            Console.WriteLine("Длина окружности = " + l);
            Console.WriteLine("Площадь круга = " + S);
            Console.WriteLine("///////////////////////");



            Console.WriteLine("Задание номер 4: ");
            double x, cos;
            Console.Write("Введите угол х = ");
            x = Convert.ToDouble(Console.ReadLine());
            cos = Math.Cos(x);
            Console.WriteLine($"y = {cos} в радианах");
            Console.WriteLine("///////////////////////");




            Console.WriteLine("Задание номер 6: ");
            Console.WriteLine("Часть а:");
            Console.Write("Введите число а = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            int e;
            e = a;
            a = b;
            b = c;
            c = e;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");



            Console.WriteLine("Часть b:");
            Console.Write("Введите число а = ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b = ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c = ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            int e2;

            e2 = a2;
            a2 = c2;
            c2 = b2;
            b2 = e2;
            Console.WriteLine($"a = {a2}");
            Console.WriteLine($"b = {b2}");
            Console.WriteLine($"c = {c2}");
            Console.WriteLine("///////////////////////");




            Console.WriteLine("Задание номер 7: ");
            Random rnd = new();
            int firstvalue = rnd.Next();
            Console.WriteLine(firstvalue);
            int secondvalue = rnd.Next();
            Console.WriteLine(secondvalue);
            int thirdvalue = rnd.Next();
            Console.WriteLine(thirdvalue);
            int fourthvalue = rnd.Next();
            Console.WriteLine(fourthvalue);
            Console.WriteLine("///////////////////////");



            Console.WriteLine("Задание номер 8: ");
            Console.Write("Введите трёхзначное число =");
            string num = Console.ReadLine();
            Console.WriteLine(num[2] + num.Remove(2));
            Console.WriteLine("///////////////////////");
            Console.WriteLine("Задание номер 9: ");




            double candyprice, cookieprice, appleprice, candy, cookie, apple, allprice;
            Console.Write("Введите стоимость конфет за киллограм = ");
            candyprice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость печенья за киллограм = ");
            cookieprice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость яблок за киллограм = ");
            appleprice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите, сколько киллограм конфет вы хотите купить = ");
            candy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите, сколько киллограм печенья вы хотите купить = ");
            cookie = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите, сколько киллограм яблок вы хотите купить = ");
            apple = Convert.ToDouble(Console.ReadLine());
            allprice = apple * appleprice + candy * candyprice + cookie * cookieprice;
            Console.Write($"Стоимость всей покупки = {allprice}");
        }
    }
}