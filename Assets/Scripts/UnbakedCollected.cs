using UnityEngine;

public class UnBakedCollected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ItemsCollected itemsCollected;
    public GameObject ClickObjToDestroy;
    public void CollectedItem()
    {
    itemsCollected.CollectedAssets();    
    }

    void OnMouseDown()
    {
    Destroy(ClickObjToDestroy);
    CollectedItem();
    Debug.Log("Unbaked Cake Collected");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
