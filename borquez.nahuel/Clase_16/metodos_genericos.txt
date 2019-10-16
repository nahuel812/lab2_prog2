class Program
    {
        static void Main(string[] args)
        {
      

      		Prueba.OpTest<string>("hola", "mundo");
      
	

        Prueba p = new Prueba();
      
		//p.OpTest2<int>(5, 3);//error
 
		p.OpTest2<object>(5, 3);
      
		//p.OpTest2<string, string>("hola", "3");//error
      
		p.OpTest2<string, int>("hola", 3);

      
		Console.ReadLine();
    
	}




    class Prueba
{
      
		public static void OpTest<T>(T s, T t) where T : class
      
		{
        
			System.Console.WriteLine(s == t);
      
		}

      
		public void OpTest2<T>(T s, T t) where T : class
      
		{
        
			System.Console.WriteLine(s == t);
      
		}

      
		public void OpTest2<T, U>(T s, U t) where T : class where U : struct
      
		{
        
			//System.Console.WriteLine(s == t);//error
        
			System.Console.WriteLine(object.Equals(s, t));
      
		}

    
	}

}