using UnityEngine;

public class FlourCollected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ItemsCollected itemsCollected;
    public GameObject Flour;
    public void CollectedItem()
    {
    itemsCollected.Collecteditem();    
    }

    void OnMouseDown()
    {
    Destroy(Flour);
    CollectedItem();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
