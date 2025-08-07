using UnityEngine;

public class Animal
{
    // ENCAPSULATION
    private string _name;
    public string GetName() => _name;
    public void SetName() => _name = _name.ToLower();


    // ABSTRACTION AND POLYMORPHISM
    public virtual string Talk() { return "I am some generic animal, I don't know how to talk"; }
}
