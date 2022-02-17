// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getMetadata(opts?: pulumi.InvokeOptions): Promise<GetMetadataResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("buildkite:index/getMetadata:getMetadata", {
    }, opts);
}

/**
 * A collection of values returned by getMetadata.
 */
export interface GetMetadataResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of strings, each one an IP address (x.x.x.x) or CIDR address (x.x.x.x/32) that Buildkite may use to send webhooks and other external requests.
     */
    readonly webhookIps: string[];
}
