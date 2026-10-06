using UnityEngine;
//this script is to destroy a game object using the space bar
public class PushSpaceToDestroy : MonoBehaviour
{
    
    public GameObject gameObjectToDestroy; // Reference to the game object to destroy
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);//this destroys the game object that this script is attached to

            //Destroy(this);//this destroys the script that this script is attached to the game object

            //Destroy (this.gameObject);//this destroys the game object that this script is attached to


            Destroy(gameObjectToDestroy); //this destroys the game object that is referenced in the inspector
        }
    }
}
