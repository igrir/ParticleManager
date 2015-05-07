using UnityEngine;
using System.Collections;
using Tinker;

public class PlayerScript : MonoBehaviour {

	public int playerNumber;
	public float waitSec;

	// Use this for initialization
	void Start () {
		StartCoroutine(testParticle());
	}

	IEnumerator testParticle() {

		int x = 0;
		bool loop = true;
		while(loop){
			yield return new WaitForSeconds(waitSec);
			
			//spawn the particle
			GameObject go2 = ParticleManager.Instance.Spawn("white_smoke", this.transform.position, 1);

			x++;

			//testing pause
			if (x > 2 && x <= 5) {
				ParticleManager.Instance.SetPause(true);
			}

			if (x > 5) {
				ParticleManager.Instance.Play();
			}
			
		}

	}

	// Update is called once per frame
	void Update () {


	}

}
