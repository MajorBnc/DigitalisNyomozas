using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Suspect
	{
		private Person gyanusitott;
		private string vallomas;
		private string vallomasDate;

		public Suspect(Person gyanusitott, string vallomas, string vallomasDate)
		{
			this.gyanusitott = gyanusitott;
			this.vallomas = vallomas;
			this.vallomasDate = vallomasDate;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public string VallomasDate { get => vallomasDate; set => vallomasDate = value; }
		internal Person Gyanusitott { get => gyanusitott; set => gyanusitott = value; }
	}
}
