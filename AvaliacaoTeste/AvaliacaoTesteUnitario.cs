using CalculoNota;

namespace AvaliacaoTeste
{
    public class AvaliacaoTesteUnitario
    {
        [Fact]
        public void NotaAbaixoDeTresResultaEmReprovacaoPorMedia()
        {
            // Arrange  
            var nota1 = 2.9;
            var nota2 = 3.0;
            var faltas = 6;
            var cargaHoraria = 48;
            var resultadoEsperado = "Reprovado por Média.";
            // Act  

            var resultado = Avaliacao.Avalia(nota1, nota2, faltas, cargaHoraria);

            //Assert  
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
