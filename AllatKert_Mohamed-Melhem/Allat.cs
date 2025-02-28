public class ViziAllatok : Allat
{
	public ViziAllatok(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()
	{
		Console.WriteLine($"Vízállat: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}

public class SzarazfoldiHideg : Allat
{
	public SzarazfoldiHideg(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()
	{
		Console.WriteLine($"Szárazföldi hideg állat: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}

public class SzarazFoldiMediterrán : Allat
{
	public SzarazFoldiMediterrán(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()
	{
		Console.WriteLine($"Szárazföldi mediterrán állat: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}

public class MelegSzarazfoldi : Allat
{
	public MelegSzarazfoldi(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()
	{
		Console.WriteLine($"Meleg szárazföldi állat: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}

public class TropusiSzarazfold : Allat
{
	public TropusiSzarazfold(string nev, string szín, int eletkor) : base(nev, szín, eletkor) { }

	public override void Jellemzo()
	{
		Console.WriteLine($"Trópusi szárazföldi állat: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}
