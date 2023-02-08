// Задача_№33 Возведите число А в натуральную степень B используя цикл

int A,B,S=2;
double sum=0;
  
       System.Console.Write("Введите число для возведения в степень:___");
            A=Convert.ToInt32(Console.ReadLine());     
       System.Console.Write("Укажите до какой степени нужно возводить ранее заданное число!?:___");
            B=Convert.ToInt32(Console.ReadLine());
       System.Console.WriteLine($"Внимание! Возвожу число ({A}) (от 2 до {B} степени!)");
while(S<=B)
  {
 sum=Math.Pow(A,S);
       System.Console.WriteLine($" {A} в степени {S} равно {sum}" );
S++;
  }








