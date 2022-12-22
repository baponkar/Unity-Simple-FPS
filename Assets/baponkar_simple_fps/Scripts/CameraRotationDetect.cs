using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baponkar.FPS.Simple;
using UnityEngine.UI;
public class CameraRotationDetect : MonoBehaviour
{
    public MouseLook mouseLook;
    public Text xRot, yRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xRot.text = "Rotation around X-axis : " + mouseLook.xRotation.ToString();
        yRot.text = "Rotation around Y-axis : " + mouseLook.yRotation.ToString();
    }
}
