using System;

public class CalcTwr
{
    public static void Main(string[] args)
    {

    double[] returns = 
    {
        0.0,
        0.0,
        -0.006253657,
        -0.00361612,
        -0.004777986,
        -0.026842209,
        0.000095331,
        0.0,
        0.0,
        -0.004793408
    };

    double twr = CalculateTwr(returns);

    Console.WriteLine($"TWR (decimal) = {twr}");
    Console.WriteLine($"TWR (percent) = {twr * 100.0:F4}%");
    }

        public static double CalculateTwr(double[] dailyReturns)
    {
        double product = 1.0;

        foreach (double r in dailyReturns)
        {
            product *= (1.0 + r);
        }

        return product - 1.0;
    }
}

/*
c) Hvilken tilnærming er mest effektiv?

Hvilken løsning som er mest effektiv kommer an på hvor beregningen skal gjøres.

Hvis dataene allerede ligger i databasen, vil T-SQL ofte være mest effektivt, siden man slipper å hente data ut av databasen før man regner. 
Det passer spesielt godt hvis man skal beregne TWR for mange samtidig.

Hvis beregningen er en del av selve applikasjonen, vil C# være bedre. 
Der kan man bruke decimal, som gir bedre presisjon enn float i SQL, og det er enklere å teste og kontrollere logikken.

Så egentlig avhenger det av systemet og hva som er viktigst, ytelse på store datamengder eller presisjon og kontroll i applikasjonen.

Jeg ville gjort bulk-beregninger i SQL nær dataene, men hatt logikken/testene i C#.
*/