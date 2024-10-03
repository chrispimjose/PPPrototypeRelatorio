namespace Relatorio
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Classe principal que usa o Prototype

			// Criação de um relatório original
			Relatorio relatorioOriginal = new Relatorio("Relatório Mensal", "Conteúdo do relatório mensal.");
			relatorioOriginal.MostrarInfo();

			// Clonando o relatório original para criar uma cópia
			Relatorio relatorioClone = (Relatorio)relatorioOriginal.Clone();
			relatorioClone.Titulo = "Relatório Semanal";  // Modificando o título do clone
			relatorioClone.Conteudo = "Conteúdo do relatório semanal.";  // Modificando o conteúdo do clone
			relatorioClone.MostrarInfo();

			// Exibindo o relatório original novamente para verificar se não foi alterado
			relatorioOriginal.MostrarInfo();

		}
	}
}
