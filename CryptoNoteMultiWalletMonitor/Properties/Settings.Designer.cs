﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CryptoNoteMultiWalletMonitor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal AutoTransferredSoFar {
            get {
                return ((decimal)(this["AutoTransferredSoFar"]));
            }
            set {
                this["AutoTransferredSoFar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\")]
        public string WalletDirectory {
            get {
                return ((string)(this["WalletDirectory"]));
            }
            set {
                this["WalletDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\")]
        public string CryptoNoteDirectory {
            get {
                return ((string)(this["CryptoNoteDirectory"]));
            }
            set {
                this["CryptoNoteDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.bin")]
        public string WalletFilter {
            get {
                return ((string)(this["WalletFilter"]));
            }
            set {
                this["WalletFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("simplewallet.exe")]
        public string WalletCommand {
            get {
                return ((string)(this["WalletCommand"]));
            }
            set {
                this["WalletCommand"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(\\s*|^)balance:\\s*(?<Balance>\\d*(.)?\\d*),\\s*unlocked\\s*balance:\\s*(?<UnlockedBala" +
            "nce>\\d*(.)?\\d*)$")]
        public string RegexBalanceMatch {
            get {
                return ((string)(this["RegexBalanceMatch"]));
            }
            set {
                this["RegexBalanceMatch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public decimal AutoTransferMinimum {
            get {
                return ((decimal)(this["AutoTransferMinimum"]));
            }
            set {
                this["AutoTransferMinimum"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.005")]
        public decimal AutoTransferFee {
            get {
                return ((decimal)(this["AutoTransferFee"]));
            }
            set {
                this["AutoTransferFee"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AutoTransferPaymentID {
            get {
                return ((string)(this["AutoTransferPaymentID"]));
            }
            set {
                this["AutoTransferPaymentID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AutoTransferAddress {
            get {
                return ((string)(this["AutoTransferAddress"]));
            }
            set {
                this["AutoTransferAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint AutoTransferMixInCount {
            get {
                return ((uint)(this["AutoTransferMixInCount"]));
            }
            set {
                this["AutoTransferMixInCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public uint RefreshIntervalSeconds {
            get {
                return ((uint)(this["RefreshIntervalSeconds"]));
            }
            set {
                this["RefreshIntervalSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingsUpgradeRequired {
            get {
                return ((bool)(this["SettingsUpgradeRequired"]));
            }
            set {
                this["SettingsUpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("240")]
        public uint AutoTransferPauseTimeSeconds {
            get {
                return ((uint)(this["AutoTransferPauseTimeSeconds"]));
            }
            set {
                this["AutoTransferPauseTimeSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoTransferEnabled {
            get {
                return ((bool)(this["AutoTransferEnabled"]));
            }
            set {
                this["AutoTransferEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\s+spent\\s+")]
        public string RegexSpentMatch {
            get {
                return ((string)(this["RegexSpentMatch"]));
            }
            set {
                this["RegexSpentMatch"] = value;
            }
        }
    }
}
