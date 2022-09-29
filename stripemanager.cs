using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stripemanager : MonoBehaviour
{
    [SerializeField]GameObject stripePrefab;
    private float[] stripePosition={-3.56f,-2.6f,-1.65f,-0.68f,0.31f,1.277f,2.2f};
    // Start is called before the first frame update
    public void SpawnStripe()
    {
        GameObject stripe=Instantiate(stripePrefab,transform);
        stripe.transform.position=new Vector3(stripePosition[Random.Range(0,stripePosition.Length)],0.62f,0);
    }
}
