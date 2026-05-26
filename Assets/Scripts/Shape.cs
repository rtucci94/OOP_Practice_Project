using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour // INHERITANCE
{
    [SerializeField]
    public TextMeshProUGUI shapeText;

    private string _name;

    public string Name // ENCAPSULATION
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Debug.LogWarning("Shape name cannot be empty.");
                return;
            }
            _name = value;
        }
    }
    private void OnMouseDown()
    {
        DisplayShapeText(); // ABSTRACTION
    }

    public virtual void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is a shape";
    }
}
