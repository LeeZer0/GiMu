using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class Drzwi : MonoBehaviour
{
    GameObject doors;
    public  Animator anim;




    void Start()
    {
        anim = doors.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    
    private void OnTriggerExit(Collider col)
    {

        if (col.gameObject.name == "Player")
        {

            Close_Dor();
            
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {

            Open_Dor();
           
        }
    }
    void Open_Dor()
    {
        anim.SetBool("IsOp", true);
    }
    void Close_Dor()
    {
        anim.SetBool("IsOp", false);
    }


}
