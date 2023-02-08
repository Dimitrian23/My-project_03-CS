// Задача_№36 Написать программу вычисления произведения чисел от 1 до N

int i=1;
int i2=2;
int N;
int S=0;

          System.Console.Write("Введите пожалуйста число для переменной(N):");
               N=Convert.ToInt32(Console.ReadLine());
while(N<=0)
     {     
          System.Console.WriteLine("___Error___Вы вводите неверное значение!");  
          System.Console.WriteLine(" Число для переменной N должно быть >1");  
          System.Console.Write("Введите повторно число для переменной(N):");
               N=Convert.ToInt32(Console.ReadLine());
     }

          System.Console.WriteLine($"Произведение всех чисел от (1) до ({N})");

while(i2<=N)
     {

S=i*i2;
          System.Console.WriteLine($"Произведение числа ------> {i} на {i2} это {S}");
i++;
i2++;
    }

  if(i<=N)  
    {   
i2--;
S=i*i2;
        System.Console.WriteLine($"Произведение числа ------> {i} на {i2} это {S}");
    }












  
// while(i<=N)
//      {
     
//       S=i*i2;   
//        System.Console.WriteLine($"Произведение числа ------> {i} на {i2} это {S}");
//       i=i+1;
//       i2=i2+1;
      
//      }



// for(int i=1;i<=N;i++)    
//      {  
       

//         System.Console.WriteLine($"Произведение числа ------> {i} на {i} это {i}");
//      }












