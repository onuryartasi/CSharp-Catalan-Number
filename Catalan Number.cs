
using System;
namespace Catala_Number
{
    class MainClass
    {
   
        public static int KatalanSayisi(int n)
		{ int ans = 0;
            
          
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (n == 1) { return 1; }
            {
                    ans += KatalanSayisi(i) * KatalanSayisi(n - i - 1);
            }
            


            return ans;

        }

		
			
		public static void Main(string[] args)
        {
           
            Console.WriteLine(KatalanSayisi(10));
            

            Console.ReadLine();
		}
	}
}

