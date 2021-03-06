// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Settings.
    /// </summary>
    public static partial class SettingsExtensions
    {
            /// <summary>
            /// Gets the application version settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AppVersionSettingObject>> ListAsync(this ISettings operations, System.Guid appId, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(appId, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the application version settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='listOfAppVersionSettingObject'>
            /// A list of the updated application version settings.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> UpdateAsync(this ISettings operations, System.Guid appId, string versionId, AppVersionSettingObject listOfAppVersionSettingObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(appId, versionId, listOfAppVersionSettingObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
