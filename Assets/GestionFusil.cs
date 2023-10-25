using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class GestionFusil : MonoBehaviour
{
    public Transform pointDeTir; // Point de d�part du Raycast
    public float distanceRaycast = 10f; // Distance du Raycast


    // Update is called once per frame
    public void Shoot()
    {
        Debug.Log("Shooting...");
            // Cr�e un Raycast dans la direction de l'axe des Z (forward) � partir du point de tir
            Ray ray = new Ray(pointDeTir.position, pointDeTir.forward);
            RaycastHit hit;

            // V�rifie si le Raycast frappe un objet � une distance de 10m
            if (Physics.Raycast(ray, out hit, distanceRaycast))
            {
            Debug.Log("dans le if du raycast");
                // V�rifie si l'objet frapp� est un ballon (vous pouvez ajuster le tag selon vos besoins)
                if (hit.collider.CompareTag("Ballon"))
                {
                Debug.Log("dans le if du ballon");
                    // Fait dispara�tre le ballon frapp�
                    Destroy(hit.collider.gameObject);
                }
            }
        

    }

}
