//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dgx {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "Dgx";
            }
        }
        
        internal static string AddInID {
            get {
                return "{47f66660-0e07-4a42-9717-c3bc379a2776}";
            }
        }
        
        internal static string Company {
            get {
                return "DigitalGlobe Inc.";
            }
        }
        
        internal static string Version {
            get {
                return "1.2";
            }
        }
        
        internal static string Description {
            get {
                return "Information and GBDX Platform is a DigitalGlobe product enabling social media, te" +
                    "xt, vector and raster search and analytics capabilities.";
            }
        }
        
        internal static string Author {
            get {
                return "DigitalGlobe Inc.";
            }
        }
        
        internal static string Date {
            get {
                return "11/13/2015";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_sma_rssPolygon', the id declared for Add-in Tool class 'RssPolygon'
            /// </summary>
            internal static string RssPolygon {
                get {
                    return "DigitalGlobe_Inc_sma_rssPolygon";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_sma_smaConfig', the id declared for Add-in Button class 'SmaConfig'
            /// </summary>
            internal static string SmaConfig {
                get {
                    return "DigitalGlobe_Inc_sma_smaConfig";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_sma_VectorIndex', the id declared for Add-in Tool class 'Dgx.Vector_Index.VectorIndex'
            /// </summary>
            internal static string Dgx_Vector_Index_VectorIndex {
                get {
                    return "DigitalGlobe_Inc_sma_VectorIndex";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_DgxAboutButton', the id declared for Add-in Button class 'Dgx.DgxAboutButton'
            /// </summary>
            internal static string Dgx_DgxAboutButton {
                get {
                    return "DigitalGlobe_Inc_Dgx_DgxAboutButton";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_VectorIndexButton', the id declared for Add-in Button class 'Dgx.Vector_Index.ESRI_Tools.VectorIndexButton'
            /// </summary>
            internal static string Dgx_Vector_Index_ESRI_Tools_VectorIndexButton {
                get {
                    return "DigitalGlobe_Inc_Dgx_VectorIndexButton";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_Selector', the id declared for Add-in Tool class 'Dgx.Gbd.Selector'
            /// </summary>
            internal static string Dgx_Gbd_Selector {
                get {
                    return "DigitalGlobe_Inc_Dgx_Selector";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_GbdButton', the id declared for Add-in Button class 'Dgx.Gbd.GbdButton'
            /// </summary>
            internal static string Dgx_Gbd_GbdButton {
                get {
                    return "DigitalGlobe_Inc_Dgx_GbdButton";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_AggregationButton', the id declared for Add-in Button class 'Dgx.Aggregations.AggregationButton'
            /// </summary>
            internal static string Dgx_Aggregations_AggregationButton {
                get {
                    return "DigitalGlobe_Inc_Dgx_AggregationButton";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_AggregationSelector', the id declared for Add-in Tool class 'Dgx.Aggregations.AggregationSelector'
            /// </summary>
            internal static string Dgx_Aggregations_AggregationSelector {
                get {
                    return "DigitalGlobe_Inc_Dgx_AggregationSelector";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_VectorIndexDockable', the id declared for Add-in DockableWindow class 'Dgx.Vector_Index.Forms.VectorIndexDockable+AddinImpl'
            /// </summary>
            internal static string Dgx_Vector_Index_Forms_VectorIndexDockable {
                get {
                    return "DigitalGlobe_Inc_Dgx_VectorIndexDockable";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_GbdDockableWindow', the id declared for Add-in DockableWindow class 'Dgx.Gbd.GbdDockableWindow+AddinImpl'
            /// </summary>
            internal static string Dgx_Gbd_GbdDockableWindow {
                get {
                    return "DigitalGlobe_Inc_Dgx_GbdDockableWindow";
                }
            }
            
            /// <summary>
            /// Returns 'DigitalGlobe_Inc_Dgx_AggregationWindow', the id declared for Add-in DockableWindow class 'Dgx.Aggregations.AggregationWindow+AddinImpl'
            /// </summary>
            internal static string Dgx_Aggregations_AggregationWindow {
                get {
                    return "DigitalGlobe_Inc_Dgx_AggregationWindow";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
