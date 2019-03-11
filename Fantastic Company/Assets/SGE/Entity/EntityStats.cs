using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EntityStats : MonoBehaviour {
    [SerializeField]
    protected Dictionary<string, double> stats = new Dictionary<string,double>();
    [SerializeField]
    protected double[] initValues;
    [SerializeField]
    protected string[] initNames;
    void Awake()
    {
        if(initNames != null && initValues != null)
        {
            for (int i = 0; i < initValues.Length && i < initNames.Length; i++)
                stats.Add(initNames[i], initValues[i]);
        }
    }
    public void AssignStat(string name, double value)
    {
        stats.Add(name, value);
    }
    public double GetStat(string name)
    {
        return stats[name];
    }
}
