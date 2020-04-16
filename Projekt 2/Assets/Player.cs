using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    Camera cam;
    PlayerMovementController playerMovement;



    private float basicSpeed;
    private float runSpeed;
    private float Timer;
    private bool isRunning;
    private float healthValue=5;

    [SerializeField]
    private float boost;
    [SerializeField]
    private float staminaWaste;
    [SerializeField]
    private float staminaRegeneration;









    public Camera Cam { get => cam; set => cam = value; }
    public bool IsRunning { get => isRunning; set => isRunning = value; }

    private void Awake()
    {
        playerMovement = new PlayerMovementController();
    }

    protected override void Start()
    {
        cam = Camera.main;
        setupVariables();
        base.Start();
    }



    private void setupVariables()
    {
        staminaRegeneration = 2;
        staminaWaste = 15;
        boost = 2;
        basicSpeed = Speed;
        runSpeed = basicSpeed * boost;
    }

    protected override void Update()
    {
        //InitializeStatsValues();
        Timer += Time.deltaTime;
        
        InputKeys();
        InputActionKeys();
        checkPlayerStatus();
        base.Update();
    }

    public void InputKeys()
    {
        Direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            Direction += Vector3.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Direction += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (1 > 0)
                IsRunning = true;

        }
        else
        {
            IsRunning = false;
        }
    }

    private void InputActionKeys()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
        }
    }


    // Set our focus to a new focus










    public void damagePlayer(int damage)
    {
        healthValue -= damage;
        if (healthValue <= 0)
            GameObject.Destroy(this);
    }

    public void checkPlayerStatus()
    {
        if(healthValue <= 0)
        {
            Destroy(gameObject);
        }
    }

}

public class PlayerMovementController
{
    public void InputKeys(ICharacter character, IPlayer player,
        bool w, bool s, bool a, bool d, bool shift)
    {
        //direction = Vector3.zero;

        if (w)
        {
            character.Direction += Vector3.up;
        }
        if (a)
        {
            character.Direction += Vector3.left;
        }
        if (s)
        {
            character.Direction += Vector3.down;
        }
        if (d)
        {
            character.Direction += Vector3.right;
        }
        if (shift)
        {
            if (1 > 0)
                player.IsRunning = true;

        }
        else
        {
            player.IsRunning = false;
        }
    }

    void OnDestroy()
    {
        Debug.Log("Script was destroyed");
    }


}
