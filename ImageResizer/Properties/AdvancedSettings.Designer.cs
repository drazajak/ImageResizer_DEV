﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BriceLambson.ImageResizer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class AdvancedSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AdvancedSettings defaultInstance = ((AdvancedSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AdvancedSettings())));
        
        public static AdvancedSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Stable")]
        public global::BriceLambson.ImageResizer.Models.UpdateFilter UpdateFilter {
            get {
                return ((global::BriceLambson.ImageResizer.Models.UpdateFilter)(this["UpdateFilter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://imageresizer.azurewebsites.net/releases.xml")]
        public string UpdateUrl {
            get {
                return ((string)(this["UpdateUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckForUpdates {
            get {
                return ((bool)(this["CheckForUpdates"]));
            }
            set {
                this["CheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<ArrayOfResizeSize>
  <ResizeSize>
    <Name>$Small$</Name>
    <Mode>Scale</Mode>
    <Width>854</Width>
    <Height>480</Height>
    <Unit>Pixels</Unit>
  </ResizeSize>
  <ResizeSize>
    <Name>$Medium$</Name>
    <Mode>Scale</Mode>
    <Width>1366</Width>
    <Height>768</Height>
    <Unit>Pixels</Unit>
  </ResizeSize>
  <ResizeSize>
    <Name>$Large$</Name>
    <Mode>Scale</Mode>
    <Width>1920</Width>
    <Height>1080</Height>
    <Unit>Pixels</Unit>
  </ResizeSize>
  <ResizeSize>
    <Name>$Mobile$</Name>
    <Mode>Scale</Mode>
    <Width>320</Width>
    <Height>480</Height>
    <Unit>Pixels</Unit>
  </ResizeSize>
</ArrayOfResizeSize>")]
        public global::System.Collections.Generic.List<BriceLambson.ImageResizer.Models.ResizeSize> DefaultSizes {
            get {
                return ((global::System.Collections.Generic.List<BriceLambson.ImageResizer.Models.ResizeSize>)(this["DefaultSizes"]));
            }
            set {
                this["DefaultSizes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0} ({1})")]
        public string FileNameFormat {
            get {
                return ((string)(this["FileNameFormat"]));
            }
            set {
                this["FileNameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("75")]
        public int QualityLevel {
            get {
                return ((int)(this["QualityLevel"]));
            }
            set {
                this["QualityLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
    }
}
