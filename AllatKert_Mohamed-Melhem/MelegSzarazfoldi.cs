using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatKert_Mohamed_Melhem
{
	internal class MelegSzarazfoldi
	{
		string elohely;
		string nev;
		string szin;
		int sebbeseg;

		public MelegSzarazfoldi(string nev, string szin, int sebbeseg)
		{
			this.elohely = "Meleg Száraz Föld";
			this.nev = nev;
			this.szin = szin;
			this.sebbeseg = sebbeseg;
		}

		public string Elohely { get => elohely; set => elohely = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Szin { get => szin; set => szin = value; }
		public int Sebbeseg { get => sebbeseg; set => sebbeseg = value; }


		public override string? ToString()
		{
			return $"Elohely : {elohely} Nev : {nev} Szin : {szin} Sebbseg : {sebbeseg}";
		}
	}
}
