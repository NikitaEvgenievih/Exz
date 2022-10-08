using ConsoleApp0810;
//try
//{
//    Console.WriteLine("Введите первое число");
//    int number1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Введите второе число");
//    int number2 = int.Parse(Console.ReadLine());


//    int result = number1 / number2;
//    Console.WriteLine("Результат деления: " + result);
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine("На ноль нельзя делить ._.");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Введено некорректное число!");
//}
//catch(Exception)
//{
//    Console.WriteLine("Неизвестная ошибка");
//}

//Human human = new Human
//{
//    Name = "Nikita",
//    Age = 16
//};

Mobila mobila1 = new Mobila
{
    Nomer = "+380993510660",
    Batarea = 10,
    SimKarta = true
};

try
{
    mobila1.Call(mobila1.Nomer);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Заряд батареи равен 0!");
}
catch(NotImplementedException ex)
{
    Console.WriteLine("В вашем телефоне нету симкарты!");
}
catch (Exception)
{
    Console.WriteLine("Номер введен неверно!");
}
