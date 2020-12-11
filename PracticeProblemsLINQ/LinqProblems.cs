using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25

        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that 
        //contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words, string s1)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //code
            //string s1 = "th"; **note** instead of passing in a variable in the code block, pass it in as a parameter
            // to give the method a pure function and more freedom to choose different strings
            var containsTHSubstring = words.Where(w => words.Contains(s1)).ToList();
            //return
            return containsTHSubstring;
        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list 
        //without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            // List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //code -- 
            List<string> nameListWithNoDuplicates = names.Distinct().ToList(); // Select(n => names.Distinct()).ToList());

            //return
            return nameListWithNoDuplicates;

        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer 
        //who has the name of Mike. 

        //List<Customer> customers = new List<Customer>()
        //    {
        //        new Customer(1, "Mike", "Rodgers"),
        //        new Customer(2, "Nick", "Allen"),
        //        new Customer(3, "Jason", "Ryan"),
        //        new Customer(4, "Dan", "Laffey")
        //    };

        public static Customer RunProblem3(List<Customer> customers, string firstName)
        {
            //code
            //Customer customer = customers.Where(c => customer.FirstName.Equals(firstName)).ToList();
            //Customer customer = customers.Select(c=> customer.FirstName == firstName).ToList();
            var customer = customers.Where(c => c.FirstName == firstName).FirstOrDefault();


            //return
            return customer;
        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer
        //who has an id of 3. Then, update that customer's first name and last name to completely 
        //different names and return the newly updated customer from the method.
            public static Customer RunProblem4(List<Customer> customers)
        {
            //code
            var customer = customers.Where(c => c.Id == 3).SetValue(c => c.FirstName = "Pa").SetValue(c => c.LastName = "Her").FirstOrDefault();
                    //return
            return customer;
        }

        public static IEnumerable<T> SetValue<T>(this IEnumerable<T> items, Action<T>updateMethod)
        {
            foreach (T item in items)
            {
                updateMethod(item);
            }
            return items;
        }
    }
}
    #endregion

    //#region Problem 5
    ////(5 points) Problem 5
    ////Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
    ////The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
    ////drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
    ////Expected output: 86.125
    //public static double RunProblem5(List<string> classGrades)
    //    {
    //        //code

    //        //return

    //    }
    //    #endregion

    //    #region Bonus Problem 1
    //    //(5 points) Bonus Problem 1
    //    //Write a method that takes in a string of letters(i.e. “Terrill”) 
    //    //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
    //    public static string RunBonusProblem1(string word)
    //    {
    //        //code

    //        //return

    //    }
    //    #endregion
    //}
 

