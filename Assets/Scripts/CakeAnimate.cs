using UnityEngine;

public class CakeAnimate : MonoBehaviour
{
    Animator animator;
    ItemsCollected ingredientsCollected;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void animateCake()
    {
            animator.SetBool("CakeBake", true);
        
    }
}
