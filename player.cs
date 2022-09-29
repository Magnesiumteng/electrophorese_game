using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    public Text timertext;
    [SerializeField]private int minute=10;
    [SerializeField]private float second=0;
    [SerializeField]private float movespeed=5f;
    [SerializeField]private GameObject replaybutton;
    [SerializeField]private GameObject winbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        Move();
    }

    void Timer()
    {
        if(second<0.01)
        {
            minute=minute-1;
            second=60;
        }
        second-=Time.deltaTime;
        timertext.text="Time: "+minute.ToString("F0")+":"+((int)second).ToString("F0");
        if(minute<0)
        {
            Time.timeScale=0f;
            winbutton.SetActive(true);

        }
        
        
        

    }

    void Move()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(movespeed*Time.deltaTime,0,0);
            GetComponent<SpriteRenderer>().flipX=false;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movespeed*Time.deltaTime,0,0);
            GetComponent<SpriteRenderer>().flipX=true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "deadline")
        {
            Time.timeScale=0f;
            replaybutton.SetActive(true);
        }

    }

    public void Replay()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("SampleScene");
    }
}

