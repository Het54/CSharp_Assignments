namespace ColorAndBallClass;

public class Color
{
    private int red { get; set; } = -1;
    private int green { get; set; } = -1;
    private int blue { get; set; } = -1;
    private int alpha { get; set; } = -1;


    public Color(int r, int g, int b, int a)
    {
        red = r;
        green = g;
        blue = b;
        alpha = a;
    }
    
    public Color(int r, int g, int b)
    {
        red = r;
        green = g;
        blue = b;
        alpha = 255;
    }

    public Color()
    {
        
    }

    public void SetRed(int r)
    {
        red = r;
    }

    public int GetRed()
    {

        return red;

    }
    
    public void SetGreen(int g)
    {
        green = g;
    }

    public int GetGreen()
    {

        return green;

    }
    
    public void SetBlue(int b)
    {
        blue = b;
    }

    public int GetBlue()
    {

        return blue;

    }
    
    public void SetAlpha(int a)
    {
        alpha = a;
    }

    public int GetAlpha()
    {
        return alpha;
    }

    public double GrayScale()
    {
        if (red != -1 && green != -1 && blue != -1)
        {
            double average = (red + green + blue) / 3;
            return average;
        }

        return -1;

    }
    
    

}