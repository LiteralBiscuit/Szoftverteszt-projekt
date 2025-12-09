namespace ConsoleApp1.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Mauto mau = new();
        mau.Sebesseg = 120;
        Assert.IsType<int>(mau.Sebesseg);
    }

    [Fact]
    public void Test2()
    {
        Mauto mau1 = new();
        Mauto mau2 = new();
        Assert.NotSame(mau1, mau2);
    }

    [Fact]
    public void Test3()
    {
        Mauto mau = new();
        string expected = "Black";
        mau.Szin = "Black";
        Assert.Matches(mau.Szin, expected);
    }

    [Fact]
    public void Test4()
    {
        Mauto mau = new();
        mau.Szin = "Black";
        Mauto mau2 = new();
        mau2.Szin = "White";
        Assert.DoesNotMatch(mau.Szin, mau2.Szin);
    }

    [Fact]
    public void Test5()
    {
        Mauto mau = new();
        mau.MozogE = true;
        Assert.True(mau.MozogE);
    }

    [Fact]
    public void Test6()
    {
        Mauto mau = new();
        mau.Marka = "Fiat";
        Assert.NotNull(mau.Marka);
    }

    [Fact]
    public void Test7()
    {
        int expected = 120;
        Mauto mau = new();
        mau.Sebesseg = 120;
        Assert.Equal(expected, mau.Sebesseg);
    }
}
