using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces101
{
    //An interface creates a contract that, any implementing class needs to implement each and every method.  Think of it as a blueprint.
    //This example is an interface that takes a generic type T, so any class that implements this interface
    //needs to write a definition for the Equals method
    //You use interfaces to provide a contract to consumers, and with multiple interface inheritance, consumers can construct complex derived types
    //Because the consumer has the ability to provide an implementation, you can have different pluggable implementations to use in your own code
    public interface IEquatable<T>
    {
        bool Equals(T obj);
    }
}
