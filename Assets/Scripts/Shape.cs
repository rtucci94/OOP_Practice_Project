using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string Name { get; set; }
    [SerializeField]
    protected TextMeshProUGUI shapeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        WhenClicked();
    }

    public virtual void DisplayShapeText()
    {
        shapeText.text = "The shape you clicked is a shape";
    }

    protected abstract void WhenClicked();
}
