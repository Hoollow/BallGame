using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{

    public Rigidbody target;

    public float maxSpeed = 0.0f;

    [Header("UI")]
    public Text speedLabel;
    // Update is called once per frame

    private float speed = 0.0f;
    void Update()
    {
        speed = target.velocity.magnitude * 3.6f; //3.6 ponieważ chciałem dostosować prędkość na bardziej realną, inaczej jest w zakresach 60km/h magnitude->długość wektora
        if (speedLabel != null)
        {
            speedLabel.text = ((int)speed + " km/h");
        }
    }
}
