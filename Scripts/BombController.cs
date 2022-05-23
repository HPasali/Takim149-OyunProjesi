using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BombController : MonoBehaviour
{
    float Horizontal;

    public float straightSpeed = 6.0f;
    public float horizontalSpeed = 3.0f;

    public Transform target;
    public GameObject bomb;
    public float time = 2f;
    public BombShooter cannonBall;
   //public cameraFollow cam;

    void Start()
    {

    }

    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");

        transform.position += new Vector3(Horizontal * horizontalSpeed, 0, straightSpeed) * Time.deltaTime;
        transform.Rotate(0f, 2f, 0f, Space.Self);        
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "FinishLine")
        {
            straightSpeed = 0;
            horizontalSpeed = 0;
            transform.DOMove(target.position, time);
            cannonBall.enabled = true;
            //cam.enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
