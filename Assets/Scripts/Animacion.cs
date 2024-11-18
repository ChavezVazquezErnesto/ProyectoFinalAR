using TMPro;
using UnityEngine;
using System.Collections;

public class TextBlink : MonoBehaviour
{
    public float blinkDuration = 0.5f;  // Duración del parpadeo (tiempo que tarda en desaparecer o aparecer)
    public float blinkDelay = 0.5f;     // Tiempo entre cada ciclo de parpadeo

    private TMP_Text textComponent;  // Referencia al componente TMP_Text

    void Start()
    {
        // Obtiene el componente TMP_Text de este objeto
        textComponent = GetComponent<TMP_Text>();

        if (textComponent != null)
        {
            Debug.Log("Componente TMP_Text encontrado. Iniciando parpadeo.");
            // Inicia la coroutine para que el texto parpadee
            StartCoroutine(BlinkText());
        }
        else
        {
            Debug.LogError("No se encontró el componente TMP_Text en este objeto.");
        }
    }

    // Coroutine que controla el parpadeo del texto
    IEnumerator BlinkText()
    {
        while (true)  // Bucle infinito para que parpadee siempre
        {
            // Hacer el texto invisible (opacidad 0)
            SetTextOpacity(0f);
            Debug.Log("Texto invisible, opacidad 0");
            yield return new WaitForSeconds(blinkDuration);  // Esperar durante el blinkDuration

            // Hacer el texto visible (opacidad 1)
            SetTextOpacity(1f);
            Debug.Log("Texto visible, opacidad 1");
            yield return new WaitForSeconds(blinkDelay);  // Esperar durante el blinkDelay
        }
    }

    // Método para cambiar la opacidad del texto
    void SetTextOpacity(float opacity)
    {
        // Usamos la propiedad alpha de TextMeshPro para cambiar la opacidad del texto
        textComponent.alpha = opacity;  // Cambiar la opacidad (alpha)

        // Depuración: Verificar el cambio de opacidad
        Debug.Log($"Opacidad cambiada a: {opacity}");
    }
}
