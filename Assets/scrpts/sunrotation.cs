using UnityEngine;

public class SunRotationController : MonoBehaviour
{
    public Transform sunTransform; // Transform van de zon
    public Vector3 newRotation; // Nieuwe rotatie van de zon wanneer de trigger wordt geraakt

    private Vector3 originalRotation; // Oorspronkelijke rotatie van de zon

    private void Start()
    {
        // Bewaar de oorspronkelijke rotatie van de zon
        originalRotation = sunTransform.rotation.eulerAngles;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Controleer of het trigger-object een speler is
        {
            // Verander de rotatie van de zon naar de nieuwe rotatie
            sunTransform.rotation = Quaternion.Euler(newRotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Controleer of het trigger-object een speler is
        {
            // Zet de rotatie van de zon terug naar de oorspronkelijke rotatie
            sunTransform.rotation = Quaternion.Euler(originalRotation);
        }
    }
}
