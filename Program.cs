using System;

namespace TestCourse2
{

    public abstract  class Person
    {
        public int age;
        public abstract string GetPersonInfo(string Name, int age, string adress);

        public abstract int GetAge();

        public void getAdress()
        {

        }
    }

    public class Employee :Object, IPerson, IManager
    {

        public int GetAge()
        {
            throw new NotImplementedException();
        }

        //public string GetPersonInfo(string Name, int age, string adress)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public interface IManager
    {

    }



    public interface IPerson
    {
        public string GetPersonInfo(string Name, int age, string adress) {
            return "Ana";
        }

        public  int GetAge();

 



    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Employee();
          //  Console.WriteLine(person.GetPersonInfo()); /// wont see it because is an employy

            IPerson person2 = new Employee();
            //Console.WriteLine(person2.GetPersonInfo());//will see it becaus is IPerson
        }
    }



    public class ClassRoom
    {

        public void Do()
        {

        }

    }


}
