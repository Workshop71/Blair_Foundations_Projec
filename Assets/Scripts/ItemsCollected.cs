using UnityEngine;

public class ItemsCollected : MonoBehaviour
{
    Animator animator;
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
        if(ingredientsCollected == 1)
        {
       
        MilkFound.SetActive(true);    
        Flour.SetActive(true);
        animator.SetBool("MilkCollected", true);
        }
        if(ingredientsCollected == 2)
        {
        
        FlourFound.SetActive(true);    
        sugar.SetActive(true);
        animator.SetBool("FlourCollected", true);
        }
        if(ingredientsCollected == 3)
        {
        
        sugarFound.SetActive(true);    
        Eggs.SetActive(true);
        animator.SetBool("SugarCollected", true);
        }
        if(ingredientsCollected == 4)
        {
        
        EggsFound.SetActive(true);    
        Vanilla.SetActive(true);
        animator.SetBool("EggsCollected", true);
        }
        if(ingredientsCollected == 5)
        {
        
        VanillaFound.SetActive(true);  
        animator.SetBool("VanillaCollected", true);  
        
        }
        if(ingredientsCollected == 6)
        {
        Cake.SetActive(false);
        CakeBaked.SetActive(true);
        }
    }
}
