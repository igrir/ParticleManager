using UnityEngine;
using System.Collections;

public class DebugParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SummonTheParticle() {
		GameObject go = Tinker.ParticleManager.Instance.Spawn("white_smoke", new Vector3(0,0,0), 1);
	}
}
