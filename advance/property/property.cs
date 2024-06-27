using System;

namespace runoob
{
    public abstract class Person
    {
	public abstract string Name
	{
	    get;
	    set;
	}
	public abstract int Age 
	{
	    get;
	    set;
	}
    }

    class Student : Person
    {
	private string code = "N.A";
	private string name = "N.A";
	private int age = 0;

	public string Code
	{
	    get
	    {
		return code;	
	    }
	    set
	    {
		code = value;
	    }
	}
	public override string Name
	{
	    get
	    {
		return name;
	    }
	    set
	    {
		name = value;
	    }
	}	
	public override int Age
	{
	    get
	    {
		return age;
	    }
	    set
	    {
		age = value;
	    }
	}
	public override string ToString()
	{
	    return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
	}
    }

    class ExampleDemo 
    {
	public static void Main()
	{
	    Student s = new Student();
	    
	    s.Code = "001";
	    s.Name = "Zara";
	    s.Age = 9;
	    Console.WriteLine("Student Info:- {0}", s);
	    
	    s.Age += 1;
	    Console.WriteLine("Student Info:- {0}", s); 
		
	}
    }

}
