using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUpMove : MonoBehaviour
{
    private float rotSpeed = 0f;
    private float revSpeed = 4f;

    void Update()
    {
        float t = Time.time;
        float posX = transform.localPosition.x;
        float posZ = transform.localPosition.z;
        float posY = Mathf.Sin(revSpeed * t);
        gameObject.transform.position = new Vector3(posX, posY, posZ);
        float rotY = revSpeed * t;
    }
}