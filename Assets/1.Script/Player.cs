using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public Rigidbody2D rgby;
    
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        rgby = GetComponent<Rigidbody2D>();
    }
    public float moveSpeed = 2; 
    void Update()
    {
        Vector2 direction = new Vector2(0,0); // Vector2.zero;
        if(Input.GetKey(KeyCode.W))
        {
            direction += new Vector2(0,1);
        }
        if(Input.GetKey(KeyCode.S))
        {
            direction += new Vector2(0,-1);
        }
         if(Input.GetKey(KeyCode.A))
        {
            direction += new Vector2(-1,0);
        }
         if(Input.GetKey(KeyCode.D))
        {
            direction += new Vector2(1,0);
        }
        rgby.linearVelocity = direction.normalized * moveSpeed;
       
    }
    
    
}
