using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _direction;
    public float speed = 10f;
    public Transform Position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {
        transform.position = transform.position + _direction * Time.fixedDeltaTime * speed;
    }
}
