using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_2023
{
    public class IEnemurable_Explanation : IEnumerable
    {
        //IEnemurable is an interface for non-generic types
        //Non-generic types are the ones that are not strongly types, For eg: ArrayList, HashMaps, Stack
        //IEnemurable has a method GetEnmurator()
        //GetEnemurator returns IEnemurator
        //IEnemurator has the methods Reset(), MoveNext() and property GetCurrent

        int i = 0;
        public IEnumerator GetEnumerator()
        {
            ArrayList ie = new ArrayList();
            ie.Add(i);
            return (IEnumerator)ie;
        }
        
    }

    class Product : IEnumerable
    {
        public string[] ProductList = new string[5];
        int index = 0;

        public void AddProduct(string product)
        {
            ProductList[index++] = product;
        }
        public void RemoveProduct(int index)
        {
            ProductList[index] = "";
        }

        //Implementing GetEnumerator()
        //Passing ProductList as reference variable so that the list remains same across
        public IEnumerator GetEnumerator()
        {
            return new ProductEnumerator(ref ProductList);
            //return ProductList.GetEnumerator(); You can directly use this as all the collection type implement IEnumerator
        }

        class ProductEnumerator : IEnumerator
        {
            int index = -1;
            string[] ProductList;

            public ProductEnumerator(ref string[] productList)
            {
                ProductList = productList;
            }

            //Property current
            //gets the current element
            public object Current
            {
                get { return ProductList[index]; }
            }

            //To set the enumerator to the next element of a given collection
            //It returns a boolean value
            //If it returns false, it indicates the end of collection
            public bool MoveNext()
            {
                index++;
                return index >= ProductList.Length ? false : true;
            }

            //Sets the enumerator before the first element of collection
            public void Reset()
            {
                index = -1;
            }
        }
    }
    /*
            Product p1 = new Product();
            p1.AddProduct("Product1");
            p1.AddProduct("Product2");
            p1.AddProduct("Product3");
            p1.RemoveProduct(1);
            foreach (var item in p1.ProductList)
            {
                Console.WriteLine(item);                                     //Product1
            }                                                                //Product3
     */

}
