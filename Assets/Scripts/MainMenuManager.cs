using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void PlayButton()
    {
        GameManager.instance.totalCoins = 0;
        GameManager.instance.life = 3;
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
