using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class QuitOnKey : MonoBehaviour
{
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.UI.AnyKey.performed += OnAnyKey;
        controls.UI.AnyKey.Enable();
    }

    private void OnDisable()
    {
        controls.UI.AnyKey.performed -= OnAnyKey;
        controls.UI.AnyKey.Disable();
    }

    private void OnAnyKey(InputAction.CallbackContext ctx)
    {
        QuitGame();
    }

    private void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}