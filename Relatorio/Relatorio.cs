using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio
{
	internal class Relatorio : IDocumento
	{
		// Classe concreta que implementa o Prototype

		public string Titulo { get; set; }
		public string Conteudo { get; set; }

		public Relatorio(string titulo, string conteudo)
		{
			Titulo = titulo;
			Conteudo = conteudo;
		}

		// Implementação do método Clone
		public IDocumento Clone()
		{
			// Cria um novo objeto copiando o estado atual
			return new Relatorio(this.Titulo, this.Conteudo);
		}

		// Método para mostrar as informações do relatório
		public void MostrarInfo()
		{
			Console.WriteLine($"Relatório: {Titulo}\nConteúdo: {Conteudo}\n");
		}
	}
}
