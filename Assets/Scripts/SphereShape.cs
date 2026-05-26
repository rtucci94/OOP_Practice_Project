using UnityEngine;

public class SphereShape : Shape
{  
    public override void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is a Sphere";
    }
}
