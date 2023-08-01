using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadLand : MonoBehaviour
{

 public GameObject player;


 void OnTriggerStay(Collider other)
 {
    other.gameObject.GetComponent<playerStat>().ReduceHP();
 }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
