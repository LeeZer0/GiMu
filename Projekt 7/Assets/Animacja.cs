using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class Animacja : MonoBehaviour
{
    GameObject player;
    public Animator anim;
    public bool klik;
    public float rel_time;


    void Start()
    {
        anim = player.GetComponent<Animator>();
        klik = false;
    }

    // Update is called once per frame
    void Update()
    {


        rel_time += Time.deltaTime;


        if (Input.GetKeyUp(KeyCode.T) && klik==false)
        {
            klik = true;
            Debug.Log("cos");
            rel_time = 0f;

        }
        if (klik && rel_time>7.0f)
        {
            klik = false;
        }
        anim.SetBool("machaj", klik);
    }








}
