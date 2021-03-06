﻿using System.Text.Json.Serialization;

namespace MaxMind.MinFraud.Util
{
    internal class WebServiceError
    {
        [JsonPropertyName("code")]
        public string? Code { get; init; }

        [JsonPropertyName("error")]
        public string? Error { get; init; }

        public override string ToString()
        {
            return $"Code: {Code}, Error: {Error}";
        }
    }
}