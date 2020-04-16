using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMen : MonoBehaviour
{
    

    static public int points;
    static public int time;
    public float secDel = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<TextMesh>().text = points.ToString();
        secDel -= Time.deltaTime;
        if(secDel<=0)
        {
            time += 1;
            secDel = 1;
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 11, Screen.height / 11, 65, 25), "Czas: " + time.ToString());
        if (time > 30 || points>400)
        {
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 65, 25), "Wygrałeś");
        }
    }
}
