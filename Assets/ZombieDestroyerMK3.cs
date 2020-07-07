using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDestroyerMK3 : MonoBehaviour
{
    private GameObject[] Zombies;

    private void FixedUpdate()
    {
        Zombies = GameObject.FindGameObjectsWithTag("Enemy");
        Annihilate(Zombies);
    }


    private void Annihilate(GameObject[] x)
    {
        foreach(GameObject element in x)
        {
            Destroy(element);
        }
    }
}
