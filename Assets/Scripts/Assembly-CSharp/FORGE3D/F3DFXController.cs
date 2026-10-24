using UnityEngine;

namespace FORGE3D
{
	public class F3DFXController : MonoBehaviour
	{
		public static F3DFXController instance;

		private int curSocket;

		private int timerID;

		[Header("Turret setup")]
		public Transform[] TurretSocket;

		public ParticleSystem[] ShellParticles;

		public F3DFXType DefaultFXType;

		[Header("Vulcan")]
		public Transform vulcanProjectile;

		public Transform vulcanMuzzle;

		public Transform vulcanImpact;

		public float vulcanOffset;

		public float VulcanFireRate;

		[Header("Solo gun")]
		public Transform soloGunProjectile;

		public Transform soloGunMuzzle;

		public Transform soloGunImpact;

		public float soloGunOffset;

		[Header("Sniper")]
		public Transform sniperBeam;

		public Transform sniperMuzzle;

		public Transform sniperImpact;

		public float sniperOffset;

		[Header("Shotgun")]
		public Transform shotGunProjectile;

		public Transform shotGunMuzzle;

		public Transform shotGunImpact;

		public float shotGunOffset;

		[Header("Seeker")]
		public Transform seekerProjectile;

		public Transform seekerMuzzle;

		public Transform seekerImpact;

		public float seekerOffset;

		[Header("Rail gun")]
		public Transform railgunBeam;

		public Transform railgunMuzzle;

		public Transform railgunImpact;

		public float railgunOffset;

		[Header("Plasma gun")]
		public Transform plasmagunProjectile;

		public Transform plasmagunMuzzle;

		public Transform plasmagunImpact;

		public float plasmaGunOffset;

		[Header("Plasma beam")]
		public Transform plasmaBeam;

		public float plasmaOffset;

		[Header("Plasma beam heavy")]
		public Transform plasmaBeamHeavy;

		public float plasmaBeamHeavyOffset;

		[Header("Lightning gun")]
		public Transform lightningGunBeam;

		public float lightingGunBeamOffset;

		[Header("Flame")]
		public Transform flameRed;

		public float flameOffset;

		[Header("Laser impulse")]
		public Transform laserImpulseProjectile;

		public Transform laserImpulseMuzzle;

		public Transform laserImpulseImpact;

		public float laserImpulseOffset;

		private void Awake()
		{
		}

		public void NextWeapon()
		{
		}

		public void PrevWeapon()
		{
		}

		private void AdvanceSocket()
		{
		}

		public void Fire()
		{
		}

		public void Stop()
		{
		}

		private void Vulcan()
		{
		}

		public void VulcanImpact(Vector3 pos)
		{
		}

		private void SoloGun()
		{
		}

		public void SoloGunImpact(Vector3 pos)
		{
		}

		private void Sniper()
		{
		}

		public void SniperImpact(Vector3 pos)
		{
		}

		private void ShotGun()
		{
		}

		private void Seeker()
		{
		}

		public void SeekerImpact(Vector3 pos)
		{
		}

		private void RailGun()
		{
		}

		public void RailgunImpact(Vector3 pos)
		{
		}

		private void PlasmaGun()
		{
		}

		public void PlasmaGunImpact(Vector3 pos)
		{
		}

		private void PlasmaBeam()
		{
		}

		private void PlasmaBeamHeavy()
		{
		}

		private void LightningGun()
		{
		}

		private void FlameRed()
		{
		}

		private void LaserImpulse()
		{
		}

		public void LaserImpulseImpact(Vector3 pos)
		{
		}
	}
}
