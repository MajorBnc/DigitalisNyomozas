using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Evidence
	{
		private int id;
		private string tipus;
		private string leiras;
		private int megbizhatosagErtek;

		public Evidence(int id, string tipus, string leiras, int megbizhatosagErtek)
		{
			this.id = id;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagErtek = megbizhatosagErtek;
		}

		public int Id { get => id; set => id = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int MegbizhatosagErtek { get => megbizhatosagErtek; set => megbizhatosagErtek = value; }
	}
}
