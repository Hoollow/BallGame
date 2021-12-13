using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoint : MonoBehaviour
{

    public AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.score += 50;
        Destroy(gameObject);
    }
}
