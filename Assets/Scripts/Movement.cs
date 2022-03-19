using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed =1f;

    private void Update()
    {
        float zDirection = Input.GetAxisRaw("Vertical");
        float xDirection = Input.GetAxisRaw("Horizontal");

        Vector3 moveDirection = new Vector3(xDirection, 0, zDirection);

        //transform.position += moveDirection * speed;
    }

}
