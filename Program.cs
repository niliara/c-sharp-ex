class Program
{
	public static void Main(string[] args)
	{
		ex1();
		Console.ReadLine();

		ex2();
		Console.ReadLine();

		Calculadora();

		DNI();

		tria();
		Console.ReadLine();

		chess();
		Console.ReadLine();

		felizNavidad();
	}



	public static void ex1()
	{
		float[] grades = new float[3];

		for (int i=0; i<grades.Count(); i++){
			Console.Write("Escribe nota {0}: ", i+1);
			grades[i] = float.Parse(Console.ReadLine());
		}

		float gradesMean = grades.Sum() / grades.Count();
		Console.WriteLine($"La nota media es {gradesMean}");

		if (gradesMean < 5){
			Console.WriteLine("Has suspendido!");
		} else {
			Console.WriteLine("Has aprobado!");
		}
	}
	

	public static void ex2()
	{
		int n;
		int evenCount = 0, oddCount = 0;

		do {
			Console.Write("Dame un numero: ");
			n = int.Parse(Console.ReadLine());

			if (n%2 == 0) {
				evenCount++;
			} else {
				oddCount++;
			}
		} while (n != 0);

		Console.WriteLine($"Introduciste {evenCount} numeros pares y {oddCount} numeros inpares");
	}


	public static void Calculadora()
	{
		float result = 0;
		string ans;
		bool ongoing = true;


		while (ongoing){
			Console.Write("introduce numero 1: "); float number1 = float.Parse(Console.ReadLine());
			Console.Write("introduce numero 2: "); float number2 = float.Parse(Console.ReadLine());

			Console.Write("elige operador: ");
			char op = char.Parse(Console.ReadLine());

			switch (op) {
				case '+':
					result = number1 + number2;
					break;
				case '-':
					result = number1 - number2;
					break;
				case '/':
					result = number1 / number2;
					break;
				case '*':
					result = number1 * number2;
					break;
			}

			Console.WriteLine("El resultado de {0} {2} {1} es {3}", number1, number2, op, result);

			do {
			Console.Write("Quieres volverlo a hacer? (Y/N): ");
			ans = Console.ReadLine().ToLower();
			} while (ans != "y" && ans != "n");

			if (ans == "n"){
				ongoing = false;
			}
		}
	}

	public static void DNI()
	{
		int dniNumber;
		do {
		Console.Write("Numero del documento: ");
		dniNumber = int.Parse(Console.ReadLine());
		} while (dniNumber/23 != 3);
	}

	public static void tria()
	{
		for (int i = 0; i<15; i++)
		{
			Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
		}
	}

	public static void chess()
	{
		for (int i=0; i<4; i++){
			for (int c=0; c<4; c++){
				Console.Write("B");
				Console.Write("N");
			}                         
			Console.WriteLine();      

			for (int c=0; c<4; c++){  
				Console.Write("N");
				Console.Write("B");
			}
			Console.WriteLine();
		}
	}





	public static void felizNavidad()
	{
		Console.WriteLine("\n\n       *** feliz navidad ***");
		for (int i = 0; i<15; i++)
		{
			Console.Write(String.Concat(Enumerable.Repeat(" ",10+ ((15-i)/2))));
			Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
		}
	}
}
