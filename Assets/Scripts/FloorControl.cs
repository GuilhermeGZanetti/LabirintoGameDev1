using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControl : MonoBehaviour
{
    public float RotSpeedBoost;

    // Update is called once per frame
    void Update()
    {   
        float target_x = 0, target_z = 0;
        if (Input.GetKey("w")) target_x += 45;
        if (Input.GetKey("s")) target_x += -45;
        if (Input.GetKey("a")) target_z += 45;
        if (Input.GetKey("d")) target_z += -45;

        Quaternion current_rotation = transform.rotation;
        Quaternion target_rotation = Quaternion.Euler(target_x, 0, target_z);
        float step = Time.deltaTime * RotSpeedBoost;

        transform.rotation = Quaternion.Lerp(current_rotation, target_rotation, step);
    }
}
