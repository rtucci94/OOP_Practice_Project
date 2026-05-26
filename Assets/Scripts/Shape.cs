using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string Name { get; set; }
    
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

    protected abstract void WhenClicked();
}
