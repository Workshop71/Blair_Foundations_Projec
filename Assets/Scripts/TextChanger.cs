using UnityEngine;
using TMPro;
public class TextChanger : MonoBehaviour
{
    public TMP_Text dialogueText;

    public int ingredientsCollected = 0;
    public void CollectedAssets()
    {
        ingredientsCollected++;
        Debug.Log("Ingredients Collected: " + ingredientsCollected);
    }

    void Update()
    {
        if (ingredientsCollected == 0)
        {
            dialogueText.text = "Right! Do you think you can make a cake? Good. First go get the Milk!";
            //Debug.Log("text updated");
        }
        if (ingredientsCollected == 1)
        {
            dialogueText.text = "Hurry up you Idiot! Go get the Flour!";
            Debug.Log("text updated2");
        }
        if (ingredientsCollected == 2)
        {
            dialogueText.text = "You think this is me Angry! Go get the Sugar to sweeten me up!";
            Debug.Log("text updated3");
        }
        if (ingredientsCollected == 3)
        {
            dialogueText.text = "God even my mum could do better than this! Baking knightmare? More like Hells Bakery! Go get the Eggs!";
        }
        if (ingredientsCollected == 4)
        {
            dialogueText.text = "WHERE THE VANILLA SAUCE!";
        }
        if (ingredientsCollected == 5)
        {
            dialogueText.text = "Finally got all the ingredients! Now you can bake the cake!";
        }
    }
}
