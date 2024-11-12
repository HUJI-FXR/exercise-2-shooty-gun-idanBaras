using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletTrans;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) {
            GameObject b =  Instantiate(bullet, bulletTrans.position, Quaternion.identity);
            b.SetActive(true);
        }
    }
}
