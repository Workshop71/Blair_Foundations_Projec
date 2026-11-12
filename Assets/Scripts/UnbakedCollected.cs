using UnityEngine;

public class UnBakedCollected : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public ItemsCollected itemsCollected;
    public MeshRenderer tinVisible, unbakedCakeVisible;
    public BoxCollider CakeCollider;
    public void CollectedItem()
    {
    itemsCollected.CollectedAssets();    
    }
    
    void OnMouseDown()
    {
        tinVisible.enabled = false;
        unbakedCakeVisible.enabled = false;
        CakeCollider.enabled = false;
    CollectedItem();
    Debug.Log("Unbaked Cake Collected");
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
