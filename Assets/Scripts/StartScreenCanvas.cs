using UnityEngine;

public class StartScreenManager : MonoBehaviour
{
    public GameObject startScreenCanvas; // Referencia al Canvas de la pantalla inicial.

    private void Start()
    {
        // Activa la pantalla inicial al iniciar la aplicación.
        startScreenCanvas.SetActive(true);
        // Pausa el juego.
        Time.timeScale = 0f;
    }

    private void Update()
    {
        // Detecta si el usuario toca la pantalla o hace clic.
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }

    public GameObject uiManager;
    private void StartGame()
    {
        startScreenCanvas.SetActive(false); // Oculta la pantalla inicial.
        uiManager.SetActive(true); // Activa los íconos del juego.
        Time.timeScale = 1f; // Reactiva el tiempo del juego.

    }
}

