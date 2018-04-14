using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{
    private int count;
    public float speed;
    private Rigidbody rb;
    public Text countText;
    public Text winText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
    }

    private void FixedUpdate()
    {
        float moveHorizental = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizental, 0, moveVertical);
        rb.AddForce(movement*speed);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);

            count++;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Scores:" + count.ToString();
        if(count>=12)
        {
            winText.text = "YOU WIN !";
        }
    }

}
