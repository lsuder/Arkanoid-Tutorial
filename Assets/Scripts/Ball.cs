using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    // Movement Speed
    public float speed = 100.0f;

    // Use this for initialization
    void Start() {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
}
