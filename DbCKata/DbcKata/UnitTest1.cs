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

public class RecruitmentPriceBasedOnSquad
{
    Squad forSquad;

    public RecruitmentPriceBasedOnSquad(Squad forSquad)
    {
        this.forSquad = forSquad;
    }

    public Positive RecruitmentPrice()
    {
        var result = 1;
        
        EnsurePriceValidity(result);
        return result;
    }

    static void EnsurePriceValidity(int result)
    {
        if (result < 3 || result > 50)
            throw new NotSupportedException("El precio de reclutamiento no es válido");
    }
}

public class Squad
{
    public int Size { get; set; }
}