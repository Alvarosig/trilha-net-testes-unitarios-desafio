using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {

        // Arrange
        string texto = "Matrix";
        int resultadoEsperado = 6;

        // Act
        int resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        bool resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
