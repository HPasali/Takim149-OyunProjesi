using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : MonoBehaviour
{
    public GameObject[] home;
    public List<GameObject> homepieces;
    public List<GameObject> homepieces1;
    public LevelManager levelManager;
    bool canIShoot;
    public AudioSource shoot;
    // Start is called before the first frame update
    void Start()
    {
        shoot = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.transform.tag == "home")
        {
            Debug.Log("okay");
            for (int i = 0; i < homepieces.Count; i++)
            {
                
                homepieces[i].GetComponent<Rigidbody>().useGravity = true;
                homepieces[i].GetComponent<MeshCollider>().enabled = true;
                
                shoot.Play();
                levelManager.win();

            }
        }
        else if(other.transform.tag == "garden")
        {
            levelManager.fail();
        }
       

    }
}

