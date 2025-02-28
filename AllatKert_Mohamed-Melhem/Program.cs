public class Program
{
	public static void Main()
	{
		List<Allat> allatLista = new List<Allat>
		{
			new ViziAllatok("Delfin", "kék", 5),
			new ViziAllatok("Cápa", "kék", 10),
			new SzarazfoldiHideg("Medve", "fehér", 28),
			new SzarazfoldiHideg("Medve Fehér", "fehér", 23),
			new SzarazFoldiMediterrán("Kecske", "sárga", 2),
			new MelegSzarazfoldi("Kobra", "zöld", 3),
			new TropusiSzarazfold("Papagáj", "piros", 20),
			new TropusiSzarazfold("Gepard", "glamur", 31),


		};

		foreach (var allat in allatLista)
		{
			allat.Jellemzo();
		}





		Console.WriteLine("AZ Állat kert kapacitasa : 15");
        Console.WriteLine($" Jelnleg : {allatLista.Count} ");

        Console.WriteLine();
        foreach (var allat in allatLista)
		{
			Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
        }
		Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("");
        Console.WriteLine("              ↑");
        Console.WriteLine("            MAX |");
        Console.WriteLine("----------------");


        Console.WriteLine("VERSENY");

        for (int i = 0; i < 1; i++)
        {
			Thread.Sleep(4000);
			Console.Clear();
            Console.WriteLine("3");
			Thread.Sleep(400);
			Console.Clear();
			Console.WriteLine("2");
			Thread.Sleep(400);
			Console.Clear();
			Console.WriteLine("1");
			Thread.Sleep(400);
			Console.Clear();
			Console.WriteLine("Start");
			Thread.Sleep(400);
		}
        int haladas = 0;
		int haladas2 = 0;


		Random random = new Random();

		Allat allat1 = allatLista[random.Next(allatLista.Count)];
		Allat allat2 = allatLista[random.Next(allatLista.Count)];
		for (int i = 0; i < 3; i++)
		{
			Thread.Sleep(1500);
		
            Console.Clear();


			Console.SetCursorPosition(haladas += allat1.sebsseg, 0);
			Console.WriteLine(allat1.Nev);

			Console.SetCursorPosition(haladas2 += allat2.sebsseg, 1);
			Console.WriteLine(allat2.Nev);
		}


        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Verseny Vége");
		Thread.Sleep(10);
        Console.WriteLine();
        Console.WriteLine();
        if (allat1.sebsseg > allat2.sebsseg)
        {
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"{allat1.Nev} Nyerte A verseyt");
        }
        else
        {
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($" {allat2.Nev} nyerte a Versent");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Black;
		Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
		{
			Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
			Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
		{

			Console.BackgroundColor = ConsoleColor.Black;
			Console.Write(" ");
			Console.BackgroundColor = ConsoleColor.White;
			Console.Write(" ");
		}
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.Write(" ");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Write(" ");
		}
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
		{
		
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Write(" ");
			Console.BackgroundColor = ConsoleColor.White;
			Console.Write(" ");
		}
        
        Console.WriteLine();
		Console.BackgroundColor = ConsoleColor.Black;
		Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("  ");
		Console.WriteLine("  ");
		Console.WriteLine("  ");
		Console.WriteLine("  ");
		Console.WriteLine("  ");
		Console.WriteLine("  ");
		Console.WriteLine("  ");
		Console.WriteLine("  ");

		Console.BackgroundColor = ConsoleColor.Black;
	}
}