using UnityEngine.UI;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    private float speed = 10.0f;
    private int counter;
    public Text textCounter;
    public Text winText;

    public void Start() {
        rb = GetComponent<Rigidbody>();
        counter = 0;
        textCounter.text = "Count: " + counter.ToString();
        winText.text = "";
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
            counter++;
            textCounter.text = "Count: " + counter.ToString();
            if(counter >=20) {
                winText.text = "you win!";
            }
        }
    }
}
