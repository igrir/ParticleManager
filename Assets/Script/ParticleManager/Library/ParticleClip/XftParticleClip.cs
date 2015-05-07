using UnityEngine;
using System.Collections;

namespace Tinker {
	public class XftParticleClip : ParticleClip {

		Xft.XffectComponent[] xfts;

		public void Start () {
			xfts = GetComponents<Xft.XffectComponent>();
		}

		public override void Play () {
			if (xfts != null) {
				foreach(Xft.XffectComponent currentXfts in xfts) {
					currentXfts.Paused = false;
				}
			}

		}
		
		public override void SetPause (bool isPause) {
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