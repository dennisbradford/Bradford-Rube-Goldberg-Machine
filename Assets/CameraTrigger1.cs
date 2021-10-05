using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger1 : MonoBehaviour
{
    public CameraMove cam;
    public Transform newPosition;
    public MyRedBall ball;
    private Vector3 endPosition;

  void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject == ball.gameObject){
            Debug.Log("Ball has entered trigger area");
            endPosition = new Vector3(newPosition.transform.position.x, newPosition.transform.position.y, cam.transform.position.z);
            cam.SetEndPosition(endPosition);
        }
  }

}
