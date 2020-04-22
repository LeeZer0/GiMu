using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float canSpa = 3f;
    private int dol = 0;
    Rigidbody Rig;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dol==1)
        {
            

            Spada();
            
        }

    }

    private void OnTriggerStay2D(Collider2D col)
    {


        if (col.gameObject.name == "Player")
        {

            //Platform.rigidbody2D.isKinematic = false;
            // GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;

        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "Player")
        {  //check name
            rend.material.SetColor("_Color", Color.red);
            dol = 1;
           
        }
    }
    void Spada()
    {
        
        
        Renderer rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
        //Debug.Log(canSpa);
        canSpa -= Time.deltaTime;
        if (canSpa < 0)
        { 
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            rend.material.SetColor("_Color", Color.black);
        }
        if (canSpa < -2)
        {
            Destroy(gameObject, 2);
            
        }
    }


}
