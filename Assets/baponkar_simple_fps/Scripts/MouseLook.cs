using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baponkar.FPS.Simple
{
    [RequireComponent(typeof(Camera))]
    [RequireComponent(typeof(AudioListener))]
    public class MouseLook : MonoBehaviour
    {
        #region Variables
        public Transform playerBody;
        public float mouseSensitivity= 100f;
        public float xRotation;
        public float yRotation; //This is required only for showing rotation
        #endregion

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -80f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);

            yRotation = mouseX;
        }
    }
}
