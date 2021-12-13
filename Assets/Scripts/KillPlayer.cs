using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ups");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoringSystem.score = 0;

    }
    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoringSystem.score = 0;

    }
}
