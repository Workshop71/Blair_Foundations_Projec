using UnityEngine;

public class ObjectFound : MonoBehaviour
{
    public GameObject clickObjToDestroy;

    void OnMouseDown()
    {
        Debug.Log("Object was clicked");
        /*public void Collecteditem() 
         {
             ingredientsCollected++;
             Debug.Log("Ingredients Collected: " + ingredientsCollected);
         }*/
        Destroy(clickObjToDestroy);
    }

}