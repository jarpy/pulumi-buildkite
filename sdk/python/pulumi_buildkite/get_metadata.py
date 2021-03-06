# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetMetadataResult',
    'AwaitableGetMetadataResult',
    'get_metadata',
]

@pulumi.output_type
class GetMetadataResult:
    """
    A collection of values returned by getMetadata.
    """
    def __init__(__self__, id=None, webhook_ips=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if webhook_ips and not isinstance(webhook_ips, list):
            raise TypeError("Expected argument 'webhook_ips' to be a list")
        pulumi.set(__self__, "webhook_ips", webhook_ips)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="webhookIps")
    def webhook_ips(self) -> Sequence[str]:
        """
        A list of strings, each one an IP address (x.x.x.x) or CIDR address (x.x.x.x/32) that Buildkite may use to send webhooks and other external requests.
        """
        return pulumi.get(self, "webhook_ips")


class AwaitableGetMetadataResult(GetMetadataResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetMetadataResult(
            id=self.id,
            webhook_ips=self.webhook_ips)


def get_metadata(opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetMetadataResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('buildkite:index/getMetadata:getMetadata', __args__, opts=opts, typ=GetMetadataResult).value

    return AwaitableGetMetadataResult(
        id=__ret__.id,
        webhook_ips=__ret__.webhook_ips)
