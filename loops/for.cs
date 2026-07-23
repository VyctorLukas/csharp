using System;

class loop_for
{
    public static void Main()
    {
        for (int i = 0; i < 20; i++)
        {
            if (i == 10)
            {
                break;
            }
            if (i % 2 == 0)
            {
                Console.Write("{0} ", i);
                continue;
            }
        }
    }
}