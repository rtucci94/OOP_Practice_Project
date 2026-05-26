using TMPro;
using UnityEngine;

public class DisplayText : MonoBehaviour
{

    public TextMeshProUGUI shapeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is Sphere ";
    }

    public override void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is Cube ";
    }
}
