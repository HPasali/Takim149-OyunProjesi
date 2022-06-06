using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BombController : MonoBehaviour
{
    float Horizontal;
    public float boost;
    public float speed;
    float backForce;
    Vector3 mousePosition;
    

    public float straightSpeed = 6.0f;
    public float horizontalSpeed = 3.0f;

    public Transform target;
    public GameObject bomb;
    public float time = 2f;
    public BombShooter cannonBall;
   public  CameraController cam;

    void Start()
    {

    }

    void Update()
    {
        
        Horizontal = Input.GetAxis("Horizontal");

        transform.position += new Vector3(Horizontal * horizontalSpeed, 0, straightSpeed) * Time.deltaTime;
        transform.Rotate(0f, 2f, 0f, Space.Self);
        float horizontal = 0;
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            horizontal = (Input.mousePosition.x - mousePosition.x) / Screen.width * 1.5f;
            mousePosition = Input.mousePosition;
        }
        boost = Mathf.Clamp(boost + Time.deltaTime * 1f, -2, -1);

        transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed * -boost + new Vector3(1, 0, 0) * horizontal * 5;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4f, 4f), transform.position.y, transform.position.z);

    }

    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "FinishLine")
        {
            straightSpeed = 0;
            horizontalSpeed = 0;
            transform.DOMove(target.position, time);
            cannonBall.enabled = true;
            cam.enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
