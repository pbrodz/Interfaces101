using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces101
{
    //This is an abstract class
    //If you declare the entire class as abstract, then you can think of it as the "base" class
    //that can provide any number of properties or methods by itself
    //The abstract part comes in when another class derives from it - the derived class can re-implement ANY of the methods in the abstract class
    //Think of the abstract class as a template or master class that CANNOT be instantiated by themselves - they HAVE to be derived from
    //And as such the derived class inherits all of this rich functionality as well as the ability to change any of the methods to suit
    public abstract class BaseHuman
    {
        //Member variables
        string m_name;
        int m_age;
        int m_sex;

        //If you want to be able to provide a common method to override, then make it abstract also
        //An abstract function can have no functionality. You're basically saying, any child class MUST give their own version of this method, however it's too general to even try to implement in the parent class. 
        public abstract bool MethodToOverride();

        //This IsIntelligent method is concrete, not abstract so whoever inherits from this class can simply invoke it
        //The deriving class can't override it because it isn't marked as abstract, of course (as the one above is)
        public bool IsIntelligent()
        {
            return true;
        }
    }

    //This is a regular class with a virtual method definition in it
    public class BaseFlyingAnimal
    {
        //Virtual methods within regular classes (when coupled with the override keyword in a derived class)
        //allow the deriving class to change up the method to suit.
        //Instead of an entire abstract class, you only abstract out the methods you want people to override
        //This, similar to the abstract class, but different in that you can instantiate it directly
        //A virtual function, is basically saying look, here's the functionality that may or may not be good enough for the child class.
        //So if it is good enough, use this method, if not, then override me, and provide your own functionality.
        public virtual bool Flies()
        {
            return true;
        }
    }
}