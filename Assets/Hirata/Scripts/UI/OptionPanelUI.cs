using UnityEngine;

public class OptionPanelUI : MonoBehaviour
{
    GameObject pausePanel;

    public void SetPausePanel(GameObject panel)
    {
        pausePanel = panel;
    }

    public void Close()
    {
        if (pausePanel != null)
        {
            pausePanel.SetActive(true);
        }

        Destroy(gameObject);
    }
}