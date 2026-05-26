using UnityEngine;

public class SphereShape : Shape
{

    void Start()
    {
        Name = "Sphere";
    }
    public override void DisplayShapeText() // POLYMORPHISM
    {
        shapeText.text = "The shape you clicked is a " + Name;
    }
}
