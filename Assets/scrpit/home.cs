using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    //public Slider slider;
    public GameObject Modesobj,birdobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setting()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene("Play");
    }
    public void homepage()
    {
        SceneManager.LoadScene("Home");
    }
    //public void vloume(float val)
    //{
    //    slider.value = val; 
    //}
    public void modesbtn()
    {
        Modesobj.SetActive(true);
    }
    public void modesbtn(int n)
    {
        PlayerPrefs.SetInt("Modes",n);
        Modesobj.SetActive(false);

        //SceneManager.LoadScene("Play");
    }
    public void birdselect(int bird)
    {
       PlayerPrefs.SetInt("Bird",bird);
        birdobj.SetActive(false);

        //SceneManager.LoadScene("Play");
    }
    public void birdselectbtn()
    {
        birdobj.SetActive(true);
    }
}
