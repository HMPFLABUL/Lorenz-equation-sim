using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CamPanel : MonoBehaviour {

    public Camera mainCam;
    public Slider Zoom;
	
    void Update()
    {
        mainCam.orthographicSize = Zoom.value;
    }

}
