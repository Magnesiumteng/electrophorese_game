using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stripe : MonoBehaviour
{
    [SerializeField]float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-movespeed*Time.deltaTime,0);
        if(transform.position.y<-4.25f)
        {
            Destroy(gameObject);
            transform.parent.GetComponent<stripemanager>().SpawnStripe();
        }
    }

   
}
