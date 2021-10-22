using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onearraytreestacks
{
    public class Program
    {

        public class KStack
        {
            public int[] arr; 
            public int[] top; 
            public int[] next; 
            public int n, k;
            public int free; 

            
            public KStack(int k1, int n1)
            {
                
                k = k1;
                n = n1;
                arr = new int[n];
                top = new int[k];
                next = new int[n];

                
                for (int i = 0; i < k; i++)
                {
                    top[i] = -1;
                }

                
                free = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    next[i] = i + 1;
                }
                next[n - 1] = -1;
            }

             
            public virtual bool Full
            {
                get
                {
                    return (free == -1);
                }
            }

            
            public virtual void push(int item, int sn)
            {
                
                if (Full)
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }

                int i = free; 

                
                free = next[i];

                
                next[i] = top[sn];
                top[sn] = i;

                
                arr[i] = item;
            }

            
            public virtual int pop(int sn)
            {
                 
                if (isEmpty(sn))
                {
                    Console.WriteLine("Stack Underflow");
                    return int.MaxValue;
                }

                
                int i = top[sn];

                top[sn] = next[i]; 

                
                next[i] = free;
                free = i;

                
                return arr[i];
            }

            
            public virtual bool isEmpty(int sn)
            {
                return (top[sn] == -1);
            }

        }

        public static void Main(string[] args)
        {
            int k = 3, n = 10;

            KStack ks = new KStack(k, n);

            //1.stack için eklenen elemanlar
            ks.push(15, 0);
            ks.push(45, 0);
            ks.push(13, 0);

            //2.Stack için eklenen elemanlar
            ks.push(17, 1);
            ks.push(49, 1);
            ks.push(39, 1);

            //3.Stack için eklenen elemanlar
            ks.push(11, 2);
            ks.push(9, 2);
            ks.push(7, 2);


            Console.WriteLine("3.Stackten atılacak öğe " + ks.pop(2));
            Console.WriteLine("2.Stackten atılacak öğe " + ks.pop(1));
            Console.WriteLine("1.Stackten atılacak öğe " + ks.pop(0));
            Console.WriteLine("Dizideki 1.eleman " + ks.arr[0]);
            Console.WriteLine("Dizideki 4.eleman " + ks.arr[3]);
            
            Console.ReadKey();
        }
    }
}
