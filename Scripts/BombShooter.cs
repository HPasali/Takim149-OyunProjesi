using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BombShooter : MonoBehaviour
{
    
    public GameObject bomb;
    public RectTransform crosshair;
    public AudioSource audioSource;


    Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        //DOTween.Init();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(bomb.transform.position.z >= 19.0f)
        {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            crosshair.DOScale(new Vector3(1, 1, 1), 0.25f);
        }

        else if (Input.GetMouseButton(0))
        {
            crosshair.position += Input.mousePosition - mousePosition;
            crosshair.position = new Vector3(Mathf.Clamp(crosshair.position.x, 0, Screen.width), Mathf.Clamp(crosshair.position.y, 0, Screen.height), 0);

            mousePosition = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            bomb.transform.position = Camera.main.transform.position + Camera.main.ScreenPointToRay(crosshair.position).direction * 1.5f;
            bomb.transform.GetComponent<Rigidbody>().AddForce(Camera.main.ScreenPointToRay(crosshair.position).direction * 2500);
            crosshair.DOScale(new Vector3(0, 0, 0), 0.25f);
            bomb.GetComponent<Rigidbody>().useGravity = true;
            audioSource.Play();
              
        }
        }
    }
}

