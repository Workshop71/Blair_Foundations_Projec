using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ItemsCollected : MonoBehaviour
{
    Animator animator;
    public TMP_Text dialogueText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Milk;
    public GameObject Eggs;
    public GameObject Flour;
    public GameObject Vanilla;
    public GameObject sugar;
    public GameObject MilkFound;
    public GameObject EggsFound;
    public GameObject FlourFound;
    public GameObject VanillaFound;
    public GameObject sugarFound;
    public GameObject Cake;
    public GameObject CakeBaked;
    public GameObject MilkBlackout;
    public GameObject EggsBlackout;
    public GameObject FlourBlackout;
    public GameObject VanillaBlackout;  
    public GameObject SugarBlackout;
    

    public GameObject speachMilk;
    public GameObject speachFlour;
    public GameObject speachSugar;
    public GameObject speachEggs;
    public GameObject speachVanilla;
    public GameObject speachBake;
    
    public int ingredientsCollected = 0;
    
    public void CollectedAssets()
    {
        ingredientsCollected++;
        Debug.Log("Ingredients Collected: " + ingredientsCollected);
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MilkBlackout.SetActive(false);
        if(ingredientsCollected == 1)
        {
        speachMilk.SetActive(false);
        speachFlour.SetActive(true);
        MilkFound.SetActive(true);    
        Flour.SetActive(true);
        animator.SetBool("MilkCollected", true);
        FlourBlackout.SetActive(false);
        }
        if(ingredientsCollected == 2)
        {
        speachFlour.SetActive(false);
        speachSugar.SetActive(true);
        FlourFound.SetActive(true);    
        sugar.SetActive(true);
        animator.SetBool("FlourCollected", true);
        SugarBlackout.SetActive(false);
        }
        if(ingredientsCollected == 3)
        {
        speachSugar.SetActive(false);
        speachEggs.SetActive(true);
        sugarFound.SetActive(true);    
        Eggs.SetActive(true);
        animator.SetBool("SugarCollected", true);
        EggsBlackout.SetActive(false);
        }
        if(ingredientsCollected == 4)
        {
        speachEggs.SetActive(false);
        speachVanilla.SetActive(true);
        EggsFound.SetActive(true);    
        Vanilla.SetActive(true);
        animator.SetBool("EggsCollected", true);
        VanillaBlackout.SetActive(false);
        }
        if(ingredientsCollected == 5)
        {
        speachVanilla.SetActive(false);
        speachBake.SetActive(true);
        VanillaFound.SetActive(true);  
        animator.SetBool("VanillaCollected", true);  
        
        }
        if(ingredientsCollected == 6)
        {
        speachBake.SetActive(false);
        Debug.Log("All Ingredients Collected! Now you can bake the cake!");
        }
        /*if(ingredientsCollected == 6)
        {
        Debug.Log("All Ingredients Collected! Now you can bake the cake!");
        Cake.SetActive(false);
        CakeBaked.SetActive(true);
        animator.SetBool("CakeBaked", true);
        //SceneManager.LoadSceneAsync(2);
        }*/
    }
}
