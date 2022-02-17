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
    /// ## # Resource: pipeline
    /// 
    /// This resource allows you to create and manage pipelines for repositories.
    /// 
    /// Buildkite Documentation: https://buildkite.com/docs/pipelines
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.IO;
    /// using Pulumi;
    /// using Buildkite = Pulumi.Buildkite;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // in ./steps.yml:
    ///         // steps:
    ///         //   - label: ':pipeline:'
    ///         //     command: buildkite-agent pipeline upload
    ///         var repo2 = new Buildkite.Pipeline("repo2", new Buildkite.PipelineArgs
    ///         {
    ///             Repository = "git@github.com:org/repo2",
    ///             Steps = File.ReadAllText("./steps.yml"),
    ///             Teams = 
    ///             {
    ///                 new Buildkite.Inputs.PipelineTeamArgs
    ///                 {
    ///                     Slug = "everyone",
    ///                     AccessLevel = "READ_ONLY",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### With GitHub Provider Settings
    /// 
    /// ```csharp
    /// using System.IO;
    /// using Pulumi;
    /// using Buildkite = Pulumi.Buildkite;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // Pipeline that should not be triggered from a GitHub webhook
    ///         var repo2_deploy = new Buildkite.Pipeline("repo2-deploy", new Buildkite.PipelineArgs
    ///         {
    ///             Repository = "git@github.com:org/repo2",
    ///             Steps = File.ReadAllText("./deploy-steps.yml"),
    ///             ProviderSettings = new Buildkite.Inputs.PipelineProviderSettingsArgs
    ///             {
    ///                 TriggerMode = "none",
    ///             },
    ///         });
    ///         // Release pipeline (triggered only when tags are pushed)
    ///         var repo2_release = new Buildkite.Pipeline("repo2-release", new Buildkite.PipelineArgs
    ///         {
    ///             Repository = "git@github.com:org/repo2",
    ///             Steps = File.ReadAllText("./release-steps.yml"),
    ///             ProviderSettings = new Buildkite.Inputs.PipelineProviderSettingsArgs
    ///             {
    ///                 BuildBranches = false,
    ///                 BuildTags = true,
    ///                 BuildPullRequests = false,
    ///                 TriggerMode = "code",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Pipelines can be imported using the `GraphQL ID` (not UUID), e.g.
    /// 
    /// ```sh
    ///  $ pulumi import buildkite:index/pipeline:Pipeline fleet UGlwZWxpbmUtLS00MzVjYWQ1OC1lODFkLTQ1YWYtODYzNy1iMWNmODA3MDIzOGQ=
    /// ```
    /// </summary>
    [BuildkiteResourceType("buildkite:index/pipeline:Pipeline")]
    public partial class Pipeline : Pulumi.CustomResource
    {
        /// <summary>
        /// The pipeline's last build status so you can display build status badge.
        /// </summary>
        [Output("badgeUrl")]
        public Output<string> BadgeUrl { get; private set; } = null!;

        /// <summary>
        /// Limit which branches and tags cause new builds to be created, either via a code push or via the Builds REST API.
        /// </summary>
        [Output("branchConfiguration")]
        public Output<string> BranchConfiguration { get; private set; } = null!;

        /// <summary>
        /// A boolean to enable automatically cancelling any running builds on the same branch when a new build is created.
        /// </summary>
        [Output("cancelIntermediateBuilds")]
        public Output<bool> CancelIntermediateBuilds { get; private set; } = null!;

        /// <summary>
        /// Limit which branches build cancelling applies to, for example !master will ensure that the master branch won't have it's builds automatically cancelled.
        /// </summary>
        [Output("cancelIntermediateBuildsBranchFilter")]
        public Output<string> CancelIntermediateBuildsBranchFilter { get; private set; } = null!;

        /// <summary>
        /// The default branch to prefill when new builds are created or triggered, usually main or master but can be anything.
        /// </summary>
        [Output("defaultBranch")]
        public Output<string> DefaultBranch { get; private set; } = null!;

        /// <summary>
        /// A description of the pipeline.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Source control provider settings for the pipeline. See Provider Settings Configuration below for details.
        /// </summary>
        [Output("providerSettings")]
        public Output<Outputs.PipelineProviderSettings> ProviderSettings { get; private set; } = null!;

        /// <summary>
        /// The git URL of the repository.
        /// </summary>
        [Output("repository")]
        public Output<string> Repository { get; private set; } = null!;

        /// <summary>
        /// A boolean to enable automatically skipping any unstarted builds on the same branch when a new build is created.
        /// </summary>
        [Output("skipIntermediateBuilds")]
        public Output<bool> SkipIntermediateBuilds { get; private set; } = null!;

        /// <summary>
        /// Limit which branches build skipping applies to, for example `!master` will ensure that the master branch won't have it's builds automatically skipped.
        /// </summary>
        [Output("skipIntermediateBuildsBranchFilter")]
        public Output<string> SkipIntermediateBuildsBranchFilter { get; private set; } = null!;

        /// <summary>
        /// The buildkite slug of the team.
        /// </summary>
        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;

        /// <summary>
        /// The string YAML steps to run the pipeline.
        /// </summary>
        [Output("steps")]
        public Output<string> Steps { get; private set; } = null!;

        /// <summary>
        /// Set team access for the pipeline. Can be specified multiple times for each team. See Teams Configuration below for details.
        /// </summary>
        [Output("teams")]
        public Output<ImmutableArray<Outputs.PipelineTeam>> Teams { get; private set; } = null!;

        /// <summary>
        /// The Buildkite webhook URL to configure on the repository to trigger builds on this pipeline.
        /// </summary>
        [Output("webhookUrl")]
        public Output<string> WebhookUrl { get; private set; } = null!;


        /// <summary>
        /// Create a Pipeline resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Pipeline(string name, PipelineArgs args, CustomResourceOptions? options = null)
            : base("buildkite:index/pipeline:Pipeline", name, args ?? new PipelineArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Pipeline(string name, Input<string> id, PipelineState? state = null, CustomResourceOptions? options = null)
            : base("buildkite:index/pipeline:Pipeline", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Pipeline resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Pipeline Get(string name, Input<string> id, PipelineState? state = null, CustomResourceOptions? options = null)
        {
            return new Pipeline(name, id, state, options);
        }
    }

    public sealed class PipelineArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Limit which branches and tags cause new builds to be created, either via a code push or via the Builds REST API.
        /// </summary>
        [Input("branchConfiguration")]
        public Input<string>? BranchConfiguration { get; set; }

        /// <summary>
        /// A boolean to enable automatically cancelling any running builds on the same branch when a new build is created.
        /// </summary>
        [Input("cancelIntermediateBuilds")]
        public Input<bool>? CancelIntermediateBuilds { get; set; }

        /// <summary>
        /// Limit which branches build cancelling applies to, for example !master will ensure that the master branch won't have it's builds automatically cancelled.
        /// </summary>
        [Input("cancelIntermediateBuildsBranchFilter")]
        public Input<string>? CancelIntermediateBuildsBranchFilter { get; set; }

        /// <summary>
        /// The default branch to prefill when new builds are created or triggered, usually main or master but can be anything.
        /// </summary>
        [Input("defaultBranch")]
        public Input<string>? DefaultBranch { get; set; }

        /// <summary>
        /// A description of the pipeline.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Source control provider settings for the pipeline. See Provider Settings Configuration below for details.
        /// </summary>
        [Input("providerSettings")]
        public Input<Inputs.PipelineProviderSettingsArgs>? ProviderSettings { get; set; }

        /// <summary>
        /// The git URL of the repository.
        /// </summary>
        [Input("repository", required: true)]
        public Input<string> Repository { get; set; } = null!;

        /// <summary>
        /// A boolean to enable automatically skipping any unstarted builds on the same branch when a new build is created.
        /// </summary>
        [Input("skipIntermediateBuilds")]
        public Input<bool>? SkipIntermediateBuilds { get; set; }

        /// <summary>
        /// Limit which branches build skipping applies to, for example `!master` will ensure that the master branch won't have it's builds automatically skipped.
        /// </summary>
        [Input("skipIntermediateBuildsBranchFilter")]
        public Input<string>? SkipIntermediateBuildsBranchFilter { get; set; }

        /// <summary>
        /// The string YAML steps to run the pipeline.
        /// </summary>
        [Input("steps", required: true)]
        public Input<string> Steps { get; set; } = null!;

        [Input("teams")]
        private InputList<Inputs.PipelineTeamArgs>? _teams;

        /// <summary>
        /// Set team access for the pipeline. Can be specified multiple times for each team. See Teams Configuration below for details.
        /// </summary>
        public InputList<Inputs.PipelineTeamArgs> Teams
        {
            get => _teams ?? (_teams = new InputList<Inputs.PipelineTeamArgs>());
            set => _teams = value;
        }

        public PipelineArgs()
        {
        }
    }

    public sealed class PipelineState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The pipeline's last build status so you can display build status badge.
        /// </summary>
        [Input("badgeUrl")]
        public Input<string>? BadgeUrl { get; set; }

        /// <summary>
        /// Limit which branches and tags cause new builds to be created, either via a code push or via the Builds REST API.
        /// </summary>
        [Input("branchConfiguration")]
        public Input<string>? BranchConfiguration { get; set; }

        /// <summary>
        /// A boolean to enable automatically cancelling any running builds on the same branch when a new build is created.
        /// </summary>
        [Input("cancelIntermediateBuilds")]
        public Input<bool>? CancelIntermediateBuilds { get; set; }

        /// <summary>
        /// Limit which branches build cancelling applies to, for example !master will ensure that the master branch won't have it's builds automatically cancelled.
        /// </summary>
        [Input("cancelIntermediateBuildsBranchFilter")]
        public Input<string>? CancelIntermediateBuildsBranchFilter { get; set; }

        /// <summary>
        /// The default branch to prefill when new builds are created or triggered, usually main or master but can be anything.
        /// </summary>
        [Input("defaultBranch")]
        public Input<string>? DefaultBranch { get; set; }

        /// <summary>
        /// A description of the pipeline.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Source control provider settings for the pipeline. See Provider Settings Configuration below for details.
        /// </summary>
        [Input("providerSettings")]
        public Input<Inputs.PipelineProviderSettingsGetArgs>? ProviderSettings { get; set; }

        /// <summary>
        /// The git URL of the repository.
        /// </summary>
        [Input("repository")]
        public Input<string>? Repository { get; set; }

        /// <summary>
        /// A boolean to enable automatically skipping any unstarted builds on the same branch when a new build is created.
        /// </summary>
        [Input("skipIntermediateBuilds")]
        public Input<bool>? SkipIntermediateBuilds { get; set; }

        /// <summary>
        /// Limit which branches build skipping applies to, for example `!master` will ensure that the master branch won't have it's builds automatically skipped.
        /// </summary>
        [Input("skipIntermediateBuildsBranchFilter")]
        public Input<string>? SkipIntermediateBuildsBranchFilter { get; set; }

        /// <summary>
        /// The buildkite slug of the team.
        /// </summary>
        [Input("slug")]
        public Input<string>? Slug { get; set; }

        /// <summary>
        /// The string YAML steps to run the pipeline.
        /// </summary>
        [Input("steps")]
        public Input<string>? Steps { get; set; }

        [Input("teams")]
        private InputList<Inputs.PipelineTeamGetArgs>? _teams;

        /// <summary>
        /// Set team access for the pipeline. Can be specified multiple times for each team. See Teams Configuration below for details.
        /// </summary>
        public InputList<Inputs.PipelineTeamGetArgs> Teams
        {
            get => _teams ?? (_teams = new InputList<Inputs.PipelineTeamGetArgs>());
            set => _teams = value;
        }

        /// <summary>
        /// The Buildkite webhook URL to configure on the repository to trigger builds on this pipeline.
        /// </summary>
        [Input("webhookUrl")]
        public Input<string>? WebhookUrl { get; set; }

        public PipelineState()
        {
        }
    }
}