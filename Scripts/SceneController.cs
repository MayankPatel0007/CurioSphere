using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
   public void MainMennu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
