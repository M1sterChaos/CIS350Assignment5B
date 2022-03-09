/*
 * (Austin Buck)
 * (Assignment 5B)
 * (Controls the mouse movement for the camera)
 */
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensativity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensativity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensativity * Time.deltaTime;

        player.transform.Rotate(Vector3.up * mouseX);

        verticalLookRotation -= mouseY;

        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
