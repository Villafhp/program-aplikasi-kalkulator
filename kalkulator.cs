using System;

class Calculator
{
    static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Pengurangan (int a, int b)
	{
		return a - b;
	}
	static int Perkalian(int a, int b)
	{
		return a * b;
	}
	static int Pembagian(int a, int b)
	{
		return a / b;
	
	
	}
	static void Main (string[] args)
	{
	    
		int a=0,b=0;
		int pilihan=0;
		
		
		
		Console.WriteLine("Aplikasi Kalkulator");
		Console.WriteLine("1. Penambahan");
		Console.WriteLine("2. Pengurangan");
		Console.WriteLine("3. Perkalian");
		Console.WriteLine("4. Pembagian");
		Console.WriteLine("Masukan pilihan = ");
		pilihan= int.Parse(Console.ReadLine());
		Console.WriteLine("\n");
		
		    if (pilihan==1)
		    {
		        Console.WriteLine("Masukan nilai a = ");
		        a=int.Parse(Console.ReadLine());
		        Console.WriteLine("Masukan nilai b = ");
		        b=int.Parse(Console.ReadLine());
		        Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
		    }
		    
		    else if (pilihan==2)
		  {
		      Console.WriteLine("Masukan nilai a = ");
		      a=int.Parse(Console.ReadLine());
		      Console.WriteLine("Masukan nilai b = ");
		      b=int.Parse(Console.ReadLine());
		      Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
		  }
		  
		    else if (pilihan==3)
		  {
		      Console.WriteLine("Masukan nilai a = ");
		      a=int.Parse(Console.ReadLine());
		      Console.WriteLine("Masukan nilai b = ");
		      b=int.Parse(Console.ReadLine());
		       Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", a, b, Perkalian(a, b));
		  }
		    else if (pilihan==4)
		  {
		      Console.WriteLine("Masukan nilai a = ");
		      a=int.Parse(Console.ReadLine());
		      Console.WriteLine("Masukan nilai b = ");
		      b=int.Parse(Console.ReadLine()); 
		      Console.WriteLine("Hasil Pembagian : {0} / {1} = {2}", a, b, Pembagian(a, b));
		  }
		    else 
		  {
		      Console.WriteLine("Maaf, Menu yang anda masukkan tidak tersedia");
		      int.Parse(Console.ReadLine());
		  
		     
		  }
		  
	
		
		
		
		
		
		
		Console.WriteLine("\nTekan sembarangan key untuk keluar");
		Console.ReadKey();
	}
	
}

