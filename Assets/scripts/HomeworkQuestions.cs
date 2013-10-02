using UnityEngine;
using System.Collections;

public class HomeworkQuestions : MonoBehaviour {
	
	public Camera cam_ramp;
	public Camera cam_balloons;
	
	public Camera cam1, cam2, cam3, cam4, cam5;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Time.deltaTime > 50f) 
		{
			cam1.enabled = false;
			cam2.enabled = true;
		}
	}
		void OnTriggerEnter() {
			cam3.enabled = true;
		}
}
