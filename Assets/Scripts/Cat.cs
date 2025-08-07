using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    // POLYMORPHISM
    public override string Talk() => "Meow Meow Meow";
}
