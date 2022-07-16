using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    public Vector3 cameraOffset;
    float cameraSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.position + cameraOffset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 finalPos = player.position + cameraOffset;
        Vector3 lerpPos = Vector3.Lerp(transform.position, finalPos, cameraSpeed);
        transform.position = lerpPos;
    }
}
