namespace DbcKata;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}

public class asfasfsafas
{
    public void Recruit()
    {
        if(Coins < RecruitmentPrice)
            throw new InvalidOperationException("No hay suficiente oro");
    }

    public int Coins { get; set; }
    public int RecruitmentPrice { get; set; }
}