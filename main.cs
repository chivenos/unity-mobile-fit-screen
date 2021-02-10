using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       ScaleScreenSize(Screen.safeArea.height,Screen.safeArea.width);
    }
    
    private void ScaleScreenSize(float x, float y)
    {
        float ratio = x / y;
        float size = Camera.main.orthographicSize * ratio;
        Camera.main.orthographicSize = size;
    }
}
