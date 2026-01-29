using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseStatus
	{
		private string actualStatusz;

		public CaseStatus(string actualStatusz)
		{
			this.actualStatusz = actualStatusz;
		}

		public string ActualStatusz { get => actualStatusz; set => actualStatusz = value; }
	}
}
