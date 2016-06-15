using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Input : MonoBehaviour {
    public Slider r;
    public Text rT;
    public Slider sig;
    public Text sigT;
    public Slider b;
    public Text bT;
    void Awake()
    {
        CheckSlidersValue();
    }
    void Update()
    {
        CheckSlidersValue();
    }

    private void CheckSlidersValue()
    {
        Data.Rho = (double)((int)(r.value * 100)) / 100;
        rT.text = "" + Data.Rho;
        CheckRho();
        Debug.Log(Data.Rho);
        Debug.Log(Data.RhoVal);
        Data.Sig = (double)((int)(sig.value * 100)) / 100;
        sigT.text = "" + Data.Sig;
        Data.Beta = (double)((int)(b.value * 100)) / 100;
        bT.text = "" + Data.Beta;
    }

    private void CheckRho()
    {
        if (Data.Rho < 50)
        {
            Data.RhoVal = Data.rhoValue.LOW;
        }
        else if(Data.Rho < 80)
        {
            Data.RhoVal = Data.rhoValue.MED;
        }
        else
        {
            Data.RhoVal = Data.rhoValue.HIGH;
        }
    }
    public void R28()
    {
        r.value = 28;
    }
    public void R9996()
    {

        r.value = (float)99.965;
    }
    public void s10()
    {
        sig.value = 10;
    }
    public void b266()
    {
        b.value = 2.667f;
    }

    public void EXIT()
    {
        Application.Quit();
    }

}
