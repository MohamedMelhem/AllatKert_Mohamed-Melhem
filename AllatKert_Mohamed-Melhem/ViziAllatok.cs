using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatKert_Mohamed_Melhem
{
	internal class ViziAllatok
	{
		string elohely;
		string nev;
		string szin;
		int sebbeseg;

		public ViziAllatok( string nev, string szin, int sebbeseg)
		{
			this.elohely = "Viz";
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
