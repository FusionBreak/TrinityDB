﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrinityDB.World
{
    public partial class worldContext : DbContext
    {
        public worldContext()
        {
        }

        public worldContext(DbContextOptions<worldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessRequirement> AccessRequirement { get; set; }
        public virtual DbSet<AchievementDbc> AchievementDbc { get; set; }
        public virtual DbSet<AchievementReward> AchievementReward { get; set; }
        public virtual DbSet<AchievementRewardLocale> AchievementRewardLocale { get; set; }
        public virtual DbSet<AreatriggerInvolvedrelation> AreatriggerInvolvedrelation { get; set; }
        public virtual DbSet<AreatriggerScripts> AreatriggerScripts { get; set; }
        public virtual DbSet<AreatriggerTavern> AreatriggerTavern { get; set; }
        public virtual DbSet<AreatriggerTeleport> AreatriggerTeleport { get; set; }
        public virtual DbSet<AreatriggerTemplate> AreatriggerTemplate { get; set; }
        public virtual DbSet<AreatriggerTemplateActions> AreatriggerTemplateActions { get; set; }
        public virtual DbSet<AreatriggerTemplatePolygonVertices> AreatriggerTemplatePolygonVertices { get; set; }
        public virtual DbSet<BattlePetBreeds> BattlePetBreeds { get; set; }
        public virtual DbSet<BattlePetQuality> BattlePetQuality { get; set; }
        public virtual DbSet<BattlegroundTemplate> BattlegroundTemplate { get; set; }
        public virtual DbSet<BattlemasterEntry> BattlemasterEntry { get; set; }
        public virtual DbSet<BlackmarketTemplate> BlackmarketTemplate { get; set; }
        public virtual DbSet<CharacterTemplate> CharacterTemplate { get; set; }
        public virtual DbSet<CharacterTemplateClass> CharacterTemplateClass { get; set; }
        public virtual DbSet<ClassExpansionRequirement> ClassExpansionRequirement { get; set; }
        public virtual DbSet<Command> Command { get; set; }
        public virtual DbSet<Conditions> Conditions { get; set; }
        public virtual DbSet<ConversationActorTemplate> ConversationActorTemplate { get; set; }
        public virtual DbSet<ConversationActors> ConversationActors { get; set; }
        public virtual DbSet<ConversationLineTemplate> ConversationLineTemplate { get; set; }
        public virtual DbSet<ConversationTemplate> ConversationTemplate { get; set; }
        public virtual DbSet<Creature> Creature { get; set; }
        public virtual DbSet<CreatureAddon> CreatureAddon { get; set; }
        public virtual DbSet<CreatureClasslevelstats> CreatureClasslevelstats { get; set; }
        public virtual DbSet<CreatureDefaultTrainer> CreatureDefaultTrainer { get; set; }
        public virtual DbSet<CreatureEquipTemplate> CreatureEquipTemplate { get; set; }
        public virtual DbSet<CreatureFormations> CreatureFormations { get; set; }
        public virtual DbSet<CreatureLootTemplate> CreatureLootTemplate { get; set; }
        public virtual DbSet<CreatureModelInfo> CreatureModelInfo { get; set; }
        public virtual DbSet<CreatureOnkillReputation> CreatureOnkillReputation { get; set; }
        public virtual DbSet<CreatureQuestender> CreatureQuestender { get; set; }
        public virtual DbSet<CreatureQuestitem> CreatureQuestitem { get; set; }
        public virtual DbSet<CreatureQueststarter> CreatureQueststarter { get; set; }
        public virtual DbSet<CreatureSummonGroups> CreatureSummonGroups { get; set; }
        public virtual DbSet<CreatureTemplate> CreatureTemplate { get; set; }
        public virtual DbSet<CreatureTemplateAddon> CreatureTemplateAddon { get; set; }
        public virtual DbSet<CreatureTemplateLocale> CreatureTemplateLocale { get; set; }
        public virtual DbSet<CreatureTemplateOutfits> CreatureTemplateOutfits { get; set; }
        public virtual DbSet<CreatureTemplateScaling> CreatureTemplateScaling { get; set; }
        public virtual DbSet<CreatureText> CreatureText { get; set; }
        public virtual DbSet<CreatureTextLocale> CreatureTextLocale { get; set; }
        public virtual DbSet<CriteriaData> CriteriaData { get; set; }
        public virtual DbSet<Disables> Disables { get; set; }
        public virtual DbSet<DisenchantLootTemplate> DisenchantLootTemplate { get; set; }
        public virtual DbSet<EventScripts> EventScripts { get; set; }
        public virtual DbSet<ExplorationBasexp> ExplorationBasexp { get; set; }
        public virtual DbSet<FishingLootTemplate> FishingLootTemplate { get; set; }
        public virtual DbSet<GameEvent> GameEvent { get; set; }
        public virtual DbSet<GameEventArenaSeasons> GameEventArenaSeasons { get; set; }
        public virtual DbSet<GameEventBattlegroundHoliday> GameEventBattlegroundHoliday { get; set; }
        public virtual DbSet<GameEventCondition> GameEventCondition { get; set; }
        public virtual DbSet<GameEventCreature> GameEventCreature { get; set; }
        public virtual DbSet<GameEventCreatureQuest> GameEventCreatureQuest { get; set; }
        public virtual DbSet<GameEventGameobject> GameEventGameobject { get; set; }
        public virtual DbSet<GameEventGameobjectQuest> GameEventGameobjectQuest { get; set; }
        public virtual DbSet<GameEventModelEquip> GameEventModelEquip { get; set; }
        public virtual DbSet<GameEventNpcVendor> GameEventNpcVendor { get; set; }
        public virtual DbSet<GameEventNpcflag> GameEventNpcflag { get; set; }
        public virtual DbSet<GameEventPool> GameEventPool { get; set; }
        public virtual DbSet<GameEventPrerequisite> GameEventPrerequisite { get; set; }
        public virtual DbSet<GameEventQuestCondition> GameEventQuestCondition { get; set; }
        public virtual DbSet<GameEventSeasonalQuestrelation> GameEventSeasonalQuestrelation { get; set; }
        public virtual DbSet<GameTele> GameTele { get; set; }
        public virtual DbSet<GameWeather> GameWeather { get; set; }
        public virtual DbSet<Gameobject> Gameobject { get; set; }
        public virtual DbSet<GameobjectAddon> GameobjectAddon { get; set; }
        public virtual DbSet<GameobjectLootTemplate> GameobjectLootTemplate { get; set; }
        public virtual DbSet<GameobjectQuestender> GameobjectQuestender { get; set; }
        public virtual DbSet<GameobjectQuestitem> GameobjectQuestitem { get; set; }
        public virtual DbSet<GameobjectQueststarter> GameobjectQueststarter { get; set; }
        public virtual DbSet<GameobjectTemplate> GameobjectTemplate { get; set; }
        public virtual DbSet<GameobjectTemplateAddon> GameobjectTemplateAddon { get; set; }
        public virtual DbSet<GameobjectTemplateLocale> GameobjectTemplateLocale { get; set; }
        public virtual DbSet<GarrisonFollowerClassSpecAbilities> GarrisonFollowerClassSpecAbilities { get; set; }
        public virtual DbSet<GarrisonPlotFinalizeInfo> GarrisonPlotFinalizeInfo { get; set; }
        public virtual DbSet<GossipMenu> GossipMenu { get; set; }
        public virtual DbSet<GossipMenuOption> GossipMenuOption { get; set; }
        public virtual DbSet<GossipMenuOptionAction> GossipMenuOptionAction { get; set; }
        public virtual DbSet<GossipMenuOptionBox> GossipMenuOptionBox { get; set; }
        public virtual DbSet<GossipMenuOptionLocale> GossipMenuOptionLocale { get; set; }
        public virtual DbSet<GossipMenuOptionTrainer> GossipMenuOptionTrainer { get; set; }
        public virtual DbSet<GraveyardZone> GraveyardZone { get; set; }
        public virtual DbSet<GuildRewards> GuildRewards { get; set; }
        public virtual DbSet<GuildRewardsReqAchievements> GuildRewardsReqAchievements { get; set; }
        public virtual DbSet<InstanceEncounters> InstanceEncounters { get; set; }
        public virtual DbSet<InstanceTemplate> InstanceTemplate { get; set; }
        public virtual DbSet<ItemEnchantmentTemplate> ItemEnchantmentTemplate { get; set; }
        public virtual DbSet<ItemLootTemplate> ItemLootTemplate { get; set; }
        public virtual DbSet<ItemScriptNames> ItemScriptNames { get; set; }
        public virtual DbSet<ItemTemplateAddon> ItemTemplateAddon { get; set; }
        public virtual DbSet<LfgDungeonRewards> LfgDungeonRewards { get; set; }
        public virtual DbSet<LfgDungeonTemplate> LfgDungeonTemplate { get; set; }
        public virtual DbSet<LinkedRespawn> LinkedRespawn { get; set; }
        public virtual DbSet<MailLevelReward> MailLevelReward { get; set; }
        public virtual DbSet<MailLootTemplate> MailLootTemplate { get; set; }
        public virtual DbSet<MillingLootTemplate> MillingLootTemplate { get; set; }
        public virtual DbSet<MountDefinitions> MountDefinitions { get; set; }
        public virtual DbSet<NpcSpellclickSpells> NpcSpellclickSpells { get; set; }
        public virtual DbSet<NpcText> NpcText { get; set; }
        public virtual DbSet<NpcVendor> NpcVendor { get; set; }
        public virtual DbSet<OutdoorpvpTemplate> OutdoorpvpTemplate { get; set; }
        public virtual DbSet<PageText> PageText { get; set; }
        public virtual DbSet<PageTextLocale> PageTextLocale { get; set; }
        public virtual DbSet<PetLevelstats> PetLevelstats { get; set; }
        public virtual DbSet<PetNameGeneration> PetNameGeneration { get; set; }
        public virtual DbSet<PhaseArea> PhaseArea { get; set; }
        public virtual DbSet<PickpocketingLootTemplate> PickpocketingLootTemplate { get; set; }
        public virtual DbSet<PlayerFactionchangeAchievement> PlayerFactionchangeAchievement { get; set; }
        public virtual DbSet<PlayerFactionchangeItems> PlayerFactionchangeItems { get; set; }
        public virtual DbSet<PlayerFactionchangeQuests> PlayerFactionchangeQuests { get; set; }
        public virtual DbSet<PlayerFactionchangeReputations> PlayerFactionchangeReputations { get; set; }
        public virtual DbSet<PlayerFactionchangeSpells> PlayerFactionchangeSpells { get; set; }
        public virtual DbSet<PlayerFactionchangeTitles> PlayerFactionchangeTitles { get; set; }
        public virtual DbSet<PlayerLevelstats> PlayerLevelstats { get; set; }
        public virtual DbSet<PlayerXpForLevel> PlayerXpForLevel { get; set; }
        public virtual DbSet<Playerchoice> Playerchoice { get; set; }
        public virtual DbSet<PlayerchoiceLocale> PlayerchoiceLocale { get; set; }
        public virtual DbSet<PlayerchoiceResponse> PlayerchoiceResponse { get; set; }
        public virtual DbSet<PlayerchoiceResponseLocale> PlayerchoiceResponseLocale { get; set; }
        public virtual DbSet<PlayerchoiceResponseReward> PlayerchoiceResponseReward { get; set; }
        public virtual DbSet<PlayerchoiceResponseRewardCurrency> PlayerchoiceResponseRewardCurrency { get; set; }
        public virtual DbSet<PlayerchoiceResponseRewardFaction> PlayerchoiceResponseRewardFaction { get; set; }
        public virtual DbSet<PlayerchoiceResponseRewardItem> PlayerchoiceResponseRewardItem { get; set; }
        public virtual DbSet<Playercreateinfo> Playercreateinfo { get; set; }
        public virtual DbSet<PlayercreateinfoAction> PlayercreateinfoAction { get; set; }
        public virtual DbSet<PlayercreateinfoCastSpell> PlayercreateinfoCastSpell { get; set; }
        public virtual DbSet<PlayercreateinfoItem> PlayercreateinfoItem { get; set; }
        public virtual DbSet<PlayercreateinfoSpellCustom> PlayercreateinfoSpellCustom { get; set; }
        public virtual DbSet<PointsOfInterest> PointsOfInterest { get; set; }
        public virtual DbSet<PointsOfInterestLocale> PointsOfInterestLocale { get; set; }
        public virtual DbSet<PoolCreature> PoolCreature { get; set; }
        public virtual DbSet<PoolGameobject> PoolGameobject { get; set; }
        public virtual DbSet<PoolPool> PoolPool { get; set; }
        public virtual DbSet<PoolQuest> PoolQuest { get; set; }
        public virtual DbSet<PoolTemplate> PoolTemplate { get; set; }
        public virtual DbSet<ProspectingLootTemplate> ProspectingLootTemplate { get; set; }
        public virtual DbSet<QuestDetails> QuestDetails { get; set; }
        public virtual DbSet<QuestGreeting> QuestGreeting { get; set; }
        public virtual DbSet<QuestGreetingLocale> QuestGreetingLocale { get; set; }
        public virtual DbSet<QuestMailSender> QuestMailSender { get; set; }
        public virtual DbSet<QuestObjectives> QuestObjectives { get; set; }
        public virtual DbSet<QuestObjectivesLocale> QuestObjectivesLocale { get; set; }
        public virtual DbSet<QuestOfferReward> QuestOfferReward { get; set; }
        public virtual DbSet<QuestOfferRewardLocale> QuestOfferRewardLocale { get; set; }
        public virtual DbSet<QuestPoi> QuestPoi { get; set; }
        public virtual DbSet<QuestPoiPoints> QuestPoiPoints { get; set; }
        public virtual DbSet<QuestRequestItems> QuestRequestItems { get; set; }
        public virtual DbSet<QuestRequestItemsLocale> QuestRequestItemsLocale { get; set; }
        public virtual DbSet<QuestTemplate> QuestTemplate { get; set; }
        public virtual DbSet<QuestTemplateAddon> QuestTemplateAddon { get; set; }
        public virtual DbSet<QuestTemplateLocale> QuestTemplateLocale { get; set; }
        public virtual DbSet<QuestVisualEffect> QuestVisualEffect { get; set; }
        public virtual DbSet<RaceUnlockRequirement> RaceUnlockRequirement { get; set; }
        public virtual DbSet<ReferenceLootTemplate> ReferenceLootTemplate { get; set; }
        public virtual DbSet<ReputationRewardRate> ReputationRewardRate { get; set; }
        public virtual DbSet<ReputationSpilloverTemplate> ReputationSpilloverTemplate { get; set; }
        public virtual DbSet<ScenarioPoi> ScenarioPoi { get; set; }
        public virtual DbSet<ScenarioPoiPoints> ScenarioPoiPoints { get; set; }
        public virtual DbSet<Scenarios> Scenarios { get; set; }
        public virtual DbSet<SceneTemplate> SceneTemplate { get; set; }
        public virtual DbSet<ScriptSplineChainMeta> ScriptSplineChainMeta { get; set; }
        public virtual DbSet<ScriptSplineChainWaypoints> ScriptSplineChainWaypoints { get; set; }
        public virtual DbSet<ScriptWaypoint> ScriptWaypoint { get; set; }
        public virtual DbSet<SkillDiscoveryTemplate> SkillDiscoveryTemplate { get; set; }
        public virtual DbSet<SkillExtraItemTemplate> SkillExtraItemTemplate { get; set; }
        public virtual DbSet<SkillFishingBaseLevel> SkillFishingBaseLevel { get; set; }
        public virtual DbSet<SkillPerfectItemTemplate> SkillPerfectItemTemplate { get; set; }
        public virtual DbSet<SkillTiers> SkillTiers { get; set; }
        public virtual DbSet<SkinningLootTemplate> SkinningLootTemplate { get; set; }
        public virtual DbSet<SmartScripts> SmartScripts { get; set; }
        public virtual DbSet<SpellArea> SpellArea { get; set; }
        public virtual DbSet<SpellAreatrigger> SpellAreatrigger { get; set; }
        public virtual DbSet<SpellAreatriggerCircular> SpellAreatriggerCircular { get; set; }
        public virtual DbSet<SpellAreatriggerSplines> SpellAreatriggerSplines { get; set; }
        public virtual DbSet<SpellCustomAttr> SpellCustomAttr { get; set; }
        public virtual DbSet<SpellDbc> SpellDbc { get; set; }
        public virtual DbSet<SpellEnchantProcData> SpellEnchantProcData { get; set; }
        public virtual DbSet<SpellGroup> SpellGroup { get; set; }
        public virtual DbSet<SpellGroupStackRules> SpellGroupStackRules { get; set; }
        public virtual DbSet<SpellLearnSpell> SpellLearnSpell { get; set; }
        public virtual DbSet<SpellLinkedSpell> SpellLinkedSpell { get; set; }
        public virtual DbSet<SpellLootTemplate> SpellLootTemplate { get; set; }
        public virtual DbSet<SpellPetAuras> SpellPetAuras { get; set; }
        public virtual DbSet<SpellProc> SpellProc { get; set; }
        public virtual DbSet<SpellRequired> SpellRequired { get; set; }
        public virtual DbSet<SpellScriptNames> SpellScriptNames { get; set; }
        public virtual DbSet<SpellScripts> SpellScripts { get; set; }
        public virtual DbSet<SpellTargetPosition> SpellTargetPosition { get; set; }
        public virtual DbSet<SpellThreat> SpellThreat { get; set; }
        public virtual DbSet<SpellTotemModel> SpellTotemModel { get; set; }
        public virtual DbSet<SpelleffectDbc> SpelleffectDbc { get; set; }
        public virtual DbSet<TerrainSwapDefaults> TerrainSwapDefaults { get; set; }
        public virtual DbSet<TerrainWorldmap> TerrainWorldmap { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<TrainerLocale> TrainerLocale { get; set; }
        public virtual DbSet<TrainerSpell> TrainerSpell { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }
        public virtual DbSet<TrinityString> TrinityString { get; set; }
        public virtual DbSet<Updates> Updates { get; set; }
        public virtual DbSet<UpdatesInclude> UpdatesInclude { get; set; }
        public virtual DbSet<VehicleAccessory> VehicleAccessory { get; set; }
        public virtual DbSet<VehicleTemplateAccessory> VehicleTemplateAccessory { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<WardenChecks> WardenChecks { get; set; }
        public virtual DbSet<WaypointData> WaypointData { get; set; }
        public virtual DbSet<WaypointScripts> WaypointScripts { get; set; }
        public virtual DbSet<Waypoints> Waypoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=password;database=world", x => x.ServerVersion("5.6.44-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessRequirement>(entity =>
            {
                entity.HasKey(e => new { e.MapId, e.Difficulty })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("access_requirement");

                entity.HasComment("Access Requirements");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapId")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Difficulty)
                    .HasColumnName("difficulty")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompletedAchievement)
                    .HasColumnName("completed_achievement")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item2)
                    .HasColumnName("item2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LevelMax)
                    .HasColumnName("level_max")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LevelMin)
                    .HasColumnName("level_min")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.QuestDoneA)
                    .HasColumnName("quest_done_A")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestDoneH)
                    .HasColumnName("quest_done_H")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestFailedText)
                    .HasColumnName("quest_failed_text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<AchievementDbc>(entity =>
            {
                entity.ToTable("achievement_dbc");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MapId)
                    .HasColumnName("mapID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RefAchievement)
                    .HasColumnName("refAchievement")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RequiredFaction)
                    .HasColumnName("requiredFaction")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");
            });

            modelBuilder.Entity<AchievementReward>(entity =>
            {
                entity.ToTable("achievement_reward");

                entity.HasComment("Loot System");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnName("MailTemplateID")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sender).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Subject)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleA).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TitleH).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<AchievementRewardLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("achievement_reward_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Locale)
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Body)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
            {
                entity.ToTable("areatrigger_involvedrelation");

                entity.HasComment("Trigger System");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<AreatriggerScripts>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("areatrigger_scripts");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<AreatriggerTavern>(entity =>
            {
                entity.ToTable("areatrigger_tavern");

                entity.HasComment("Trigger System");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<AreatriggerTeleport>(entity =>
            {
                entity.ToTable("areatrigger_teleport");

                entity.HasComment("Trigger System");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortLocId)
                    .HasColumnName("PortLocID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AreatriggerTemplate>(entity =>
            {
                entity.ToTable("areatrigger_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<AreatriggerTemplateActions>(entity =>
            {
                entity.HasKey(e => new { e.AreaTriggerId, e.ActionType, e.ActionParam })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("areatrigger_template_actions");

                entity.Property(e => e.AreaTriggerId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionType).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionParam).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetType).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<AreatriggerTemplatePolygonVertices>(entity =>
            {
                entity.HasKey(e => new { e.AreaTriggerId, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("areatrigger_template_polygon_vertices");

                entity.Property(e => e.AreaTriggerId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<BattlePetBreeds>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.BreedId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("battle_pet_breeds");

                entity.Property(e => e.SpeciesId)
                    .HasColumnName("speciesId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BreedId)
                    .HasColumnName("breedId")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<BattlePetQuality>(entity =>
            {
                entity.HasKey(e => e.SpeciesId)
                    .HasName("PRIMARY");

                entity.ToTable("battle_pet_quality");

                entity.Property(e => e.SpeciesId)
                    .HasColumnName("speciesId")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<BattlegroundTemplate>(entity =>
            {
                entity.ToTable("battleground_template");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllianceStartLoc).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HordeStartLoc).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.MaxLvl).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MaxPlayersPerTeam).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MinLvl).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MinPlayersPerTeam).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Weight)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<BattlemasterEntry>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("battlemaster_entry");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Entry of a creature");

                entity.Property(e => e.BgTemplate)
                    .HasColumnName("bg_template")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Battleground template id");
            });

            modelBuilder.Entity<BlackmarketTemplate>(entity =>
            {
                entity.HasKey(e => e.MarketId)
                    .HasName("PRIMARY");

                entity.ToTable("blackmarket_template");

                entity.Property(e => e.MarketId)
                    .HasColumnName("marketId")
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("bonusListIDs")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ItemEntry)
                    .HasColumnName("itemEntry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinBid)
                    .HasColumnName("minBid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SellerNpc)
                    .HasColumnName("sellerNpc")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CharacterTemplate>(entity =>
            {
                entity.ToTable("character_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(70)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CharacterTemplateClass>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.FactionGroup, e.Class })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("character_template_class");

                entity.Property(e => e.TemplateId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FactionGroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("3 - Alliance, 5 - Horde");

                entity.Property(e => e.Class).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<ClassExpansionRequirement>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PRIMARY");

                entity.ToTable("class_expansion_requirement");

                entity.Property(e => e.ClassId)
                    .HasColumnName("classID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Expansion)
                    .HasColumnName("expansion")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("command");

                entity.HasComment("Chat System");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Help)
                    .HasColumnName("help")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<Conditions>(entity =>
            {
                entity.HasKey(e => new { e.SourceTypeOrReferenceId, e.SourceGroup, e.SourceEntry, e.SourceId, e.ElseGroup, e.ConditionTypeOrReference, e.ConditionTarget, e.ConditionValue1, e.ConditionValue2, e.ConditionValue3 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

                entity.ToTable("conditions");

                entity.HasComment("Condition System");

                entity.Property(e => e.SourceTypeOrReferenceId)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceGroup)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceEntry)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceId).HasColumnType("int(11)");

                entity.Property(e => e.ElseGroup)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionTypeOrReference)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionTarget).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ConditionValue1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ConditionValue2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ConditionValue3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ErrorTextId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ErrorType)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NegativeCondition).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ConversationActorTemplate>(entity =>
            {
                entity.ToTable("conversation_actor_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatureId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CreatureModelId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<ConversationActors>(entity =>
            {
                entity.HasKey(e => new { e.ConversationId, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("conversation_actors");

                entity.Property(e => e.ConversationId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ConversationActorGuid).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ConversationActorId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<ConversationLineTemplate>(entity =>
            {
                entity.ToTable("conversation_line_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActorIdx).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Flags).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.StartTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.UiCameraId)
                    .HasColumnName("UiCameraID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<ConversationTemplate>(entity =>
            {
                entity.ToTable("conversation_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstLineId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.LastLineEndTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<Creature>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature");

                entity.HasComment("Creature System");

                entity.HasIndex(e => e.Id)
                    .HasName("idx_id");

                entity.HasIndex(e => e.Map)
                    .HasName("idx_map");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId)
                    .HasColumnName("areaId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("Area Identifier");

                entity.Property(e => e.Curhealth)
                    .HasColumnName("curhealth")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Curmana)
                    .HasColumnName("curmana")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Currentwaypoint)
                    .HasColumnName("currentwaypoint")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dynamicflags)
                    .HasColumnName("dynamicflags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Creature Identifier");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Modelid)
                    .HasColumnName("modelid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MovementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Npcflag)
                    .HasColumnName("npcflag")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PhaseGroup)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PhaseId)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PhaseUseFlags)
                    .HasColumnName("phaseUseFlags")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.ScriptName)
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SpawnDifficulties)
                    .IsRequired()
                    .HasColumnName("spawnDifficulties")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Spawndist).HasColumnName("spawndist");

                entity.Property(e => e.Spawntimesecs)
                    .HasColumnName("spawntimesecs")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'120'");

                entity.Property(e => e.TerrainSwapMap)
                    .HasColumnName("terrainSwapMap")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.UnitFlags)
                    .HasColumnName("unit_flags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UnitFlags2)
                    .HasColumnName("unit_flags2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UnitFlags3)
                    .HasColumnName("unit_flags3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("Zone Identifier");
            });

            modelBuilder.Entity<CreatureAddon>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_addon");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AiAnimKit)
                    .HasColumnName("aiAnimKit")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Auras)
                    .HasColumnName("auras")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bytes1)
                    .HasColumnName("bytes1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Bytes2)
                    .HasColumnName("bytes2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Emote)
                    .HasColumnName("emote")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MeleeAnimKit)
                    .HasColumnName("meleeAnimKit")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Mount)
                    .HasColumnName("mount")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MovementAnimKit)
                    .HasColumnName("movementAnimKit")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.PathId)
                    .HasColumnName("path_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureClasslevelstats>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.Class })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_classlevelstats");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Attackpower)
                    .HasColumnName("attackpower")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Basearmor)
                    .HasColumnName("basearmor")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Basemana)
                    .HasColumnName("basemana")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DamageBase).HasColumnName("damage_base");

                entity.Property(e => e.DamageExp1).HasColumnName("damage_exp1");

                entity.Property(e => e.DamageExp2).HasColumnName("damage_exp2");

                entity.Property(e => e.DamageExp3).HasColumnName("damage_exp3");

                entity.Property(e => e.DamageExp4).HasColumnName("damage_exp4");

                entity.Property(e => e.DamageExp5).HasColumnName("damage_exp5");

                entity.Property(e => e.Rangedattackpower)
                    .HasColumnName("rangedattackpower")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<CreatureDefaultTrainer>(entity =>
            {
                entity.HasKey(e => e.CreatureId)
                    .HasName("PRIMARY");

                entity.ToTable("creature_default_trainer");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrainerId).HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<CreatureEquipTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_equip_template");

                entity.Property(e => e.CreatureId)
                    .HasColumnName("CreatureID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AppearanceModId1)
                    .HasColumnName("AppearanceModID1")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AppearanceModId2)
                    .HasColumnName("AppearanceModID2")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AppearanceModId3)
                    .HasColumnName("AppearanceModID3")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemId1)
                    .HasColumnName("ItemID1")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemId2)
                    .HasColumnName("ItemID2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemId3)
                    .HasColumnName("ItemID3")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemVisual1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemVisual2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemVisual3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureFormations>(entity =>
            {
                entity.HasKey(e => e.MemberGuid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_formations");

                entity.Property(e => e.MemberGuid)
                    .HasColumnName("memberGUID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.Dist)
                    .HasColumnName("dist")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.GroupAi)
                    .HasColumnName("groupAI")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LeaderGuid)
                    .HasColumnName("leaderGUID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Point1)
                    .HasColumnName("point_1")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Point2)
                    .HasColumnName("point_2")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<CreatureLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureModelInfo>(entity =>
            {
                entity.HasKey(e => e.DisplayId)
                    .HasName("PRIMARY");

                entity.ToTable("creature_model_info");

                entity.HasComment("Creature System (Model related info)");

                entity.Property(e => e.DisplayId)
                    .HasColumnName("DisplayID")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayIdOtherGender)
                    .HasColumnName("DisplayID_Other_Gender")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureOnkillReputation>(entity =>
            {
                entity.HasKey(e => e.CreatureId)
                    .HasName("PRIMARY");

                entity.ToTable("creature_onkill_reputation");

                entity.HasComment("Creature OnKill Reputation gain");

                entity.Property(e => e.CreatureId)
                    .HasColumnName("creature_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Creature Identifier");

                entity.Property(e => e.IsTeamAward1).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTeamAward2).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxStanding1).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxStanding2).HasColumnType("tinyint(4)");

                entity.Property(e => e.RewOnKillRepFaction1).HasColumnType("smallint(6)");

                entity.Property(e => e.RewOnKillRepFaction2).HasColumnType("smallint(6)");

                entity.Property(e => e.RewOnKillRepValue1)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewOnKillRepValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TeamDependent).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<CreatureQuestender>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_questender");

                entity.HasComment("Creature System");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CreatureQuestitem>(entity =>
            {
                entity.HasKey(e => new { e.CreatureEntry, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_questitem");

                entity.Property(e => e.CreatureEntry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<CreatureQueststarter>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_queststarter");

                entity.HasComment("Creature System");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CreatureSummonGroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("creature_summon_groups");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupId")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.SummonTime)
                    .HasColumnName("summonTime")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SummonType)
                    .HasColumnName("summonType")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SummonerId)
                    .HasColumnName("summonerId")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SummonerType)
                    .HasColumnName("summonerType")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<CreatureTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template");

                entity.HasComment("Creature System");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ainame)
                    .IsRequired()
                    .HasColumnName("AIName")
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ArmorModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.BaseAttackTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BaseVariance).HasDefaultValueSql("'1'");

                entity.Property(e => e.DamageModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.DifficultyEntry1)
                    .HasColumnName("difficulty_entry_1")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DifficultyEntry2)
                    .HasColumnName("difficulty_entry_2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DifficultyEntry3)
                    .HasColumnName("difficulty_entry_3")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dmgschool)
                    .HasColumnName("dmgschool")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Dynamicflags)
                    .HasColumnName("dynamicflags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExperienceModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Family)
                    .HasColumnName("family")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FemaleName)
                    .IsRequired()
                    .HasColumnName("femaleName")
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FlagsExtra)
                    .HasColumnName("flags_extra")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.GossipMenuId)
                    .HasColumnName("gossip_menu_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HealthModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.HealthModifierExtra).HasDefaultValueSql("'1'");

                entity.Property(e => e.HealthScalingExpansion)
                    .HasColumnType("mediumint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HoverHeight).HasDefaultValueSql("'1'");

                entity.Property(e => e.IconName)
                    .HasColumnType("char(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InhabitType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.KillCredit1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.KillCredit2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Lootid)
                    .HasColumnName("lootid")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ManaModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.ManaModifierExtra).HasDefaultValueSql("'1'");

                entity.Property(e => e.Maxgold)
                    .HasColumnName("maxgold")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Maxlevel)
                    .HasColumnName("maxlevel")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MechanicImmuneMask)
                    .HasColumnName("mechanic_immune_mask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Mingold)
                    .HasColumnName("mingold")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Minlevel)
                    .HasColumnName("minlevel")
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Modelid1)
                    .HasColumnName("modelid1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Modelid2)
                    .HasColumnName("modelid2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Modelid3)
                    .HasColumnName("modelid3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Modelid4)
                    .HasColumnName("modelid4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MovementId)
                    .HasColumnName("movementId")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.MovementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Npcflag)
                    .HasColumnName("npcflag")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Pickpocketloot)
                    .HasColumnName("pickpocketloot")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RacialLeader).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RangeAttackTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RangeVariance).HasDefaultValueSql("'1'");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RegenHealth)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RequiredExpansion)
                    .HasColumnType("mediumint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Resistance1)
                    .HasColumnName("resistance1")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Resistance2)
                    .HasColumnName("resistance2")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Resistance3)
                    .HasColumnName("resistance3")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Resistance4)
                    .HasColumnName("resistance4")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Resistance5)
                    .HasColumnName("resistance5")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Resistance6)
                    .HasColumnName("resistance6")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Scale)
                    .HasColumnName("scale")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Skinloot)
                    .HasColumnName("skinloot")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpeedRun)
                    .HasColumnName("speed_run")
                    .HasDefaultValueSql("'1.14286'")
                    .HasComment("Result of 8.0/7.0, most common value");

                entity.Property(e => e.SpeedWalk)
                    .HasColumnName("speed_walk")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Result of 2.5/2.5, most common value");

                entity.Property(e => e.Spell1)
                    .HasColumnName("spell1")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell2)
                    .HasColumnName("spell2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell3)
                    .HasColumnName("spell3")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell4)
                    .HasColumnName("spell4")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell5)
                    .HasColumnName("spell5")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell6)
                    .HasColumnName("spell6")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell7)
                    .HasColumnName("spell7")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell8)
                    .HasColumnName("spell8")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Subname)
                    .HasColumnName("subname")
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleAlt)
                    .HasColumnType("char(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrainerClass)
                    .HasColumnName("trainer_class")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TypeFlags)
                    .HasColumnName("type_flags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TypeFlags2)
                    .HasColumnName("type_flags2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UnitClass)
                    .HasColumnName("unit_class")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UnitFlags)
                    .HasColumnName("unit_flags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UnitFlags2)
                    .HasColumnName("unit_flags2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UnitFlags3)
                    .HasColumnName("unit_flags3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.VehicleId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VignetteId)
                    .HasColumnName("VignetteID")
                    .HasColumnType("mediumint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureTemplateAddon>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template_addon");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AiAnimKit)
                    .HasColumnName("aiAnimKit")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Auras)
                    .HasColumnName("auras")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bytes1)
                    .HasColumnName("bytes1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Bytes2)
                    .HasColumnName("bytes2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Emote)
                    .HasColumnName("emote")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MeleeAnimKit)
                    .HasColumnName("meleeAnimKit")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Mount)
                    .HasColumnName("mount")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MovementAnimKit)
                    .HasColumnName("movementAnimKit")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.PathId)
                    .HasColumnName("path_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_template_locale");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameAlt)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleAlt)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureTemplateOutfits>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template_outfits");

                entity.HasComment("Use positive values for item entries and negative to use item displayid for head, shoulders etc.");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Back)
                    .HasColumnName("back")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BackAppearance)
                    .HasColumnName("back_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BodyAppearance)
                    .HasColumnName("body_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Chest)
                    .HasColumnName("chest")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChestAppearance)
                    .HasColumnName("chest_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Face)
                    .HasColumnName("face")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Facialhair)
                    .HasColumnName("facialhair")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Feature1)
                    .HasColumnName("feature1")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Feature2)
                    .HasColumnName("feature2")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Feature3)
                    .HasColumnName("feature3")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Feet)
                    .HasColumnName("feet")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.FeetAppearance)
                    .HasColumnName("feet_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("0 for male, 1 for female");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Hands)
                    .HasColumnName("hands")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HandsAppearance)
                    .HasColumnName("hands_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Head)
                    .HasColumnName("head")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HeadAppearance)
                    .HasColumnName("head_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Legs)
                    .HasColumnName("legs")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.LegsAppearance)
                    .HasColumnName("legs_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Npcsoundsid)
                    .HasColumnName("npcsoundsid")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("entry from NPCSounds.dbc/db2");

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shoulders)
                    .HasColumnName("shoulders")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ShouldersAppearance)
                    .HasColumnName("shoulders_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Skin)
                    .HasColumnName("skin")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Tabard)
                    .HasColumnName("tabard")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TabardAppearance)
                    .HasColumnName("tabard_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Waist)
                    .HasColumnName("waist")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.WaistAppearance)
                    .HasColumnName("waist_appearance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Wrists)
                    .HasColumnName("wrists")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.WristsAppearance)
                    .HasColumnName("wrists_appearance")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureTemplateScaling>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template_scaling");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelScalingDeltaMax).HasColumnType("smallint(5)");

                entity.Property(e => e.LevelScalingDeltaMin).HasColumnType("smallint(5)");

                entity.Property(e => e.LevelScalingMax).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LevelScalingMin).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<CreatureText>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("creature_text");

                entity.Property(e => e.CreatureId)
                    .HasColumnName("CreatureID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BroadcastTextId)
                    .HasColumnType("mediumint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Emote)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Language).HasColumnType("tinyint(3)");

                entity.Property(e => e.Probability).HasColumnType("float unsigned");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TextRange).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Type).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<CreatureTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("creature_text_locale");

                entity.Property(e => e.CreatureId)
                    .HasColumnName("CreatureID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CriteriaData>(entity =>
            {
                entity.HasKey(e => new { e.CriteriaId, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("criteria_data");

                entity.HasComment("Achievment system");

                entity.Property(e => e.CriteriaId)
                    .HasColumnName("criteria_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value1)
                    .HasColumnName("value1")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Disables>(entity =>
            {
                entity.HasKey(e => new { e.SourceType, e.Entry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("disables");

                entity.Property(e => e.SourceType)
                    .HasColumnName("sourceType")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Params0)
                    .IsRequired()
                    .HasColumnName("params_0")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Params1)
                    .IsRequired()
                    .HasColumnName("params_1")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DisenchantLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("disenchant_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EventScripts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("event_scripts");

                entity.Property(e => e.Command)
                    .HasColumnName("command")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dataint)
                    .HasColumnName("dataint")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datalong)
                    .HasColumnName("datalong")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Datalong2)
                    .HasColumnName("datalong2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<ExplorationBasexp>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PRIMARY");

                entity.ToTable("exploration_basexp");

                entity.HasComment("Exploration System");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Basexp)
                    .HasColumnName("basexp")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<FishingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("fishing_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEvent>(entity =>
            {
                entity.HasKey(e => e.EventEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Announce)
                    .HasColumnName("announce")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'")
                    .HasComment("0 dont announce, 1 announce, 2 value from config");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasComment("Description of the event displayed in console")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("timestamp")
                    .HasComment("Absolute end date, the event will never start after");

                entity.Property(e => e.Holiday)
                    .HasColumnName("holiday")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Client side holiday id");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'2592000'")
                    .HasComment("Length in minutes of the event");

                entity.Property(e => e.Occurence)
                    .HasColumnName("occurence")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'5184000'")
                    .HasComment("Delay in minutes between occurences of the event");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("timestamp")
                    .HasComment("Absolute start date, the event will never start before");

                entity.Property(e => e.WorldEvent)
                    .HasColumnName("world_event")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("0 if normal event, 1 if world event");
            });

            modelBuilder.Entity<GameEventArenaSeasons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("game_event_arena_seasons");

                entity.HasIndex(e => new { e.Season, e.EventEntry })
                    .HasName("season")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Season)
                    .HasColumnName("season")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Arena season number");
            });

            modelBuilder.Entity<GameEventBattlegroundHoliday>(entity =>
            {
                entity.HasKey(e => e.EventEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_battleground_holiday");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Bgflag)
                    .HasColumnName("bgflag")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GameEventCondition>(entity =>
            {
                entity.HasKey(e => new { e.EventEntry, e.ConditionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_condition");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DoneWorldStateField)
                    .HasColumnName("done_world_state_field")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MaxWorldStateField)
                    .HasColumnName("max_world_state_field")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqNum)
                    .HasColumnName("req_num")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventCreature>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_creature");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(4)")
                    .HasComment("Entry of the game event. Put negative entry to remove during event.");
            });

            modelBuilder.Entity<GameEventCreatureQuest>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_creature_quest");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event.");
            });

            modelBuilder.Entity<GameEventGameobject>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_gameobject");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(4)")
                    .HasComment("Entry of the game event. Put negative entry to remove during event.");
            });

            modelBuilder.Entity<GameEventGameobjectQuest>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("game_event_gameobject_quest");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");
            });

            modelBuilder.Entity<GameEventModelEquip>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_model_equip");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(4)")
                    .HasComment("Entry of the game event.");

                entity.Property(e => e.Modelid)
                    .HasColumnName("modelid")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GameEventNpcVendor>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Item, e.ExtendedCost, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("game_event_npc_vendor");

                entity.HasIndex(e => e.Slot)
                    .HasName("slot");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtendedCost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("BonusListIDs")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(4)")
                    .HasComment("Entry of the game event.");

                entity.Property(e => e.IgnoreFiltering).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Incrtime)
                    .HasColumnName("incrtime")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Maxcount)
                    .HasColumnName("maxcount")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<GameEventNpcflag>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_npcflag");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Npcflag)
                    .HasColumnName("npcflag")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<GameEventPool>(entity =>
            {
                entity.HasKey(e => e.PoolEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_pool");

                entity.Property(e => e.PoolEntry)
                    .HasColumnName("pool_entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Id of the pool");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(4)")
                    .HasComment("Entry of the game event. Put negative entry to remove during event.");
            });

            modelBuilder.Entity<GameEventPrerequisite>(entity =>
            {
                entity.HasKey(e => new { e.EventEntry, e.PrerequisiteEvent })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_prerequisite");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.PrerequisiteEvent)
                    .HasColumnName("prerequisite_event")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<GameEventQuestCondition>(entity =>
            {
                entity.HasKey(e => e.Quest)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_quest_condition");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Entry of the game event.");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventSeasonalQuestrelation>(entity =>
            {
                entity.HasKey(e => new { e.QuestId, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_seasonal_questrelation");

                entity.HasComment("Player System");

                entity.HasIndex(e => e.QuestId)
                    .HasName("idx_quest");

                entity.Property(e => e.QuestId)
                    .HasColumnName("questId")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.EventEntry)
                    .HasColumnName("eventEntry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Entry of the game event");
            });

            modelBuilder.Entity<GameTele>(entity =>
            {
                entity.ToTable("game_tele");

                entity.HasComment("Tele Command");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");
            });

            modelBuilder.Entity<GameWeather>(entity =>
            {
                entity.HasKey(e => e.Zone)
                    .HasName("PRIMARY");

                entity.ToTable("game_weather");

                entity.HasComment("Weather System");

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FallRainChance)
                    .HasColumnName("fall_rain_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.FallSnowChance)
                    .HasColumnName("fall_snow_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.FallStormChance)
                    .HasColumnName("fall_storm_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpringRainChance)
                    .HasColumnName("spring_rain_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringSnowChance)
                    .HasColumnName("spring_snow_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringStormChance)
                    .HasColumnName("spring_storm_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerRainChance)
                    .HasColumnName("summer_rain_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerSnowChance)
                    .HasColumnName("summer_snow_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerStormChance)
                    .HasColumnName("summer_storm_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterRainChance)
                    .HasColumnName("winter_rain_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterSnowChance)
                    .HasColumnName("winter_snow_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterStormChance)
                    .HasColumnName("winter_storm_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'25'");
            });

            modelBuilder.Entity<Gameobject>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject");

                entity.HasComment("Gameobject System");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Animprogress)
                    .HasColumnName("animprogress")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.AreaId)
                    .HasColumnName("areaId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("Area Identifier");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Gameobject Identifier");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PhaseGroup)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PhaseId)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PhaseUseFlags)
                    .HasColumnName("phaseUseFlags")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PositionX)
                    .HasColumnName("position_x")
                    .HasColumnType("float(15,5)");

                entity.Property(e => e.PositionY)
                    .HasColumnName("position_y")
                    .HasColumnType("float(15,5)");

                entity.Property(e => e.PositionZ)
                    .HasColumnName("position_z")
                    .HasColumnType("float(15,5)");

                entity.Property(e => e.Rotation0).HasColumnName("rotation0");

                entity.Property(e => e.Rotation1).HasColumnName("rotation1");

                entity.Property(e => e.Rotation2).HasColumnName("rotation2");

                entity.Property(e => e.Rotation3).HasColumnName("rotation3");

                entity.Property(e => e.ScriptName)
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SpawnDifficulties)
                    .IsRequired()
                    .HasColumnName("spawnDifficulties")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Spawntimesecs)
                    .HasColumnName("spawntimesecs")
                    .HasColumnType("int(11)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TerrainSwapMap)
                    .HasColumnName("terrainSwapMap")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zoneId")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("Zone Identifier");
            });

            modelBuilder.Entity<GameobjectAddon>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_addon");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.InvisibilityType)
                    .HasColumnName("invisibilityType")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.InvisibilityValue)
                    .HasColumnName("invisibilityValue")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ParentRotation0).HasColumnName("parent_rotation0");

                entity.Property(e => e.ParentRotation1).HasColumnName("parent_rotation1");

                entity.Property(e => e.ParentRotation2).HasColumnName("parent_rotation2");

                entity.Property(e => e.ParentRotation3)
                    .HasColumnName("parent_rotation3")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.WorldEffectId)
                    .HasColumnName("WorldEffectID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectQuestender>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_questender");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<GameobjectQuestitem>(entity =>
            {
                entity.HasKey(e => new { e.GameObjectEntry, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_questitem");

                entity.Property(e => e.GameObjectEntry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<GameobjectQueststarter>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_queststarter");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnName("quest")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<GameobjectTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_template");

                entity.HasComment("Gameobject System");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ainame)
                    .IsRequired()
                    .HasColumnName("AIName")
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CastBarCaption)
                    .IsRequired()
                    .HasColumnName("castBarCaption")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data0).HasColumnType("int(10)");

                entity.Property(e => e.Data1).HasColumnType("int(10)");

                entity.Property(e => e.Data10).HasColumnType("int(10)");

                entity.Property(e => e.Data11).HasColumnType("int(10)");

                entity.Property(e => e.Data12).HasColumnType("int(10)");

                entity.Property(e => e.Data13).HasColumnType("int(10)");

                entity.Property(e => e.Data14).HasColumnType("int(10)");

                entity.Property(e => e.Data15).HasColumnType("int(10)");

                entity.Property(e => e.Data16).HasColumnType("int(10)");

                entity.Property(e => e.Data17).HasColumnType("int(10)");

                entity.Property(e => e.Data18).HasColumnType("int(10)");

                entity.Property(e => e.Data19).HasColumnType("int(10)");

                entity.Property(e => e.Data2).HasColumnType("int(10)");

                entity.Property(e => e.Data20).HasColumnType("int(10)");

                entity.Property(e => e.Data21).HasColumnType("int(10)");

                entity.Property(e => e.Data22).HasColumnType("int(10)");

                entity.Property(e => e.Data23).HasColumnType("int(10)");

                entity.Property(e => e.Data24).HasColumnType("int(10)");

                entity.Property(e => e.Data25).HasColumnType("int(10)");

                entity.Property(e => e.Data26).HasColumnType("int(10)");

                entity.Property(e => e.Data27).HasColumnType("int(10)");

                entity.Property(e => e.Data28).HasColumnType("int(10)");

                entity.Property(e => e.Data29).HasColumnType("int(10)");

                entity.Property(e => e.Data3).HasColumnType("int(10)");

                entity.Property(e => e.Data30).HasColumnType("int(10)");

                entity.Property(e => e.Data31).HasColumnType("int(10)");

                entity.Property(e => e.Data32).HasColumnType("int(10)");

                entity.Property(e => e.Data4).HasColumnType("int(10)");

                entity.Property(e => e.Data5).HasColumnType("int(10)");

                entity.Property(e => e.Data6).HasColumnType("int(10)");

                entity.Property(e => e.Data7).HasColumnType("int(10)");

                entity.Property(e => e.Data8).HasColumnType("int(10)");

                entity.Property(e => e.Data9).HasColumnType("int(10)");

                entity.Property(e => e.DisplayId)
                    .HasColumnName("displayId")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IconName)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequiredLevel).HasColumnType("int(10)");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Unk1)
                    .IsRequired()
                    .HasColumnName("unk1")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectTemplateAddon>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_template_addon");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Maxgold)
                    .HasColumnName("maxgold")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mingold)
                    .HasColumnName("mingold")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WorldEffectId)
                    .HasColumnName("WorldEffectID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_template_locale");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CastBarCaption)
                    .HasColumnName("castBarCaption")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unk1)
                    .HasColumnName("unk1")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GarrisonFollowerClassSpecAbilities>(entity =>
            {
                entity.HasKey(e => new { e.ClassSpecId, e.AbilityId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("garrison_follower_class_spec_abilities");

                entity.Property(e => e.ClassSpecId)
                    .HasColumnName("classSpecId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AbilityId)
                    .HasColumnName("abilityId")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GarrisonPlotFinalizeInfo>(entity =>
            {
                entity.HasKey(e => e.GarrPlotInstanceId)
                    .HasName("PRIMARY");

                entity.ToTable("garrison_plot_finalize_info");

                entity.Property(e => e.GarrPlotInstanceId)
                    .HasColumnName("garrPlotInstanceId")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllianceAnimKitId)
                    .HasColumnName("allianceAnimKitId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AllianceGameObjectId)
                    .HasColumnName("allianceGameObjectId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AllianceO).HasColumnName("allianceO");

                entity.Property(e => e.AllianceX).HasColumnName("allianceX");

                entity.Property(e => e.AllianceY).HasColumnName("allianceY");

                entity.Property(e => e.AllianceZ).HasColumnName("allianceZ");

                entity.Property(e => e.HordeAnimKitId)
                    .HasColumnName("hordeAnimKitId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.HordeGameObjectId)
                    .HasColumnName("hordeGameObjectId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HordeO).HasColumnName("hordeO");

                entity.Property(e => e.HordeX).HasColumnName("hordeX");

                entity.Property(e => e.HordeY).HasColumnName("hordeY");

                entity.Property(e => e.HordeZ).HasColumnName("hordeZ");
            });

            modelBuilder.Entity<GossipMenu>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.TextId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu");

                entity.Property(e => e.MenuId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TextId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<GossipMenuOption>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option");

                entity.Property(e => e.MenuId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionBroadcastTextId).HasColumnType("int(11) unsigned");

                entity.Property(e => e.OptionIcon).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.OptionNpcFlag).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OptionText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OptionType).HasColumnType("int(11) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<GossipMenuOptionAction>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option_action");

                entity.Property(e => e.MenuId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionMenuId).HasColumnType("int(11) unsigned");

                entity.Property(e => e.ActionPoiId).HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<GossipMenuOptionBox>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option_box");

                entity.Property(e => e.MenuId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BoxBroadcastTextId).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BoxCoded).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BoxMoney).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BoxText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GossipMenuOptionLocale>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option_locale");

                entity.Property(e => e.MenuId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BoxText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OptionText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GossipMenuOptionTrainer>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option_trainer");

                entity.Property(e => e.MenuId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TrainerId).HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<GraveyardZone>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.GhostZone })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("graveyard_zone");

                entity.HasComment("Trigger System");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GhostZone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Faction).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<GuildRewards>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PRIMARY");

                entity.ToTable("guild_rewards");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Cost)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinGuildRep)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GuildRewardsReqAchievements>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.AchievementRequired })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_rewards_req_achievements");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AchievementRequired)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InstanceEncounters>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("instance_encounters");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Unique entry from DungeonEncounter.dbc")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreditEntry)
                    .HasColumnName("creditEntry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CreditType)
                    .HasColumnName("creditType")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LastEncounterDungeon)
                    .HasColumnName("lastEncounterDungeon")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("If not 0, LfgDungeon.dbc entry for the instance it is last encounter in");
            });

            modelBuilder.Entity<InstanceTemplate>(entity =>
            {
                entity.HasKey(e => e.Map)
                    .HasName("PRIMARY");

                entity.ToTable("instance_template");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowMount)
                    .HasColumnName("allowMount")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Script)
                    .IsRequired()
                    .HasColumnName("script")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Type, e.Ench })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("item_enchantment_template");

                entity.HasComment("Item Random Enchantment System");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Ench)
                    .HasColumnName("ench")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasColumnType("float unsigned");
            });

            modelBuilder.Entity<ItemLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItemScriptNames>(entity =>
            {
                entity.ToTable("item_script_names");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ItemTemplateAddon>(entity =>
            {
                entity.ToTable("item_template_addon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlagsCu).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FoodType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MaxMoneyLoot).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MinMoneyLoot).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellPpmchance)
                    .HasColumnName("SpellPPMChance")
                    .HasColumnType("float unsigned");
            });

            modelBuilder.Entity<LfgDungeonRewards>(entity =>
            {
                entity.HasKey(e => new { e.DungeonId, e.MaxLevel })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("lfg_dungeon_rewards");

                entity.Property(e => e.DungeonId)
                    .HasColumnName("dungeonId")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Dungeon entry from dbc");

                entity.Property(e => e.MaxLevel)
                    .HasColumnName("maxLevel")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Max level at which this reward is rewarded");

                entity.Property(e => e.FirstQuestId)
                    .HasColumnName("firstQuestId")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Quest id with rewards for first dungeon this day");

                entity.Property(e => e.OtherQuestId)
                    .HasColumnName("otherQuestId")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Quest id with rewards for Nth dungeon this day");
            });

            modelBuilder.Entity<LfgDungeonTemplate>(entity =>
            {
                entity.HasKey(e => e.DungeonId)
                    .HasName("PRIMARY");

                entity.ToTable("lfg_dungeon_template");

                entity.Property(e => e.DungeonId)
                    .HasColumnName("dungeonId")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Unique id from LFGDungeons.dbc")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.RequiredItemLevel)
                    .HasColumnName("requiredItemLevel")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LinkedRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.LinkType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("linked_respawn");

                entity.HasComment("Creature Respawn Link System");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LinkType)
                    .HasColumnName("linkType")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LinkedGuid)
                    .HasColumnName("linkedGuid")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<MailLevelReward>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.RaceMask })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_level_reward");

                entity.HasComment("Mail System");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RaceMask)
                    .HasColumnName("raceMask")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnName("mailTemplateId")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SenderEntry)
                    .HasColumnName("senderEntry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MailLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MillingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("milling_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MountDefinitions>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("mount_definitions");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spellId")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherFactionSpellId)
                    .HasColumnName("otherFactionSpellId")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<NpcSpellclickSpells>(entity =>
            {
                entity.HasKey(e => new { e.NpcEntry, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("npc_spellclick_spells");

                entity.Property(e => e.NpcEntry)
                    .HasColumnName("npc_entry")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("reference to creature_template");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spell_id")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("spell which should be casted ");

                entity.Property(e => e.CastFlags)
                    .HasColumnName("cast_flags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit");

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("relation with summoner: 0-no 1-friendly 2-raid 3-party player can click");
            });

            modelBuilder.Entity<NpcText>(entity =>
            {
                entity.ToTable("npc_text");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId0)
                    .HasColumnName("BroadcastTextID0")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId1)
                    .HasColumnName("BroadcastTextID1")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId2)
                    .HasColumnName("BroadcastTextID2")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId3)
                    .HasColumnName("BroadcastTextID3")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId4)
                    .HasColumnName("BroadcastTextID4")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId5)
                    .HasColumnName("BroadcastTextID5")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId6)
                    .HasColumnName("BroadcastTextID6")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId7)
                    .HasColumnName("BroadcastTextID7")
                    .HasColumnType("mediumint(6) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<NpcVendor>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item, e.ExtendedCost, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("npc_vendor");

                entity.HasComment("Npc System");

                entity.HasIndex(e => e.Slot)
                    .HasName("slot");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtendedCost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("BonusListIDs")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IgnoreFiltering).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Incrtime)
                    .HasColumnName("incrtime")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Maxcount)
                    .HasColumnName("maxcount")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Slot)
                    .HasColumnName("slot")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OutdoorpvpTemplate>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("outdoorpvp_template");

                entity.HasComment("OutdoorPvP Templates");

                entity.Property(e => e.TypeId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PageText>(entity =>
            {
                entity.ToTable("page_text");

                entity.HasComment("Item System");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Flags).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NextPageId)
                    .HasColumnName("NextPageID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PageTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("page_text_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PetLevelstats>(entity =>
            {
                entity.HasKey(e => new { e.CreatureEntry, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_levelstats");

                entity.HasComment("Stores pet levels stats.");

                entity.Property(e => e.CreatureEntry)
                    .HasColumnName("creature_entry")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Agi)
                    .HasColumnName("agi")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Armor)
                    .HasColumnName("armor")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Hp)
                    .HasColumnName("hp")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Inte)
                    .HasColumnName("inte")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Mana)
                    .HasColumnName("mana")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Spi)
                    .HasColumnName("spi")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Sta)
                    .HasColumnName("sta")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Str)
                    .HasColumnName("str")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<PetNameGeneration>(entity =>
            {
                entity.ToTable("pet_name_generation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Half)
                    .HasColumnName("half")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PhaseArea>(entity =>
            {
                entity.HasKey(e => new { e.AreaId, e.PhaseId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("phase_area");

                entity.Property(e => e.AreaId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.PhaseId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pickpocketing_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayerFactionchangeAchievement>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_achievement");

                entity.Property(e => e.AllianceId)
                    .HasColumnName("alliance_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HordeId)
                    .HasColumnName("horde_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PlayerFactionchangeItems>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_items");

                entity.Property(e => e.AllianceId)
                    .HasColumnName("alliance_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HordeId)
                    .HasColumnName("horde_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CommentA)
                    .HasColumnName("commentA")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommentH)
                    .HasColumnName("commentH")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RaceA)
                    .HasColumnName("race_A")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RaceH)
                    .HasColumnName("race_H")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PlayerFactionchangeQuests>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_quests");

                entity.HasIndex(e => e.AllianceId)
                    .HasName("alliance_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.HordeId)
                    .HasName("horde_uniq")
                    .IsUnique();

                entity.Property(e => e.AllianceId)
                    .HasColumnName("alliance_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HordeId)
                    .HasColumnName("horde_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PlayerFactionchangeReputations>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_reputations");

                entity.Property(e => e.AllianceId)
                    .HasColumnName("alliance_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HordeId)
                    .HasColumnName("horde_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PlayerFactionchangeSpells>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_spells");

                entity.Property(e => e.AllianceId)
                    .HasColumnName("alliance_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HordeId)
                    .HasColumnName("horde_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PlayerFactionchangeTitles>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_titles");

                entity.Property(e => e.AllianceId)
                    .HasColumnName("alliance_id")
                    .HasColumnType("int(8)");

                entity.Property(e => e.HordeId)
                    .HasColumnName("horde_id")
                    .HasColumnType("int(8)");
            });

            modelBuilder.Entity<PlayerLevelstats>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("player_levelstats");

                entity.HasComment("Stores levels stats.");

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Agi)
                    .HasColumnName("agi")
                    .HasColumnType("smallint(6) unsigned")
                    .HasComment("agility");

                entity.Property(e => e.Inte)
                    .HasColumnName("inte")
                    .HasColumnType("smallint(6) unsigned")
                    .HasComment("intellect");

                entity.Property(e => e.Sta)
                    .HasColumnName("sta")
                    .HasColumnType("smallint(6) unsigned")
                    .HasComment("stamina");

                entity.Property(e => e.Str)
                    .HasColumnName("str")
                    .HasColumnType("smallint(6) unsigned")
                    .HasComment("strength");
            });

            modelBuilder.Entity<PlayerXpForLevel>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PRIMARY");

                entity.ToTable("player_xp_for_level");

                entity.Property(e => e.Level).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Experience).HasColumnType("float unsigned");
            });

            modelBuilder.Entity<Playerchoice>(entity =>
            {
                entity.HasKey(e => e.ChoiceId)
                    .HasName("PRIMARY");

                entity.ToTable("playerchoice");

                entity.Property(e => e.ChoiceId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Question)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UiTextureKitId).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<PlayerchoiceLocale>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playerchoice_locale");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Question)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<PlayerchoiceResponse>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.ResponseId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playerchoice_response");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.ResponseId).HasColumnType("int(11)");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnType("varchar(511)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChoiceArtFileId).HasColumnType("int(11)");

                entity.Property(e => e.Confirmation)
                    .IsRequired()
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(2047)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasColumnType("varchar(511)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Index).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<PlayerchoiceResponseLocale>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.ResponseId, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playerchoice_response_locale");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.ResponseId).HasColumnType("int(11)");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnType("varchar(511)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmation)
                    .IsRequired()
                    .HasColumnType("varchar(127)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(2047)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasColumnType("varchar(511)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<PlayerchoiceResponseReward>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.ResponseId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playerchoice_response_reward");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.ResponseId).HasColumnType("int(11)");

                entity.Property(e => e.ArenaPointCount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.HonorPointCount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Money).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PackageId).HasColumnType("int(11)");

                entity.Property(e => e.SkillLineId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SkillPointCount).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TitleId).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");

                entity.Property(e => e.Xp).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<PlayerchoiceResponseRewardCurrency>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.ResponseId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playerchoice_response_reward_currency");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.ResponseId).HasColumnType("int(11)");

                entity.Property(e => e.CurrencyId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Index).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<PlayerchoiceResponseRewardFaction>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.ResponseId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playerchoice_response_reward_faction");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.ResponseId).HasColumnType("int(11)");

                entity.Property(e => e.FactionId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Index).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<PlayerchoiceResponseRewardItem>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.ResponseId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playerchoice_response_reward_item");

                entity.Property(e => e.ChoiceId).HasColumnType("int(11)");

                entity.Property(e => e.ResponseId).HasColumnType("int(11)");

                entity.Property(e => e.BonusListIds)
                    .HasColumnName("BonusListIDs")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Index).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Playercreateinfo>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playercreateinfo");

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayercreateinfoAction>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Button })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_action");

                entity.HasIndex(e => new { e.Race, e.Class })
                    .HasName("playercreateinfo_race_class_index")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Button)
                    .HasColumnName("button")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<PlayercreateinfoCastSpell>(entity =>
            {
                entity.HasKey(e => new { e.RaceMask, e.ClassMask, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_cast_spell");

                entity.Property(e => e.RaceMask)
                    .HasColumnName("raceMask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ClassMask)
                    .HasColumnName("classMask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PlayercreateinfoItem>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Itemid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_item");

                entity.HasIndex(e => new { e.Race, e.Class })
                    .HasName("playercreateinfo_race_class_index")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PlayercreateinfoSpellCustom>(entity =>
            {
                entity.HasKey(e => new { e.Racemask, e.Classmask, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_spell_custom");

                entity.Property(e => e.Racemask)
                    .HasColumnName("racemask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Classmask)
                    .HasColumnName("classmask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Note)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PointsOfInterest>(entity =>
            {
                entity.ToTable("points_of_interest");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Flags)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Icon)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Importance)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PointsOfInterestLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("points_of_interest_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolCreature>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("pool_creature");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoolEntry)
                    .HasColumnName("pool_entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolGameobject>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("pool_gameobject");

                entity.HasIndex(e => e.Guid)
                    .HasName("idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoolEntry)
                    .HasColumnName("pool_entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolPool>(entity =>
            {
                entity.HasKey(e => e.PoolId)
                    .HasName("PRIMARY");

                entity.ToTable("pool_pool");

                entity.Property(e => e.PoolId)
                    .HasColumnName("pool_id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MotherPool)
                    .HasColumnName("mother_pool")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolQuest>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("pool_quest");

                entity.HasIndex(e => e.Entry)
                    .HasName("idx_guid");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PoolEntry)
                    .HasColumnName("pool_entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("pool_template");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Pool entry");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxLimit)
                    .HasColumnName("max_limit")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Max number of objects (0) is no limit");
            });

            modelBuilder.Entity<ProspectingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("prospecting_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuestDetails>(entity =>
            {
                entity.ToTable("quest_details");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Emote1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteDelay1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<QuestGreeting>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_greeting");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GreetEmoteDelay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.GreetEmoteType).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Greeting)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<QuestGreetingLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Type, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("quest_greeting_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Greeting)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestMailSender>(entity =>
            {
                entity.HasKey(e => e.QuestId)
                    .HasName("PRIMARY");

                entity.ToTable("quest_mail_sender");

                entity.Property(e => e.QuestId)
                    .HasColumnType("int(5) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardMailSenderEntry).HasColumnType("int(5) unsigned");
            });

            modelBuilder.Entity<QuestObjectives>(entity =>
            {
                entity.ToTable("quest_objectives");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Amount).HasColumnType("int(10)");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Flags2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("ObjectID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Order).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.QuestId)
                    .HasColumnName("QuestID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StorageIndex).HasColumnType("tinyint(3)");

                entity.Property(e => e.Type).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<QuestObjectivesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_objectives_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StorageIndex).HasColumnType("tinyint(3)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuestOfferReward>(entity =>
            {
                entity.ToTable("quest_offer_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Emote1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteDelay1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<QuestOfferRewardLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_offer_reward_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RewardText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestPoi>(entity =>
            {
                entity.HasKey(e => new { e.QuestId, e.BlobIndex, e.Idx1 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("quest_poi");

                entity.HasIndex(e => new { e.QuestId, e.BlobIndex })
                    .HasName("idx")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.QuestId)
                    .HasColumnName("QuestID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlobIndex).HasColumnType("int(11)");

                entity.Property(e => e.Idx1).HasColumnType("int(11)");

                entity.Property(e => e.AlwaysAllowMergingBlobs).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Floor).HasColumnType("int(11)");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ObjectiveIndex).HasColumnType("int(11)");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priority).HasColumnType("int(11)");

                entity.Property(e => e.QuestObjectId)
                    .HasColumnName("QuestObjectID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuestObjectiveId)
                    .HasColumnName("QuestObjectiveID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WoDunk1)
                    .HasColumnName("WoDUnk1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorldEffectId)
                    .HasColumnName("WorldEffectID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorldMapAreaId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<QuestPoiPoints>(entity =>
            {
                entity.HasKey(e => new { e.QuestId, e.Idx1, e.Idx2 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("quest_poi_points");

                entity.HasIndex(e => e.QuestId)
                    .HasName("questId_id");

                entity.Property(e => e.QuestId)
                    .HasColumnName("QuestID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idx1).HasColumnType("int(11)");

                entity.Property(e => e.Idx2).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.X).HasColumnType("int(11)");

                entity.Property(e => e.Y).HasColumnType("int(11)");
            });

            modelBuilder.Entity<QuestRequestItems>(entity =>
            {
                entity.ToTable("quest_request_items");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CompletionText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmoteOnComplete).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteOnCompleteDelay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteOnIncomplete).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteOnIncompleteDelay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<QuestRequestItemsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_request_items_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompletionText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestTemplate>(entity =>
            {
                entity.ToTable("quest_template");

                entity.HasComment("Quest System");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedSoundKitId)
                    .HasColumnName("AcceptedSoundKitID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AllowableRaces)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AreaDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AreaGroupId)
                    .HasColumnName("AreaGroupID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CompleteSoundKitId)
                    .HasColumnName("CompleteSoundKitID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Expansion).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FlagsEx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDrop1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDrop2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDrop3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDrop4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDropQuantity1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDropQuantity2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDropQuantity3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDropQuantity4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.LogDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogTitle)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxScalingLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.MinLevel).HasColumnType("int(11)");

                entity.Property(e => e.Poicontinent)
                    .HasColumnName("POIContinent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Poipriority)
                    .HasColumnName("POIPriority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Poix).HasColumnName("POIx");

                entity.Property(e => e.Poiy).HasColumnName("POIy");

                entity.Property(e => e.PortraitGiver).HasColumnType("int(10) unsigned");

                entity.Property(e => e.PortraitGiverName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitGiverText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitTurnIn).HasColumnType("int(10) unsigned");

                entity.Property(e => e.PortraitTurnInName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitTurnInText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestCompletionLog)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestInfoId)
                    .HasColumnName("QuestInfoID")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.QuestLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.QuestPackageId)
                    .HasColumnName("QuestPackageID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.QuestRewardId)
                    .HasColumnName("QuestRewardID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.QuestSortId)
                    .HasColumnName("QuestSortID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.QuestType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.RewardAmount1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardAmount2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardAmount3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardAmount4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardArenaPoints).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardArtifactCategoryId)
                    .HasColumnName("RewardArtifactCategoryID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardArtifactXpdifficulty)
                    .HasColumnName("RewardArtifactXPDifficulty")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardArtifactXpmultiplier)
                    .HasColumnName("RewardArtifactXPMultiplier")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RewardBonusMoney).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemDisplayId1)
                    .HasColumnName("RewardChoiceItemDisplayID1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemDisplayId2)
                    .HasColumnName("RewardChoiceItemDisplayID2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemDisplayId3)
                    .HasColumnName("RewardChoiceItemDisplayID3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemDisplayId4)
                    .HasColumnName("RewardChoiceItemDisplayID4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemDisplayId5)
                    .HasColumnName("RewardChoiceItemDisplayID5")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemDisplayId6)
                    .HasColumnName("RewardChoiceItemDisplayID6")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId1)
                    .HasColumnName("RewardChoiceItemID1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId2)
                    .HasColumnName("RewardChoiceItemID2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId3)
                    .HasColumnName("RewardChoiceItemID3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId4)
                    .HasColumnName("RewardChoiceItemID4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId5)
                    .HasColumnName("RewardChoiceItemID5")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId6)
                    .HasColumnName("RewardChoiceItemID6")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity5).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity6).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyId1)
                    .HasColumnName("RewardCurrencyID1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyId2)
                    .HasColumnName("RewardCurrencyID2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyId3)
                    .HasColumnName("RewardCurrencyID3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyId4)
                    .HasColumnName("RewardCurrencyID4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyQty1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyQty2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyQty3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardCurrencyQty4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardDisplaySpell1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardDisplaySpell2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardDisplaySpell3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionCapIn1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionCapIn2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionCapIn3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionCapIn4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionCapIn5).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionId1)
                    .HasColumnName("RewardFactionID1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionId2)
                    .HasColumnName("RewardFactionID2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionId3)
                    .HasColumnName("RewardFactionID3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionId4)
                    .HasColumnName("RewardFactionID4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionId5)
                    .HasColumnName("RewardFactionID5")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardFactionOverride1).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionOverride2).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionOverride3).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionOverride4).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionOverride5).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionValue1).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionValue2).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionValue3).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionValue4).HasColumnType("int(11)");

                entity.Property(e => e.RewardFactionValue5).HasColumnType("int(11)");

                entity.Property(e => e.RewardHonor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardItem1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardItem2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardItem3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardItem4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardKillHonor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardMoney).HasColumnType("int(11)");

                entity.Property(e => e.RewardMoneyDifficulty).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardMoneyMultiplier).HasDefaultValueSql("'1'");

                entity.Property(e => e.RewardNextQuest).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardNumSkillUps).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardSkillLineId)
                    .HasColumnName("RewardSkillLineID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardTitle).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardXpdifficulty)
                    .HasColumnName("RewardXPDifficulty")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardXpmultiplier)
                    .HasColumnName("RewardXPMultiplier")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StartItem).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SuggestedGroupNum).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TimeAllowed).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuestTemplateAddon>(entity =>
            {
                entity.ToTable("quest_template_addon");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllowableClasses).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExclusiveGroup)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NextQuestId)
                    .HasColumnName("NextQuestID")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrevQuestId)
                    .HasColumnName("PrevQuestID")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProvidedItemCount).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RequiredMaxRepFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredMaxRepValue)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredMinRepFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredMinRepValue)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredSkillId)
                    .HasColumnName("RequiredSkillID")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkillPoints).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardMailDelay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardMailTemplateId)
                    .HasColumnName("RewardMailTemplateID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SourceSpellId)
                    .HasColumnName("SourceSpellID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecialFlags).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<QuestTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_template_locale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AreaDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LogTitle)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitGiverName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitGiverText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitTurnInName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PortraitTurnInText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestCompletionLog)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuestVisualEffect>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Index })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_visual_effect");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Index).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(5)");

                entity.Property(e => e.VisualEffect)
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<RaceUnlockRequirement>(entity =>
            {
                entity.HasKey(e => e.RaceId)
                    .HasName("PRIMARY");

                entity.ToTable("race_unlock_requirement");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.AchievementId)
                    .HasColumnName("achievementId")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Expansion)
                    .HasColumnName("expansion")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<ReferenceLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reference_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ReputationRewardRate>(entity =>
            {
                entity.HasKey(e => e.Faction)
                    .HasName("PRIMARY");

                entity.ToTable("reputation_reward_rate");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatureRate)
                    .HasColumnName("creature_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestDailyRate)
                    .HasColumnName("quest_daily_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestMonthlyRate)
                    .HasColumnName("quest_monthly_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRate)
                    .HasColumnName("quest_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRepeatableRate)
                    .HasColumnName("quest_repeatable_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestWeeklyRate)
                    .HasColumnName("quest_weekly_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SpellRate)
                    .HasColumnName("spell_rate")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
            {
                entity.HasKey(e => e.Faction)
                    .HasName("PRIMARY");

                entity.ToTable("reputation_spillover_template");

                entity.HasComment("Reputation spillover reputation gain");

                entity.Property(e => e.Faction)
                    .HasColumnName("faction")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction entry")
                    .ValueGeneratedNever();

                entity.Property(e => e.Faction1)
                    .HasColumnName("faction1")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction to give spillover for");

                entity.Property(e => e.Faction2)
                    .HasColumnName("faction2")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Faction3)
                    .HasColumnName("faction3")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Faction4)
                    .HasColumnName("faction4")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Faction5)
                    .HasColumnName("faction5")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Rank1)
                    .HasColumnName("rank_1")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("max rank,above this will not give any spillover");

                entity.Property(e => e.Rank2)
                    .HasColumnName("rank_2")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rank3)
                    .HasColumnName("rank_3")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rank4)
                    .HasColumnName("rank_4")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rank5)
                    .HasColumnName("rank_5")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rate1)
                    .HasColumnName("rate_1")
                    .HasComment("the given rep points * rate");

                entity.Property(e => e.Rate2).HasColumnName("rate_2");

                entity.Property(e => e.Rate3).HasColumnName("rate_3");

                entity.Property(e => e.Rate4).HasColumnName("rate_4");

                entity.Property(e => e.Rate5).HasColumnName("rate_5");
            });

            modelBuilder.Entity<ScenarioPoi>(entity =>
            {
                entity.HasKey(e => new { e.CriteriaTreeId, e.BlobIndex, e.Idx1 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("scenario_poi");

                entity.HasIndex(e => new { e.CriteriaTreeId, e.BlobIndex })
                    .HasName("idx")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.CriteriaTreeId)
                    .HasColumnName("CriteriaTreeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlobIndex).HasColumnType("int(11)");

                entity.Property(e => e.Idx1).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Floor).HasColumnType("int(11)");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlayerConditionId)
                    .HasColumnName("PlayerConditionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priority).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WorldEffectId)
                    .HasColumnName("WorldEffectID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorldMapAreaId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ScenarioPoiPoints>(entity =>
            {
                entity.HasKey(e => new { e.CriteriaTreeId, e.Idx1, e.Idx2 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("scenario_poi_points");

                entity.HasIndex(e => e.CriteriaTreeId)
                    .HasName("questId_id");

                entity.Property(e => e.CriteriaTreeId)
                    .HasColumnName("CriteriaTreeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idx1).HasColumnType("int(11)");

                entity.Property(e => e.Idx2).HasColumnType("int(11)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.X).HasColumnType("int(11)");

                entity.Property(e => e.Y).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Scenarios>(entity =>
            {
                entity.HasKey(e => new { e.Map, e.Difficulty })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("scenarios");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Difficulty)
                    .HasColumnName("difficulty")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScenarioA)
                    .HasColumnName("scenario_A")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScenarioH)
                    .HasColumnName("scenario_H")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SceneTemplate>(entity =>
            {
                entity.HasKey(e => e.SceneId)
                    .HasName("PRIMARY");

                entity.ToTable("scene_template");

                entity.Property(e => e.SceneId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScriptPackageId)
                    .HasColumnName("ScriptPackageID")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<ScriptSplineChainMeta>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.ChainId, e.SplineId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("script_spline_chain_meta");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ChainId)
                    .HasColumnName("chainId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SplineId)
                    .HasColumnName("splineId")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ExpectedDuration)
                    .HasColumnName("expectedDuration")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MsUntilNext)
                    .HasColumnName("msUntilNext")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<ScriptSplineChainWaypoints>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.ChainId, e.SplineId, e.WpId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("script_spline_chain_waypoints");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ChainId)
                    .HasColumnName("chainId")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SplineId)
                    .HasColumnName("splineId")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.WpId)
                    .HasColumnName("wpId")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<ScriptWaypoint>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Pointid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("script_waypoint");

                entity.HasComment("Script Creature waypoints");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("creature_template entry");

                entity.Property(e => e.Pointid)
                    .HasColumnName("pointid")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LocationX).HasColumnName("location_x");

                entity.Property(e => e.LocationY).HasColumnName("location_y");

                entity.Property(e => e.LocationZ).HasColumnName("location_z");

                entity.Property(e => e.PointComment)
                    .HasColumnName("point_comment")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Waittime)
                    .HasColumnName("waittime")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("waittime in millisecs");
            });

            modelBuilder.Entity<SkillDiscoveryTemplate>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("skill_discovery_template");

                entity.HasComment("Skill Discovery System");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spellId")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the discoverable spell");

                entity.Property(e => e.ReqSpell)
                    .HasColumnName("reqSpell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("spell requirement");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasComment("chance to discover");

                entity.Property(e => e.ReqSkillValue)
                    .HasColumnName("reqSkillValue")
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("skill points requirement");
            });

            modelBuilder.Entity<SkillExtraItemTemplate>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("skill_extra_item_template");

                entity.HasComment("Skill Specialization System");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spellId")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the item creation spell");

                entity.Property(e => e.AdditionalCreateChance)
                    .HasColumnName("additionalCreateChance")
                    .HasComment("chance to create add");

                entity.Property(e => e.AdditionalMaxNum)
                    .HasColumnName("additionalMaxNum")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("max num of adds");

                entity.Property(e => e.RequiredSpecialization)
                    .HasColumnName("requiredSpecialization")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Specialization spell id");
            });

            modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("skill_fishing_base_level");

                entity.HasComment("Fishing system");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Area identifier");

                entity.Property(e => e.Skill)
                    .HasColumnName("skill")
                    .HasColumnType("smallint(6)")
                    .HasComment("Base skill level requirement");
            });

            modelBuilder.Entity<SkillPerfectItemTemplate>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("skill_perfect_item_template");

                entity.HasComment("Crafting Perfection System");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spellId")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the item creation spell");

                entity.Property(e => e.PerfectCreateChance)
                    .HasColumnName("perfectCreateChance")
                    .HasComment("chance to create the perfect item instead");

                entity.Property(e => e.PerfectItemType)
                    .HasColumnName("perfectItemType")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("perfect item type to create instead");

                entity.Property(e => e.RequiredSpecialization)
                    .HasColumnName("requiredSpecialization")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Specialization spell id");
            });

            modelBuilder.Entity<SkillTiers>(entity =>
            {
                entity.ToTable("skill_tiers");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value10).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value11).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value12).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value13).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value14).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value15).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value16).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value5).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value6).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value7).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value8).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Value9).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SkinningLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("skinning_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SmartScripts>(entity =>
            {
                entity.HasKey(e => new { e.Entryorguid, e.SourceType, e.Id, e.Link })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("smart_scripts");

                entity.Property(e => e.Entryorguid)
                    .HasColumnName("entryorguid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ActionParam1)
                    .HasColumnName("action_param1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionParam2)
                    .HasColumnName("action_param2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionParam3)
                    .HasColumnName("action_param3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionParam4)
                    .HasColumnName("action_param4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionParam5)
                    .HasColumnName("action_param5")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionParam6)
                    .HasColumnName("action_param6")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasComment("Event Comment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventChance)
                    .HasColumnName("event_chance")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.EventFlags)
                    .HasColumnName("event_flags")
                    .HasColumnType("smallint(3) unsigned");

                entity.Property(e => e.EventParam1)
                    .HasColumnName("event_param1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EventParam2)
                    .HasColumnName("event_param2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EventParam3)
                    .HasColumnName("event_param3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EventParam4)
                    .HasColumnName("event_param4")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EventParamString)
                    .IsRequired()
                    .HasColumnName("event_param_string")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventPhaseMask)
                    .HasColumnName("event_phase_mask")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.EventType)
                    .HasColumnName("event_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TargetO).HasColumnName("target_o");

                entity.Property(e => e.TargetParam1)
                    .HasColumnName("target_param1")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetParam2)
                    .HasColumnName("target_param2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetParam3)
                    .HasColumnName("target_param3")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetType)
                    .HasColumnName("target_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TargetX).HasColumnName("target_x");

                entity.Property(e => e.TargetY).HasColumnName("target_y");

                entity.Property(e => e.TargetZ).HasColumnName("target_z");
            });

            modelBuilder.Entity<SpellArea>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.Area, e.QuestStart, e.AuraSpell, e.Racemask, e.Gender })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

                entity.ToTable("spell_area");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestStart)
                    .HasColumnName("quest_start")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AuraSpell)
                    .HasColumnName("aura_spell")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Racemask)
                    .HasColumnName("racemask")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.QuestEnd)
                    .HasColumnName("quest_end")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestEndStatus)
                    .HasColumnName("quest_end_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'11'");

                entity.Property(e => e.QuestStartStatus)
                    .HasColumnName("quest_start_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'64'");
            });

            modelBuilder.Entity<SpellAreatrigger>(entity =>
            {
                entity.HasKey(e => e.SpellMiscId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_areatrigger");

                entity.Property(e => e.SpellMiscId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaTriggerId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DecalPropertiesId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FacingCurveId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MorphCurveId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MoveCurveId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScaleCurveId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TimeToTarget).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TimeToTargetScale).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SpellAreatriggerCircular>(entity =>
            {
                entity.HasKey(e => e.SpellMiscId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_areatrigger_circular");

                entity.Property(e => e.SpellMiscId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CanLoop).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CounterClockwise).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.StartDelay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Zoffset).HasColumnName("ZOffset");
            });

            modelBuilder.Entity<SpellAreatriggerSplines>(entity =>
            {
                entity.HasKey(e => new { e.SpellMiscId, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_areatrigger_splines");

                entity.Property(e => e.SpellMiscId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SpellCustomAttr>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_custom_attr");

                entity.HasComment("SpellInfo custom attributes");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("spell id");

                entity.Property(e => e.Attributes)
                    .HasColumnName("attributes")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellCustomAttributes");
            });

            modelBuilder.Entity<SpellDbc>(entity =>
            {
                entity.ToTable("spell_dbc");

                entity.HasComment("Custom spell.dbc entries");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Attributes).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx10).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx5).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx6).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx7).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx8).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx9).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CastingTimeIndex)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DurationIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RangeIndex)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SchoolMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellAuraOptionsId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellCastingRequirementsId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellCategoriesId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellClassOptionsId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellEquippedItemsId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellInterruptsId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellLevelsId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellTargetRestrictionsId).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SpellEnchantProcData>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_enchant_proc_data");

                entity.HasComment("Spell enchant proc data");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomChance)
                    .HasColumnName("customChance")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ppmchance)
                    .HasColumnName("PPMChance")
                    .HasColumnType("float unsigned");

                entity.Property(e => e.ProcEx)
                    .HasColumnName("procEx")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SpellGroup>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_group");

                entity.HasComment("Spell System");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spell_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpellGroupStackRules>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_group_stack_rules");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.StackRule)
                    .HasColumnName("stack_rule")
                    .HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<SpellLearnSpell>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_learn_spell");

                entity.HasComment("Item System");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<SpellLinkedSpell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_linked_spell");

                entity.HasComment("Spell System");

                entity.HasIndex(e => new { e.SpellTrigger, e.SpellEffect, e.Type })
                    .HasName("trigger_effect_type")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpellEffect)
                    .HasColumnName("spell_effect")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellTrigger)
                    .HasColumnName("spell_trigger")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<SpellLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_loot_template");

                entity.HasComment("Loot System");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellPetAuras>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.EffectId, e.Pet })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("spell_pet_auras");

                entity.Property(e => e.Spell)
                    .HasColumnName("spell")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasComment("dummy spell id");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectId")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Pet)
                    .HasColumnName("pet")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("pet id; 0 = all");

                entity.Property(e => e.Aura)
                    .HasColumnName("aura")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasComment("pet aura id");
            });

            modelBuilder.Entity<SpellProc>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_proc");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributesMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Charges).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Cooldown).HasColumnType("int(10) unsigned");

                entity.Property(e => e.HitMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ProcFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SchoolMask).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SpellFamilyMask0).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyMask1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyMask2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyMask3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyName).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SpellPhaseMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellTypeMask).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SpellRequired>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_required");

                entity.HasComment("Spell Additinal Data");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spell_id")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSpell)
                    .HasColumnName("req_spell")
                    .HasColumnType("mediumint(8)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellScriptNames>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_script_names");

                entity.HasIndex(e => new { e.SpellId, e.ScriptName })
                    .HasName("spell_id")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnName("spell_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpellScripts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_scripts");

                entity.Property(e => e.Command)
                    .HasColumnName("command")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dataint)
                    .HasColumnName("dataint")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datalong)
                    .HasColumnName("datalong")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Datalong2)
                    .HasColumnName("datalong2")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffIndex)
                    .HasColumnName("effIndex")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<SpellTargetPosition>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.EffectIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_target_position");

                entity.HasComment("Spell System");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EffectIndex).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MapId)
                    .HasColumnName("MapID")
                    .HasColumnType("smallint(3) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellThreat>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_threat");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApPctMod)
                    .HasColumnName("apPctMod")
                    .HasComment("additional threat bonus from attack power");

                entity.Property(e => e.FlatMod)
                    .HasColumnName("flatMod")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PctMod)
                    .HasColumnName("pctMod")
                    .HasDefaultValueSql("'1'")
                    .HasComment("threat multiplier for damage/healing");
            });

            modelBuilder.Entity<SpellTotemModel>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.RaceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_totem_model");

                entity.Property(e => e.SpellId)
                    .HasColumnName("SpellID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RaceId)
                    .HasColumnName("RaceID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DisplayId)
                    .HasColumnName("DisplayID")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<SpelleffectDbc>(entity =>
            {
                entity.ToTable("spelleffect_dbc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Effect).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectAmplitude).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectApplyAuraName).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectBasePoints).HasColumnType("int(10)");

                entity.Property(e => e.EffectBonusMultiplier).HasColumnType("float unsigned");

                entity.Property(e => e.EffectChainTarget).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectDamageMultiplier).HasColumnType("float unsigned");

                entity.Property(e => e.EffectDieSides).HasColumnType("int(10)");

                entity.Property(e => e.EffectImplicitTargetA).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectImplicitTargetB).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectItemType).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectMechanic).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectMiscValue).HasColumnType("int(10)");

                entity.Property(e => e.EffectMiscValueB).HasColumnType("int(10)");

                entity.Property(e => e.EffectRadiusIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectRadiusIndexMax).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectRealPointsPerLevel).HasColumnType("float unsigned");

                entity.Property(e => e.EffectSpellClassMaskA).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectSpellClassMaskB).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectSpellClassMaskC).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectSpellId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectTriggerSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EffectValueMultiplier).HasColumnType("float unsigned");
            });

            modelBuilder.Entity<TerrainSwapDefaults>(entity =>
            {
                entity.HasKey(e => new { e.MapId, e.TerrainSwapMap })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("terrain_swap_defaults");

                entity.Property(e => e.MapId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TerrainSwapMap).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TerrainWorldmap>(entity =>
            {
                entity.HasKey(e => new { e.TerrainSwapMap, e.WorldMapArea })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("terrain_worldmap");

                entity.Property(e => e.TerrainSwapMap).HasColumnType("int(10) unsigned");

                entity.Property(e => e.WorldMapArea).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("trainer");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Greeting)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TrainerLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("trainer_locale");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GreetingLang)
                    .HasColumnName("Greeting_lang")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TrainerSpell>(entity =>
            {
                entity.HasKey(e => new { e.TrainerId, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("trainer_spell");

                entity.Property(e => e.TrainerId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MoneyCost).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ReqAbility1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ReqAbility2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ReqAbility3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ReqLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ReqSkillLine).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ReqSkillRank).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(5)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Transports>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("transports");

                entity.HasComment("Transports");

                entity.HasIndex(e => e.Entry)
                    .HasName("idx_entry")
                    .IsUnique();

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhaseUseFlags)
                    .HasColumnName("phaseUseFlags")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Phasegroup)
                    .HasColumnName("phasegroup")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Phaseid)
                    .HasColumnName("phaseid")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TrinityString>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("trinity_string");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ContentDefault)
                    .IsRequired()
                    .HasColumnName("content_default")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnName("content_loc1")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnName("content_loc2")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnName("content_loc3")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnName("content_loc4")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnName("content_loc5")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnName("content_loc6")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnName("content_loc7")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnName("content_loc8")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Updates>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("updates");

                entity.HasComment("List of all applied updates in this database.");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasComment("filename with extension of the update.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasColumnType("char(40)")
                    .HasDefaultValueSql("''")
                    .HasComment("sha1 hash of the sql file.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("time the query takes to apply in ms.");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("enum('RELEASED','ARCHIVED')")
                    .HasDefaultValueSql("'RELEASED'")
                    .HasComment("defines if an update is released or archived.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("timestamp when the query was applied.");
            });

            modelBuilder.Entity<UpdatesInclude>(entity =>
            {
                entity.HasKey(e => e.Path)
                    .HasName("PRIMARY");

                entity.ToTable("updates_include");

                entity.HasComment("List of directories where we want to include sql updates.");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("varchar(200)")
                    .HasComment("directory to include. $ means relative to the source directory.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("enum('RELEASED','ARCHIVED')")
                    .HasDefaultValueSql("'RELEASED'")
                    .HasComment("defines if the directory contains released or archived updates.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<VehicleAccessory>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.SeatId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("vehicle_accessory");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SeatId)
                    .HasColumnName("seat_id")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AccessoryEntry)
                    .HasColumnName("accessory_entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minion)
                    .HasColumnName("minion")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Summontimer)
                    .HasColumnName("summontimer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'30000'")
                    .HasComment("timer, only relevant for certain summontypes");

                entity.Property(e => e.Summontype)
                    .HasColumnName("summontype")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'6'")
                    .HasComment("see enum TempSummonType");
            });

            modelBuilder.Entity<VehicleTemplateAccessory>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SeatId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("vehicle_template_accessory");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SeatId)
                    .HasColumnName("seat_id")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AccessoryEntry)
                    .HasColumnName("accessory_entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minion)
                    .HasColumnName("minion")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Summontimer)
                    .HasColumnName("summontimer")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'30000'")
                    .HasComment("timer, only relevant for certain summontypes");

                entity.Property(e => e.Summontype)
                    .HasColumnName("summontype")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'6'")
                    .HasComment("see enum TempSummonType");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasKey(e => e.CoreVersion)
                    .HasName("PRIMARY");

                entity.ToTable("version");

                entity.HasComment("Version Notes");

                entity.Property(e => e.CoreVersion)
                    .HasColumnName("core_version")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasComment("Core revision dumped at startup.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CacheId)
                    .HasColumnName("cache_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoreRevision)
                    .HasColumnName("core_revision")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DbVersion)
                    .HasColumnName("db_version")
                    .HasColumnType("varchar(120)")
                    .HasComment("Version of world DB.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HotfixCacheId)
                    .HasColumnName("hotfix_cache_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WardenChecks>(entity =>
            {
                entity.ToTable("warden_checks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("varchar(48)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("varchar(24)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Str)
                    .HasColumnName("str")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<WaypointData>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Point })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("waypoint_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Creature GUID");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionChance)
                    .HasColumnName("action_chance")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MoveType)
                    .HasColumnName("move_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Wpguid)
                    .HasColumnName("wpguid")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WaypointScripts>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("waypoint_scripts");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command)
                    .HasColumnName("command")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Dataint)
                    .HasColumnName("dataint")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Datalong)
                    .HasColumnName("datalong")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Datalong2)
                    .HasColumnName("datalong2")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Delay)
                    .HasColumnName("delay")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<Waypoints>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Pointid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("waypoints");

                entity.HasComment("Creature waypoints");

                entity.Property(e => e.Entry)
                    .HasColumnName("entry")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pointid)
                    .HasColumnName("pointid")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PointComment)
                    .HasColumnName("point_comment")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
