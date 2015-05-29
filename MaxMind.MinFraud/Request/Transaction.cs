﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace MaxMind.MinFraud.Request
{

    /// <summary>
    /// The transaction to be sent to the web service.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Constructor. See <see href="https://dev.maxmind.com/minfraud-score-and-insights-api-documentation/#Request_Body">
        /// the minFraud documentation</see> for a general overview of the request sent to the web
        /// service.
        /// </summary>
        /// <param name="device">Information about the device used in the transaction.</param>
        /// <param name="account">Information about the account used in the transaction.</param>
        /// <param name="billing">Billing information used in the transaction.</param>
        /// <param name="creditCard">Information about the credit card used in the transaction.</param>
        /// <param name="email">Information about the email used in the transaction.</param>
        /// <param name="userEvent">Details about the event such as the time.</param>
        /// <param name="order">Details about the order.</param>
        /// <param name="payment">Information about the payment processing.</param>
        /// <param name="shipping">Shipping information used in the transaction.</param>
        /// <param name="shoppingCart">List of shopping items in the transaction.</param>
        public Transaction(
            Device device,
            Account account = null,
            Billing billing = null,
            CreditCard creditCard = null,
            Email email = null,
            Event userEvent = null,
            Order order = null,
            Payment payment = null,
            Shipping shipping = null,
            List<ShoppingCartItem> shoppingCart = default(List<ShoppingCartItem>)
            )
        {
            Device = device;
            Account = account;
            Billing = billing;
            CreditCard = creditCard;
            Email = email;
            Event = userEvent;
            Order = order;
            Payment = payment;
            Shipping = shipping;
            ShoppingCart = shoppingCart;
        }

        /// <summary>
        /// Account information for the transaction.
        /// </summary>
        [JsonProperty("account")]
        public Account Account { get; }

        /// <summary>
        /// Information about the account used in the transaction.
        /// </summary>
        [JsonProperty("billing")]
        public Billing Billing { get; }

        /// <summary>
        /// Information about the credit card used in the transaction.
        /// </summary>
        [JsonProperty("credit_card")]
        public CreditCard CreditCard { get; }

        /// <summary>
        /// Information about the device used in the transaction.
        /// </summary>
        [JsonProperty("device")]
        public Device Device { get; }

        /// <summary>
        /// Information about the email used in the transaction.
        /// </summary>
        [JsonProperty("email")]
        public Email Email { get; }

        /// <summary>
        /// Details about the event such as the time.
        /// </summary>
        [JsonProperty("event")]
        public Event Event { get; }

        /// <summary>
        /// Details about the order.
        /// </summary>
        [JsonProperty("order")]
        public Order Order { get; }

        /// <summary>
        /// Information about the payment processing.
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; }

        /// <summary>
        /// Shipping information used in the transaction.
        /// </summary>
        [JsonProperty("shipping")]
        public Shipping Shipping { get; }

        /// <summary>
        /// List of shopping items in the transaction.s
        /// </summary>
        [JsonProperty("shopping_cart")]
        public List<ShoppingCartItem> ShoppingCart { get; }

        public override string ToString()
        {
            return
                $"Account: {Account}, Billing: {Billing}, CreditCard: {CreditCard}, Device: {Device}, Email: {Email}, Event: {Event}, Order: {Order}, Payment: {Payment}, Shipping: {Shipping}, ShoppingCart: {ShoppingCart}";
        }
    }
}