using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Renderer[] waterRenderers; // Array van renderers van de waterobjecten
    public Material lavaMaterial; // Het nieuwe materiaal dat je wilt toepassen op het water

    private Material[] originalMaterials; // Array van oorspronkelijke materialen van het water
    private bool materialsChanged = false; // Variabele om bij te houden of de materialen al zijn veranderd

    private void Start()
    {
        // Bewaar de oorspronkelijke materialen van het water
        originalMaterials = new Material[waterRenderers.Length];
        for (int i = 0; i < waterRenderers.Length; i++)
        {
            originalMaterials[i] = waterRenderers[i].material;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Controleer of het trigger-object een speler is
        {
            // Als de materialen nog niet zijn veranderd, verander ze naar het nieuwe materiaal
            if (!materialsChanged)
            {
                ChangeMaterials(lavaMaterial);
                materialsChanged = true;
            }
            else // Als de materialen al zijn veranderd, verander ze terug naar de oorspronkelijke materialen
            {
                ChangeMaterials(originalMaterials);
                materialsChanged = false;
            }
        }
    }

    // Methode om de materialen van de waterobjecten te veranderen
    private void ChangeMaterials(Material newMaterial)
    {
        foreach (Renderer renderer in waterRenderers)
        {
            renderer.material = newMaterial;
        }
    }

    // Overloaded methode om de materialen van de waterobjecten te veranderen naar een array van materialen
    private void ChangeMaterials(Material[] newMaterials)
    {
        for (int i = 0; i < waterRenderers.Length; i++)
        {
            waterRenderers[i].material = newMaterials[i];
        }
    }
}
