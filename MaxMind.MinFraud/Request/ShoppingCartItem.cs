﻿using System.Text.Json.Serialization;

namespace MaxMind.MinFraud.Request
{
    /// <summary>
    /// Information for an item in the shopping cart for the transaction
    /// being sent to the web service.
    /// </summary>
    public sealed class ShoppingCartItem
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="category">The category of the item.</param>
        /// <param name="itemId">Your internal ID for the item.</param>
        /// <param name="quantity">The quantity of the item in the shopping cart.
        /// This must be positive</param>
        /// <param name="price">The price of the item in the shopping cart. This
        /// should be the same currency as the order currency.</param>
        public ShoppingCartItem(
            string? category = null,
            string? itemId = null,
            int? quantity = null,
            decimal? price = null
        )
        {
            Category = category;
            ItemId = itemId;
            Quantity = quantity;
            Price = price;
        }

        /// <summary>
        /// The category of the item.
        /// </summary>
        [JsonPropertyName("category")]
        public string? Category { get; init; }

        /// <summary>
        /// Your internal ID for the item.
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; init; }

        /// <summary>
        /// The quantity of the item in the shopping cart.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; init; }

        /// <summary>
        /// The per-unit price of the item in the shopping cart. This should
        /// use the same currency as the order currency.
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; init; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Category: {Category}, ItemId: {ItemId}, Quantity: {Quantity}, Price: {Price}";
        }
    }
}