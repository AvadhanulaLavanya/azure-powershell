// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Security Settings of managed instance DTC.
    /// </summary>
    public partial class ManagedInstanceDtcSecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceDtcSecuritySettings class.
        /// </summary>
        public ManagedInstanceDtcSecuritySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceDtcSecuritySettings class.
        /// </summary>
        /// <param name="transactionManagerCommunicationSettings">Transaction
        /// Manager communication settings of managed instance DTC.</param>
        /// <param name="xaTransactionsEnabled">Allow XA Transactions to
        /// managed instance DTC.</param>
        /// <param name="snaLu6point2TransactionsEnabled">Allow SNA LU 6.2
        /// Transactions to managed instance DTC.</param>
        /// <param name="xaTransactionsDefaultTimeout">Default timeout for XA
        /// Transactions (in seconds).</param>
        /// <param name="xaTransactionsMaximumTimeout">Maximum timeout for XA
        /// Transactions (in seconds).</param>
        public ManagedInstanceDtcSecuritySettings(ManagedInstanceDtcTransactionManagerCommunicationSettings transactionManagerCommunicationSettings = default(ManagedInstanceDtcTransactionManagerCommunicationSettings), bool? xaTransactionsEnabled = default(bool?), bool? snaLu6point2TransactionsEnabled = default(bool?), int? xaTransactionsDefaultTimeout = default(int?), int? xaTransactionsMaximumTimeout = default(int?))
        {
            TransactionManagerCommunicationSettings = transactionManagerCommunicationSettings;
            XaTransactionsEnabled = xaTransactionsEnabled;
            SnaLu6point2TransactionsEnabled = snaLu6point2TransactionsEnabled;
            XaTransactionsDefaultTimeout = xaTransactionsDefaultTimeout;
            XaTransactionsMaximumTimeout = xaTransactionsMaximumTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets transaction Manager communication settings of managed
        /// instance DTC.
        /// </summary>
        [JsonProperty(PropertyName = "transactionManagerCommunicationSettings")]
        public ManagedInstanceDtcTransactionManagerCommunicationSettings TransactionManagerCommunicationSettings { get; set; }

        /// <summary>
        /// Gets or sets allow XA Transactions to managed instance DTC.
        /// </summary>
        [JsonProperty(PropertyName = "xaTransactionsEnabled")]
        public bool? XaTransactionsEnabled { get; set; }

        /// <summary>
        /// Gets or sets allow SNA LU 6.2 Transactions to managed instance DTC.
        /// </summary>
        [JsonProperty(PropertyName = "snaLu6point2TransactionsEnabled")]
        public bool? SnaLu6point2TransactionsEnabled { get; set; }

        /// <summary>
        /// Gets or sets default timeout for XA Transactions (in seconds).
        /// </summary>
        [JsonProperty(PropertyName = "xaTransactionsDefaultTimeout")]
        public int? XaTransactionsDefaultTimeout { get; set; }

        /// <summary>
        /// Gets or sets maximum timeout for XA Transactions (in seconds).
        /// </summary>
        [JsonProperty(PropertyName = "xaTransactionsMaximumTimeout")]
        public int? XaTransactionsMaximumTimeout { get; set; }

    }
}
