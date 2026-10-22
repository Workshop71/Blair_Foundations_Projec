using UnityEngine;

public class ClickAni : MonoBehaviour
{
    Animator LadyGaga;

    void Start()
    {
        LadyGaga = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        LadyGaga.SetBool("IsClicked", true);
    
    }
}
