using UnityEngine;
using UnityEngine.InputSystem;

public class PauseUI : MonoBehaviour
{
    MoveAction inputActions;

    public GameObject pausePanelPrefab;

    GameObject currentPausePanel;

    bool isPaused = false;

    void Awake()
    {
        inputActions = new MoveAction();
    }

    void OnEnable()
    {
        inputActions.PlayerInputAction.Enable();

        inputActions.PlayerInputAction.UI.performed += OnPause;
    }

    void OnDisable()
    {
        inputActions.PlayerInputAction.UI.performed -= OnPause;

        inputActions.PlayerInputAction.Disable();
    }

    void OnPause(InputAction.CallbackContext context)
    {
        if (isPaused)
        {
            ClosePause();
        }
        else
        {
            OpenPause();
        }
    }

    public void OpenPause()
    {
        currentPausePanel =
            Instantiate(pausePanelPrefab, transform);

        currentPausePanel
            .GetComponent<PausePanelUI>()
            .SetPauseUI(this);

        Time.timeScale = 0f;

        isPaused = true;
    }

    public void ClosePause()
    {
        Destroy(currentPausePanel);

        Time.timeScale = 1f;

        isPaused = false;
    }
}