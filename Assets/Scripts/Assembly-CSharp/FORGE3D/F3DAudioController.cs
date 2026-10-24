using UnityEngine;

namespace FORGE3D
{
	public class F3DAudioController : MonoBehaviour
	{
		public static F3DAudioController instance;

		private float timer_01;

		private float timer_02;

		public Transform audioSource;

		[Header("Vulcan")]
		public AudioClip[] vulcanHit;

		public AudioClip vulcanShot;

		public float vulcanDelay;

		public float vulcanHitDelay;

		[Header("Solo gun")]
		public AudioClip[] soloGunHit;

		public AudioClip soloGunShot;

		public float soloGunDelay;

		public float soloGunHitDelay;

		[Header("Sniper")]
		public AudioClip[] sniperHit;

		public AudioClip sniperShot;

		public float sniperDelay;

		public float sniperHitDelay;

		[Header("Shot gun")]
		public AudioClip[] shotGunHit;

		public AudioClip shotGunShot;

		public float shotGunDelay;

		public float shotGunHitDelay;

		[Header("Seeker")]
		public AudioClip[] seekerHit;

		public AudioClip seekerShot;

		public float seekerDelay;

		public float seekerHitDelay;

		[Header("Rail gun")]
		public AudioClip[] railgunHit;

		public AudioClip railgunShot;

		public float railgunDelay;

		public float railgunHitDelay;

		[Header("Plasma gun")]
		public AudioClip[] plasmagunHit;

		public AudioClip plasmagunShot;

		public float plasmagunDelay;

		public float plasmagunHitDelay;

		[Header("Plasma beam")]
		public AudioClip plasmabeamOpen;

		public AudioClip plasmabeamLoop;

		public AudioClip plasmabeamClose;

		[Header("Plasma beam heavy")]
		public AudioClip plasmabeamHeavyOpen;

		public AudioClip plasmabeamHeavyLoop;

		public AudioClip plasmabeamHeavyClose;

		[Header("Lightning gun")]
		public AudioClip lightningGunOpen;

		public AudioClip lightningGunLoop;

		public AudioClip lightningGunClose;

		[Header("Flame gun")]
		public AudioClip flameGunOpen;

		public AudioClip flameGunLoop;

		public AudioClip flameGunClose;

		[Header("Laser impulse")]
		public AudioClip[] laserImpulseHit;

		public AudioClip laserImpulseShot;

		public float laserImpulseDelay;

		public float laserImpulseHitDelay;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void VulcanShot(Vector3 pos)
		{
		}

		public void VulcanHit(Vector3 pos)
		{
		}

		public void SoloGunShot(Vector3 pos)
		{
		}

		public void SoloGunHit(Vector3 pos)
		{
		}

		public void SniperShot(Vector3 pos)
		{
		}

		public void SniperHit(Vector3 pos)
		{
		}

		public void ShotGunShot(Vector3 pos)
		{
		}

		public void ShotGunHit(Vector3 pos)
		{
		}

		public void SeekerShot(Vector3 pos)
		{
		}

		public void SeekerHit(Vector3 pos)
		{
		}

		public void RailGunShot(Vector3 pos)
		{
		}

		public void RailGunHit(Vector3 pos)
		{
		}

		public void PlasmaGunShot(Vector3 pos)
		{
		}

		public void PlasmaGunHit(Vector3 pos)
		{
		}

		public void PlasmaBeamLoop(Vector3 pos, Transform loopParent)
		{
		}

		public void PlasmaBeamClose(Vector3 pos)
		{
		}

		public void PlasmaBeamHeavyLoop(Vector3 pos, Transform loopParent)
		{
		}

		public void PlasmaBeamHeavyClose(Vector3 pos)
		{
		}

		public void LightningGunLoop(Vector3 pos, Transform loopParent)
		{
		}

		public void LightningGunClose(Vector3 pos)
		{
		}

		public void FlameGunLoop(Vector3 pos, Transform loopParent)
		{
		}

		public void FlameGunClose(Vector3 pos)
		{
		}

		public void LaserImpulseShot(Vector3 pos)
		{
		}

		public void LaserImpulseHit(Vector3 pos)
		{
		}
	}
}
