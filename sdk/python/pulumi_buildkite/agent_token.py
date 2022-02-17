# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['AgentTokenArgs', 'AgentToken']

@pulumi.input_type
class AgentTokenArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a AgentToken resource.
        :param pulumi.Input[str] description: This is the description of the agent token.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        This is the description of the agent token.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class _AgentTokenState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 uuid: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AgentToken resources.
        :param pulumi.Input[str] description: This is the description of the agent token.
        :param pulumi.Input[str] token: The value of the created agent token.
        :param pulumi.Input[str] uuid: The UUID of the token.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if token is not None:
            pulumi.set(__self__, "token", token)
        if uuid is not None:
            pulumi.set(__self__, "uuid", uuid)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        This is the description of the agent token.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[str]]:
        """
        The value of the created agent token.
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "token", value)

    @property
    @pulumi.getter
    def uuid(self) -> Optional[pulumi.Input[str]]:
        """
        The UUID of the token.
        """
        return pulumi.get(self, "uuid")

    @uuid.setter
    def uuid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "uuid", value)


class AgentToken(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ## # Resource: agent_token

        This resource allows you to create and manage agent tokens.

        Buildkite Documentation: https://buildkite.com/docs/agent/v3/tokens

        ## Example Usage

        ```python
        import pulumi
        import pulumi_buildkite as buildkite

        fleet = buildkite.AgentToken("fleet", description="token used by build fleet")
        ```

        ## Import

        Tokens can be imported using the `GraphQL ID` (not UUID), e.g.

        ```sh
         $ pulumi import buildkite:index/agentToken:AgentToken fleet QWdlbnRUb2tlbi0tLTQzNWNhZDU4LWU4MWQtNDVhZi04NjM3LWIxY2Y4MDcwMjM4ZA==
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: This is the description of the agent token.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[AgentTokenArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## # Resource: agent_token

        This resource allows you to create and manage agent tokens.

        Buildkite Documentation: https://buildkite.com/docs/agent/v3/tokens

        ## Example Usage

        ```python
        import pulumi
        import pulumi_buildkite as buildkite

        fleet = buildkite.AgentToken("fleet", description="token used by build fleet")
        ```

        ## Import

        Tokens can be imported using the `GraphQL ID` (not UUID), e.g.

        ```sh
         $ pulumi import buildkite:index/agentToken:AgentToken fleet QWdlbnRUb2tlbi0tLTQzNWNhZDU4LWU4MWQtNDVhZi04NjM3LWIxY2Y4MDcwMjM4ZA==
        ```

        :param str resource_name: The name of the resource.
        :param AgentTokenArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AgentTokenArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AgentTokenArgs.__new__(AgentTokenArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["token"] = None
            __props__.__dict__["uuid"] = None
        super(AgentToken, __self__).__init__(
            'buildkite:index/agentToken:AgentToken',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            token: Optional[pulumi.Input[str]] = None,
            uuid: Optional[pulumi.Input[str]] = None) -> 'AgentToken':
        """
        Get an existing AgentToken resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: This is the description of the agent token.
        :param pulumi.Input[str] token: The value of the created agent token.
        :param pulumi.Input[str] uuid: The UUID of the token.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AgentTokenState.__new__(_AgentTokenState)

        __props__.__dict__["description"] = description
        __props__.__dict__["token"] = token
        __props__.__dict__["uuid"] = uuid
        return AgentToken(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        This is the description of the agent token.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def token(self) -> pulumi.Output[str]:
        """
        The value of the created agent token.
        """
        return pulumi.get(self, "token")

    @property
    @pulumi.getter
    def uuid(self) -> pulumi.Output[str]:
        """
        The UUID of the token.
        """
        return pulumi.get(self, "uuid")

