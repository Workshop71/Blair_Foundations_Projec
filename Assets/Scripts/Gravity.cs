using UnityEngine;

public class Gravity : MonoBehaviour
{
   void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        
    }
}
