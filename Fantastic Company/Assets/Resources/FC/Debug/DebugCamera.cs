using UnityEngine;
using System.Collections;

public class DebugCamera : MonoBehaviour {
    public float Speed = .25f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.DownArrow)) gameObject.transform.Translate(Vector3.back * Speed, Space.Self);
        if (Input.GetKey(KeyCode.UpArrow)) gameObject.transform.Translate(Vector3.forward * Speed, Space.Self);
        if (Input.GetKey(KeyCode.LeftArrow)) gameObject.transform.Translate(Vector3.left * Speed, Space.Self);
        if (Input.GetKey(KeyCode.RightArrow)) gameObject.transform.Translate(Vector3.right * Speed, Space.Self);
	}
}
