using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singletons
{
    public class SingletonExample
    {
        private static SingletonExample uniqueInstance;
        private List<int> numbers;

        // Single constructor should always be private
        private SingletonExample()
        {
            numbers = new List<int>();
        }

        // This is the accessor method
        public static SingletonExample GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance =  new SingletonExample();
            }
            return uniqueInstance;
        }

        public void AddNumberToList(int num)
        {
            numbers.Add(num);
        }

        public List<int> GetList()
        {
            return numbers;
        }
    }
}
