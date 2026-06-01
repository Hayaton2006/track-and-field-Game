using UnityEngine;

public class PausePanelUI : MonoBehaviour
{
    PauseUI pauseUI;

    public GameObject optionPanelPrefab;

    public void SetPauseUI(PauseUI ui)
    {
        pauseUI = ui;
    }

    public void ClosePause()
    {
        pauseUI.ClosePause();
    }

    public void OpenOption()
    {
        gameObject.SetActive(false);

        GameObject optionPanel =
            Instantiate(optionPanelPrefab, transform.parent);

        optionPanel
            .GetComponent<OptionPanelUI>()
            .SetPausePanel(gameObject);
    }
}