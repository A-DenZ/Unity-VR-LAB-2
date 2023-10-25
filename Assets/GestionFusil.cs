using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class GestionFusil : MonoBehaviour
{
    public Transform pointDeTir; // Point de départ du Raycast
    public float distanceRaycast = 10f; // Distance du Raycast


    // Update is called once per frame
    public void Shoot()
    {
        Debug.Log("Shooting...");
            // Crée un Raycast dans la direction de l'axe des Z (forward) à partir du point de tir
            Ray ray = new Ray(pointDeTir.position, pointDeTir.forward);
            RaycastHit hit;

            // Vérifie si le Raycast frappe un objet à une distance de 10m
            if (Physics.Raycast(ray, out hit, distanceRaycast))
            {
            Debug.Log("dans le if du raycast");
                // Vérifie si l'objet frappé est un ballon (vous pouvez ajuster le tag selon vos besoins)
                if (hit.collider.CompareTag("Ballon"))
                {
                Debug.Log("dans le if du ballon");
                    // Fait disparaître le ballon frappé
                    Destroy(hit.collider.gameObject);
                }
            }
        

    }

}
