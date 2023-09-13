using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncommingVahicleMovement : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.y < -10f && gameObject.name.Contains("Clone"))
        {
            Destroy(gameObject);
        }
    }
}
