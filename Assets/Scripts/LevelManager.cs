using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField]
    private AudioClip musicSong;

    //UI
    [SerializeField]
    private Text coinsText;
    [SerializeField]
    private Text heartsText;
    [SerializeField]
    private GameObject panelGameOver;
    [SerializeField]
    private GameObject panelPause;
    [SerializeField]
    private GameObject panelWin;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateCoins();
        UpdateLives();
        AudioManager.instance.PlayMusic(musicSong);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives()
    {
        heartsText.text = "x" + GameManager.instance.life.ToString();
    }

    public void UpdateCoins()
    {
        coinsText.text="x"+GameManager.instance.totalCoins.ToString();
    }

    public void RestartButton()
    {
        GameManager.instance.life = 3;
        GameManager.instance.totalCoins = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }

    public void Pause()
    {
        if (panelPause.activeInHierarchy == false)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            panelPause.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FinishLevel()
    {
        Time.timeScale = 0;
        panelWin.SetActive(true);
    }
}
