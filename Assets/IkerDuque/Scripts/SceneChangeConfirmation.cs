using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeConfirmation : MonoBehaviour
{
    [SerializeField] private GameObject confirmationCanvas; // El Canvas de confirmación
    [SerializeField] private string sceneToLoad; // La escena a cargar

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Muestra el Canvas de confirmación al detectar la colisión
            confirmationCanvas.SetActive(true);
        }
    }

    public void ConfirmChangeScene()
    {
        // Carga la escena
        SceneManager.LoadScene(sceneToLoad);
    }

    public void CancelChangeScene()
    {
        // Oculta el Canvas de confirmación sin hacer nada
        confirmationCanvas.SetActive(false);
    }
}
