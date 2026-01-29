using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Timeline
	{
		private string date;
		private string leirasEsemeny;

		public Timeline(string date, string leirasEsemeny)
		{
			this.date = date;
			this.leirasEsemeny = leirasEsemeny;
		}

		public string Date { get => date; set => date = value; }
		public string LeirasEsemeny { get => leirasEsemeny; set => leirasEsemeny = value; }
	}
}
