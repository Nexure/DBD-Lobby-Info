﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DBD_Magic.Responses;
//
//    var friendsResponse = FriendsResponse.FromJson(jsonString);

namespace DBD_Magic.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FriendsResponse
    {
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("friendId")]
        public Guid FriendId { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("platformIds")]
        public PlatformIds PlatformIds { get; set; }

        [JsonProperty("friendPlayerName")]
        public FriendPlayerName FriendPlayerName { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("mute")]
        public bool Mute { get; set; }
    }

    public partial class FriendPlayerName
    {
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("providerPlayerNames")]
        public PlatformIds ProviderPlayerNames { get; set; }
    }

    public partial class PlatformIds
    {
        [JsonProperty("steam", NullValueHandling = NullValueHandling.Ignore)]
        public string Steam { get; set; }
    }

    public enum Status { Confirmed, Invite, Pending };

    public partial class FriendsResponse
    {
        public static FriendsResponse[] FromJson(string json) => JsonConvert.DeserializeObject<FriendsResponse[]>(json, DBD_Magic.Responses.FriendsConverter.Settings);
    }

    public static class FriendsSerialize
    {
        public static string ToJson(this FriendsResponse[] self) => JsonConvert.SerializeObject(self, DBD_Magic.Responses.FriendsConverter.Settings);
    }

    internal static class FriendsConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "confirmed":
                    return Status.Confirmed;
                case "invite":
                    return Status.Invite;
                case "pending":
                    return Status.Pending;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Confirmed:
                    serializer.Serialize(writer, "confirmed");
                    return;
                case Status.Invite:
                    serializer.Serialize(writer, "invite");
                    return;
                case Status.Pending:
                    serializer.Serialize(writer, "pending");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
