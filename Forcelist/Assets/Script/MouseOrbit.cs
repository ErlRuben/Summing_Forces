using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOrbit : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     float angles = transform.eulerAngles;
    //     x = angles.y;
    //     yield = angles.x;   
    // }

    // // Update is called once per frame
    // void LateUpdate()
    // {
    //     if (target){
    //         x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
    //         y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
    //         distance += Input.mouseScrollDelta.y * 0.2f;

    //         y = ClampAngle(y, yMinLimit, yMaxLimit);

    //         float rotation = Quaternion.Euler(y, x, 0);
    //         float position = rotation * Vector3(0.0f, 0.0f, -distance) + target.position;

    //         transform.rotation = rotation;
    //         transform.position = position;
    //     }
    // }
    // static void ClampAngle ( float angle, float min, float max){
    //     if (angle < -360){
    //         angle +=360;
    //     }
    //     if (angle > 360){
    //         angle-=360;
    //     }
    //     return Mathf.Clamp(angle,min,max);
    // }
}

