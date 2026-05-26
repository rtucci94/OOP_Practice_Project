using UnityEngine;

public class CubeShape : Shape
{
    void Start()
    {
        Name = "Cube";
    }
    public override void DisplayShapeText() // POLYMORPHISM
    {
        shapeText.text = "The shape you clicked is a " + Name;
    }
}
