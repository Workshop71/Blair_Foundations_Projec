using UnityEngine;
using UnityEngine.SceneManagement;
public class ThatsAllFolks : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    void EndGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    
}
