// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

declare var exports: any;
const __config = new pulumi.Config("buildkite");

/**
 * API token with GraphQL access and `write_pipelines, read_pipelines` scopes
 */
export declare const apiToken: string | undefined;
Object.defineProperty(exports, "apiToken", {
    get() {
        return __config.get("apiToken");
    },
    enumerable: true,
});

/**
 * The Buildkite organization ID
 */
export declare const organization: string | undefined;
Object.defineProperty(exports, "organization", {
    get() {
        return __config.get("organization");
    },
    enumerable: true,
});

