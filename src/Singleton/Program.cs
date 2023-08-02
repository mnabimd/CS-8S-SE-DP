using Singleton._01;


var s1 =  SingletonObject.GetInstance();

Console.WriteLine(s1.IsDarkTheme);

s1.IsDarkTheme = true;

Console.WriteLine(s1.IsDarkTheme);