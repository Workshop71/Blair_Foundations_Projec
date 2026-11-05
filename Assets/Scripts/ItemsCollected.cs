using UnityEngine;

public class ItemsCollected : MonoBehaviour
{
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

    public int ingredientsCollected = 0;

    public void Collecteditem()
    {
        ingredientsCollected++;
        Debug.Log("Ingredients Collected: " + ingredientsCollected);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ingredientsCollected == 1)
        {
        Milk.SetActive(false);
        }
        {
        MilkFound.SetActive(true);    
        }
        {
        Flour.SetActive(true);
        }
        if(ingredientsCollected == 2)
        {
        Flour.SetActive(false);
        }
        {
        FlourFound.SetActive(true);    
        }
        {
        sugar.SetActive(true);
        }
        if(ingredientsCollected == 3)
        {
        sugar.SetActive(false);
        }
        {
        sugarFound.SetActive(true);    
        }
        {
        Eggs.SetActive(true);
        }
        if(ingredientsCollected == 4)
        {
        Eggs.SetActive(false);
        }
        {
        EggsFound.SetActive(true);    
        }
        {
        Vanilla.SetActive(true);
        }
        if(ingredientsCollected == 5)
        {
        Vanilla.SetActive(false);
        }
        {
        VanillaFound.SetActive(true);    
        }
        {
        Flour.SetActive(true);
        }
    }
}
