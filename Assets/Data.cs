using UnityEngine;
using System.Collections;

public static class Data{
    #region rho prop
    private static double rho;
    public static double Rho
    {
        get
        {
            return rho;
        }
        set
        {
            rho = value;
        }
    }
    #endregion
    #region beta prop
    private static double beta;
    public static double Beta
    {
        get
        {
            return beta;
        }
        set
        {
            beta = value;
        }
    }
    #endregion
    #region sigma prop
    private static double sig;
    public static double Sig
    {
        get
        {
            return sig;
        }
        set
        {
            sig = value;
        }
    }
    #endregion

    public enum rhoValue
    {
        LOW, MED, HIGH
    }
    private static rhoValue rhoVal;
    public static rhoValue RhoVal
    {
        get
        {
            return rhoVal;
        }
        set
        {
            rhoVal = value;
        }
    }

}
