using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);     //Sondaki +1 yeni sahneye yani yeni level' a geçirir.
    }
    public void QuitGame()
    {
        Application.Quit();   //Unity editörde çalışmaz.      
        Debug.Log("quit");
    }
}
