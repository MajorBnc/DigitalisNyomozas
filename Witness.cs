using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Witness
	{
		private Person tanu;
		private string vallomasSzovege;
		private string vallomasDate;

		public Witness(Person tanu, string vallomasSzovege, string vallomasDate)
		{
			this.tanu = tanu;
			this.vallomasSzovege = vallomasSzovege;
			this.vallomasDate = vallomasDate;
		}

		public string VallomasSzovege { get => vallomasSzovege; set => vallomasSzovege = value; }
		public string VallomasDate { get => vallomasDate; set => vallomasDate = value; }
		internal Person Tanu { get => tanu; set => tanu = value; }
	}
}
