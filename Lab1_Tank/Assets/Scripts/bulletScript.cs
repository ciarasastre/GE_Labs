using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    public GameObject bullets;
    public float bull_xPos = 0 / 5;
    public float bull_yPos = 1;
    public float bull_zPos = 2;

    private void Start()
    {
        //Instantiate(bullets, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        //Now get the bullets working
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullets, new Vector3(bull_xPos, bull_yPos, bull_zPos), Quaternion.Euler(0, 180, 0));
        }

    }

    void Fire_Bullet()
    { 


    }

}
