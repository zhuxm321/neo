﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntShares.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7630401")]
        public uint Magic {
            get {
                return ((uint)(this["Magic"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("23")]
        public byte CoinVersion {
            get {
                return ((byte)(this["CoinVersion"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>03b209fd4f53a7170ea4444e0cb0a6bb6a53c2bd016926989cf85f9b0fba17a70c</string>
  <string>02df48f60e8f3e01c48ff40b9b7f1310d7a8b2a193188befe1c2e3df740e895093</string>
  <string>03b8d9d5771d8f513aa0869b9cc8d50986403b78c6da36890638c3d46a5adce04a</string>
  <string>02ca0e27697b9c248f6f16e085fd0061e26f44da85b58ee835c110caa5ec3ba554</string>
  <string>024c7b7fb6c310fccf1ba33b082519d82964ea93868d676662d4a59ad548df0e7d</string>
  <string>02aaec38470f6aad0042c6e877cfd8087d2676b0f516fddd362801b9bd3936399e</string>
  <string>02486fd15702c4490a26703112a5cc1d0923fd697a33406bd5a1c00e0013b09a70</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection StandbyMiners {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["StandbyMiners"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>seed1.antshares.org:10333</string>
  <string>seed2.antshares.org:10333</string>
  <string>seed3.antshares.org:10333</string>
  <string>seed4.antshares.org:10333</string>
  <string>seed5.antshares.org:10333</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SeedList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SeedList"]));
            }
        }
    }
}