using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] Player;
    Vector2 offset;
    public GameObject[] bird;

    // Start is called before the first frame update
    void Start()
    {

        offset = transform.position - Player[PlayerPrefs.GetInt("Bird", 1) - 1].transform.position;
        bird[PlayerPrefs.GetInt("Bird", 1)-1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player[PlayerPrefs.GetInt("Bird", 1) - 1].transform.position.x+offset.x,transform.position.y,transform.position.z); 
    }
}
