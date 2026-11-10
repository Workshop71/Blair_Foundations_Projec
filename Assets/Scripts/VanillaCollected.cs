using UnityEngine;

public class VanillaCollected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ItemsCollected itemsCollected;
    public GameObject vanilla;
    public void CollectedItem()
    {
    itemsCollected.CollectedAssets();    
    }

    void OnMouseDown()
    {
    Destroy(vanilla);
    CollectedItem();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
