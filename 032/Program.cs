// Зфдача_№32 Найти сумму чисел от 1 до А


int N,S=0;

       System.Console.Write("Введите пожалуйста число для переменной(N):");
            N=Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=N;i++)    
     {  
        S+=i;
     }
 if(S==0)
   {
        System.Console.WriteLine("___Error___Вы вводите неверное значение!");  
        System.Console.WriteLine(" Число для переменной N должно быть >1");  
   }
   
if(S>0)
  {
        System.Console.WriteLine($"Сумма всех чисел от ------> 1 до {N} равна {S}");
  }












