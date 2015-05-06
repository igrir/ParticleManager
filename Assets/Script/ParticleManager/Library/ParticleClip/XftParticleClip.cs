using UnityEngine;
using System.Collections;

namespace Tinker {
	public class XftParticleClip : ParticleClip {

		
		public override void Play () {
			Xft.XffectComponent[] xfts = GetComponents<Xft.XffectComponent>();
			if (xfts != null) {
				foreach(Xft.XffectComponent currentXfts in xfts) {
					currentXfts.Paused = false;
				}
			}

		}
		
		public override void SetPause (bool isPause) {

			Xft.XffectComponent[] xfts = GetComponents<Xft.XffectComponent>();
			if (xfts != null) {
				foreach(Xft.XffectComponent currentXfts in xfts) {
					if (isPause) {
						if (!currentXfts.Paused) {
							currentXfts.Paused = true;
						}
					}else{
						if (currentXfts.Paused) {
							currentXfts.Paused = false;
						}
					}
				}
			}
		}



	}
}