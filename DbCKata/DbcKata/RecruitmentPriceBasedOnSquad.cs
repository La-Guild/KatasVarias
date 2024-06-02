namespace DbcKata;

public class RecruitmentPriceBasedOnSquad
{
    Squad forSquad;

    public RecruitmentPriceBasedOnSquad(Squad forSquad)
    {
        this.forSquad = forSquad;
    }

    private Positive RecruitmentPrice()
    {
        var result = 5;

        EnsurePriceValidity(result);
        return result;
    }

    public static implicit operator Positive(RecruitmentPriceBasedOnSquad sadfgkhjn)
    {
        return sadfgkhjn.RecruitmentPrice();
    }

    static void EnsurePriceValidity(int result)
    {
        if (result < 3 || result > 50)
            throw new NotSupportedException("El precio de reclutamiento no es válido");
    }
}