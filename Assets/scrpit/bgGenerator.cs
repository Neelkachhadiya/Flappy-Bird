using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgGenerator : MonoBehaviour
{
    public GameObject bgprefab,genpoint;
    float distance = 22.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<genpoint.transform.position.x)
        {
            transform.position=new Vector2(transform.position.x+distance,transform.position.y);
            GameObject g= Instantiate(bgprefab,transform.position,Quaternion.identity);
            Destroy(g,10f);
        }
    }
}
