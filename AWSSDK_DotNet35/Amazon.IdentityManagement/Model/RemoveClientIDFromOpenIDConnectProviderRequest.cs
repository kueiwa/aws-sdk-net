/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveClientIDFromOpenIDConnectProvider operation.
    /// Removes the specified client ID (also known as audience) from the list of client IDs
    /// registered for the specified IAM OpenID Connect provider.
    /// 
    ///  
    /// <para>
    /// This action is idempotent; it does not fail or return an error if you try to remove
    /// a client ID that was removed previously.
    /// </para>
    /// </summary>
    public partial class RemoveClientIDFromOpenIDConnectProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _clientID;
        private string _openIDConnectProviderArn;

        /// <summary>
        /// Gets and sets the property ClientID. 
        /// <para>
        /// The client ID (also known as audience) to remove from the IAM OpenID Connect provider.
        /// For more information about client IDs, see <a>CreateOpenIDConnectProvider</a>.
        /// </para>
        /// </summary>
        public string ClientID
        {
            get { return this._clientID; }
            set { this._clientID = value; }
        }

        // Check to see if ClientID property is set
        internal bool IsSetClientID()
        {
            return this._clientID != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM OpenID Connect (OIDC) provider to remove
        /// the client ID from. You can get a list of OIDC provider ARNs by using the <a>ListOpenIDConnectProviders</a>
        /// action.
        /// </para>
        /// </summary>
        public string OpenIDConnectProviderArn
        {
            get { return this._openIDConnectProviderArn; }
            set { this._openIDConnectProviderArn = value; }
        }

        // Check to see if OpenIDConnectProviderArn property is set
        internal bool IsSetOpenIDConnectProviderArn()
        {
            return this._openIDConnectProviderArn != null;
        }

    }
}