using System;

class Problem10
{
    //  D------------C
    //  |            |
    //  |            |
    //  |            |
    //  A------------B
    //
    //  y
    //  ^
    //  |
    //  |----> x

    static bool CheckIfIsInARectangle(float xA, float yA, float xC, float yC, float x, float y)
    {
        if (x > xA && y > yA && x < xC && y < yC)
        {
            return true;
        }
        return false;
    }
    static bool CheckIfPointIsInsideARANDOMCircle(float x, float y, float xO, float yO, float r)
    {
        double c = (Math.Pow(x - xO, 2) + Math.Pow(y - yO, 2));
        if (c <= r)
        {
            return true;

        }
        return false;
    }
    static void Main()
    {
        float x = 2f,
            y = 1.5f,
            xO = 1f,
            yO = 1f,
            yC = 1f,
            xA = -1f,
            xC = 5f,
            yA = -1f;
        if (!CheckIfIsInARectangle(xA, yA, xC, yC, x, y) && CheckIfPointIsInsideARANDOMCircle(x, y, xO, yO, 1.5f))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

}
