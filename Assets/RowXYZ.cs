using UnityEngine;
using System.Collections;
using System.Collections.Generic;


interface CordXYZs
{
   void Initialize(double x0, double y0, double z0);
   void NextPoint();
}

public class RowXYZ : MonoBehaviour,CordXYZs
{
    protected List<double> x;
    protected List<double> y;
    protected List<double> z;
    public virtual void NextPoint()
    {

        x.Add(x[x.Count - 1] +1);
        x.Add(y[y.Count - 1] +1);
        x.Add(z[z.Count - 1] +1);

    }
    public void Initialize(double x0,double y0,double z0)
    {
        x = new List<double>();
        y = new List<double>();
        z = new List<double>();
        x.Add(x0);
        y.Add(y0);
        z.Add(z0);
    }
}
