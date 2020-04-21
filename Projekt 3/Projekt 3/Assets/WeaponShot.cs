using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShot : MonoBehaviour
{

    public GameObject cam;
    public GameObject body;
    private Rigidbody rig;
    private Vector3 spherePosition;
    public GameObject prefab;
    public float rel_time = 3.0f;
    public float fast_shot = 1f;
    public int mag_cap = 5;
    public int num_mag = 5;
    public int damage = 1;
    public bool isEnemyShot = false;
    public float fast_bulest = 100f;

    private float canShot = 0.0f;
    private float canAmo = 0.0f;
    private int amo = 5;
    private int magazin = 5;
    private int rel = 0;
    private float barWidth;
    private float barHeight;
    private int CanUse = 0;

    private GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {





        if (Input.GetKey(KeyCode.Alpha1))
        {
            CanUse = 0;

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            CanUse = 1;

        }

        if (Input.GetKey(KeyCode.Mouse0) && CanUse == 1)
        {
            
            if (canShot <= 0.0f && amo > 0)
            {
                amo -= 1;
                canShot = fast_shot;
                
                fire();
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            
            if (magazin > 0 && amo >= 0 && amo < mag_cap)
            {
                amo = 0;
                if (rel == 0)
                {
                    rel = 1;
                    magazin -= 1;

                }
                canAmo = rel_time;




            }
        }




        if (canShot > 0.0f)
        {
            canShot -= Time.deltaTime;

        }
        if (canAmo > 0.0f)
        {
            canAmo -= Time.deltaTime;

        }
        if (amo == 0 && rel == 1 && canAmo <= 0.0f)
        {
            amo = mag_cap;
            rel = 0;
        }



    }


    void fire()
    {


        var moues = Input.mousePosition;
        //var screenPoint = Camera.main.ViewportToScreenPoint(transform.localPosition);
        var screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        var offset = new Vector3(body.transform.position.x, body.transform.position.y + 1f, body.transform.position.z );
        float bodyy= (body.transform.localEulerAngles.y )  ;
        float bodyy2 = (body.transform.localEulerAngles.y-360f)*(-1);
        Debug.Log(bodyy);

        //Debug.Log(cam.transform.rotation.x);
        if (0f<= bodyy && bodyy < 90f)
        {
           float a= bodyy ;
           float b= 90f-Mathf.Abs(a);
           

           g = (GameObject)Instantiate(prefab, offset, Quaternion.Euler(0, 0, 0));
           g.GetComponent<Rigidbody>().AddForce(a, -cam.transform.rotation.x * 180, b, ForceMode.Impulse);


        }
        if (90f <= bodyy && bodyy < 180f)
        {
            float a = 180f-bodyy ;
            float b = 90f-Mathf.Abs(a) ;


            g = (GameObject)Instantiate(prefab, offset, Quaternion.Euler(0, 0, 0));
            g.GetComponent<Rigidbody>().AddForce(a, -cam.transform.rotation.x * 180, -b, ForceMode.Impulse);


        }
        if (180f <= bodyy && bodyy < 270f)
        {
            float a = 180f - bodyy;
            float b = 90f - Mathf.Abs(a);


            g = (GameObject)Instantiate(prefab, offset, Quaternion.Euler(0, 0, 0));
            g.GetComponent<Rigidbody>().AddForce(a, -cam.transform.rotation.x * 180, -b, ForceMode.Impulse);
        }
        if (270f <= bodyy && bodyy < 360f)
        {
            float a = bodyy-360f;
            float b = 90f - Mathf.Abs(a);


            g = (GameObject)Instantiate(prefab, offset, Quaternion.Euler(0, 0, 0));
            g.GetComponent<Rigidbody>().AddForce(a, -cam.transform.rotation.x * 180, b, ForceMode.Impulse);
        }
        //var dir = (body.transform.rotation.y, cam.transform.rotation.x) ;
        //GameObject g = (GameObject)Instantiate(prefab, offset, Quaternion.Euler(0, 0, 0));


        //body.transform.rotation.y * 180;

        //g.GetComponent<Rigidbody2D>().gravityScale = 1f;
        //g.GetComponent<Rigidbody>().AddForce(bodyy, -cam.transform.rotation.x * 180, 100, ForceMode.Impulse);

        Destroy(g, 10);
        //
    }

    void Awake()
    {
        barHeight = Screen.height * 0.02f;
        barWidth = barHeight * 10.0f;
    }

    void OnGUI()
    {

        GUI.TextField(new Rect(Screen.width - barWidth - 20,
                                Screen.height - barHeight * 3 - 50,
                                30,
                                20),
                                amo.ToString());
        GUI.TextField(new Rect(Screen.width - barWidth + 10,
                                Screen.height - barHeight * 3 - 50,
                                20,
                                20),
                                magazin.ToString());
        GUI.TextField(new Rect(Screen.width - barWidth - 20,
                                Screen.height - barHeight * 3 - 70,
                                30,
                                20),
                                amo.ToString());



    }


    void OnTriggerEnter2D(Collider2D col)
    {
        // Is this a shot?
        Debug.Log(col+" 2 ");
        if (true)
        {

            Destroy(gameObject);
        }
    }

}
