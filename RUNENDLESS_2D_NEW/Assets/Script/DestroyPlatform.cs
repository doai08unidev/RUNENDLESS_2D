using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private Transform destroyPoint;
    // Start is called before the first frame updateQ
    void Start()
    {
        destroyPoint = GameObject.Find("DestroyPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x < destroyPoint.transform.position.x){
            // Destroy(this.gameObject);
            gameObject.name="vua moi destroy";
            gameObject.SetActive(false);
        }
    }
}
