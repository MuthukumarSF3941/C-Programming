using System;
using System.Collections.Generic;

namespace FilterDelegate;

public class Program
{
    public static void Main(string[] args)
    {
        Person person1=new Person() {Name="John", Age=10};
        Person person2=new Person() {Name="Franklin", Age=35};
        Person person3=new Person() {Name="Antony", Age=19};
        Person person4=new Person() {Name="Mary", Age=68};
        Person person5=new Person() {Name="Mark", Age=13};
        Person person6=new Person() {Name="Mecloria", Age=56};

        List<Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};


        DisplayPeople("children:",people,IsChild);
        DisplayPeople("Adults:",people,IsAdult);
        DisplayPeople("Seniors:",people,IsSenior);
        DisplayPeople("Voter:",people,IsVoter);


        
       


    }
      static void DisplayPeople(string title,List<Person> people,FilterDelegates filter)
        {
            System.Console.WriteLine("People in "+title+" List are:");

            foreach (Person p in people)
            {
                        if(filter(p))
                        {
                            System.Console.WriteLine("{0}, is {1} year old",p.Name,p.Age);
                        }
            }
           
        }

        static bool IsChild(Person p) {return p.Age<15;}
        static bool IsVoter(Person p)  {return p.Age>=18;}

        static bool IsAdult(Person p)  
        {
           if(p.Age>=18 && p.Age<50)
           {
            return true;

           }
           else
           {
            return false;
           }
        }

        static bool IsSenior(Person p)  {return p.Age>=50;}
}