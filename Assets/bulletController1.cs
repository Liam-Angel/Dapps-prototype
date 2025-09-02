using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bulletController1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform firePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(30f, 0f);
    }


}
