// Зфдача_№34 Определить количество цифр в числе. Сделать подпрограмму.

int S;

          System.Console.Write("Введите пожалуйста число__:");
               S=Convert.ToInt32(Console.ReadLine());
if(S<=0)
  {
          System.Console.WriteLine("_______________E_R_R_O_R_______________");
          System.Console.WriteLine("Введите многозначное число больше нуля!");
  }
else
  {
          System.Console.WriteLine($"Количество цифр в числе____{CounterDigits(S)}");

int CounterDigits(int S)
 {
   int counter=0;
   while(S!=0)
      {
       counter++;
       S/=10;
      }
  return counter;
 }
  }   
