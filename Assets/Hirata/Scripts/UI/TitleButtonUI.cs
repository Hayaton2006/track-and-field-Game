using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonUI: MonoBehaviour
{
    public void BackToTitle()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("TitleScene");
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("InGameScene");
    }
}
