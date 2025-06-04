using UnityEngine;

public class ZoneSpawner : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Prefab de la zona interactiva.")]
    private GameObject blueZonePrefab;

    [SerializeField]
    [Tooltip("Prefab de la zona interactiva.")]
    private GameObject redZonePrefab;

    [SerializeField]
    [Tooltip("Distancia de las zonas respecto a la cámara.")]
    private float zoneDistance = 2f;

    void Start()
    {
        // Crear zona azul.
        Vector3 cameraPosition = Camera.main.transform.position;
        Vector3 cameraForward = Camera.main.transform.forward;

        Vector3 blueZonePosition = cameraPosition + cameraForward * zoneDistance + Vector3.left;
        Vector3 redZonePosition = cameraPosition + cameraForward * zoneDistance + Vector3.right;

        Instantiate(blueZonePrefab, blueZonePosition, Quaternion.identity);
        Instantiate(redZonePrefab, redZonePosition, Quaternion.identity);
    }
}
