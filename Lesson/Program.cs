using System;
using System.Text;
 
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SelectionSort SelectionSort = new SelectionSort();
           Console.WriteLine("Vui lòng nhập dãy số từ bàn phím!");
            int _daySo = int.Parse(Console.ReadLine());
            
            int[] array =  new int[10];
            // Nhập Dãy Số
             Console.WriteLine("Dãy số được nhập với số lượng phần tử là : {0}", _daySo);
            SelectionSort.NhapDaySo(array, _daySo);
            // Xuất dãy số
             Console.WriteLine("Dãy số được nhập");
            SelectionSort.XuatDaySo(array, _daySo);
           
            // Selection Sort
             Console.WriteLine("Dãy số được sắp xếp!");
            SelectionSort.SapXep(array, _daySo);
            //XuatDaySo(array, _daySo);
            Console.ReadKey();
            //bool _result = SapXep(_daySo);
        }   
    }
    
}
