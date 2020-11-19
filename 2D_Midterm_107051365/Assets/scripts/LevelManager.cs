
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLevel(string nameLV)
    {
        SceneManager.LoadScene (nameLV);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
