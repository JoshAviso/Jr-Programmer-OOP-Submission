using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimalTracker : MonoBehaviour
{
    [SerializeField] private TMP_Text _animalName;
    [SerializeField] private TMP_Text _animalSay;
    public List<Animal> animals = new List<Animal>();
    private int currentAnimalIndex = -1;
    void Start()
    {
        animals.Add(new Cat("Mr. Whiskers"));
        animals.Add(new Dog("Fluffball"));
        animals.Add(new Fish("Mr. Nemo"));
    }
    void Update()
    {
        if (_animalName == null) return;
        if (_animalSay == null) return;

        if (currentAnimalIndex <= -1 || currentAnimalIndex >= animals.Count)
        {
            _animalName.text = "Select an Animal";
            _animalSay.text = "";
        }

        else
        {
            _animalName.text = animals[currentAnimalIndex].GetName();
            _animalSay.text = animals[currentAnimalIndex].Talk();
        }
    }

    public void SetSelectedAnimal(int index)
    {
        currentAnimalIndex = index;
    }
}
