// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Buildkite.Outputs
{

    [OutputType]
    public sealed class PipelineTeam
    {
        /// <summary>
        /// The level of access to grant. Must be one of `READ_ONLY`, `BUILD_AND_READ` or `MANAGE_BUILD_AND_READ`.
        /// </summary>
        public readonly string AccessLevel;
        /// <summary>
        /// The buildkite slug of the team.
        /// </summary>
        public readonly string Slug;

        [OutputConstructor]
        private PipelineTeam(
            string accessLevel,

            string slug)
        {
            AccessLevel = accessLevel;
            Slug = slug;
        }
    }
}
