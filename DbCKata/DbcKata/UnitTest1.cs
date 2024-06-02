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
    public void Execute(Purse purse, RecruitmentPriceBasedOnSquad asfas)
    {
        if (!purse.CanAfford(asfas.RecruitmentPrice()))
            throw new InvalidOperationException("No hay suficiente oro");

        purse.Afdasfs(asfas.RecruitmentPrice());
    }
}

public class Squad
{
    public NotNegative Size { get; set; }
}