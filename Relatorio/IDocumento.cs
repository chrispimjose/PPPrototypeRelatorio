using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio
{
	internal interface IDocumento
	{
		// Interface que define o método Clone
		IDocumento Clone();
		void MostrarInfo();
	}
}
