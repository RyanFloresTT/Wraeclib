namespace Wraeclib.Models;

using System.Text.Json.Serialization;

public class Character {
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("realm")]
    public string Realm { get; set; } = null!;

    [JsonPropertyName("class")]
    public string Class { get; set; } = null!;

    [JsonPropertyName("league")]
    public string? League { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("experience")]
    public long Experience { get; set; }

    [JsonPropertyName("ruthless")]
    public bool? Ruthless { get; set; }

    [JsonPropertyName("expired")]
    public bool? Expired { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("current")]
    public bool? Current { get; set; }

    [JsonPropertyName("equipment")]
    public List<Item>? Equipment { get; set; }

    [JsonPropertyName("inventory")]
    public List<Item>? Inventory { get; set; }

    [JsonPropertyName("rucksack")]
    public List<Item>? Rucksack { get; set; }

    [JsonPropertyName("jewels")]
    public List<Item>? Jewels { get; set; }

    [JsonPropertyName("passives")]
    public CharacterPassives? Passives { get; set; }

    [JsonPropertyName("metadata")]
    public CharacterMetadata? Metadata { get; set; }
}

public class CharacterPassives {
    [JsonPropertyName("hashes")]
    public List<int> Hashes { get; set; } = null!;

    [JsonPropertyName("hashes_ex")]
    public List<int> HashesEx { get; set; } = null!;

    [JsonPropertyName("mastery_effects")]
    public Dictionary<string, int> MasteryEffects { get; set; } = null!;

    [JsonPropertyName("skill_overrides")]
    public Dictionary<string, SkillOverride>? SkillOverrides { get; set; }

    [JsonPropertyName("bandit_choice")]
    public string? BanditChoice { get; set; }

    [JsonPropertyName("pantheon_major")]
    public string? PantheonMajor { get; set; }

    [JsonPropertyName("pantheon_minor")]
    public string? PantheonMinor { get; set; }

    [JsonPropertyName("jewel_data")]
    public Dictionary<string, ItemJewelData>? JewelData { get; set; }

    [JsonPropertyName("alternate_ascendancy")]
    public string? AlternateAscendancy { get; set; }
}

public class SkillOverride {
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = null!;

    [JsonPropertyName("activeEffectImage")]
    public string ActiveEffectImage { get; set; } = null!;
}

public class CharacterMetadata {
    [JsonPropertyName("version")]
    public string Version { get; set; } = null!;
}

public class Item {
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    [JsonPropertyName("verified")]
    public bool Verified { get; set; }

    [JsonPropertyName("w")]
    public int Width { get; set; }

    [JsonPropertyName("h")]
    public int Height { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = null!;

    [JsonPropertyName("support")]
    public bool? Support { get; set; }

    [JsonPropertyName("stackSize")]
    public int? StackSize { get; set; }

    [JsonPropertyName("maxStackSize")]
    public int? MaxStackSize { get; set; }

    [JsonPropertyName("stackSizeText")]
    public string? StackSizeText { get; set; }

    [JsonPropertyName("league")]
    public string? League { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("gemSockets")]
    public List<string>? GemSockets { get; set; }

    [JsonPropertyName("influences")]
    public ItemInfluences? Influences { get; set; }

    [JsonPropertyName("sockets")]
    public List<ItemSocket>? Sockets { get; set; }

    [JsonPropertyName("socketedItems")]
    public List<Item>? SocketedItems { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("typeLine")]
    public string TypeLine { get; set; } = null!;

    [JsonPropertyName("baseType")]
    public string BaseType { get; set; } = null!;

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; } = null!;

    [JsonPropertyName("identified")]
    public bool? Identified { get; set; }

    [JsonPropertyName("itemLevel")]
    public int? ItemLevel { get; set; }

    [JsonPropertyName("ilvl")]
    public int Ilvl { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("forum_note")]
    public string? ForumNote { get; set; }

    [JsonPropertyName("lockedToCharacter")]
    public bool? LockedToCharacter { get; set; }

    [JsonPropertyName("lockedToAccount")]
    public bool? LockedToAccount { get; set; }

    [JsonPropertyName("duplicated")]
    public bool? Duplicated { get; set; }

    [JsonPropertyName("split")]
    public bool? Split { get; set; }

    [JsonPropertyName("corrupted")]
    public bool? Corrupted { get; set; }

    [JsonPropertyName("unmodifiable")]
    public bool? Unmodifiable { get; set; }

    [JsonPropertyName("cisRaceReward")]
    public bool? CisRaceReward { get; set; }

    [JsonPropertyName("seaRaceReward")]
    public bool? SeaRaceReward { get; set; }

    [JsonPropertyName("thRaceReward")]
    public bool? ThRaceReward { get; set; }

    [JsonPropertyName("properties")]
    public List<ItemProperty>? Properties { get; set; }

    [JsonPropertyName("notableProperties")]
    public List<ItemProperty>? NotableProperties { get; set; }

    [JsonPropertyName("requirements")]
    public List<ItemProperty>? Requirements { get; set; }

    [JsonPropertyName("additionalProperties")]
    public List<ItemProperty>? AdditionalProperties { get; set; }

    [JsonPropertyName("nextLevelRequirements")]
    public List<ItemProperty>? NextLevelRequirements { get; set; }

    [JsonPropertyName("talismanTier")]
    public int? TalismanTier { get; set; }

    [JsonPropertyName("rewards")]
    public List<ItemProperty>? Rewards { get; set; }

    [JsonPropertyName("secDescrText")]
    public string? SecDescrText { get; set; }

    [JsonPropertyName("utilityMods")]
    public List<string>? UtilityMods { get; set; }

    [JsonPropertyName("logbookMods")]
    public List<LogbookMod>? LogbookMods { get; set; }

    [JsonPropertyName("enchantMods")]
    public List<string>? EnchantMods { get; set; }

    [JsonPropertyName("scourgeMods")]
    public List<string>? ScourgeMods { get; set; }

    [JsonPropertyName("implicitMods")]
    public List<string>? ImplicitMods { get; set; }

    [JsonPropertyName("ultimatumMods")]
    public List<UltimatumMod>? UltimatumMods { get; set; }

    [JsonPropertyName("explicitMods")]
    public List<string>? ExplicitMods { get; set; }

    [JsonPropertyName("craftedMods")]
    public List<string>? CraftedMods { get; set; }

    [JsonPropertyName("fracturedMods")]
    public List<string>? FracturedMods { get; set; }

    [JsonPropertyName("crucibleMods")]
    public List<string>? CrucibleMods { get; set; }

    [JsonPropertyName("cosmeticMods")]
    public List<string>? CosmeticMods { get; set; }

    [JsonPropertyName("veiledMods")]
    public List<string>? VeiledMods { get; set; }

    [JsonPropertyName("veiled")]
    public bool? Veiled { get; set; }

    [JsonPropertyName("descrText")]
    public string? DescrText { get; set; }

    [JsonPropertyName("flavourText")]
    public List<string>? FlavourText { get; set; }

    [JsonPropertyName("flavourTextParsed")]
    public List<string>? FlavourTextParsed { get; set; }

    [JsonPropertyName("prophecyText")]
    public string? ProphecyText { get; set; }

    [JsonPropertyName("isRelic")]
    public bool? IsRelic { get; set; }

    [JsonPropertyName("replica")]
    public bool? Replica { get; set; }

    [JsonPropertyName("foreseeing")]
    public bool? Foreseeing { get; set; }

    [JsonPropertyName("incubatedItem")]
    public IncubatedItem? IncubatedItem { get; set; }

    [JsonPropertyName("scourged")]
    public Scourged? Scourged { get; set; }

    [JsonPropertyName("crucible")]
    public CrucibleTree? Crucible { get; set; }

    [JsonPropertyName("ruthless")]
    public bool? Ruthless { get; set; }

    [JsonPropertyName("frameType")]
    public int FrameType { get; set; }

    [JsonPropertyName("artFilename")]
    public string? ArtFilename { get; set; }

    [JsonPropertyName("hybrid")]
    public ItemProperty? Hybrid { get; set; }

    [JsonPropertyName("extended")]
    public ItemExtended? Extended { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }

    [JsonPropertyName("inventoryId")]
    public string? InventoryId { get; set; }

    [JsonPropertyName("socket")]
    public int? Socket { get; set; }

    [JsonPropertyName("colour")]
    public string? Colour { get; set; }
}

public class ItemInfluences {
    [JsonPropertyName("elder")]
    public bool? Elder { get; set; }

    [JsonPropertyName("shaper")]
    public bool? Shaper { get; set; }

    [JsonPropertyName("searing")]
    public bool? Searing { get; set; }

    [JsonPropertyName("tangled")]
    public bool? Tangled { get; set; }
}

public class ItemSocket {
    [JsonPropertyName("group")]
    public int Group { get; set; }

    [JsonPropertyName("attr")]
    public string? Attr { get; set; }

    [JsonPropertyName("sColour")]
    public string? SColour { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("item")]
    public string? Item { get; set; }
}

public class ItemProperty {
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("values")]
    public List<List<object>> Values { get; set; } = null!;

    [JsonPropertyName("displayMode")]
    public int? DisplayMode { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }

    [JsonPropertyName("progress")]
    public double? Progress { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

public class LogbookMod {
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("faction")]
    public Faction Faction { get; set; } = null!;

    [JsonPropertyName("mods")]
    public List<string> Mods { get; set; } = null!;
}

public class Faction {
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}

public class UltimatumMod {
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("tier")]
    public int Tier { get; set; }
}

public class IncubatedItem {
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class Scourged {
    [JsonPropertyName("tier")]
    public int Tier { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("total")]
    public int? Total { get; set; }
}

public class CrucibleTree {
    [JsonPropertyName("layout")]
    public string Layout { get; set; } = null!;

    [JsonPropertyName("nodes")]
    public Dictionary<string, CrucibleNode> Nodes { get; set; } = null!;
}

public class CrucibleNode {
    [JsonPropertyName("skill")]
    public int? Skill { get; set; }

    [JsonPropertyName("tier")]
    public int? Tier { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("allocated")]
    public bool? Allocated { get; set; }

    [JsonPropertyName("isNotable")]
    public bool? IsNotable { get; set; }

    [JsonPropertyName("isReward")]
    public bool? IsReward { get; set; }

    [JsonPropertyName("stats")]
    public List<string>? Stats { get; set; }

    [JsonPropertyName("reminderText")]
    public List<string>? ReminderText { get; set; }

    [JsonPropertyName("orbit")]
    public int? Orbit { get; set; }

    [JsonPropertyName("orbitIndex")]
    public int? OrbitIndex { get; set; }

    [JsonPropertyName("out")]
    public List<string> Out { get; set; } = null!;

    [JsonPropertyName("in")]
    public List<string> In { get; set; } = null!;
}

public class ItemExtended {
    [JsonPropertyName("category")]
    public string Category { get; set; } = null!;

    [JsonPropertyName("subcategories")]
    public List<string>? Subcategories { get; set; }

    [JsonPropertyName("prefixes")]
    public int? Prefixes { get; set; }

    [JsonPropertyName("suffixes")]
    public int? Suffixes { get; set; }
}

public class ItemJewelData {
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("radius")]
    public int? Radius { get; set; }

    [JsonPropertyName("radiusMin")]
    public int? RadiusMin { get; set; }

    [JsonPropertyName("radiusVisual")]
    public string? RadiusVisual { get; set; }

    [JsonPropertyName("subgraph")]
    public JewelSubgraph? Subgraph { get; set; }
}

public class JewelSubgraph {
    [JsonPropertyName("groups")]
    public Dictionary<string, PassiveGroup> Groups { get; set; } = null!;

    [JsonPropertyName("nodes")]
    public Dictionary<string, PassiveNode> Nodes { get; set; } = null!;
}

public class PassiveGroup {
    [JsonPropertyName("x")]
    public double X { get; set; }

    [JsonPropertyName("y")]
    public double Y { get; set; }

    [JsonPropertyName("orbits")]
    public List<int> Orbits { get; set; } = null!;

    [JsonPropertyName("isProxy")]
    public bool? IsProxy { get; set; }

    [JsonPropertyName("proxy")]
    public string? Proxy { get; set; }

    [JsonPropertyName("nodes")]
    public List<string> Nodes { get; set; } = null!;
}

public class PassiveNode {
    [JsonPropertyName("skill")]
    public int? Skill { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("isKeystone")]
    public bool? IsKeystone { get; set; }

    [JsonPropertyName("isNotable")]
    public bool? IsNotable { get; set; }

    [JsonPropertyName("isMastery")]
    public bool? IsMastery { get; set; }

    [JsonPropertyName("inactiveIcon")]
    public string? InactiveIcon { get; set; }

    [JsonPropertyName("activeIcon")]
    public string? ActiveIcon { get; set; }

    [JsonPropertyName("activeEffectImage")]
    public string? ActiveEffectImage { get; set; }

    [JsonPropertyName("masteryEffects")]
    public List<MasteryEffect>? MasteryEffects { get; set; }

    [JsonPropertyName("isBlighted")]
    public bool? IsBlighted { get; set; }

    [JsonPropertyName("isTattoo")]
    public bool? IsTattoo { get; set; }

    [JsonPropertyName("isProxy")]
    public bool? IsProxy { get; set; }

    [JsonPropertyName("isJewelSocket")]
    public bool? IsJewelSocket { get; set; }

    [JsonPropertyName("expansionJewel")]
    public ExpansionJewel? ExpansionJewel { get; set; }

    [JsonPropertyName("recipe")]
    public List<string>? Recipe { get; set; }

    [JsonPropertyName("grantedStrength")]
    public int? GrantedStrength { get; set; }

    [JsonPropertyName("grantedDexterity")]
    public int? GrantedDexterity { get; set; }

    [JsonPropertyName("grantedIntelligence")]
    public int? GrantedIntelligence { get; set; }

    [JsonPropertyName("ascendancyName")]
    public string? AscendancyName { get; set; }

    [JsonPropertyName("isAscendancyStart")]
    public bool? IsAscendancyStart { get; set; }

    [JsonPropertyName("isMultipleChoice")]
    public bool? IsMultipleChoice { get; set; }

    [JsonPropertyName("isMultipleChoiceOption")]
    public bool? IsMultipleChoiceOption { get; set; }

    [JsonPropertyName("grantedPassivePoints")]
    public int? GrantedPassivePoints { get; set; }

    [JsonPropertyName("stats")]
    public List<string>? Stats { get; set; }

    [JsonPropertyName("reminderText")]
    public List<string>? ReminderText { get; set; }

    [JsonPropertyName("flavourText")]
    public List<string>? FlavourText { get; set; }

    [JsonPropertyName("classStartIndex")]
    public int? ClassStartIndex { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("orbit")]
    public int? Orbit { get; set; }

    [JsonPropertyName("orbitIndex")]
    public int? OrbitIndex { get; set; }

    [JsonPropertyName("out")]
    public List<string> Out { get; set; } = null!;

    [JsonPropertyName("in")]
    public List<string> In { get; set; } = null!;
}

public class MasteryEffect {
    [JsonPropertyName("effect")]
    public int Effect { get; set; }

    [JsonPropertyName("stats")]
    public List<string> Stats { get; set; } = null!;

    [JsonPropertyName("reminderText")]
    public List<string>? ReminderText { get; set; }
}

public class ExpansionJewel {
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    [JsonPropertyName("index")]
    public int? Index { get; set; }

    [JsonPropertyName("proxy")]
    public int? Proxy { get; set; }

    [JsonPropertyName("parent")]
    public int? Parent { get; set; }
}