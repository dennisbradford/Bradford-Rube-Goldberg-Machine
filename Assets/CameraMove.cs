using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 endPosition;
    private Vector3 startPosition;
    private float desiredDuration = 0.5f;
    public float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition;
        elapsedTime = 0f;
    }

    public void SetEndPosition(Vector3 nep){ //nep = new end position
        endPosition = nep;
        elapsedTime = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;
        transform.position = Vector3.Lerp(startPosition, endPosition, percentageComplete);

        if(elapsedTime > desiredDuration)
            startPosition = endPosition;
    }
}
