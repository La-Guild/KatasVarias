namespace DbcKata;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}

public class Recruit
{
    public void Execute(Purse purse, RecruitmentPriceBasedOnSquad recruitmentPrice)
    {
        if (!purse.CanAfford(recruitmentPrice))
            throw new InvalidOperationException("No hay suficiente oro");

        purse.Afdasfs(recruitmentPrice);
    }
}

public class Squad
{
    public NotNegative Size { get; set; }
}