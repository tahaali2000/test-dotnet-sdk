// <copyright file="NacTag.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CypressTestAPI.Standard;
using CypressTestAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CypressTestAPI.Standard.Models
{
    /// <summary>
    /// NacTag.
    /// </summary>
    public class NacTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacTag"/> class.
        /// </summary>
        public NacTag()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacTag"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="allowUsermacOverride">allow_usermac_override.</param>
        /// <param name="createdTime">created_time.</param>
        /// <param name="egressVlanNames">egress_vlan_names.</param>
        /// <param name="gbpTag">gbp_tag.</param>
        /// <param name="id">id.</param>
        /// <param name="match">match.</param>
        /// <param name="matchAll">match_all.</param>
        /// <param name="modifiedTime">modified_time.</param>
        /// <param name="orgId">org_id.</param>
        /// <param name="radiusAttrs">radius_attrs.</param>
        /// <param name="radiusGroup">radius_group.</param>
        /// <param name="radiusVendorAttrs">radius_vendor_attrs.</param>
        /// <param name="sessionTimeout">session_timeout.</param>
        /// <param name="usernameAttr">username_attr.</param>
        /// <param name="values">values.</param>
        /// <param name="vlan">vlan.</param>
        public NacTag(
            string name,
            Models.NacTag type,
            bool? allowUsermacOverride = false,
            double? createdTime = null,
            List<string> egressVlanNames = null,
            int? gbpTag = null,
            Guid? id = null,
            Models.NacTag match = null,
            bool? matchAll = false,
            double? modifiedTime = null,
            Guid? orgId = null,
            List<string> radiusAttrs = null,
            string radiusGroup = "",
            List<string> radiusVendorAttrs = null,
            int? sessionTimeout = null,
            Models.NacTag usernameAttr = null,
            List<string> values = null,
            string vlan = "")
        {
            this.AllowUsermacOverride = allowUsermacOverride;
            this.CreatedTime = createdTime;
            this.EgressVlanNames = egressVlanNames;
            this.GbpTag = gbpTag;
            this.Id = id;
            this.Match = match;
            this.MatchAll = matchAll;
            this.ModifiedTime = modifiedTime;
            this.Name = name;
            this.OrgId = orgId;
            this.RadiusAttrs = radiusAttrs;
            this.RadiusGroup = radiusGroup;
            this.RadiusVendorAttrs = radiusVendorAttrs;
            this.SessionTimeout = sessionTimeout;
            this.Type = type;
            this.UsernameAttr = usernameAttr;
            this.Values = values;
            this.Vlan = vlan;
        }

        /// <summary>
        /// can be set to true to allow the override by usermac result
        /// </summary>
        [JsonProperty("allow_usermac_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUsermacOverride { get; set; }

        /// <summary>
        /// Gets or sets CreatedTime.
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? CreatedTime { get; set; }

        /// <summary>
        /// if `type`==`egress_vlan_names`, list of egress vlans to return
        /// </summary>
        [JsonProperty("egress_vlan_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EgressVlanNames { get; set; }

        /// <summary>
        /// if `type`==`gbp_tag`
        /// </summary>
        [JsonProperty("gbp_tag", NullValueHandling = NullValueHandling.Ignore)]
        public int? GbpTag { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets Match.
        /// </summary>
        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacTag Match { get; set; }

        /// <summary>
        /// This field is applicable only when `type`==`match`
        ///   * `false`: means it is sufficient to match any of the values (i.e., match-any behavior)
        ///   * `true`: means all values should be matched (i.e., match-all behavior)
        /// Currently it makes sense to set this field to `true` only if the `match`==`idp_role` or `match`==`usermac_label`'
        /// </summary>
        [JsonProperty("match_all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchAll { get; set; }

        /// <summary>
        /// Gets or sets ModifiedTime.
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets OrgId.
        /// </summary>
        [JsonProperty("org_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrgId { get; set; }

        /// <summary>
        /// if `type`==`radius_attrs`, user can specify a list of one or more standard attributes in the field "radius_attrs".
        /// It is the responsibility of the user to provide a syntactically correct string, otherwise it may not work as expected.
        /// Note that it is allowed to have more than one radius_attrs in the result of a given rule.
        /// </summary>
        [JsonProperty("radius_attrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RadiusAttrs { get; set; }

        /// <summary>
        /// if `type`==`radius_group`
        /// </summary>
        [JsonProperty("radius_group", NullValueHandling = NullValueHandling.Ignore)]
        public string RadiusGroup { get; set; }

        /// <summary>
        /// if `type`==`radius_vendor_attrs`, user can specify a list of one or more vendor-specific attributes in the field "radius_vendor_attrs".
        /// It is the responsibility of the user to provide a syntactically correct string, otherwise it may not work as expected.
        /// Note that it is allowed to have more than one radius_vendor_attrs in the result of a given rule.
        /// </summary>
        [JsonProperty("radius_vendor_attrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RadiusVendorAttrs { get; set; }

        /// <summary>
        /// if `type`==`session_timeout, in seconds
        /// </summary>
        [JsonProperty("session_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.NacTag Type { get; set; }

        /// <summary>
        /// Gets or sets UsernameAttr.
        /// </summary>
        [JsonProperty("username_attr", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacTag UsernameAttr { get; set; }

        /// <summary>
        /// if `type`==`match`
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }

        /// <summary>
        /// if `type`==`vlan`
        /// </summary>
        [JsonProperty("vlan", NullValueHandling = NullValueHandling.Ignore)]
        public string Vlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NacTag : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NacTag other &&
                (this.AllowUsermacOverride == null && other.AllowUsermacOverride == null ||
                 this.AllowUsermacOverride?.Equals(other.AllowUsermacOverride) == true) &&
                (this.CreatedTime == null && other.CreatedTime == null ||
                 this.CreatedTime?.Equals(other.CreatedTime) == true) &&
                (this.EgressVlanNames == null && other.EgressVlanNames == null ||
                 this.EgressVlanNames?.Equals(other.EgressVlanNames) == true) &&
                (this.GbpTag == null && other.GbpTag == null ||
                 this.GbpTag?.Equals(other.GbpTag) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Match == null && other.Match == null ||
                 this.Match?.Equals(other.Match) == true) &&
                (this.MatchAll == null && other.MatchAll == null ||
                 this.MatchAll?.Equals(other.MatchAll) == true) &&
                (this.ModifiedTime == null && other.ModifiedTime == null ||
                 this.ModifiedTime?.Equals(other.ModifiedTime) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.OrgId == null && other.OrgId == null ||
                 this.OrgId?.Equals(other.OrgId) == true) &&
                (this.RadiusAttrs == null && other.RadiusAttrs == null ||
                 this.RadiusAttrs?.Equals(other.RadiusAttrs) == true) &&
                (this.RadiusGroup == null && other.RadiusGroup == null ||
                 this.RadiusGroup?.Equals(other.RadiusGroup) == true) &&
                (this.RadiusVendorAttrs == null && other.RadiusVendorAttrs == null ||
                 this.RadiusVendorAttrs?.Equals(other.RadiusVendorAttrs) == true) &&
                (this.SessionTimeout == null && other.SessionTimeout == null ||
                 this.SessionTimeout?.Equals(other.SessionTimeout) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.UsernameAttr == null && other.UsernameAttr == null ||
                 this.UsernameAttr?.Equals(other.UsernameAttr) == true) &&
                (this.Values == null && other.Values == null ||
                 this.Values?.Equals(other.Values) == true) &&
                (this.Vlan == null && other.Vlan == null ||
                 this.Vlan?.Equals(other.Vlan) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AllowUsermacOverride = {(this.AllowUsermacOverride == null ? "null" : this.AllowUsermacOverride.ToString())}");
            toStringOutput.Add($"CreatedTime = {(this.CreatedTime == null ? "null" : this.CreatedTime.ToString())}");
            toStringOutput.Add($"EgressVlanNames = {(this.EgressVlanNames == null ? "null" : $"[{string.Join(", ", this.EgressVlanNames)} ]")}");
            toStringOutput.Add($"GbpTag = {(this.GbpTag == null ? "null" : this.GbpTag.ToString())}");
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Match = {(this.Match == null ? "null" : this.Match.ToString())}");
            toStringOutput.Add($"MatchAll = {(this.MatchAll == null ? "null" : this.MatchAll.ToString())}");
            toStringOutput.Add($"ModifiedTime = {(this.ModifiedTime == null ? "null" : this.ModifiedTime.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"OrgId = {(this.OrgId == null ? "null" : this.OrgId.ToString())}");
            toStringOutput.Add($"RadiusAttrs = {(this.RadiusAttrs == null ? "null" : $"[{string.Join(", ", this.RadiusAttrs)} ]")}");
            toStringOutput.Add($"RadiusGroup = {this.RadiusGroup ?? "null"}");
            toStringOutput.Add($"RadiusVendorAttrs = {(this.RadiusVendorAttrs == null ? "null" : $"[{string.Join(", ", this.RadiusVendorAttrs)} ]")}");
            toStringOutput.Add($"SessionTimeout = {(this.SessionTimeout == null ? "null" : this.SessionTimeout.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"UsernameAttr = {(this.UsernameAttr == null ? "null" : this.UsernameAttr.ToString())}");
            toStringOutput.Add($"Values = {(this.Values == null ? "null" : $"[{string.Join(", ", this.Values)} ]")}");
            toStringOutput.Add($"Vlan = {this.Vlan ?? "null"}");
        }
    }
}