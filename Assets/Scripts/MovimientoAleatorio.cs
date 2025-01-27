using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    float horizontal;
    float vertical;
    float speed;
    void Start()
    {
        horizontal = Random.Range(-1f, 1f);
        vertical = Random.Range(-1f, 1f);
        speed = Random.Range(1f, 3f);

    }
    void Update()
    {
        Vector3 direccion = new Vector3(horizontal, vertical).normalized;

        transform.position += direccion * speed * Time.deltaTime;
    }
}
