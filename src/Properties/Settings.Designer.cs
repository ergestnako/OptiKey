﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JuliusSweetland.OptiKey.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Ins")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Windows.Forms.Keys SelectionTriggerKeyboardKeyDownUpKey {
            get {
                return ((global::System.Windows.Forms.Keys)(this["SelectionTriggerKeyboardKeyDownUpKey"]));
            }
            set {
                this["SelectionTriggerKeyboardKeyDownUpKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NextHigh")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.TriggerStopSignals MultiKeySelectionTriggerStopSignal {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.TriggerStopSignals)(this["MultiKeySelectionTriggerStopSignal"]));
            }
            set {
                this["MultiKeySelectionTriggerStopSignal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Left")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Windows.Forms.MouseButtons SelectionTriggerMouseDownUpButton {
            get {
                return ((global::System.Windows.Forms.MouseButtons)(this["SelectionTriggerMouseDownUpButton"]));
            }
            set {
                this["SelectionTriggerMouseDownUpButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fixations")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.TriggerSources KeySelectionTriggerSource {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.TriggerSources)(this["KeySelectionTriggerSource"]));
            }
            set {
                this["KeySelectionTriggerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
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
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.0130000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan PointsMousePositionSampleInterval {
            get {
                return ((global::System.TimeSpan)(this["PointsMousePositionSampleInterval"]));
            }
            set {
                this["PointsMousePositionSampleInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MousePosition")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.PointsSources PointsSource {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.PointsSources)(this["PointsSource"]));
            }
            set {
                this["PointsSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.1500000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan PointTtl {
            get {
                return ((global::System.TimeSpan)(this["PointTtl"]));
            }
            set {
                this["PointTtl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double PointSelectionTriggerFixationRadius {
            get {
                return ((double)(this["PointSelectionTriggerFixationRadius"]));
            }
            set {
                this["PointSelectionTriggerFixationRadius"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:01.5000000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan PointSelectionTriggerFixationCompleteTime {
            get {
                return ((global::System.TimeSpan)(this["PointSelectionTriggerFixationCompleteTime"]));
            }
            set {
                this["PointSelectionTriggerFixationCompleteTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6666")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int GazeTrackerUdpPort {
            get {
                return ((int)(this["GazeTrackerUdpPort"]));
            }
            set {
                this["GazeTrackerUdpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("^STREAM_DATA\\s(?<instanceTime>\\d+)\\s(?<x>-?\\d+(\\.[0-9]+)?)\\s(?<y>-?\\d+(\\.[0-9]+)?" +
            ")")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string GazeTrackerUdpRegex {
            get {
                return ((string)(this["GazeTrackerUdpRegex"]));
            }
            set {
                this["GazeTrackerUdpRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool MultiKeySelectionEnabled {
            get {
                return ((bool)(this["MultiKeySelectionEnabled"]));
            }
            set {
                this["MultiKeySelectionEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.0500000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan MultiKeySelectionFixationMinDwellTime {
            get {
                return ((global::System.TimeSpan)(this["MultiKeySelectionFixationMinDwellTime"]));
            }
            set {
                this["MultiKeySelectionFixationMinDwellTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int MultiKeySelectionMaxDictionaryMatches {
            get {
                return ((int)(this["MultiKeySelectionMaxDictionaryMatches"]));
            }
            set {
                this["MultiKeySelectionMaxDictionaryMatches"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:01:00")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan MultiKeySelectionMaxDuration {
            get {
                return ((global::System.TimeSpan)(this["MultiKeySelectionMaxDuration"]));
            }
            set {
                this["MultiKeySelectionMaxDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BritishEnglish")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.Languages Language {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.Languages)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:01.5000000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan KeySelectionTriggerFixationCompleteTime {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerFixationCompleteTime"]));
            }
            set {
                this["KeySelectionTriggerFixationCompleteTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("400")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double MainWindowHeight {
            get {
                return ((double)(this["MainWindowHeight"]));
            }
            set {
                this["MainWindowHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double MainWindowLeft {
            get {
                return ((double)(this["MainWindowLeft"]));
            }
            set {
                this["MainWindowLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Windows.WindowState MainWindowState {
            get {
                return ((global::System.Windows.WindowState)(this["MainWindowState"]));
            }
            set {
                this["MainWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double MainWindowTop {
            get {
                return ((double)(this["MainWindowTop"]));
            }
            set {
                this["MainWindowTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double MainWindowWidth {
            get {
                return ((double)(this["MainWindowWidth"]));
            }
            set {
                this["MainWindowWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationTitleFontSize {
            get {
                return ((int)(this["ToastNotificationTitleFontSize"]));
            }
            set {
                this["ToastNotificationTitleFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationContentFontSize {
            get {
                return ((int)(this["ToastNotificationContentFontSize"]));
            }
            set {
                this["ToastNotificationContentFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationCharactersPerLine {
            get {
                return ((int)(this["ToastNotificationCharactersPerLine"]));
            }
            set {
                this["ToastNotificationCharactersPerLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationSecondsPerLine {
            get {
                return ((int)(this["ToastNotificationSecondsPerLine"]));
            }
            set {
                this["ToastNotificationSecondsPerLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationAdditionalSeconds {
            get {
                return ((int)(this["ToastNotificationAdditionalSeconds"]));
            }
            set {
                this["ToastNotificationAdditionalSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool SimulateKeyStrokes {
            get {
                return ((bool)(this["SimulateKeyStrokes"]));
            }
            set {
                this["SimulateKeyStrokes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/Resources/Themes/Android_Dark.xaml")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string Theme {
            get {
                return ((string)(this["Theme"]));
            }
            set {
                this["Theme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool Debug {
            get {
                return ((bool)(this["Debug"]));
            }
            set {
                this["Debug"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/Resources/Fonts/#Roboto")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FontFamily {
            get {
                return ((string)(this["FontFamily"]));
            }
            set {
                this["FontFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Condensed")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FontStretch {
            get {
                return ((string)(this["FontStretch"]));
            }
            set {
                this["FontStretch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Light")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FontWeight {
            get {
                return ((string)(this["FontWeight"]));
            }
            set {
                this["FontWeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ScratchpadNumberOfLines {
            get {
                return ((int)(this["ScratchpadNumberOfLines"]));
            }
            set {
                this["ScratchpadNumberOfLines"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool AutoAddSpace {
            get {
                return ((bool)(this["AutoAddSpace"]));
            }
            set {
                this["AutoAddSpace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool AutoCapitalise {
            get {
                return ((bool)(this["AutoCapitalise"]));
            }
            set {
                this["AutoCapitalise"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int SpeechRate {
            get {
                return ((int)(this["SpeechRate"]));
            }
            set {
                this["SpeechRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string SpeechVoice {
            get {
                return ((string)(this["SpeechVoice"]));
            }
            set {
                this["SpeechVoice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int SpeechVolume {
            get {
                return ((int)(this["SpeechVolume"]));
            }
            set {
                this["SpeechVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\Error1.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string ErrorSoundFile {
            get {
                return ((string)(this["ErrorSoundFile"]));
            }
            set {
                this["ErrorSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\Info1.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string InfoSoundFile {
            get {
                return ((string)(this["InfoSoundFile"]));
            }
            set {
                this["InfoSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\Selection1.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string SelectionSoundFile {
            get {
                return ((string)(this["SelectionSoundFile"]));
            }
            set {
                this["SelectionSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\MultiKeyCaptureEnd1.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string MultiKeySelectionCaptureEndSoundFile {
            get {
                return ((string)(this["MultiKeySelectionCaptureEndSoundFile"]));
            }
            set {
                this["MultiKeySelectionCaptureEndSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\MultiKeyCaptureStart1.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string MultiKeySelectionCaptureStartSoundFile {
            get {
                return ((string)(this["MultiKeySelectionCaptureStartSoundFile"]));
            }
            set {
                this["MultiKeySelectionCaptureStartSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(?:\\s*)(([_a-zA-Z0-9-\\+]+(\\.[_a-zA-Z0-9-\\+]+)*@[a-zA-Z0-9-]+(\\.[a-zA-Z0-9-]+)*(\\." +
            "[a-zA-Z]{2,6}))|(([a-zA-Z]\\.){2,})|([a-zA-Z]+([\'-][a-zA-Z]+)*))(?:\\s*)")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string WordRegex {
            get {
                return ((string)(this["WordRegex"]));
            }
            set {
                this["WordRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fixations")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.TriggerSources PointSelectionTriggerSource {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.TriggerSources)(this["PointSelectionTriggerSource"]));
            }
            set {
                this["PointSelectionTriggerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Basic")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.UiComplexity UiComplexity {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.UiComplexity)(this["UiComplexity"]));
            }
            set {
                this["UiComplexity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.7500000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan KeySelectionTriggerIncompleteFixationTtl {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerIncompleteFixationTtl"]));
            }
            set {
                this["KeySelectionTriggerIncompleteFixationTtl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.1000000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan KeySelectionTriggerFixationLockOnTime {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerFixationLockOnTime"]));
            }
            set {
                this["KeySelectionTriggerFixationLockOnTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.1000000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan PointSelectionTriggerFixationLockOnTime {
            get {
                return ((global::System.TimeSpan)(this["PointSelectionTriggerFixationLockOnTime"]));
            }
            set {
                this["PointSelectionTriggerFixationLockOnTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeechOnly")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKey.Enums.KeyboardsSets KeyboardSet {
            get {
                return ((global::JuliusSweetland.OptiKey.Enums.KeyboardsSets)(this["KeyboardSet"]));
            }
            set {
                this["KeyboardSet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Windows.WindowState ManagementConsoleWindowState {
            get {
                return ((global::System.Windows.WindowState)(this["ManagementConsoleWindowState"]));
            }
            set {
                this["ManagementConsoleWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("400")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double ManagementConsoleWindowHeight {
            get {
                return ((double)(this["ManagementConsoleWindowHeight"]));
            }
            set {
                this["ManagementConsoleWindowHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double ManagementConsoleWindowLeft {
            get {
                return ((double)(this["ManagementConsoleWindowLeft"]));
            }
            set {
                this["ManagementConsoleWindowLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double ManagementConsoleWindowTop {
            get {
                return ((double)(this["ManagementConsoleWindowTop"]));
            }
            set {
                this["ManagementConsoleWindowTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public double ManagementConsoleWindowWidth {
            get {
                return ((double)(this["ManagementConsoleWindowWidth"]));
            }
            set {
                this["ManagementConsoleWindowWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int MoveAndResizeAdjustmentAmountInPixels {
            get {
                return ((int)(this["MoveAndResizeAdjustmentAmountInPixels"]));
            }
            set {
                this["MoveAndResizeAdjustmentAmountInPixels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NextHigh")]
        public string SelectionTriggerStopSignal {
            get {
                return ((string)(this["SelectionTriggerStopSignal"]));
            }
            set {
                this["SelectionTriggerStopSignal"] = value;
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
    }
}
