using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    public float speed = 10.0f;
    public int damage = 0;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
