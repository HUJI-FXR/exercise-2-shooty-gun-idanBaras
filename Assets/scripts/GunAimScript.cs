using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    private Camera cam;
    private float negativeRot = 180f;
    Vector3 mousePos;
    Vector3 mouseHelp;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseHelp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z - cam.transform.position.z);
        mousePos = cam.ScreenToWorldPoint(mouseHelp);
        Vector3 rotation = mousePos - gameObject.transform.position;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rot + negativeRot);
    }
}
