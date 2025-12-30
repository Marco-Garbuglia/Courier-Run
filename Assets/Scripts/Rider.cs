using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rider : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    public AudioClip[] audioClips;
    AudioSource audioSource;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //int counter = 0;
        if(Input.GetMouseButtonDown(0) && !GameController.gameover)
        {
            if(counter < 1)   //solo finche� sono meno di 2 si pu� saltare
            {
                audioSource.PlayOneShot(audioClips[0]);
                rb.linearVelocity = new Vector2(0.5f, 7f);  // 0.5f � accelerazione orizzontale
                counter++;
            }
            if(counter > 1)  //solo finche� sono pi� di 2 si pu� decelerare per non andare troppo avanti
            {
                audioSource.PlayOneShot(audioClips[0]);
                rb.linearVelocity = new Vector2(-0.5f, 0f);  // 0.5f � decelerazione orizzontale
                counter++;
            }
            if (rb.position.y <= -1.87) //solo quando tocca Pavimento ossia in y=-1.87, il counter delle premute diventa zero
            {
                counter = 0;
            }
        }

        if(transform.position.x < -4 || transform.position.x > 4) //quando rider esce dall'inquadratura allora GameOver
        {
            audioSource.PlayOneShot(audioClips[1]);
            GameController.gameover = true;
            gameover.SetActive(true);
            restart.SetActive(true);
        }
    }
    //private void OnTriggerEnter2D(Collision2D collision)
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
     //   if(collision.gameObject.tag == "Ostacoli")// || collision.gameObject.tag == "Pavimento") //private void OnCollisionEnter2D(Collision2D collision)
       // {
        //    audioSource.PlayOneShot(audioClips[1]);
          //  GameController.gameover = true;
            //gameover.SetActive(true);
           // restart.SetActive(true);
        //}
    //}
}
//}
