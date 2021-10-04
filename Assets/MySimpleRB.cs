using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySimpleRB : MonoBehaviour
{
    // Start is called before the first frame update

        Rigidbody2D rb;
        bool moveLeft;
        bool moveRight;

        public float power = 1.0f;

        void Awake(){
            rb = GetComponent<Rigidbody2D>();
        }

        void CheckInput(){
            if(Input.GetKey(KeyCode.LeftArrow)) {
                moveLeft = true;
            }
            else {
                moveLeft = false;
            }

            moveRight = Input.GetKey(KeyCode.RightArrow);
        }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
    }

    private void FixedUpdate() {
        if(moveLeft)
            rb.AddForce(Vector2.left * power);
    
        if(moveRight)
            rb.AddForce(Vector2.right *power);
        

    }
}
