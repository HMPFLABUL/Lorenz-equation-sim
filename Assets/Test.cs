using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test: MonoBehaviour{

    List<double> x = new List<double>();
    List<double> y = new List<double>();
    List<double> z = new List<double>();
    public int probes = 100;
    double sig = 10;
    double b=2.6666667;
    double rho = 28;
    public double dt = 0.01f;
    public LineRenderer curve;
    private Vector3[] pos;
    
    void Start()
    {
        pos = new Vector3[probes];
        x.Add(0.1);
        y.Add(0.1);
        z.Add(0.1);
        for(int i = 0; i < probes; i++)
        {
            Next();
        }
       Draw();
    }

    void Update()
    {
    }
    void Next()
    {
        int i = x.Count-1;
        double dx = dt*sig * y[i] - dt*sig * x[i]+x[i];
        x.Add(dx);
        double dy = dt*rho * x[i] - z[i] * x[i]*dt - y[i]*dt+y[i];
        y.Add(dy);
        double dz = x[i] * y[i]*dt - b * z[i]*dt+z[i];
        z.Add(dz);
        pos[i] = new Vector3((float)x[i], (float)z[i], (float)y[i]);
    }

    void Draw()
    {
        curve.SetVertexCount(probes);
        curve.SetPositions(pos);
    }

    
    


}
