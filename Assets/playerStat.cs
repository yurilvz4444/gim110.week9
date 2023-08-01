using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStat : MonoBehaviour
{
    public int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth > 100)
        {
         playerHealth = 100;
        }
    }

        public void ReduceHP()
        {
            playerHealth -= 1;
        }
}
