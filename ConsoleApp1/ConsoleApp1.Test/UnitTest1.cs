namespace ConsoleApp1.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Given
        Mauto mau = new();
        mau.Sebesseg = 120;

        //When

        //Then
        Assert.IsType<int>(mau.Sebesseg);
    }

    [Fact]
    public void Test2()
    {
        //Given
        Mauto mau1 = new();
        Mauto mau2 = new();

        //When

        //Then
        Assert.NotSame(mau1, mau2);
    }

    [Fact]
    public void Test3()
    {
        //Given
        Mauto mau = new();
        string expected = "Black";
        mau.Szin = "Black";

        //When

        //Then
        Assert.Matches(mau.Szin, expected);
    }

    [Fact]
    public void Test4()
    {
        //Given
        Mauto mau = new();

        //When

        //Then
        Assert.Same(mau, mau);
    }

    [Fact]
    public void Test5()
    {
        //Given
        Mauto mau = new();
        mau.Szin = "Black";

        //When

        //Then
        Assert.NotEmpty(mau.Szin);
    }
}
