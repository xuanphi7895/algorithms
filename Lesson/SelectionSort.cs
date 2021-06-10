using System.Text;
using System;
namespace Lesson
{
    public class SelectionSort
    {
        public void NhapDaySo(int[] a, int n)
         {
            for (int i = 0; i < n ; i ++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void XuatDaySo(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write( " a[" + i + "]= " +  a[i] + " ");
            }
            Console.WriteLine(" ");
        }
       public void SapXep(int[] a, int n)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[min] > a[j])
                        {
                            min = j;
                        }
                       
                    }
                    if (min != i)
                    {
                        int x = a[min];
                        a[min] = a[i];
                        a[i] = x;
                   }
                   Console.Write( " a[" + i + "]= " +  a[i] + " ");
                }
            }
            catch (System.Exception)
            {
                
                throw;
                
            }
        }
    }
}