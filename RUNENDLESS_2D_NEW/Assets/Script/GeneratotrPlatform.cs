using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratotrPlatform : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] Transform generatorPoint;
    float distancePlat = 3f;
    float widthPlatform;
     
    // Start is called before the first frame update
    void Start()
    {
        widthPlatform = GameObject.Find("Platform").GetComponent<BoxCollider2D>().size.x;
        print(widthPlatform);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x < generatorPoint.transform.position.x){
            this.transform.position = new Vector3(this.transform.position.x + distancePlat + widthPlatform, this.transform.position.y, this.transform.position.z);
            Instantiate(platform,this.transform.position,this.transform.rotation);
        }
    }
}
