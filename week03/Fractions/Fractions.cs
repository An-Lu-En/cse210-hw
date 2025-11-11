public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor 1: No parameters → default fraction = 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor 2: One parameter → top number, bottom = 1
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constructor 3: Two parameters → top and bottom
    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    // Getter and Setter for top
    public int GetTop()
    {
        return numerator;
    }

    public void SetTop(int top)
    {
        numerator = top;
    }

    // Getter and Setter for bottom
    public int GetBottom()
    {
        return denominator;
    }

    public void SetBottom(int bottom)
    {
        denominator = bottom;
    }

    // Return "3/4"
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Return decimal value e.g 3/4 = 0.75
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
