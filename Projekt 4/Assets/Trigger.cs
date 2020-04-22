using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider col)
    {
        
        if (col.gameObject.name == "Pocisk(Clone)")
        {
            Debug.Log("kolor");
            rend.material.SetColor("_Color", Random.ColorHSV());

        }
    }
}
