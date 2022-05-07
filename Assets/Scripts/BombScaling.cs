using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScaling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag.Equals("ScaleUpBoard")){
            gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }
        if(other.transform.tag.Equals("ScaleDownBoard")){
            gameObject.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
        }
    }
}
