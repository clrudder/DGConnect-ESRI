﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aggregation_Unit_Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aggregation_Unit_Tests.TestResources", typeof(TestResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;responseDate&quot;:&quot;2015-10-27T16:51:17Z&quot;,&quot;geom&quot;:{&quot;coordinates&quot;:[[[36.0,35.0],[36.0,35.25],[36.44,35.25],[36.44,35.0],[36.0,35.0]]],&quot;type&quot;:&quot;Polygon&quot;},&quot;query&quot;:null,&quot;startDate&quot;:null,&quot;endDate&quot;:null,&quot;totalItems&quot;:4499,&quot;aggregations&quot;:[{&quot;name&quot;:&quot;geohash:4&quot;,&quot;terms&quot;:[{&quot;term&quot;:&quot;sy1z&quot;,&quot;count&quot;:1619,&quot;aggregations&quot;:[{&quot;name&quot;:&quot;terms:ingest_source&quot;,&quot;terms&quot;:[{&quot;term&quot;:&quot;HGIS&quot;,&quot;count&quot;:1024,&quot;aggregations&quot;:[{&quot;name&quot;:&quot;terms:item_type&quot;,&quot;terms&quot;:[{&quot;term&quot;:&quot;Cropland&quot;,&quot;count&quot;:487,&quot;aggregations&quot;:null},{&quot;term&quot;:&quot;GNDB&quot;,&quot;count&quot;:346,&quot;aggregations&quot;:n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string doubleAggregation {
            get {
                return ResourceManager.GetString("doubleAggregation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;responseDate&quot;: &quot;2015-09-09T13:32:57Z&quot;,
        ///  &quot;geom&quot;: {
        ///    &quot;coordinates&quot;: [[ 
        ///      [ -180, -90 ], [ -180, 90 ], [ 180, 90 ], [ 180, -90 ], [ -180, -90 ]
        ///    ]],
        ///    &quot;type&quot;: &quot;Polygon&quot;
        ///  },
        ///  &quot;query&quot;: &quot;item_type:tweet&quot;,
        ///  &quot;startDate&quot;: null,
        ///  &quot;endDate&quot;: null,
        ///  &quot;totalItems&quot;: 14424,
        ///  &quot;aggregations&quot;: [
        ///    {
        ///      &quot;name&quot;: &quot;geohash:4&quot;,
        ///      &quot;terms&quot;: [
        ///        {
        ///          &quot;term&quot;: &quot;sxk9&quot;,
        ///          &quot;count&quot;: 1365,
        ///          &quot;aggregations&quot;: [
        ///            {
        ///              &quot;name&quot;: &quot;date_hist:h&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MogJson {
            get {
                return ResourceManager.GetString("MogJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;responseDate&quot; : &quot;2015-10-13T21:04:28Z&quot;,&quot;geom&quot; : {&quot;coordinates&quot; : [[[-77.9457575318865, 0.326966219845797], [-77.9457575318865, 9.36891804200086], [-70.1411254327631, 9.36891804200086], [-70.1411254327631, 0.326966219845797], [-77.9457575318865, 0.326966219845797]]],&quot;type&quot; : &quot;Polygon&quot;},&quot;query&quot; : null,&quot;startDate&quot; : &quot;2015-10-06T00:00:00&quot;,&quot;endDate&quot; : &quot;2015-10-13T00:00:00&quot;,&quot;totalItems&quot; : 147817,&quot;aggregations&quot; : [{&quot;name&quot; : &quot;geohash:4&quot;,&quot;terms&quot; : [{&quot;term&quot; : &quot;d2g0&quot;,&quot;count&quot; : 56819,&quot;aggregations&quot; : [{&quot;name&quot; : &quot;avg: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string sentimentAggregation {
            get {
                return ResourceManager.GetString("sentimentAggregation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {[{&quot;term&quot; : &quot;Historical Twitter reprocess&quot;,&quot;count&quot; : 509,&quot;aggregations&quot; : null}, {&quot;term&quot; : &quot;Gnip&quot;,&quot;count&quot; : 93,&quot;aggregations&quot; : null}]}.
        /// </summary>
        internal static string TermList {
            get {
                return ResourceManager.GetString("TermList", resourceCulture);
            }
        }
    }
}
