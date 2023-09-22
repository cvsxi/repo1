using System.Threading;

namespace thread
{
    

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
           
            
            
            for (int i = 0; i < 6; i++)
            {
                
                Thread thread = new(JustPace.justpace);
                thread.Name = $"поток {i}";
                thread.Start();

            }
         
        }
     
        
       
    }
}