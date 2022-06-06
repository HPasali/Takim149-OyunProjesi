using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BombScaling : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag.Equals("ScaleUpBoard")){
            // gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            transform.DOScale(new Vector3(gameObject.transform.localScale.x + 0.2f, gameObject.transform.localScale.y + 0.2f, gameObject.transform.localScale.z + 0.2f), duration: 0);
            
           
            

        }
        if(other.transform.tag.Equals("ScaleDownBoard")){
            //  gameObject.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            transform.DOScale(new Vector3(gameObject.transform.localScale.x - 0.1f, gameObject.transform.localScale.y - 0.1f, gameObject.transform.localScale.z - 0.1f), duration: 0);
        }
    }
}
