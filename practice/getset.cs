using System;


public class Demo
{
    private int Val {get; set;} // 需要声明成public 
}

class Test
{
    public static void Main()
    {
	Demo d = new Demo();
	Console.WriteLine("d.Val:{0}", d.Val);
    }
}

