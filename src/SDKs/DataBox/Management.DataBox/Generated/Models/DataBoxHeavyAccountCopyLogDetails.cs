// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Copy log details for a storage account for Databox heavy
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxHeavy")]
    public partial class DataBoxHeavyAccountCopyLogDetails : CopyLogDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxHeavyAccountCopyLogDetails
        /// class.
        /// </summary>
        public DataBoxHeavyAccountCopyLogDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxHeavyAccountCopyLogDetails
        /// class.
        /// </summary>
        /// <param name="accountName">Destination account name.</param>
        /// <param name="copyLogLink">Link for copy logs.</param>
        public DataBoxHeavyAccountCopyLogDetails(string accountName = default(string), IList<string> copyLogLink = default(IList<string>))
        {
            AccountName = accountName;
            CopyLogLink = copyLogLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets destination account name.
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets link for copy logs.
        /// </summary>
        [JsonProperty(PropertyName = "copyLogLink")]
        public IList<string> CopyLogLink { get; private set; }

    }
}