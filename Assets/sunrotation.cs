using UnityEngine;

public class SunRotationScript : MonoBehaviour
{
    public Transform sunTransform; // Transform van de zon
    public Vector3 newRotation; // Nieuwe rotatie van de zon wanneer de trigger wordt geraakt

    private Vector3 originalRotation; // Oorspronkelijke rotatie van de zon
    private bool rotated = false; // Variabele om bij te houden of de rotatie is veranderd

    private void Start()
    {
        // Bewaar de oorspronkelijke rotatie van de zon
        originalRotation = sunTransform.rotation.eulerAngles;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !rotated) // Controleer of het trigger-object een speler is en de rotatie nog niet is veranderd
        {
            // Verander de rotatie van de zon naar de nieuwe rotatie
            sunTransform.rotation = Quaternion.Euler(newRotation);
            rotated = true; // Markeer dat de rotatie is veranderd
        }
    }


}
