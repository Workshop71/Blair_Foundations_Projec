using UnityEngine;

public class SugarCollected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ItemsCollected itemsCollected;
    public GameObject sugar;
    public void CollectedItem()
    {
    itemsCollected.CollectedAssets();    
    }

    void OnMouseDown()
    {
    Destroy(sugar);
    CollectedItem();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}