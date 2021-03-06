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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Provides information about a pending maintenance action for a resource.
    /// </summary>
    public partial class PendingMaintenanceAction
    {
        private string _action;
        private DateTime? _autoAppliedAfterDate;
        private DateTime? _currentApplyDate;
        private DateTime? _forcedApplyDate;
        private string _optInStatus;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of pending maintenance action that is available for the resource.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AutoAppliedAfterDate. 
        /// <para>
        /// The date of the maintenance window when the action will be applied. The maintenance
        /// action will be applied to the resource during its first maintenance window after this
        /// date. If this date is specified, any <code>next-maintenance</code> opt-in requests
        /// are ignored.
        /// </para>
        /// </summary>
        public DateTime AutoAppliedAfterDate
        {
            get { return this._autoAppliedAfterDate.GetValueOrDefault(); }
            set { this._autoAppliedAfterDate = value; }
        }

        // Check to see if AutoAppliedAfterDate property is set
        internal bool IsSetAutoAppliedAfterDate()
        {
            return this._autoAppliedAfterDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentApplyDate. 
        /// <para>
        /// The effective date when the pending maintenance action will be applied to the resource.
        /// This takes into account opt-in requests received from the <a>ApplyPendingMaintenanceAction</a>
        /// API, the <code>AutoAppliedAfterDate</code>, and the <code>ForcedApplyDate</code>.
        /// This value is blank if an opt-in request has not been received and no value has been
        /// specified for the <code>AutoAppliedAfterDate</code> or <code>ForcedApplyDate</code>.
        /// </para>
        /// </summary>
        public DateTime CurrentApplyDate
        {
            get { return this._currentApplyDate.GetValueOrDefault(); }
            set { this._currentApplyDate = value; }
        }

        // Check to see if CurrentApplyDate property is set
        internal bool IsSetCurrentApplyDate()
        {
            return this._currentApplyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForcedApplyDate. 
        /// <para>
        /// The date when the maintenance action will be automatically applied. The maintenance
        /// action will be applied to the resource on this date regardless of the maintenance
        /// window for the resource. If this date is specified, any <code>immediate</code> opt-in
        /// requests are ignored.
        /// </para>
        /// </summary>
        public DateTime ForcedApplyDate
        {
            get { return this._forcedApplyDate.GetValueOrDefault(); }
            set { this._forcedApplyDate = value; }
        }

        // Check to see if ForcedApplyDate property is set
        internal bool IsSetForcedApplyDate()
        {
            return this._forcedApplyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// Indicates the type of opt-in request that has been received for the resource.
        /// </para>
        /// </summary>
        public string OptInStatus
        {
            get { return this._optInStatus; }
            set { this._optInStatus = value; }
        }

        // Check to see if OptInStatus property is set
        internal bool IsSetOptInStatus()
        {
            return this._optInStatus != null;
        }

    }
}