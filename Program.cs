//void SayHello() => Console.WriteLine("Hello");
//SayHello();
//void Game(string MyGame) => Console.WriteLine(MyGame);
//Game("GTA V");

//Console.Write("Введите свое имя: ");
//string inputName = Console.ReadLine();
//Console.Write("Введите ваш язык (русский, немецкий, английский): ");
//string language = Console.ReadLine().ToLower();
//switch (language)
//{
//    case "русский": SayHelloRu(); break;
//    case "английский": SayHelloEn(); break;
//    case "немецкий": SayHelloDe(); break;
//    default: Console.WriteLine("Язык не найден"); break;
//}
//void SayHelloRu() => Console.WriteLine($"Привет {inputName}");
//void SayHelloEn() => Console.WriteLine($"hello {inputName}");
//void SayHelloDe() => Console.WriteLine($"Guten Tag {inputName}");

//void print(string str) => Console.WriteLine(str);
//print("я могу сказать тебе о том, что я больше не буду лгать");

//void Sum(int x, int y) => Console.WriteLine(x+y);
//Sum(3,2);

//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//Sum(x, y);

//void PrintPerson(string personName = "Неизвестно", int age = 18, string vuz = "Неизвестно") => Console.WriteLine($"Имя: {personName}, возраст: {age}, вуз: {vuz}");
//PrintPerson(personName: "некто из сан-франциско", age: -94, vuz: "государственный университет некоторой забугорной губернии");
//PrintPerson();

//string GetMessage() => "Hello";
//int GetNumber() => 10;

//Console.WriteLine(GetMessage());
//Console.WriteLine(GetNumber());

//int number = Convert.ToInt32(Console.ReadLine());
//void CheckValue(int number)
//{
//    if (number < 0)
//    {
//        Console.WriteLine("Число отрицательное");
//        return;
//    }
//    Console.WriteLine("Число положительное");
//}
//CheckValue(number);

//Random random = new Random();
//int number = random.Next(1,100);
//Console.WriteLine(number);

//void ShowWelcomeMessage() => Console.WriteLine("Здравствуйте, добро пожаловать в наш консольный прогноз погоды!");
//string GetWeather()
//{
//    string[] weathers = ["солнечно", "пасмурно", "дождливо", "ураган", "переменная облачность", "переменная ясность", "штиль", "морозно", "погода еще определяется, зайдите попозже"];
//    Random random = new Random();
//    int index = random.Next(weathers.Length);
//    return weathers[index];
//}
//void ShowGoodbyeMessage() => Console.WriteLine("Хорошего дня!");

//ShowWelcomeMessage();
//Console.WriteLine($"Сегодня {GetWeather()}");
//ShowGoodbyeMessage();

//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}
//Console.WriteLine(Factorial(5));