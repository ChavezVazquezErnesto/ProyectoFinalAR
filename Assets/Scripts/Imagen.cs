using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTrackedImageHandler : MonoBehaviour
{
    private ARTrackedImage trackedImage;

    void Awake()
    {
        // Obtén el componente ARTrackedImage
        trackedImage = GetComponent<ARTrackedImage>();
    }

    void Update()
    {
        // Verifica el estado de rastreo
        if (trackedImage.trackingState == TrackingState.None || 
            trackedImage.trackingState == TrackingState.Limited)
        {
            // Si la imagen no es rastreada, oculta el modelo
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (trackedImage.trackingState == TrackingState.Tracking)
        {
            // Si la imagen es rastreada, muestra el modelo
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
