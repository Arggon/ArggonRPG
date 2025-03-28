namespace ArggonRPG.Domain.Services;

public static class DamageCalculator
{
    public static int CalcularDañoFinal(int dañoBase, float multiplicador = 1.0f)
    {
        return (int)(dañoBase * multiplicador);
    }
}