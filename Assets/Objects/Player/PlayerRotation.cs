using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    public float mouseHorizontalSens;
    float yRotation = 0f;

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseHorizontalSens * Time.deltaTime;
        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}
