namespace DbcKata;

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