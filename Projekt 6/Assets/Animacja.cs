using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class Animacja : MonoBehaviour
{
    GameObject player;
    public Animator anim;
    private bool klik;



    void Start()
    {
        anim = player.GetComponent<Animator>();
        klik = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T) && klik==false)
        {
            anim.SetBool("machaj", true);
            klik = true;
            Debug.Log("cos");
        }
        if (Input.GetKeyUp(KeyCode.Y) && klik == true)
        {
            anim.SetBool("machaj", false);
            klik = false;
            Debug.Log("cdsaos");
        }

    }





    void Open_Dor()
    {
        
    }
    void Close_Dor()
    {
       
    }


}
