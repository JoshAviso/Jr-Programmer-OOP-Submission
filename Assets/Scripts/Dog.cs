using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    // POLYMORPHISM
    public override string Talk() => "Bork Bork Bark!";
}
