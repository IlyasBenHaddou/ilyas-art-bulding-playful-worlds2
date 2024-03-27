using UnityEngine;
using UnityEngine.Rendering;

public class VolumeToggle : MonoBehaviour
{
    public Volume volume; // Het Volume-component dat je wilt in- en uitschakelen

    private void Start()
    {
        volume.enabled = false; // Zorg ervoor dat het Volume-component uit staat bij het starten van de scène
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Controleer of het trigger-object een speler is
        {
            volume.enabled = !volume.enabled; // Wissel de enabled status van het Volume-component
        }
    }
}
