﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Marvel.Models
{
    public partial class CharacterViewModel
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("attributionText")]
        public string AttributionText { get; set; }

        [JsonProperty("attributionHTML")]
        public string AttributionHtml { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }

    public partial class Result
    {
        public QuickType.ComicViewModel ComicsModel { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonProperty("comics")]
        public Comics Comics { get; set; }

        [JsonProperty("series")]
        public Comics Series { get; set; }

        [JsonProperty("stories")]
        public Stories Stories { get; set; }

        [JsonProperty("events")]
        public Comics Events { get; set; }

        [JsonProperty("urls")]
        public Url[] Urls { get; set; }
    }

    public partial class Comics
    {
        [JsonProperty("available")]
        public long Available { get; set; }

        [JsonProperty("collectionURI")]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items")]
        public ComicsItem[] Items { get; set; }

        [JsonProperty("returned")]
        public long Returned { get; set; }
    }

    public partial class ComicsItem
    {
        [JsonProperty("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Stories
    {
        [JsonProperty("available")]
        public long Available { get; set; }

        [JsonProperty("collectionURI")]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items")]
        public StoriesItem[] Items { get; set; }

        [JsonProperty("returned")]
        public long Returned { get; set; }
    }

    public partial class StoriesItem
    {
        [JsonProperty("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public ItemType Type { get; set; }
    }

    public partial class Thumbnail
    {
        [JsonProperty("path")]
        public Uri Path { get; set; }

        [JsonProperty("extension")]
        public Extension Extension { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("type")]
        public UrlType Type { get; set; }

        [JsonProperty("url")]
        public Uri UrlUrl { get; set; }
    }

    public enum ItemType { Ad, Backcovers, Cover, Empty, InteriorStory, Pinup, Profile, Recap, TextArticle };

    public enum Extension { Gif, Jpg, Png };

    public enum UrlType { Comiclink, Detail, Wiki };

    public partial class CharacterViewModel
    {
        public static CharacterViewModel FromJson(string json) => JsonConvert.DeserializeObject<CharacterViewModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CharacterViewModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                ItemTypeConverter.Singleton,
                ExtensionConverter.Singleton,
                UrlTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ItemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemType) || t == typeof(ItemType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return ItemType.Empty;
                case "ad":
                    return ItemType.Ad;
                case "backcovers":
                    return ItemType.Backcovers;
                case "cover":
                    return ItemType.Cover;
                case "interiorStory":
                    return ItemType.InteriorStory;
                case "pinup":
                    return ItemType.Pinup;
                case "profile":
                    return ItemType.Profile;
                case "recap":
                    return ItemType.Recap;
                case "text article":
                    return ItemType.TextArticle;
            }
            throw new Exception("Cannot unmarshal type ItemType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemType)untypedValue;
            switch (value)
            {
                case ItemType.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case ItemType.Ad:
                    serializer.Serialize(writer, "ad");
                    return;
                case ItemType.Backcovers:
                    serializer.Serialize(writer, "backcovers");
                    return;
                case ItemType.Cover:
                    serializer.Serialize(writer, "cover");
                    return;
                case ItemType.InteriorStory:
                    serializer.Serialize(writer, "interiorStory");
                    return;
                case ItemType.Pinup:
                    serializer.Serialize(writer, "pinup");
                    return;
                case ItemType.Profile:
                    serializer.Serialize(writer, "profile");
                    return;
                case ItemType.Recap:
                    serializer.Serialize(writer, "recap");
                    return;
                case ItemType.TextArticle:
                    serializer.Serialize(writer, "text article");
                    return;
            }
            throw new Exception("Cannot marshal type ItemType");
        }

        public static readonly ItemTypeConverter Singleton = new ItemTypeConverter();
    }

    internal class ExtensionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Extension) || t == typeof(Extension?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "gif":
                    return Extension.Gif;
                case "jpg":
                    return Extension.Jpg;
                case "png":
                    return Extension.Png;
            }
            throw new Exception("Cannot unmarshal type Extension");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Extension)untypedValue;
            switch (value)
            {
                case Extension.Gif:
                    serializer.Serialize(writer, "gif");
                    return;
                case Extension.Jpg:
                    serializer.Serialize(writer, "jpg");
                    return;
                case Extension.Png:
                    serializer.Serialize(writer, "png");
                    return;
            }
            throw new Exception("Cannot marshal type Extension");
        }

        public static readonly ExtensionConverter Singleton = new ExtensionConverter();
    }

    internal class UrlTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UrlType) || t == typeof(UrlType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "comiclink":
                    return UrlType.Comiclink;
                case "detail":
                    return UrlType.Detail;
                case "wiki":
                    return UrlType.Wiki;
            }
            throw new Exception("Cannot unmarshal type UrlType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UrlType)untypedValue;
            switch (value)
            {
                case UrlType.Comiclink:
                    serializer.Serialize(writer, "comiclink");
                    return;
                case UrlType.Detail:
                    serializer.Serialize(writer, "detail");
                    return;
                case UrlType.Wiki:
                    serializer.Serialize(writer, "wiki");
                    return;
            }
            throw new Exception("Cannot marshal type UrlType");
        }

        public static readonly UrlTypeConverter Singleton = new UrlTypeConverter();
    }
}
