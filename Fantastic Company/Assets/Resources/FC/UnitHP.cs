using UnityEngine;
using System.Collections;
using System;

public class UnitHP : MonoBehaviour {
    public float HP = 100.0F;
    public float Max_HP = 100.0F;
    public Action<GameObject> onHPZero = (x) => Destroy(x);
    protected GameObject HPBar;
    protected Material BarMat;
    protected GameObject Camera;
	// Use this for initialization
	void Start () {
        Camera = GameObject.Find("Player").transform.GetChild(0).gameObject;
        HPBar = GameObject.CreatePrimitive(PrimitiveType.Plane);
        BarMat = (HPBar.GetComponent<MeshRenderer>().material = new Material(Resources.Load<Material>("FC/HPBar")));
        HPBar.transform.Rotate(0, 135, 315);
        Destroy(HPBar.GetComponent<MeshCollider>());
	}
	
	// Update is called once per frame
	void Update () {
        HPBar.transform.position = gameObject.transform.position + Vector3.up * 1.5F;
        BarMat.color = Color.Lerp(Color.red, Color.green, HP / Max_HP);
        HPBar.transform.localScale = new Vector3(.01F, 1F, HP / Max_HP * .075F);
        if (HP <= 0) onHPZero.Invoke(gameObject);
	}

    void OnDestroy()
    {
        Destroy(HPBar);
    }
}
