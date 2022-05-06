using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    float Horizontal;

    [SerializeField] float straightSpeed = 2.0f;
    [SerializeField] float horizontalSpeed = 1.0f;
    void Start()
    {

    }

    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");

        transform.position += new Vector3(Horizontal * horizontalSpeed, 0, straightSpeed) * Time.deltaTime;
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "FinishLine"){
            straightSpeed = 0;
            horizontalSpeed = 0;
        }
    }
}
