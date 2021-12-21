using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabExam
{
    class Node{
        int data;

        }

    internal class Set
    {
        private int[] Arr;
        private int top;

        public int getTop()
        {
            return top;
        }
        public Set(int size)
        {
            top = 0;
            Arr= new int[size];
        }
        public int getElement(int index)
        {
            try
            {
                return Arr[index];
            }
            catch (Exception)
            {
                
                Console.WriteLine("Element Does Not Exist");
                return 0;
            }
        }

        public void Insert(int n)
        {
            bool check = true;
            for(int i = 0; i < top; i++)
            {
                if(Arr[i] == n)
                {
                    Console.WriteLine("Already Added");
                    check = false;
                    break;
                }
            }
            if (check)
            {
                    Arr[top] = n;
                top++;
            }
        }
        public void DisplayAll()
        {
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(this.getElement(i));
            }
        }
        public Set Intersection( Set set2)
        {
              Set result = new Set(this.getTop()+set2.getTop());
            for (int i = 0; i < this.getTop(); i++)
            {
                for(int j = 0; j<set2.getTop(); j++)
                {
                    if(this.getElement(i) == set2.getElement(j))
                    {
                        result.Insert(this.getElement(i));
                    }
                }
            }
            return result;
            
            
        }
    }
}
