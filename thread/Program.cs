using System.Threading;

namespace thread
{
    

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
           
            
            int x = 0;
            for (int i = 0; i < 6; i++)
            {
                
                Thread thread = new(JustPace.justpace);
                thread.Name = $"поток {i}";
                thread.Start();

            }
         
        }
     
        
       
    }
}