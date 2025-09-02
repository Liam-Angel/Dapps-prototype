using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shootController : MonoBehaviour
{
    public GameObject bullet;
    public InputAction shootAction;
    public Transform firePoint;
    public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
        shootAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        bool allowShoot;
        
        
        float shootInput = shootAction.ReadValue<float>();
        print(shootInput);
        if (shootInput == 1)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);           
        }
    }
}
