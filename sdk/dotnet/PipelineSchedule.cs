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
    /// ## # Resource: pipeline_schedule
    /// 
    /// This resource allows you to create and manage pipeline schedules.
    /// 
    /// Buildkite Documentation: https://buildkite.com/docs/pipelines/scheduled-builds
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
    ///         var repo2Nightly = new Buildkite.PipelineSchedule("repo2Nightly", new Buildkite.PipelineScheduleArgs
    ///         {
    ///             PipelineId = buildkite_pipeline.Repo2.Id,
    ///             Label = "Nightly build",
    ///             Cronline = "@midnight",
    ///             Branch = buildkite_pipeline.Repo2.Default_branch,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Pipeline schedules can be imported using a slug (which consists of `$BUILDKITE_ORGANIZATION_SLUG/$BUILDKITE_PIPELINE_SLUG/$PIPELINE_SCHEDULE_UUID`), e.g.
    /// 
    /// ```sh
    ///  $ pulumi import buildkite:index/pipelineSchedule:PipelineSchedule test myorg/test/1be3e7c7-1e03-4011-accf-b2d8eec90222
    /// ```
    /// </summary>
    [BuildkiteResourceType("buildkite:index/pipelineSchedule:PipelineSchedule")]
    public partial class PipelineSchedule : Pulumi.CustomResource
    {
        /// <summary>
        /// The branch to use for the build.
        /// </summary>
        [Output("branch")]
        public Output<string> Branch { get; private set; } = null!;

        /// <summary>
        /// The commit ref to use for the build.
        /// </summary>
        [Output("commit")]
        public Output<string?> Commit { get; private set; } = null!;

        /// <summary>
        /// Schedule interval (see [docs](https://buildkite.com/docs/pipelines/scheduled-builds#schedule-intervals)).
        /// </summary>
        [Output("cronline")]
        public Output<string> Cronline { get; private set; } = null!;

        /// <summary>
        /// Whether the schedule should run.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// A map of environment variables to use for the build.
        /// </summary>
        [Output("env")]
        public Output<ImmutableDictionary<string, string>?> Env { get; private set; } = null!;

        /// <summary>
        /// Schedule label.
        /// </summary>
        [Output("label")]
        public Output<string> Label { get; private set; } = null!;

        /// <summary>
        /// The message to use for the build.
        /// </summary>
        [Output("message")]
        public Output<string> Message { get; private set; } = null!;

        [Output("pipelineId")]
        public Output<string> PipelineId { get; private set; } = null!;

        /// <summary>
        /// The UUID of the pipeline schedule
        /// </summary>
        [Output("uuid")]
        public Output<string> Uuid { get; private set; } = null!;


        /// <summary>
        /// Create a PipelineSchedule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PipelineSchedule(string name, PipelineScheduleArgs args, CustomResourceOptions? options = null)
            : base("buildkite:index/pipelineSchedule:PipelineSchedule", name, args ?? new PipelineScheduleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PipelineSchedule(string name, Input<string> id, PipelineScheduleState? state = null, CustomResourceOptions? options = null)
            : base("buildkite:index/pipelineSchedule:PipelineSchedule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PipelineSchedule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PipelineSchedule Get(string name, Input<string> id, PipelineScheduleState? state = null, CustomResourceOptions? options = null)
        {
            return new PipelineSchedule(name, id, state, options);
        }
    }

    public sealed class PipelineScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The branch to use for the build.
        /// </summary>
        [Input("branch", required: true)]
        public Input<string> Branch { get; set; } = null!;

        /// <summary>
        /// The commit ref to use for the build.
        /// </summary>
        [Input("commit")]
        public Input<string>? Commit { get; set; }

        /// <summary>
        /// Schedule interval (see [docs](https://buildkite.com/docs/pipelines/scheduled-builds#schedule-intervals)).
        /// </summary>
        [Input("cronline", required: true)]
        public Input<string> Cronline { get; set; } = null!;

        /// <summary>
        /// Whether the schedule should run.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("env")]
        private InputMap<string>? _env;

        /// <summary>
        /// A map of environment variables to use for the build.
        /// </summary>
        public InputMap<string> Env
        {
            get => _env ?? (_env = new InputMap<string>());
            set => _env = value;
        }

        /// <summary>
        /// Schedule label.
        /// </summary>
        [Input("label", required: true)]
        public Input<string> Label { get; set; } = null!;

        /// <summary>
        /// The message to use for the build.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("pipelineId", required: true)]
        public Input<string> PipelineId { get; set; } = null!;

        public PipelineScheduleArgs()
        {
        }
    }

    public sealed class PipelineScheduleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The branch to use for the build.
        /// </summary>
        [Input("branch")]
        public Input<string>? Branch { get; set; }

        /// <summary>
        /// The commit ref to use for the build.
        /// </summary>
        [Input("commit")]
        public Input<string>? Commit { get; set; }

        /// <summary>
        /// Schedule interval (see [docs](https://buildkite.com/docs/pipelines/scheduled-builds#schedule-intervals)).
        /// </summary>
        [Input("cronline")]
        public Input<string>? Cronline { get; set; }

        /// <summary>
        /// Whether the schedule should run.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("env")]
        private InputMap<string>? _env;

        /// <summary>
        /// A map of environment variables to use for the build.
        /// </summary>
        public InputMap<string> Env
        {
            get => _env ?? (_env = new InputMap<string>());
            set => _env = value;
        }

        /// <summary>
        /// Schedule label.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// The message to use for the build.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("pipelineId")]
        public Input<string>? PipelineId { get; set; }

        /// <summary>
        /// The UUID of the pipeline schedule
        /// </summary>
        [Input("uuid")]
        public Input<string>? Uuid { get; set; }

        public PipelineScheduleState()
        {
        }
    }
}
