using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class HumanBehavior : MonoBehaviour
{

    [SerializeField] Animator animationController;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.CompareTag( "Obstacle"))
            {
                Debug.Log("Haha");
            }
        }
    }


    public void PlayerInput()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W)) { 
            animationController.SetTrigger("isJump");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            animationController.SetTrigger("isSlide");
        }
    }

   

}
