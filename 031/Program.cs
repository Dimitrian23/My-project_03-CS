// Задача_№31 Вывести на экран кубы чисел от 1 до N

int i=1;
int N,S;

       System.Console.Write("Введите пожалуйста число для переменной(N):");
            N=Convert.ToInt32(Console.ReadLine());
            
   if(N<=0)
     {
       System.Console.WriteLine("___Error___Вы вводите неверное значение!");  
       System.Console.WriteLine(" Число для переменной N должно быть >1");  
     }
while(i<=N)
     {
      S=i*i*i;   
       System.Console.WriteLine($"Куб числа ------> {i} это {S}");
      i=i+1;
     }







