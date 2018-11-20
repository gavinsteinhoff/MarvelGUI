// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var comicViewModel = ComicViewModel.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ComicViewModel
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long? Code { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("copyright", NullValueHandling = NullValueHandling.Ignore)]
        public string Copyright { get; set; }

        [JsonProperty("attributionText", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributionText { get; set; }

        [JsonProperty("attributionHTML", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributionHtml { get; set; }

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Result[] Results { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("digitalId", NullValueHandling = NullValueHandling.Ignore)]
        public long? DigitalId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("issueNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? IssueNumber { get; set; }

        [JsonProperty("variantDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string VariantDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public string Modified { get; set; }

        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Ignore)]
        public string Isbn { get; set; }

        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; }

        [JsonProperty("diamondCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DiamondCode { get; set; }

        [JsonProperty("ean", NullValueHandling = NullValueHandling.Ignore)]
        public string Ean { get; set; }

        [JsonProperty("issn", NullValueHandling = NullValueHandling.Ignore)]
        public string Issn { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public Format? Format { get; set; }

        [JsonProperty("pageCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageCount { get; set; }

        [JsonProperty("textObjects", NullValueHandling = NullValueHandling.Ignore)]
        public TextObject[] TextObjects { get; set; }

        [JsonProperty("resourceURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ResourceUri { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public Url[] Urls { get; set; }

        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public Series Series { get; set; }

        [JsonProperty("variants", NullValueHandling = NullValueHandling.Ignore)]
        public CollectedIssue[] Variants { get; set; }

        [JsonProperty("collections", NullValueHandling = NullValueHandling.Ignore)]
        public CollectedIssue[] Collections { get; set; }

        [JsonProperty("collectedIssues", NullValueHandling = NullValueHandling.Ignore)]
        public CollectedIssue[] CollectedIssues { get; set; }

        [JsonProperty("dates", NullValueHandling = NullValueHandling.Ignore)]
        public Date[] Dates { get; set; }

        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public Price[] Prices { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail[] Images { get; set; }

        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Creators Creators { get; set; }

        [JsonProperty("characters", NullValueHandling = NullValueHandling.Ignore)]
        public Characters Characters { get; set; }

        [JsonProperty("stories", NullValueHandling = NullValueHandling.Ignore)]
        public Stories Stories { get; set; }

        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public Characters Events { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("comics", NullValueHandling = NullValueHandling.Ignore)]
        public Characters Comics { get; set; }
    }

    public partial class Characters
    {
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public long? Available { get; set; }

        [JsonProperty("collectionURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public CollectedIssue[] Items { get; set; }

        [JsonProperty("returned", NullValueHandling = NullValueHandling.Ignore)]
        public long? Returned { get; set; }
    }

    public partial class CollectedIssue
    {
        [JsonProperty("resourceURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class Creators
    {
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public long? Available { get; set; }

        [JsonProperty("collectionURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public CreatorsItem[] Items { get; set; }

        [JsonProperty("returned", NullValueHandling = NullValueHandling.Ignore)]
        public long? Returned { get; set; }
    }

    public partial class CreatorsItem
    {
        [JsonProperty("resourceURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Role? Role { get; set; }
    }

    public partial class Date
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public DateType? Type { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string DateDate { get; set; }
    }

    public partial class Thumbnail
    {
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Path { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public Extension? Extension { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public PriceType? Type { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public double? PricePrice { get; set; }
    }

    public partial class Series
    {
        [JsonProperty("resourceURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public long? Available { get; set; }

        [JsonProperty("collectionURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public CollectedIssue[] Items { get; set; }

        [JsonProperty("returned", NullValueHandling = NullValueHandling.Ignore)]
        public long? Returned { get; set; }
    }

    public partial class Stories
    {
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public long? Available { get; set; }

        [JsonProperty("collectionURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public StoriesItem[] Items { get; set; }

        [JsonProperty("returned", NullValueHandling = NullValueHandling.Ignore)]
        public long? Returned { get; set; }
    }

    public partial class StoriesItem
    {
        [JsonProperty("resourceURI", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public ItemType? Type { get; set; }
    }

    public partial class TextObject
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TextObjectType? Type { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public Language? Language { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public UrlType? Type { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlUrl { get; set; }
    }

    public enum Role { Artist, Colorist, ColoristCover, Editor, Inker, InkerCover, Letterer, Other, Painter, PainterCover, Penciler, PencilerCover, Penciller, PencillerCover, Writer };

    public enum DateType { FocDate, OnsaleDate, UnlimitedDate, DigitalPurchaseDate };

    public enum Format { Comic, DigitalComic, Hardcover, InfiniteComic, TradePaperback, Digest };

    public enum Extension { Jpg };

    public enum PriceType { PrintPrice, DigitalPurchasePrice };

    public enum ItemType { Cover, Empty, InteriorStory, Letters, Promo, Recap };

    public enum Language { EnUs };

    public enum TextObjectType { IssuePreviewText, IssueSolicitText };

    public enum UrlType { Comiclink, Detail, Purchase, Reader, Wiki, InAppLink };

    public partial class ComicViewModel
    {
        public static ComicViewModel FromJson(string json) => JsonConvert.DeserializeObject<ComicViewModel>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ComicViewModel self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                RoleConverter.Singleton,
                DateTypeConverter.Singleton,
                FormatConverter.Singleton,
                ExtensionConverter.Singleton,
                PriceTypeConverter.Singleton,
                ItemTypeConverter.Singleton,
                LanguageConverter.Singleton,
                TextObjectTypeConverter.Singleton,
                UrlTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class RoleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Role) || t == typeof(Role?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "artist":
                    return Role.Artist;
                case "colorist":
                    return Role.Colorist;
                case "colorist (cover)":
                    return Role.ColoristCover;
                case "editor":
                    return Role.Editor;
                case "inker":
                    return Role.Inker;
                case "inker (cover)":
                    return Role.InkerCover;
                case "letterer":
                    return Role.Letterer;
                case "other":
                    return Role.Other;
                case "painter":
                    return Role.Painter;
                case "painter (cover)":
                    return Role.PainterCover;
                case "penciler":
                    return Role.Penciler;
                case "penciler (cover)":
                    return Role.PencilerCover;
                case "penciller":
                    return Role.Penciller;
                case "penciller (cover)":
                    return Role.PencillerCover;
                case "writer":
                    return Role.Writer;
            }
            throw new Exception("Cannot unmarshal type Role");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Role)untypedValue;
            switch (value)
            {
                case Role.Artist:
                    serializer.Serialize(writer, "artist");
                    return;
                case Role.Colorist:
                    serializer.Serialize(writer, "colorist");
                    return;
                case Role.ColoristCover:
                    serializer.Serialize(writer, "colorist (cover)");
                    return;
                case Role.Editor:
                    serializer.Serialize(writer, "editor");
                    return;
                case Role.Inker:
                    serializer.Serialize(writer, "inker");
                    return;
                case Role.InkerCover:
                    serializer.Serialize(writer, "inker (cover)");
                    return;
                case Role.Letterer:
                    serializer.Serialize(writer, "letterer");
                    return;
                case Role.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case Role.Painter:
                    serializer.Serialize(writer, "painter");
                    return;
                case Role.PainterCover:
                    serializer.Serialize(writer, "painter (cover)");
                    return;
                case Role.Penciler:
                    serializer.Serialize(writer, "penciler");
                    return;
                case Role.PencilerCover:
                    serializer.Serialize(writer, "penciler (cover)");
                    return;
                case Role.Penciller:
                    serializer.Serialize(writer, "penciller");
                    return;
                case Role.PencillerCover:
                    serializer.Serialize(writer, "penciller (cover)");
                    return;
                case Role.Writer:
                    serializer.Serialize(writer, "writer");
                    return;
            }
            throw new Exception("Cannot marshal type Role");
        }

        public static readonly RoleConverter Singleton = new RoleConverter();
    }

    internal class DateTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DateType) || t == typeof(DateType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "focDate":
                    return DateType.FocDate;
                case "onsaleDate":
                    return DateType.OnsaleDate;
                case "unlimitedDate":
                    return DateType.UnlimitedDate;
                case "digitalPurchaseDate":
                    return DateType.DigitalPurchaseDate;

            }
            throw new Exception("Cannot unmarshal type DateType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DateType)untypedValue;
            switch (value)
            {
                case DateType.FocDate:
                    serializer.Serialize(writer, "focDate");
                    return;
                case DateType.OnsaleDate:
                    serializer.Serialize(writer, "onsaleDate");
                    return;
                case DateType.UnlimitedDate:
                    serializer.Serialize(writer, "unlimitedDate");
                    return;
            }
            throw new Exception("Cannot marshal type DateType");
        }

        public static readonly DateTypeConverter Singleton = new DateTypeConverter();
    }

    internal class FormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Format) || t == typeof(Format?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Comic":
                    return Format.Comic;
                case "Digital Comic":
                    return Format.DigitalComic;
                case "Hardcover":
                    return Format.Hardcover;
                case "Infinite Comic":
                    return Format.InfiniteComic;
                case "Trade Paperback":
                    return Format.TradePaperback;
                case "Digest":
                    return Format.Digest;
            }
            throw new Exception("Cannot unmarshal type Format");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Format)untypedValue;
            switch (value)
            {
                case Format.Comic:
                    serializer.Serialize(writer, "Comic");
                    return;
                case Format.DigitalComic:
                    serializer.Serialize(writer, "Digital Comic");
                    return;
                case Format.Hardcover:
                    serializer.Serialize(writer, "Hardcover");
                    return;
                case Format.InfiniteComic:
                    serializer.Serialize(writer, "Infinite Comic");
                    return;
                case Format.TradePaperback:
                    serializer.Serialize(writer, "Trade Paperback");
                    return;
            }
            throw new Exception("Cannot marshal type Format");
        }

        public static readonly FormatConverter Singleton = new FormatConverter();
    }

    internal class ExtensionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Extension) || t == typeof(Extension?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "jpg")
            {
                return Extension.Jpg;
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
            if (value == Extension.Jpg)
            {
                serializer.Serialize(writer, "jpg");
                return;
            }
            throw new Exception("Cannot marshal type Extension");
        }

        public static readonly ExtensionConverter Singleton = new ExtensionConverter();
    }

    internal class PriceTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PriceType) || t == typeof(PriceType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "printPrice")
            {
                return PriceType.PrintPrice;
            }
            else if (value == "digitalPurchasePrice")
            {
                return PriceType.DigitalPurchasePrice;
            }
            throw new Exception("Cannot unmarshal type PriceType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PriceType)untypedValue;
            if (value == PriceType.PrintPrice)
            {
                serializer.Serialize(writer, "printPrice");
                return;
            }
            throw new Exception("Cannot marshal type PriceType");
        }

        public static readonly PriceTypeConverter Singleton = new PriceTypeConverter();
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
                case "cover":
                    return ItemType.Cover;
                case "interiorStory":
                    return ItemType.InteriorStory;
                case "letters":
                    return ItemType.Letters;
                case "promo":
                    return ItemType.Promo;
                case "recap":
                    return ItemType.Recap;
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
                case ItemType.Cover:
                    serializer.Serialize(writer, "cover");
                    return;
                case ItemType.InteriorStory:
                    serializer.Serialize(writer, "interiorStory");
                    return;
                case ItemType.Letters:
                    serializer.Serialize(writer, "letters");
                    return;
                case ItemType.Promo:
                    serializer.Serialize(writer, "promo");
                    return;
                case ItemType.Recap:
                    serializer.Serialize(writer, "recap");
                    return;
            }
            throw new Exception("Cannot marshal type ItemType");
        }

        public static readonly ItemTypeConverter Singleton = new ItemTypeConverter();
    }

    internal class LanguageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Language) || t == typeof(Language?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "en-us")
            {
                return Language.EnUs;
            }
            throw new Exception("Cannot unmarshal type Language");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Language)untypedValue;
            if (value == Language.EnUs)
            {
                serializer.Serialize(writer, "en-us");
                return;
            }
            throw new Exception("Cannot marshal type Language");
        }

        public static readonly LanguageConverter Singleton = new LanguageConverter();
    }

    internal class TextObjectTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextObjectType) || t == typeof(TextObjectType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "issue_preview_text":
                    return TextObjectType.IssuePreviewText;
                case "issue_solicit_text":
                    return TextObjectType.IssueSolicitText;
            }
            throw new Exception("Cannot unmarshal type TextObjectType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TextObjectType)untypedValue;
            switch (value)
            {
                case TextObjectType.IssuePreviewText:
                    serializer.Serialize(writer, "issue_preview_text");
                    return;
                case TextObjectType.IssueSolicitText:
                    serializer.Serialize(writer, "issue_solicit_text");
                    return;
            }
            throw new Exception("Cannot marshal type TextObjectType");
        }

        public static readonly TextObjectTypeConverter Singleton = new TextObjectTypeConverter();
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
                case "purchase":
                    return UrlType.Purchase;
                case "reader":
                    return UrlType.Reader;
                case "wiki":
                    return UrlType.Wiki;
                case "inAppLink":
                    return UrlType.InAppLink;
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
                case UrlType.Purchase:
                    serializer.Serialize(writer, "purchase");
                    return;
                case UrlType.Reader:
                    serializer.Serialize(writer, "reader");
                    return;
                case UrlType.Wiki:
                    serializer.Serialize(writer, "wiki");
                    return;
                case UrlType.InAppLink:
                    serializer.Serialize(writer, "inAppLink");
                    return;
            }
            throw new Exception("Cannot marshal type UrlType");
        }

        public static readonly UrlTypeConverter Singleton = new UrlTypeConverter();
    }
}
