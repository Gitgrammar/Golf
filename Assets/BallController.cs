using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Vector2  startPos;
    Vector2 endPos;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            Vector2 dir = startPos - endPos;
            Vector3 vec = new Vector3(0, dir.y, dir.x);
            rb.AddForce(vec * 3f);
        }
        
    }
}
