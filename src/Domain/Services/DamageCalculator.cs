namespace ArggonRPG;

public class DamageCalculator
{
    public static int CalcularDañoFinal(int dañoBase, float multiplicador = 1.0f)
    {
        return (int)(dañoBase * multiplicador);
    }
} 