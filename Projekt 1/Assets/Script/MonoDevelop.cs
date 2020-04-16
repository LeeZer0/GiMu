using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonoDevelop : MonoBehaviour
{
public int wynik=0;
public int speed;
    // Start is called before the first frame update
    void Start(){
        wynik=0;
    }
    // Update is called once per frame
    void Update(){
        float   moveHorizontal = Input.GetAxis ("Horizontal");
        float   moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    void OnTriggerEnter( Collider other){
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            wynik+=1;
        }
        if (other.gameObject.tag == "PickUp_2")
        {
            other.gameObject.SetActive(false);
            wynik+=2;
        }
    }
    
 void OnGUI() {
    GUI.Box (new Rect (Screen.width/11,Screen.height/11,65,25),"Wynik: "+wynik.ToString());
    if (wynik>9)
    {
          GUI.Box (new Rect (Screen.width/2,Screen.height/2,65,25),"Wygrałeś");
    }
}
}
