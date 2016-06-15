using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Draw : RowXYZ {
    
    double sig = 10;
    double b = 2.6666667;
    double rho = 28;
    public int probes;
    public double dt;

    public LineRenderer curve;
    private Vector3[] pos;

    public override void NextPoint()
    {
        int i = x.Count - 1;
        x.Add(dt * sig * y[i] - dt * sig * x[i] + x[i]);
        y.Add(dt * rho * x[i] - z[i] * x[i] * dt - y[i] * dt + y[i]);
        z.Add(x[i] * y[i] * dt - b * z[i] * dt + z[i]);
        pos[i] = new Vector3((float)x[i], (float)z[i], (float)y[i]);
    }

    public void Drawing()
    {
        Initialize(1,1,1);
        SetScale();
        pos = new Vector3[probes];
        sig = Data.Sig;
        b = Data.Beta;
        rho = Data.Rho;
        for (int i = 0; i < probes; i++)
        {
            NextPoint();
        }
        curve.SetVertexCount(probes);
        curve.SetPositions(pos);
    }

    private void SetScale()
    {
        switch (Data.RhoVal)
        {
            case Data.rhoValue.LOW:
                probes = 1500;
                dt = 0.01;
                break;
            case Data.rhoValue.MED:
                probes = 10000;
                dt = 0.001;
                break;
            case Data.rhoValue.HIGH:
                probes = 50000;
                dt = 0.0001;
                break;
        }
    }
}
