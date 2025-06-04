using UnityEngine;

public class SecondaryCameraController : MonoBehaviour
{
    [SerializeField]
    private Camera secondaryCamera; // Asigna aquí la cámara que deseas controlar

    private bool isRenderingEnabled = false;

    void Start()
    {
        if (secondaryCamera != null)
        {
            // Configura la cámara para no renderizar nada al inicio
            secondaryCamera.cullingMask = 0; // No renderiza ninguna capa
            secondaryCamera.clearFlags = CameraClearFlags.SolidColor; // Fondo sólido (negro)
            secondaryCamera.backgroundColor = Color.black;
        }
    }

    void Update()
    {
        // Habilita el renderizado de la cámara al interactuar con la pantalla
        if (!isRenderingEnabled && Input.GetMouseButtonDown(0)) // Detecta clic o toque
        {
            EnableCameraRendering();
        }
    }

    private void EnableCameraRendering()
    {
        if (secondaryCamera != null)
        {
            secondaryCamera.clearFlags = CameraClearFlags.Skybox; // Cambia a renderizado normal
            secondaryCamera.cullingMask = ~0; // Renderiza todas las capas
            isRenderingEnabled = true;
        }
    }
}
