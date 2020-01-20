using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  
  public int speed = 100;
  private int count;
  

  // Pour l'initialisation 
  void Start () {

      count = 0;
  }
  void FixedUpdate () {
    
    float mouveHorizontal = Input.GetAxis("Horizontal");
    float mouveVertical = Input.GetAxis("Vertical");
    
    Vector3 mouvment = new Vector3(mouveHorizontal, 0, mouveVertical);
    GetComponent<Rigidbody>().AddForce(mouvment * speed * Time.deltaTime);
   
  }

  
  void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "cube")
    {
      other.gameObject.SetActive(false);
      count = count + 1;
    }
    
    else if(other.gameObject.tag == "mechant")
    {
    Application.LoadLevel(0);
    Debug.Log("Game Over !");

    }
  }

}

