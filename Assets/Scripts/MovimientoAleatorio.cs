using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    float horizontal;
    float vertical;
    float speed;
    float movement_rotation;
    void Start()
    {
        horizontal = Random.Range(-1f, 1f);
        vertical = Random.Range(-1f, 1f);
        speed = Random.Range(1f, 3f);
        movement_rotation = Random.Range(0f, 360f);
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, movement_rotation );

    }
    void Update()
    {
        Vector3 direccion = new Vector3(horizontal, vertical).normalized;

        transform.position += direccion * speed * Time.deltaTime;
    }
}
