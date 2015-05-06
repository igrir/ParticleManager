using UnityEngine;
using System.Collections;

namespace Tinker {
	public class ParticleSystemParticleClip : ParticleClip {
		
		
		public override void Play () {
			ParticleSystem[] ps = GetComponents<ParticleSystem>();
			if (ps != null) {
				foreach(ParticleSystem currentPs in ps){
					currentPs.Play();
				}
			}
			
		}
		public override void SetPause (bool isPause) {
			
			ParticleSystem[] ps = GetComponents<ParticleSystem>();
			if (ps != null) {
				foreach(ParticleSystem currentPs in ps){
					if (isPause) {
						if (currentPs.isPlaying) {
							currentPs.Pause();
						}
					}else{
						if (currentPs.isPaused) {
							currentPs.Play();
						}
					}
					
				}
			}
		}


		
		
	}
}