using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI shapeText;
    private void OnMouseDown()
    {
        DisplayShapeText();
    }

    public virtual void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is a shape";
    }
}
