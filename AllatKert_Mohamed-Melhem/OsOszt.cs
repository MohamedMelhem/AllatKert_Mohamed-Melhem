using System;
using System.Collections.Generic;

public class Allat
{
	public string Nev { get; set; }
	public string Szín { get; set; }
	public int sebsseg { get; set; }

	public Allat(string nev, string szín, int eletkor)
	{
		Nev = nev;
		Szín = szín;
		sebsseg = eletkor;
	}

	public virtual void Jellemzo()
	{
		Console.WriteLine($"Állat neve: {Nev}, Szín: {Szín}, Életkor: {sebsseg} év.");
	}
}
