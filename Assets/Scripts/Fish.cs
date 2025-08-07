using UnityEngine;

// INHERITANCE
public class Fish : Animal
{
    public Fish(string name) : base(name) { }
    // POLYMORPHISM
    public override string Talk() => "Glubububub Glubbub";
}
