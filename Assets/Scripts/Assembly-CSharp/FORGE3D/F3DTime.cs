using System;
using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	public class F3DTime : MonoBehaviour
	{
		private class Timer
		{
			public int id;

			public bool isActive;

			public float rate;

			public int ticks;

			public int ticksElapsed;

			public float last;

			public Action callBack;

			public Timer(int id_, float rate_, int ticks_, Action callback_)
			{
			}

			public void Tick()
			{
			}
		}

		public static F3DTime time;

		private List<Timer> timers;

		private List<int> removalPending;

		private int idCounter;

		private void Awake()
		{
		}

		public int AddTimer(float rate, Action callBack)
		{
			return 0;
		}

		public int AddTimer(float rate, int ticks, Action callBack)
		{
			return 0;
		}

		public void RemoveTimer(int timerId)
		{
		}

		private void Remove()
		{
		}

		private void Tick()
		{
		}

		private void Update()
		{
		}
	}
}
