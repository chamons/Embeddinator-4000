using System;
namespace TestLib
{
	public class MyClass
	{
		public int this[int i] { get { return 42; } }
		public int this[string i] { get { return 42; } }
	}
}
