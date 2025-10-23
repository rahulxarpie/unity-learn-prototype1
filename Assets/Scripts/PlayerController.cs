using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed = 20f;
    [SerializeField] private float rightSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;

    // Comment 1 here
    // comment 2 here

    private void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * rightSpeed * horizontalInput);
    }
}
