using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class birdController : MonoBehaviour
{
    public AudioClip die, flap, birdHit, point;
    public AudioSource Audio;
    Rigidbody2D rb;
    float speed = 5f;
    public Text scoretext, highscoretext;
    int scorecnt = 0,highscore,temp;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        highscore=PlayerPrefs.GetInt("HighScore", 0);
        highscoretext.text = "HighScore=" + highscore;

        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity =new Vector2(speed,rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            Audio.clip=flap;
            Audio.Play();
            rb.velocity=new Vector2(rb.velocity.x,speed); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            Audio.clip=die;
            Audio.Play();
            print("end");
            temp = PlayerPrefs.GetInt("HighScore");
            if (temp < scorecnt)
            {
                highscore = scorecnt;
                PlayerPrefs.SetInt("HighScore", highscore);
            }
            //StartCoroutine(SceneDeley());
            SceneManager.LoadScene("GameOver");

        }

        if (collision.gameObject.tag=="Point")
        {
            scorecnt += 1;
            scoretext.text = "Score=" + scorecnt;
           

            Audio.clip= point;
            Audio.Play();

            Destroy(collision.gameObject);
            print("point");
        }
    }
    //IEnumerator SceneDeley()
    //{
    //    yield return new WaitForSeconds(.5f);
    //    SceneManager.LoadScene("GameOver");

    //}
}
