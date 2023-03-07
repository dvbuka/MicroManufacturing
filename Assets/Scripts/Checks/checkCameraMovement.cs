using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class checkCameraMovement : levelRequirementParent
{
    GameObject Camera;
    float startAngle;
    public checkCameraMovement(LayerStackHolder layers) : base(layers) {
        name = "Take a look around the waifer";
        description = "You can move the camera with the arrow keys.";
        Camera = GameObject.Find("Main Camera");
        startAngle = Camera.transform.rotation.eulerAngles.y;
        checkOutsideEdits= true;
    }

    public override void check()
    {
        float curAngle = Camera.transform.rotation.eulerAngles.y;
        if (Mathf.DeltaAngle(startAngle,curAngle) >= 160)
        {
            met = true;
        }
        else
        {
            met = false;
        }
    }
}