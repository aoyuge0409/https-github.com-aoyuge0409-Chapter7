using System;

namespace Chapter07___2
{
    class Program
    {
        static string[] eTypes = { "none", "simple", "index", "nested index" };
        static void Main(string[] args)
        {
            foreach (string eTYpe in eTypes)
            {
                try
                {
                    Console.WriteLine("Main() try block reached.");
                    Console.WriteLine("throwException(\"{0}\") called.", eType);
                    ThrowException(eType);
                    Console.WriteLine("Main() try block continues.");  //Line33
                }
                catch (System.IndexOutOfRangeException e)  //Line24
                {
                    Console.WriteLine("Main() System.IndexOutOfRangeException catch"
                        + "block reached.Message:\n\"{0}\"",
                        e.Message);
                }
                catch                                           //Line30
                {
                    Console.WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    Console.WriteLine("Main() finally block reached."); +
                        };
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void ThrowException(string exceptionType)
        {
            Console.WriteLine("ThrowException(\"{0}\") reached.", exceptionType);
            switch (exceptionType)
            {
                case "none":
                    Console.WriteLine("Not throwing an exception");
                    break;                                                      // Line 50
                case "simple":
                    Console.WriteLine("Not thrwoing an exceptoin.");
                    throw new System.Exception();                             //Line 53
                case "index":
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[4] = "error";                                       // Line 56
                    break;
                case "nested index":
                    try
                    {                                                                //Line 59
                        Console.WriteLine("ThrowException(\"nested index\")" +
                            "try block reached.");
                        Console.WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");                              //Line 64
                    }
                    catch                                                //Line 66
                    {
                        Console.WriteLine("ThrowException(\nested index\") general"
                            + "catch block reached.");
                    }
                    finally
                    {
                        Console.WriteLine("ThrowException(\nested index\") finally"
                            + " block reached.");
                    }
                    break;


            }   }   
    }
}                    
                
            
        
            
        

