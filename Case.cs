using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Case
	{
		private int ugyazonosito;
		private string cim;
		private string leiras;
		private string allapot;
		List<Case> szemelyek;
		List<Case> bizonyitekok;

		public Case(int ugyazonosito, string cim, string leiras, string allapot, List<Case> szemelyek, List<Case> bizonyitekok)
		{
			this.ugyazonosito = ugyazonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
		}

		public int Ugyazonosito { get => ugyazonosito; set => ugyazonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		public List<Case> Szemelyek { get => szemelyek; set => szemelyek = value; }
		public List<Case> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	}
}
