﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Lab2b.com.lavasoft.wsgeoip {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GeoIPServiceSoap", Namespace="http://lavasoft.com/")]
    public partial class GeoIPService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetIpLocationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetIpLocation_2_0OperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLocationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCountryISO2ByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCountryNameByISO2OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GeoIPService() {
            this.Url = global::Lab2b.Properties.Settings.Default.Lab2b_com_lavasoft_wsgeoip_GeoIPService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetIpLocationCompletedEventHandler GetIpLocationCompleted;
        
        /// <remarks/>
        public event GetIpLocation_2_0CompletedEventHandler GetIpLocation_2_0Completed;
        
        /// <remarks/>
        public event GetLocationCompletedEventHandler GetLocationCompleted;
        
        /// <remarks/>
        public event GetCountryISO2ByNameCompletedEventHandler GetCountryISO2ByNameCompleted;
        
        /// <remarks/>
        public event GetCountryNameByISO2CompletedEventHandler GetCountryNameByISO2Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://lavasoft.com/GetIpLocation", RequestNamespace="http://lavasoft.com/", ResponseNamespace="http://lavasoft.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIpLocation(string sIp) {
            object[] results = this.Invoke("GetIpLocation", new object[] {
                        sIp});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetIpLocationAsync(string sIp) {
            this.GetIpLocationAsync(sIp, null);
        }
        
        /// <remarks/>
        public void GetIpLocationAsync(string sIp, object userState) {
            if ((this.GetIpLocationOperationCompleted == null)) {
                this.GetIpLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIpLocationOperationCompleted);
            }
            this.InvokeAsync("GetIpLocation", new object[] {
                        sIp}, this.GetIpLocationOperationCompleted, userState);
        }
        
        private void OnGetIpLocationOperationCompleted(object arg) {
            if ((this.GetIpLocationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIpLocationCompleted(this, new GetIpLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://lavasoft.com/GetIpLocation_2_0", RequestNamespace="http://lavasoft.com/", ResponseNamespace="http://lavasoft.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIpLocation_2_0(string sIp) {
            object[] results = this.Invoke("GetIpLocation_2_0", new object[] {
                        sIp});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetIpLocation_2_0Async(string sIp) {
            this.GetIpLocation_2_0Async(sIp, null);
        }
        
        /// <remarks/>
        public void GetIpLocation_2_0Async(string sIp, object userState) {
            if ((this.GetIpLocation_2_0OperationCompleted == null)) {
                this.GetIpLocation_2_0OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIpLocation_2_0OperationCompleted);
            }
            this.InvokeAsync("GetIpLocation_2_0", new object[] {
                        sIp}, this.GetIpLocation_2_0OperationCompleted, userState);
        }
        
        private void OnGetIpLocation_2_0OperationCompleted(object arg) {
            if ((this.GetIpLocation_2_0Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIpLocation_2_0Completed(this, new GetIpLocation_2_0CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://lavasoft.com/GetLocation", RequestNamespace="http://lavasoft.com/", ResponseNamespace="http://lavasoft.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetLocation() {
            object[] results = this.Invoke("GetLocation", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetLocationAsync() {
            this.GetLocationAsync(null);
        }
        
        /// <remarks/>
        public void GetLocationAsync(object userState) {
            if ((this.GetLocationOperationCompleted == null)) {
                this.GetLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLocationOperationCompleted);
            }
            this.InvokeAsync("GetLocation", new object[0], this.GetLocationOperationCompleted, userState);
        }
        
        private void OnGetLocationOperationCompleted(object arg) {
            if ((this.GetLocationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLocationCompleted(this, new GetLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://lavasoft.com/GetCountryISO2ByName", RequestNamespace="http://lavasoft.com/", ResponseNamespace="http://lavasoft.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCountryISO2ByName(string countryName) {
            object[] results = this.Invoke("GetCountryISO2ByName", new object[] {
                        countryName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCountryISO2ByNameAsync(string countryName) {
            this.GetCountryISO2ByNameAsync(countryName, null);
        }
        
        /// <remarks/>
        public void GetCountryISO2ByNameAsync(string countryName, object userState) {
            if ((this.GetCountryISO2ByNameOperationCompleted == null)) {
                this.GetCountryISO2ByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCountryISO2ByNameOperationCompleted);
            }
            this.InvokeAsync("GetCountryISO2ByName", new object[] {
                        countryName}, this.GetCountryISO2ByNameOperationCompleted, userState);
        }
        
        private void OnGetCountryISO2ByNameOperationCompleted(object arg) {
            if ((this.GetCountryISO2ByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCountryISO2ByNameCompleted(this, new GetCountryISO2ByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://lavasoft.com/GetCountryNameByISO2", RequestNamespace="http://lavasoft.com/", ResponseNamespace="http://lavasoft.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCountryNameByISO2(string iso2Code) {
            object[] results = this.Invoke("GetCountryNameByISO2", new object[] {
                        iso2Code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCountryNameByISO2Async(string iso2Code) {
            this.GetCountryNameByISO2Async(iso2Code, null);
        }
        
        /// <remarks/>
        public void GetCountryNameByISO2Async(string iso2Code, object userState) {
            if ((this.GetCountryNameByISO2OperationCompleted == null)) {
                this.GetCountryNameByISO2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCountryNameByISO2OperationCompleted);
            }
            this.InvokeAsync("GetCountryNameByISO2", new object[] {
                        iso2Code}, this.GetCountryNameByISO2OperationCompleted, userState);
        }
        
        private void OnGetCountryNameByISO2OperationCompleted(object arg) {
            if ((this.GetCountryNameByISO2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCountryNameByISO2Completed(this, new GetCountryNameByISO2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetIpLocationCompletedEventHandler(object sender, GetIpLocationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIpLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetIpLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetIpLocation_2_0CompletedEventHandler(object sender, GetIpLocation_2_0CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIpLocation_2_0CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetIpLocation_2_0CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetLocationCompletedEventHandler(object sender, GetLocationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetCountryISO2ByNameCompletedEventHandler(object sender, GetCountryISO2ByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCountryISO2ByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCountryISO2ByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetCountryNameByISO2CompletedEventHandler(object sender, GetCountryNameByISO2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCountryNameByISO2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCountryNameByISO2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591