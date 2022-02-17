// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Buildkite
{
    /// <summary>
    /// ## # Resource: team_member
    /// 
    /// This resource allows manage team membership for existing organization users.
    /// 
    /// The user must already be part of the organization to which you are managing team membership. This will not invite a new user to the organization.
    /// 
    /// Buildkite Documentation: https://buildkite.com/docs/pipelines/permissions
    /// 
    /// Note: You must first enable Teams on your organization.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Buildkite = Pulumi.Buildkite;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var team = new Buildkite.Team("team", new Buildkite.TeamArgs
    ///         {
    ///             Privacy = "VISIBLE",
    ///             DefaultTeam = true,
    ///             DefaultMemberRole = "MEMBER",
    ///         });
    ///         var aSmith = new Buildkite.TeamMember("aSmith", new Buildkite.TeamMemberArgs
    ///         {
    ///             Role = "MEMBER",
    ///             TeamId = team.Id,
    ///             UserId = "VXNlci0tLWRlOTdmMjBiLWJkZmMtNGNjOC1hOTcwLTY1ODNiZTk2ZGEyYQ==",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Team members can be imported using the GraphQL ID of the membership. Note this is different to the ID of the user.
    /// 
    /// ```sh
    ///  $ pulumi import buildkite:index/teamMember:TeamMember a_smith VGVhbU1lbWJlci0tLTVlZDEyMmY2LTM2NjQtNDI1MS04YzMwLTc4NjRiMDdiZDQ4Zg==
    /// ```
    /// 
    ///  To find the ID of a team member you are trying to import you can use the GraphQL snippet below. A link to this snippet can also be found at https://buildkite.com/user/graphql/console/c6a2cc65-dc59-49df-95c6-7167b68dbd5d. You will need fo fill in the organization slug and search terms for teams and members. Both search terms work on the name of the associated object. graphql query {
    /// 
    ///  organization(slug"") {
    /// 
    ///  teams(first2, search"") {
    /// 
    ///  edges {
    /// 
    ///  node {
    /// 
    ///  members(first2, search"") {
    /// 
    ///  edges {
    /// 
    ///  node {
    /// 
    ///  id
    /// 
    ///  }
    /// 
    ///  }
    /// 
    ///  }
    /// 
    ///  }
    /// 
    ///  }
    /// 
    ///  }
    /// 
    ///  } }
    /// </summary>
    [BuildkiteResourceType("buildkite:index/teamMember:TeamMember")]
    public partial class TeamMember : Pulumi.CustomResource
    {
        /// <summary>
        /// Either MEMBER or MAINTAINER.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The GraphQL ID of the team to add to/remove from.
        /// </summary>
        [Output("teamId")]
        public Output<string> TeamId { get; private set; } = null!;

        /// <summary>
        /// The GraphQL ID of the user to add/remove.
        /// </summary>
        [Output("userId")]
        public Output<string> UserId { get; private set; } = null!;

        /// <summary>
        /// The UUID for the team membership.
        /// </summary>
        [Output("uuid")]
        public Output<string> Uuid { get; private set; } = null!;


        /// <summary>
        /// Create a TeamMember resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TeamMember(string name, TeamMemberArgs args, CustomResourceOptions? options = null)
            : base("buildkite:index/teamMember:TeamMember", name, args ?? new TeamMemberArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TeamMember(string name, Input<string> id, TeamMemberState? state = null, CustomResourceOptions? options = null)
            : base("buildkite:index/teamMember:TeamMember", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TeamMember resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TeamMember Get(string name, Input<string> id, TeamMemberState? state = null, CustomResourceOptions? options = null)
        {
            return new TeamMember(name, id, state, options);
        }
    }

    public sealed class TeamMemberArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Either MEMBER or MAINTAINER.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The GraphQL ID of the team to add to/remove from.
        /// </summary>
        [Input("teamId", required: true)]
        public Input<string> TeamId { get; set; } = null!;

        /// <summary>
        /// The GraphQL ID of the user to add/remove.
        /// </summary>
        [Input("userId", required: true)]
        public Input<string> UserId { get; set; } = null!;

        public TeamMemberArgs()
        {
        }
    }

    public sealed class TeamMemberState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Either MEMBER or MAINTAINER.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// The GraphQL ID of the team to add to/remove from.
        /// </summary>
        [Input("teamId")]
        public Input<string>? TeamId { get; set; }

        /// <summary>
        /// The GraphQL ID of the user to add/remove.
        /// </summary>
        [Input("userId")]
        public Input<string>? UserId { get; set; }

        /// <summary>
        /// The UUID for the team membership.
        /// </summary>
        [Input("uuid")]
        public Input<string>? Uuid { get; set; }

        public TeamMemberState()
        {
        }
    }
}
