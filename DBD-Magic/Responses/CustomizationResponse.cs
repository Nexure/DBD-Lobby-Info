﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DBD_Magic.Responses;
//
//    var customizationResponse = CustomizationResponse.FromJson(jsonString);

namespace DBD_Magic.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CustomizationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("rarity")]
        public Rarity Rarity { get; set; }

        [JsonProperty("associatedRole")]
        public AssociatedRole AssociatedRole { get; set; }

        [JsonProperty("collectionName")]
        public string CollectionName { get; set; }

        [JsonProperty("collectionDescription")]
        public string CollectionDescription { get; set; }

        [JsonProperty("platformExclusiveFlag")]
        public long PlatformExclusiveFlag { get; set; }

        [JsonProperty("associatedCharacter")]
        public long AssociatedCharacter { get; set; }

        [JsonProperty("prestigeUnlockLevel")]
        public long PrestigeUnlockLevel { get; set; }

        [JsonProperty("prestigeUnlockDate")]
        public string PrestigeUnlockDate { get; set; }

        [JsonProperty("itemIsInStore")]
        public bool ItemIsInStore { get; set; }

        [JsonProperty("isNonVioletBuild")]
        public bool IsNonVioletBuild { get; set; }

        [JsonProperty("isAvailableInAtlantaBuild")]
        public bool IsAvailableInAtlantaBuild { get; set; }
    }

    public enum AssociatedRole { EPlayerRoleVeCamper, EPlayerRoleVeNone, EPlayerRoleVeSlasher };

    public enum Category { ECustomizationCategoryCharm, ECustomizationCategoryKillerBody, ECustomizationCategoryKillerHead, ECustomizationCategoryKillerWeapon, ECustomizationCategorySurvivorHead, ECustomizationCategorySurvivorLegs, ECustomizationCategorySurvivorTorso };

    public enum Rarity { EItemRarityArtifact, EItemRarityCommon, EItemRarityRare, EItemRaritySpecialEvent, EItemRarityUltraRare, EItemRarityUncommon, EItemRarityVeryRare };

    public partial class CustomizationResponse
    {
        public static Dictionary<string, CustomizationResponse> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, CustomizationResponse>>(json, DBD_Magic.Responses.CustomizationConverter.Settings);
    }

    public static class CustomizationSerialize
    {
        public static string ToJson(this Dictionary<string, CustomizationResponse> self) => JsonConvert.SerializeObject(self, DBD_Magic.Responses.CustomizationConverter.Settings);
    }

    internal static class CustomizationConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AssociatedRoleConverter.Singleton,
                CategoryConverter.Singleton,
                RarityConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AssociatedRoleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AssociatedRole) || t == typeof(AssociatedRole?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "EPlayerRole::VE_Camper":
                    return AssociatedRole.EPlayerRoleVeCamper;
                case "EPlayerRole::VE_None":
                    return AssociatedRole.EPlayerRoleVeNone;
                case "EPlayerRole::VE_Slasher":
                    return AssociatedRole.EPlayerRoleVeSlasher;
            }
            throw new Exception("Cannot unmarshal type AssociatedRole");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AssociatedRole)untypedValue;
            switch (value)
            {
                case AssociatedRole.EPlayerRoleVeCamper:
                    serializer.Serialize(writer, "EPlayerRole::VE_Camper");
                    return;
                case AssociatedRole.EPlayerRoleVeNone:
                    serializer.Serialize(writer, "EPlayerRole::VE_None");
                    return;
                case AssociatedRole.EPlayerRoleVeSlasher:
                    serializer.Serialize(writer, "EPlayerRole::VE_Slasher");
                    return;
            }
            throw new Exception("Cannot marshal type AssociatedRole");
        }

        public static readonly AssociatedRoleConverter Singleton = new AssociatedRoleConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ECustomizationCategory::Charm":
                    return Category.ECustomizationCategoryCharm;
                case "ECustomizationCategory::KillerBody":
                    return Category.ECustomizationCategoryKillerBody;
                case "ECustomizationCategory::KillerHead":
                    return Category.ECustomizationCategoryKillerHead;
                case "ECustomizationCategory::KillerWeapon":
                    return Category.ECustomizationCategoryKillerWeapon;
                case "ECustomizationCategory::SurvivorHead":
                    return Category.ECustomizationCategorySurvivorHead;
                case "ECustomizationCategory::SurvivorLegs":
                    return Category.ECustomizationCategorySurvivorLegs;
                case "ECustomizationCategory::SurvivorTorso":
                    return Category.ECustomizationCategorySurvivorTorso;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.ECustomizationCategoryCharm:
                    serializer.Serialize(writer, "ECustomizationCategory::Charm");
                    return;
                case Category.ECustomizationCategoryKillerBody:
                    serializer.Serialize(writer, "ECustomizationCategory::KillerBody");
                    return;
                case Category.ECustomizationCategoryKillerHead:
                    serializer.Serialize(writer, "ECustomizationCategory::KillerHead");
                    return;
                case Category.ECustomizationCategoryKillerWeapon:
                    serializer.Serialize(writer, "ECustomizationCategory::KillerWeapon");
                    return;
                case Category.ECustomizationCategorySurvivorHead:
                    serializer.Serialize(writer, "ECustomizationCategory::SurvivorHead");
                    return;
                case Category.ECustomizationCategorySurvivorLegs:
                    serializer.Serialize(writer, "ECustomizationCategory::SurvivorLegs");
                    return;
                case Category.ECustomizationCategorySurvivorTorso:
                    serializer.Serialize(writer, "ECustomizationCategory::SurvivorTorso");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }

    internal class RarityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Rarity) || t == typeof(Rarity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "EItemRarity::Artifact":
                    return Rarity.EItemRarityArtifact;
                case "EItemRarity::Common":
                    return Rarity.EItemRarityCommon;
                case "EItemRarity::Rare":
                    return Rarity.EItemRarityRare;
                case "EItemRarity::SpecialEvent":
                    return Rarity.EItemRaritySpecialEvent;
                case "EItemRarity::UltraRare":
                    return Rarity.EItemRarityUltraRare;
                case "EItemRarity::Uncommon":
                    return Rarity.EItemRarityUncommon;
                case "EItemRarity::VeryRare":
                    return Rarity.EItemRarityVeryRare;
            }
            throw new Exception("Cannot unmarshal type Rarity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Rarity)untypedValue;
            switch (value)
            {
                case Rarity.EItemRarityArtifact:
                    serializer.Serialize(writer, "EItemRarity::Artifact");
                    return;
                case Rarity.EItemRarityCommon:
                    serializer.Serialize(writer, "EItemRarity::Common");
                    return;
                case Rarity.EItemRarityRare:
                    serializer.Serialize(writer, "EItemRarity::Rare");
                    return;
                case Rarity.EItemRaritySpecialEvent:
                    serializer.Serialize(writer, "EItemRarity::SpecialEvent");
                    return;
                case Rarity.EItemRarityUltraRare:
                    serializer.Serialize(writer, "EItemRarity::UltraRare");
                    return;
                case Rarity.EItemRarityUncommon:
                    serializer.Serialize(writer, "EItemRarity::Uncommon");
                    return;
                case Rarity.EItemRarityVeryRare:
                    serializer.Serialize(writer, "EItemRarity::VeryRare");
                    return;
            }
            throw new Exception("Cannot marshal type Rarity");
        }

        public static readonly RarityConverter Singleton = new RarityConverter();
    }
}
