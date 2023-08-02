using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //the code will align the bottom of the camera as the bottom boundry position and the height of it will change with the device screen type.
    //place boundaries into the game scene
    [SerializeField] private GameObject LeftBoundry; 
    [SerializeField] private GameObject RightBoundry;
    [SerializeField] private GameObject BottomBoundry;

    // Start is called before the first frame update
    void Start()
    {
        ScaleScreenSize();
    }

    private void ScaleScreenSize()
    {
        float halfWidth = (RightBoundry.transform.position.x - LeftBoundry.transform.position.x)/2;

        Camera.main.orthographicSize = halfWidth / Camera.main.aspect;
        Vector3 camPos = Camera.main.transform.position;
        Camera.main.transform.position = new Vector3(camPos.x, Camera.main.orthographicSize + BottomBoundry.transform.position.y, camPos.z);
    }
}
