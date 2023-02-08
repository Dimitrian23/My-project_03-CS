// Задача_№35 Подсчитать сумму цифр в числе. Сделать подпрограмму.

int N;
int d0,d1,d2,d3,d4,d5;
int sum;

     System.Console.Write("Введите пожалуйста число (от 10 до 1000000)__:");
            N=Convert.ToInt32(Console.ReadLine());

while(N<=9)
{
    System.Console.WriteLine("__E_R_R_O_R__");
     System.Console.Write("Введёное число должно быть не меньше (9) и не больше (1000000):");
     System.Console.Write("Введите пожалуйста число__:");
            N=Convert.ToInt32(Console.ReadLine());
}
while(N>=1000000)
{
    System.Console.WriteLine("__E_R_R_O_R__");
     System.Console.Write("Введённое число должно быть не больше (1000000) и не меньше (9):");
     System.Console.Write("Введите пожалуйста число__:");
            N=Convert.ToInt32(Console.ReadLine());
}

int n=0;          
n=n+N;  
           

int Proverka(int N)
{    
    int counter=0;
       while(N!=0)
            {
             counter++;
             N/=10;
            }
       return counter;

}
System.Console.WriteLine($"Колличество цифр в введёном числе__{Proverka (N)}");




if(Proverka(N)==2)
{
d0=n%10;
d1=n/10%10;
System.Console.WriteLine($"_{d1}_{d0}_");
sum=d1+d0;
System.Console.WriteLine($"Сумма всех цифр в числе {n} равна {d1}+{d0}={sum})");
}

if(Proverka(N)==3)
{
d0=N%10;
d1=N/10%10;
d2=N/100%10;
System.Console.WriteLine($"_{d2}_{d1}_{d0}_");
sum=d2+d1+d0;
System.Console.WriteLine($"Сумма всех цифр в числе {n} равна ({d2}+{d1}+{d0}={sum})");
}

if(Proverka(N)==4)
{
d0=N%10;
d1=N/10%10;
d2=N/100%10;
d3=N/1000%10;
System.Console.WriteLine($"_{d3}_{d2}_{d1}_{d0}_");
sum=d3+d2+d1+d0;
System.Console.WriteLine($"Сумма всех цифр в числе {n} равна ({d3}+{d2}+{d1}+{d0}={sum})");
}

if(Proverka(N)==5)
{
d0=N%10;
d1=N/10%10;
d2=N/100%10;
d3=N/1000%10;
d4=N/10000%10;
System.Console.WriteLine($"{d4}_{d3}_{d2}_{d1}_{d0}_");
sum=d4+d3+d2+d1+d0;
System.Console.WriteLine($"Сумма всех цифр в числе {n} равна ({d4}+{d3}+{d2}+{d1}+{d0}={sum})");
}

if(Proverka(N)==6)
{
d0=N%10;
d1=N/10%10;
d2=N/100%10;
d3=N/1000%10;
d4=N/10000%10;
d5=N/100000%10;
System.Console.WriteLine($"{d5}_{d4}_{d3}_{d2}_{d1}_{d0}_");
sum=d5+d4+d3+d2+d1+d0;
System.Console.WriteLine($"Сумма всех цифр в числе {n} равна ({d5}+{d4}+{d3}+{d2}+{d1}+{d0}={sum})");
}






