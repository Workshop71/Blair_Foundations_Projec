using UnityEngine;

public class EggsCollected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ItemsCollected itemsCollected;
    public GameObject Eggs;
    public void CollectedItem()
    {
    itemsCollected.CollectedAssets();    
    }

    void OnMouseDown()
    {
    Destroy(Eggs);
    CollectedItem();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
