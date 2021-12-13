using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        MoveBall component = other.gameObject.GetComponent<MoveBall>();

        if (component != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
