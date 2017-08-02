using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    public int counter;
    public Text win;
    public Text count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        counter = 0;
        updateCounter();
        win.text = "";
       
    }

    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = Input.GetAxis("Jump");
        
        Vector3 movement = new Vector3(moveHorizontal, moveJump*5, moveVertical);
        
        rb.AddForce(movement * speed);

        
    }

    void updateCounter()
    {
        count.text = "Score: " + counter.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            counter = counter + 1;
            updateCounter();

            if (counter >= 10)
                win.text = "Congratulations, you won the game!";
        }
    }
}
