using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float bulletSpeed;
    private Camera cam;
    Vector3 mousePos;
    Vector3 mouseHelp;
    void Start()
    {

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        mouseHelp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z - cam.transform.position.z);
        mousePos = cam.ScreenToWorldPoint(mouseHelp);
        Vector3 rotationy = mousePos - gameObject.transform.position;
        float rot = Mathf.Atan2(rotationy.y, rotationy.x) * Mathf.Rad2Deg;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, rot);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rotationy.x, rotationy.y).normalized*bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
