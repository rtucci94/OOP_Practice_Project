using UnityEngine;

public class PillShape : Shape
{

    void Start()
    {
        Name = "Pill";
    }
    public override void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is a " + Name;
    }
}
