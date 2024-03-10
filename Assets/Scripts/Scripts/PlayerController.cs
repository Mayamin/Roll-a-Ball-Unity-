using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  //check player input in every game, apply that to player game object every frame
  //update is called before rendering a game and fixed update is called before conductiong any physics calcualtion
  
  //when we create public variable we can edit and apply changes in editor (from Inspector)
  public float speed; 
  public Text countText;
  public Text winText;

  //varaible to hold the refernce
  private Rigidbody rb;
  private int count;


  void Start()
  {
    rb = GetComponent<Rigidbody>();
    count = 0 ;
    SetCountText();
    winText.text = "";
    
  }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // x y z values determine the direction of force
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
          other.gameObject.SetActive(false);
          count = count + 1 ;
          SetCountText();
        }
    }

       void SetCountText()
    {
      countText.text = "Count: " + count.ToString();
      if(count >= 13)
      {
        winText.text = "You Win!";
      }

    }


   
}
