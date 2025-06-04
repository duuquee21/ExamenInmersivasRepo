using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveZone : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Texto de la UI que sugiere cambiar de escena.")]
    private GameObject suggestionUI;

    [SerializeField]
    [Tooltip("Nombre de la escena a cargar.")]
    private string sceneToLoad;

    void Start()
    {
        // Asegurarse de que la UI está oculta al inicio.
        if (suggestionUI != null)
        {
            suggestionUI.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Mostrar la UI al entrar en la zona.
        if (other.CompareTag("Player") && suggestionUI != null)
        {
            suggestionUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Ocultar la UI al salir de la zona.
        if (other.CompareTag("Player") && suggestionUI != null)
        {
            suggestionUI.SetActive(false);
        }
    }

    public void LoadScene()
    {
        // Cargar la escena específica.
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
