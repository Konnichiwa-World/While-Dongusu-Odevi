using System;
namespace whilee
{    class Programmm
    {        public static void Main(string[] args)
        {System.Console.WriteLine("Lütfen bir sayi giriniz:");
            Int32 x =Int32.Parse(Console.ReadLine());
        Int32 a=1;System.Console.WriteLine("while döngüsü üçgeni");
       while(a<=x){ Int32 b=1;                                    //while döngüsü
while(b<=a){System.Console.Write("#");b++;}
System.Console.WriteLine("");
      a++;}    
      System.Console.WriteLine(" for döngüsü üçgeni");
      Int32 d, c;                                                 //for döngüsü
for(d=1;d<=x;d++){                                                
      for(c=1;c<=d;c++){
System.Console.Write("#");}
System.Console.WriteLine("");
      }
      System.Console.WriteLine(" if+switch döngüsü üçgeni");
      
      if(x<=5){                                                   //if+switch
switch(x){
      case 1: System.Console.WriteLine("#");
      break;
      case 2: System.Console.WriteLine("#\n##");
      break;
      case 3: System.Console.WriteLine("#\n##\n###");
      break;
      case 4: System.Console.WriteLine("#\n##\n###\n####");
      break;
      case 5: System.Console.WriteLine("#\n##\n###\n####\n#####");
      break;
}}
else {
      System.Console.WriteLine("elimizde kalmadı, lütfen 5e kadar yazınız.");}}
      }}


      