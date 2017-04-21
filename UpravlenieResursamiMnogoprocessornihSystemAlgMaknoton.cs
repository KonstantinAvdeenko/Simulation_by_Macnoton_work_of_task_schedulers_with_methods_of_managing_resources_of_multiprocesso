using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpravlenieResursamiMnogoprocessornihSystemAlgMaknoton
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, n;
             Console.WriteLine("Введите количество общих заданий на все процессоры");
             L = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите количество идентичных процессоров");
             n = int.Parse(Console.ReadLine());
	         double theta; // значение нижней границы времени для алгоритма Макнотона
             double optimalT1; // оптимальное время
             double wasteTime1; // простаивание процессора
             int[] timesOfTasks = new int[L]; 
	         Random init = new Random();
            for (int i = 0; i < L; ++i)
            {
	                timesOfTasks[i] = init.Next(1, L);  // случайная инициализация массива различным временем выполнения заданий 
            }
	            Array.Sort(timesOfTasks); // сортировка массива
	            Array.Reverse(timesOfTasks); // перестановка элементов, чтобы они были убывающими
                theta = Math.Max(timesOfTasks[0], middleOfSum(timesOfTasks, n)); 
	            optimalT1 = theta;
	            wasteTime1 = AlgorithmMaknoton(timesOfTasks, theta, n); 
	             Console.WriteLine("\nПростой процессора -  {0:0.0} \n Оптимальное время(нижняя граница) -  {1:0.0}", wasteTime1, theta);
                 Console.ReadKey();
	        }

        public static double middleOfSum(int[] arr, int quantatityProcs)
        { // считает потраченное время на все задания и делит его на время кванта процессорного времени, чтобы узнать нужное количество квантов 
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i) 
            {
                sum += arr[i];
            }
            return (double)(sum / (double)quantatityProcs);
        }

	        public static double AlgorithmMaknoton(int [] times, double thetaLevel, int n)
	        {
                double temp = thetaLevel; // время кванта процессорного времени
	            int currentProcessor = n;
                for (int i = 0; i < times.Length; ++i) // заполняет и распределяет работу на каждом процессоре в виде вместившихся полностью и не вместившихся на процессор заданий  
	            {
                    if (temp <= 0 && currentProcessor > 1) // не вместившееся на процессор задание переходит на следующий процессор  
	                {
	                    temp += thetaLevel;
	                    --currentProcessor;
	                }
                    temp -= times[i]; // вычитается потраченное на задание время, чтоб выявить время простаивания любого из процессоров
	            }
	            return temp;
	        }
        }
    }
