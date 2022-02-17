// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Buildkite
{
    public static class GetMetadata
    {
        public static Task<GetMetadataResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMetadataResult>("buildkite:index/getMetadata:getMetadata", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetMetadataResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A list of strings, each one an IP address (x.x.x.x) or CIDR address (x.x.x.x/32) that Buildkite may use to send webhooks and other external requests.
        /// </summary>
        public readonly ImmutableArray<string> WebhookIps;

        [OutputConstructor]
        private GetMetadataResult(
            string id,

            ImmutableArray<string> webhookIps)
        {
            Id = id;
            WebhookIps = webhookIps;
        }
    }
}
