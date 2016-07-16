// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains information about the execution of a job in the Azure Batch
    /// service.
    /// </summary>
    public partial class JobExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobExecutionInformation class.
        /// </summary>
        public JobExecutionInformation() { }

        /// <summary>
        /// Initializes a new instance of the JobExecutionInformation class.
        /// </summary>
        public JobExecutionInformation(DateTime startTime, DateTime? endTime = default(DateTime?), string poolId = default(string), JobSchedulingError schedulingError = default(JobSchedulingError), string terminateReason = default(string))
        {
            StartTime = startTime;
            EndTime = endTime;
            PoolId = poolId;
            SchedulingError = schedulingError;
            TerminateReason = terminateReason;
        }

        /// <summary>
        /// Gets or sets the start time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the completion time of the job. This property is set
        /// only if the job is in the completed state.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the pool to which this job is assigned.
        /// </summary>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets details of any error encountered by the service in
        /// starting the job.
        /// </summary>
        [JsonProperty(PropertyName = "schedulingError")]
        public JobSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets a string describing the reason the job ended.
        /// </summary>
        [JsonProperty(PropertyName = "terminateReason")]
        public string TerminateReason { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}