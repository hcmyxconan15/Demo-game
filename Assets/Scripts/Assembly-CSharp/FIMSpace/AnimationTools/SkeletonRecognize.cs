using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.AnimationTools
{
	public static class SkeletonRecognize
	{
		public enum EWhatIsIt
		{
			Unknown = 0,
			Humanoidal = 1,
			Quadroped = 2,
			Creature = 3
		}

		public class SkeletonInfo
		{
			public Transform AnimatorTransform;

			public float LowestVsHighestLen;

			public float MostLeftVsMostRightLen;

			public float MostForwVsMostBackLen;

			public float AverageLen;

			public Transform ProbablyRootBone;

			public Transform ProbablyHips;

			public Transform ProbablyChest;

			public Transform ProbablyHead;

			public List<Transform> TrReachingGround;

			public List<Transform> TrReachingSides;

			public List<Transform> TrEnds;

			public List<Transform> ProbablySpineChain;

			public List<Transform> ProbablySpineChainShort;

			public List<List<Transform>> ProbablyRightArms;

			public List<List<Transform>> ProbablyLeftArms;

			public List<List<Transform>> ProbablyLeftLegs;

			public List<Transform> ProbablyLeftLegRoot;

			public List<List<Transform>> ProbablyRightLegs;

			public List<Transform> ProbablyRightLegRoot;

			public Vector3 LocalSpaceHighest;

			public Vector3 LocalSpaceMostRight;

			public Vector3 LocalSpaceMostForward;

			public Vector3 LocalSpaceMostBack;

			public Vector3 LocalSpaceMostLeft;

			public Vector3 LocalSpaceLowest;

			public EWhatIsIt WhatIsIt;

			public int SpineChainLength => 0;

			public int LeftArms => 0;

			public int LeftLegs => 0;

			public int RightArms => 0;

			public int RightLegs => 0;

			public int Legs => 0;

			public int Arms => 0;

			public SkeletonInfo(Transform t, List<Transform> checkOnly = null, Transform pelvisHelp = null)
			{
			}

			private bool NotContainedYetByAny(Transform t)
			{
				return false;
			}

			private bool NotContainedYetByLimbs(Transform t)
			{
				return false;
			}

			public Transform GetHighestChild(Transform t, Transform root, float inCenterRangeFactor)
			{
				return null;
			}

			private void ClearDuplicates(List<List<Transform>> limbs, List<Transform> roots)
			{
			}

			private Vector3 Loc(Transform t)
			{
				return default;
			}

			public string GetLog()
			{
				return null;
			}

			public static int GetDepth(Transform t, Transform skelRootBone)
			{
				return 0;
			}
		}

		public static readonly string[] SpineNames;

		public static readonly string[] NeckNames;

		public static readonly string[] HeadNames;

		public static readonly string[] RootNames;

		public static readonly string[] PelvisNames;

		public static readonly string[] ChestNames;

		public static readonly string[] ShouldersNames;

		public static readonly string[] UpperLegNames;

		public static readonly string[] KneeNames;

		public static readonly string[] ElbowNames;

		public static bool IsChildOf(Transform child, Transform parent)
		{
			return false;
		}

		public static Transform GetBottomMostChildTransform(Transform parent)
		{
			return null;
		}

		public static bool NameContains(string name, string[] names)
		{
			return false;
		}
	}
}
