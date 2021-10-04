using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger1 : MonoBehaviour
{
    public Camera cam;
    public Transform newPosition;
    private Vector3 endPosition;
    private Vector3 startPosition;
    private float desiredDuration = 0.5f;
    private float elapsedTime;

    void Start(){
        endPosition = cam.transform.position;
    }
  void OnTriggerEnter2D(Collider2D collision){
      elapsedTime = 0;
      startPosition = cam.transform.position;
      endPosition = new Vector3(newPosition.transform.position.x, newPosition.transform.position.y, cam.transform.position.z);
  }

  void Update(){
      elapsedTime += Time.deltaTime;
      float percentageComplete = elapsedTime / desiredDuration;
      cam.transform.position = Vector3.Lerp(startPosition, endPosition, percentageComplete);
  }
}
