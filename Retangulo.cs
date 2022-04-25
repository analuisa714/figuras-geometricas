public class Retangulo 
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Perimetro { get => (Base + Altura) * 2; } 
    public double Area { get => Base * Altura; } 
    public Retangulo(double _base, double altura)
    {
        Base = _base;
        Altura = altura;
    }
}