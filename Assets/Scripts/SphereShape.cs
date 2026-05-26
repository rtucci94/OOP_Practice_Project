using UnityEngine;

public class SphereShape : Shape
{
    protected override void WhenClicked()
    {
        //Do stuff here
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is a Sphere";
    }
}
