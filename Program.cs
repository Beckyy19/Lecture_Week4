using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Question 1 : ");
            Console.WriteLine("Enter the word :");
            string example = Convert.ToString(Console.ReadLine());
            Question1(example);
            
            
            Console.WriteLine("Question 2 ");
            bool result = Question2();
            Console.WriteLine(result);
                     
            Console.WriteLine("Question 3 : ");
            
            string example_3 = Convert.ToString(Console.ReadLine());
            Compressing_String(example_3);
            
            Question5();
            
            Console.Write("Type the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Question7(number);
            

            Console.WriteLine("Enter the word :");
            string example = Convert.ToString(Console.ReadLine());
            Question8(example);
            

            Person P1 = new Person("Rebecca");
            Console.WriteLine(P1.ToString());
            Person P2 = new Person("Adrien");
            Console.WriteLine(P2.ToString());
            Person P3 = new Person("Aline");
            Console.WriteLine(P3.ToString());
            */

            Question6();
            Console.ReadKey();

        }

        static void Question1(string example)
        {
            int size = example.Length;
            char[] tab = new char[size];

            //substring
            tab[0] = Convert.ToChar(example.Substring(size - 1, 1));
            tab[size-1] = Convert.ToChar(example.Substring(0, 1));
            for (int i =1; i < size-1; i++)
            {
                tab[i] = Convert.ToChar(example[i]);
                
            }

            for (int i = 0; i < size; i ++)
            {
                Console.Write(tab[i]);
            }
        }

        
        static bool Question2()
        {
            bool result = false;
            int size;

            Console.Write("Type the size of the array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] tab = new int[size];

            Random rd = new Random();
            int rand_num;

            for (int i = 0; i < size; ++i)
            {
                rand_num = rd.Next(1, 10);
                tab[i] = rand_num;
            }

            foreach (int i in tab)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            int size2;

            Console.Write("Type the size of the sequence that you are looking for : ");
            size2 = Convert.ToInt32(Console.ReadLine());
            int[] example =  new int[size2];

            for (int i = 0; i < size2; ++i)
            {
                Console.Write("Enter the number : ");
                example[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            int compteur = 0;
                for (int i = 0; i < tab.Length/2 +1; i++)
                {

                    for (int j = 0; j < example.Length; j++)
                    {
                        if (example[j] == tab[i+j])
                        {
                            compteur++;
                        }
                    }
                    if(compteur == size2)
                    { 
                        result = true;
                        break;
                    }
                    
                }
                return result;

        }

        static void Question3_A()
        {
            Console.Write("Write a letter : ");
            
            char example = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ascii value of the character " +example+ " is : "+Convert.ToInt32(example));
        }
        static void Question3_B(string order)
        {
            string result = "";
            int size = order.Length;

            char[] array = new char[size];

            if(size%2 == 0)
            { 
                for (int i = 0; i < size; i++)
                {
                    array[i] = order[size - i-1];
                }
            }
            else
            {
                for (int i = 0; i < size/2; i++)
                {
                    array[i] = order[size - i - 1];
                }

                for (int j = size/2; j < size; j++)
                {
                    array[j] = order[size - j - 1];
                }
                   
            }

            result = string.Join(string.Empty, array);
            Console.WriteLine(result);
        }

        
        static void Compressing_String(string example)
        {

            string result = example[0] + "";
            char letter = example[0];

            int compteur = 0;


            for (int i = 0; i < example.Length; i++)
            {
                if (letter == example[i])
                {
                    compteur++;
                }
                else
                {
                    result += Convert.ToString(compteur) + example[i]+"";
                    compteur = 1;
                    letter = example[i];
                }
            }
            Console.WriteLine(result+Convert.ToString(compteur));

        }

        static void Question5()
        {

            int result = 0;
            int compteur = 1;

            for (int i = 0; i < 10; i++)
            {
                result = i * i * i;

                if (result == i)
                {
                    Console.WriteLine("Armstrong Number " + compteur + " : " + i);
                    compteur++;
                }
            }

            for (int i = 10; i < 100; i++)
            {
                result = (i / 10) * (i / 10) * (i / 10) + (i % 10) * (i % 10) * (i % 10);

                if (result == i)
                {
                    Console.WriteLine("Armstrong Number " + compteur + " : " + i);
                    compteur++;
                }
            }

            for (int i = 100; i < 1000; i++)
            {

                result = (i % 10) * (i % 10) * (i % 10) + (i - (i % 100)) / 100 * (i - (i % 100)) / 100 * (i - (i % 100)) / 100 + ((i % 100) - (i % 10)) / 10 * ((i % 100) - (i % 10)) / 10 * ((i % 100) - (i % 10)) / 10;

                if (result == i)
                {
                    Console.WriteLine("Armstrong Number " + compteur + " : " + i);
                    compteur++;
                }
            }


        }


        static void Question6()
        {
            
            Console.Write("PLease enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[size];

            Random rd = new Random();
            int rand_num;

            for (int i = 0; i < size; ++i)
            {
                rand_num = rd.Next(1, 10);
                tab[i] = rand_num;
            }
            
            /*
            int[] tab = { 5, 7, 5, 2, 2, 4, 5 };
            int size = tab.Length;
            */
            foreach (int i in tab)
            {
                Console.Write(i + "\t");
            }
            
            Console.WriteLine();


            int temp = 0;
            int compteur = 0;


            for (int i = 0; i < size; i++)
            {
                temp = tab[i];

                for (int a = 0; a < i; a++)
                {
                    if(temp == tab[a])
                    {
                        compteur = 0;
                        i++;
                        break;
                    }
                }

                temp = tab[i];

                for (int j = i; j < size; j++)
                {

                    if (temp == tab[j])
                    {

                        compteur++;
                    }
                }
                Console.WriteLine(temp + " is " + compteur + " times.");
                compteur = 0;
            }
        }

        //list<int> list = new list<int>() 

        static void Question7(int number)
        {
            int result = 1;

            for (int i = 2; i <=number; i++)
            {
                result = result*i;
            }

            Console.WriteLine(number+"! = "+result);
        }

        static void Question8(string example)
        {
            int compteur = 0;

            for (int i = 0; i < example.Length; i++)
            {
                if(example[i] == ' ')
                {
                    compteur++;
                }
            }

            Console.WriteLine("Numbers of spaces found in the phrase : " + compteur);


        }

    }
        
}
