using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TagOfferWeightConfig", menuName = "GameData/Tag Offer Weight Config")]
public class TagOfferWeightConfig : ScriptableObject
{
	[Tooltip("Master switch for tag-weighted level-up rolls.")]
	public bool Enabled;

	[Tooltip("Minimum final multiplier applied to base category weight.")]
	public float MinMultiplier;

	[Tooltip("Maximum final multiplier applied to base category weight.")]
	public float MaxMultiplier;

	[Header("Base offer weights (before tag/archetype multipliers)")]
	[Tooltip("Level-up and shop roll weight for weapons (typeId 0).")]
	public float BaseOfferWeightWeapon;

	[Tooltip("Level-up and shop roll weight for microchips (typeId 1).")]
	public float BaseOfferWeightMicrochip;

	[Tooltip("Level-up roll weight for drones (typeId 2). Shop does not offer drones.")]
	public float BaseOfferWeightDrone;

	[Tooltip("Level-up and shop roll weight for overloads (typeId 3).")]
	public float BaseOfferWeightOverload;

	[Header("Match bonuses (per overlapping tag)")]
	public float SchoolMatchMultiplier;

	public float DeliveryMatchMultiplier;

	public float StatusMatchMultiplier;

	public float TriggerMatchMultiplier;

	public float RoleMatchMultiplier;

	public float BoostMatchMultiplier;

	public float MetaMatchMultiplier;

	[Header("Stack scaling")]
	[Tooltip("Extra multiplier per build stack beyond the first: 1 + (stacks-1) × this.")]
	public float StackBonusPerTag;

	[Tooltip("Build stacks counted toward stack scaling (additional stacks ignored).")]
	public int MaxStacksCounted;

	[Header("Archetype affinity (stronger than tag affinity)")]
	[Tooltip("Master switch for archetype-weighted level-up rolls.")]
	public bool ArchetypeWeightingEnabled;

	[Tooltip("Multiplier per overlapping build archetype on an offer.")]
	public float ArchetypeMatchMultiplier;

	[Tooltip("Build archetype stacks required before archetype affinity affects offer weight.")]
	public int ArchetypeMinStacksForWeight;

	[Tooltip("Extra multiplier per archetype stack beyond the first: 1 + (stacks-1) × this.")]
	public float ArchetypeStackBonus;

	[Tooltip("Archetype stacks counted toward stack scaling (additional stacks ignored).")]
	public int ArchetypeMaxStacksCounted;

	[Tooltip("Flat weight subtracted when an item has archetypes but none match the starting mech.")]
	public bool OffArchetypeWeightPenaltyEnabled;

	[Tooltip("Flat weight subtracted when an item has archetypes but none match the starting mech.")]
	public float OffArchetypeWeightPenalty;

	[Tooltip("Minimum offer weight after the off-archetype penalty is applied.")]
	public float MinOfferWeightAfterPenalty;

	[Header("Selection bias")]
	[Tooltip("Forces at least one pick from the highest-weight tier; that pick is shuffled into a random slot.")]
	public bool GuaranteeOneTopWeightedPick;

	[Tooltip("Weight must be >= pool max weight × this to count as top tier (0.95 = within 5% of best).")]
	[Range(0.5f, 1f)]
	public float TopTierWeightRatio;

	[Tooltip("Forces at least one unowned (not installed) offer when any exist in the roll pool.")]
	public bool GuaranteeOneUnownedPick;

	[Tooltip("Multiplier applied to unowned offers after tag/archetype weights. 1 = no bonus.")]
	public float UnownedOfferWeightMultiplier;

	[Header("Fresh offer rotation")]
	[Tooltip("On a hidden cadence (1-3 level-ups), excludes last screen's offers when enough alternatives exist.")]
	public bool FreshOfferRotationEnabled;

	[Header("Recent offer anti-repeat")]
	[Tooltip("On the next level-up, last screen's offers keep a reduced weight instead of reprinting at full strength.")]
	public bool RecentOfferWeightPenaltyEnabled;

	[Tooltip("Multiply last screen's offers on the next level-up. 1 = no penalty. 0.35 drops a 2.5x item to about base weight.")]
	[Range(0.05f, 1f)]
	public float RecentOfferWeightMultiplier;

	[Header("Side pool (off-build wildcards)")]
	[Tooltip("Keeps base-weight, no-tag-match new offers out of the roll pool except for a small random sample. Installed upgrades always stay in the main pool.")]
	public bool SidePoolSplitEnabled;

	[Tooltip("Random off-build offers merged into the roll pool each level-up.")]
	public int SidePoolWildcardCount;

	[Tooltip("If the main pool is smaller than this after the split, backfill from the side pool.")]
	public int MinMainPoolSizeBeforeBackfill;

	[Tooltip("Skip the side-pool split until the build has at least this many tag stacks.")]
	public int MinBuildTagStacksForSidePoolSplit;

	[Header("Ignored tags (offer weight only)")]
	[Tooltip("Tags that stay on items for gates, UI, and resolved tags, but do not affect level-up or shop weight matching.")]
	public List<GameTag> IgnoredTagsForOfferWeight;

	public bool IsIgnoredForOfferWeight(GameTag tag)
	{
		return false;
	}

	public float GetBaseOfferWeight(int typeId)
	{
		return 0f;
	}

	public static float GetFallbackBaseOfferWeight(int typeId)
	{
		return 0f;
	}
}
