using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AxisControl : MonoBehaviour {

    public Transform chart;
    public Slider yAxis;
    public Slider rotZ;
    public Slider rotX;

    void Update()
    {
        chart.localPosition = new Vector3(chart.localPosition.x, yAxis.value, chart.localPosition.z);
        chart.localEulerAngles = new Vector3(rotX.value,rotZ.value,chart.localRotation.z);
    }
}
