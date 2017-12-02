using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    private float speed = 10.0f;

    public void Start() {
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Pick up")) {
            other.gameObject.SetActive(false);
        }
    }
}
