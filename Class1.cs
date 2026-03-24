using System;

public class Test
{
    private int Mid;
    private int Final;

    public int MyMid {get;} = 56;
    public int MyFinal
    {
        get
        {
            return Final;
        }
        set
        {
            if ((value > 0) && (value < 100))
            {
                Final = value;
            }
            else
            {
                Final = 0;
            }
        }
    }
}