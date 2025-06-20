using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipedownprefab;
    int mode=1;
    float pipeposy, pipeposx;
    private GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("Modes",1);

        switch (mode)
        {
            case 1:

                InvokeRepeating("Pipe1DoweGenerator", 1f, 2f);


                break;
            case 2:
                InvokeRepeating("Pipe2DoweGenerator", 1f, 1.5f);

                break;
            case 3:
                InvokeRepeating("Pipe2DoweGenerator", 1f, 1f);

                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

    
    
    }
    
    public void Pipe1DoweGenerator()
    {

        pipeposy = Random.Range(-3f, -1f);
         g = Instantiate(pipedownprefab, new Vector2(transform.position.x, pipeposy), Quaternion.identity);
        Destroy(g, 15f);
    }
    
    public void Pipe2DoweGenerator()
    {
        //mode=PlayerPrefs.GetInt("Modes");
      
                
        pipeposy = Random.Range(-4f, -1f);
        pipeposx = Random.Range(0f, 2f);
        g = Instantiate(pipedownprefab, new Vector2(transform.position.x+pipeposx, pipeposy), Quaternion.identity);
        Destroy(g, 15f);
          
        
    }
    public void Pipe3DoweGenerator()
    {

        pipeposy = Random.Range(-2f, -1f);
        pipeposx = Random.Range(0f, 5f);
        g = Instantiate(pipedownprefab, new Vector2(transform.position.x + pipeposx, pipeposy), Quaternion.identity);
        Destroy(g, 15f);
    }
}
