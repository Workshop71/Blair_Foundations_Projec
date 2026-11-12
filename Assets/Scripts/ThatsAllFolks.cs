using UnityEngine;
using UnityEngine.SceneManagement;
public class ThatsAllFolks : MonoBehaviour

{
    public Howtoturnwithmouse HowToTurnWithMouse;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    void EndGame()
    {
        HowToTurnWithMouse.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;


        SceneManager.LoadSceneAsync(2);
    }
    
}
