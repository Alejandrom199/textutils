using Xunit;
using TextUtils;

namespace TextUtils.Tests;

public class StringHelperTests
{
    [Fact]
    public void Reverse_TextoNormal_InvierteCorrectamente()
    {
        var resultado = StringHelper.Reverse("hola");
        Assert.Equal("aloh", resultado);
    }

    [Fact]
    public void Reverse_TextoVacio_RetornaVacio()
    {
        var resultado = StringHelper.Reverse("");
        Assert.Equal("", resultado);
    }

    [Theory]
    [InlineData("hola mundo", 2)]
    [InlineData("uno dos tres", 3)]
    [InlineData("", 0)]
    [InlineData("  espacios   multiples  ", 2)]
    public void CountWords_VariosCasos_CuentaCorrectamente(
        string input, int esperado)
    {
        var resultado = StringHelper.CountWords(input);
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ToSlug_TextoConEspacios_GeneraSlug()
    {
        var resultado = StringHelper.ToSlug("Hola Mundo");
        Assert.Equal("hola-mundo", resultado);
    }

    [Theory]
    [InlineData("anita lava la tina", true)]
    [InlineData("reconocer", true)]
    [InlineData("hola", false)]
    public void IsPalindrome_VariosCasos_DetectaCorrectamente(
        string input, bool esperado)
    {
        var resultado = StringHelper.IsPalindrome(input);
        Assert.Equal(esperado, resultado);
    }
}