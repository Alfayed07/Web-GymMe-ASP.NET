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

namespace WebApplicationFront1.WebService {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback registerNewUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback loginOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback getSupplementListOperationCompleted;
        
        private System.Threading.SendOrPostCallback createNewSupplementOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateSupplementOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteSupplementOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCartListOperationCompleted;
        
        private System.Threading.SendOrPostCallback addNewCartOperationCompleted;
        
        private System.Threading.SendOrPostCallback clearCartOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService() {
            this.Url = global::WebApplicationFront1.Properties.Settings.Default.WebApplicationFront1_WebService_WebService;
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
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event registerNewUserCompletedEventHandler registerNewUserCompleted;
        
        /// <remarks/>
        public event loginCompletedEventHandler loginCompleted;
        
        /// <remarks/>
        public event getUserCompletedEventHandler getUserCompleted;
        
        /// <remarks/>
        public event getAllUserCompletedEventHandler getAllUserCompleted;
        
        /// <remarks/>
        public event getSupplementListCompletedEventHandler getSupplementListCompleted;
        
        /// <remarks/>
        public event createNewSupplementCompletedEventHandler createNewSupplementCompleted;
        
        /// <remarks/>
        public event updateSupplementCompletedEventHandler updateSupplementCompleted;
        
        /// <remarks/>
        public event deleteSupplementCompletedEventHandler deleteSupplementCompleted;
        
        /// <remarks/>
        public event getCartListCompletedEventHandler getCartListCompleted;
        
        /// <remarks/>
        public event addNewCartCompletedEventHandler addNewCartCompleted;
        
        /// <remarks/>
        public event clearCartCompletedEventHandler clearCartCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/registerNewUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void registerNewUser(string username, string email, string password, System.DateTime DOB, string gender, string role) {
            this.Invoke("registerNewUser", new object[] {
                        username,
                        email,
                        password,
                        DOB,
                        gender,
                        role});
        }
        
        /// <remarks/>
        public void registerNewUserAsync(string username, string email, string password, System.DateTime DOB, string gender, string role) {
            this.registerNewUserAsync(username, email, password, DOB, gender, role, null);
        }
        
        /// <remarks/>
        public void registerNewUserAsync(string username, string email, string password, System.DateTime DOB, string gender, string role, object userState) {
            if ((this.registerNewUserOperationCompleted == null)) {
                this.registerNewUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregisterNewUserOperationCompleted);
            }
            this.InvokeAsync("registerNewUser", new object[] {
                        username,
                        email,
                        password,
                        DOB,
                        gender,
                        role}, this.registerNewUserOperationCompleted, userState);
        }
        
        private void OnregisterNewUserOperationCompleted(object arg) {
            if ((this.registerNewUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registerNewUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string login(string username, string password) {
            object[] results = this.Invoke("login", new object[] {
                        username,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void loginAsync(string username, string password) {
            this.loginAsync(username, password, null);
        }
        
        /// <remarks/>
        public void loginAsync(string username, string password, object userState) {
            if ((this.loginOperationCompleted == null)) {
                this.loginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloginOperationCompleted);
            }
            this.InvokeAsync("login", new object[] {
                        username,
                        password}, this.loginOperationCompleted, userState);
        }
        
        private void OnloginOperationCompleted(object arg) {
            if ((this.loginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loginCompleted(this, new loginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getUser(string username) {
            object[] results = this.Invoke("getUser", new object[] {
                        username});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUserAsync(string username) {
            this.getUserAsync(username, null);
        }
        
        /// <remarks/>
        public void getUserAsync(string username, object userState) {
            if ((this.getUserOperationCompleted == null)) {
                this.getUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUserOperationCompleted);
            }
            this.InvokeAsync("getUser", new object[] {
                        username}, this.getUserOperationCompleted, userState);
        }
        
        private void OngetUserOperationCompleted(object arg) {
            if ((this.getUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUserCompleted(this, new getUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllUser() {
            object[] results = this.Invoke("getAllUser", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllUserAsync() {
            this.getAllUserAsync(null);
        }
        
        /// <remarks/>
        public void getAllUserAsync(object userState) {
            if ((this.getAllUserOperationCompleted == null)) {
                this.getAllUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllUserOperationCompleted);
            }
            this.InvokeAsync("getAllUser", new object[0], this.getAllUserOperationCompleted, userState);
        }
        
        private void OngetAllUserOperationCompleted(object arg) {
            if ((this.getAllUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllUserCompleted(this, new getAllUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getSupplementList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getSupplementList() {
            object[] results = this.Invoke("getSupplementList", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getSupplementListAsync() {
            this.getSupplementListAsync(null);
        }
        
        /// <remarks/>
        public void getSupplementListAsync(object userState) {
            if ((this.getSupplementListOperationCompleted == null)) {
                this.getSupplementListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetSupplementListOperationCompleted);
            }
            this.InvokeAsync("getSupplementList", new object[0], this.getSupplementListOperationCompleted, userState);
        }
        
        private void OngetSupplementListOperationCompleted(object arg) {
            if ((this.getSupplementListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getSupplementListCompleted(this, new getSupplementListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/createNewSupplement", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void createNewSupplement(string name, System.DateTime date, int price, int TypeId) {
            this.Invoke("createNewSupplement", new object[] {
                        name,
                        date,
                        price,
                        TypeId});
        }
        
        /// <remarks/>
        public void createNewSupplementAsync(string name, System.DateTime date, int price, int TypeId) {
            this.createNewSupplementAsync(name, date, price, TypeId, null);
        }
        
        /// <remarks/>
        public void createNewSupplementAsync(string name, System.DateTime date, int price, int TypeId, object userState) {
            if ((this.createNewSupplementOperationCompleted == null)) {
                this.createNewSupplementOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateNewSupplementOperationCompleted);
            }
            this.InvokeAsync("createNewSupplement", new object[] {
                        name,
                        date,
                        price,
                        TypeId}, this.createNewSupplementOperationCompleted, userState);
        }
        
        private void OncreateNewSupplementOperationCompleted(object arg) {
            if ((this.createNewSupplementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createNewSupplementCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateSupplement", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateSupplement(int supplementId, string name, System.DateTime date, int price, int TypeId) {
            this.Invoke("updateSupplement", new object[] {
                        supplementId,
                        name,
                        date,
                        price,
                        TypeId});
        }
        
        /// <remarks/>
        public void updateSupplementAsync(int supplementId, string name, System.DateTime date, int price, int TypeId) {
            this.updateSupplementAsync(supplementId, name, date, price, TypeId, null);
        }
        
        /// <remarks/>
        public void updateSupplementAsync(int supplementId, string name, System.DateTime date, int price, int TypeId, object userState) {
            if ((this.updateSupplementOperationCompleted == null)) {
                this.updateSupplementOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateSupplementOperationCompleted);
            }
            this.InvokeAsync("updateSupplement", new object[] {
                        supplementId,
                        name,
                        date,
                        price,
                        TypeId}, this.updateSupplementOperationCompleted, userState);
        }
        
        private void OnupdateSupplementOperationCompleted(object arg) {
            if ((this.updateSupplementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateSupplementCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteSupplement", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void deleteSupplement(int supplementId) {
            this.Invoke("deleteSupplement", new object[] {
                        supplementId});
        }
        
        /// <remarks/>
        public void deleteSupplementAsync(int supplementId) {
            this.deleteSupplementAsync(supplementId, null);
        }
        
        /// <remarks/>
        public void deleteSupplementAsync(int supplementId, object userState) {
            if ((this.deleteSupplementOperationCompleted == null)) {
                this.deleteSupplementOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteSupplementOperationCompleted);
            }
            this.InvokeAsync("deleteSupplement", new object[] {
                        supplementId}, this.deleteSupplementOperationCompleted, userState);
        }
        
        private void OndeleteSupplementOperationCompleted(object arg) {
            if ((this.deleteSupplementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteSupplementCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCartList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCartList(int id) {
            object[] results = this.Invoke("getCartList", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCartListAsync(int id) {
            this.getCartListAsync(id, null);
        }
        
        /// <remarks/>
        public void getCartListAsync(int id, object userState) {
            if ((this.getCartListOperationCompleted == null)) {
                this.getCartListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCartListOperationCompleted);
            }
            this.InvokeAsync("getCartList", new object[] {
                        id}, this.getCartListOperationCompleted, userState);
        }
        
        private void OngetCartListOperationCompleted(object arg) {
            if ((this.getCartListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCartListCompleted(this, new getCartListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addNewCart", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addNewCart(int userId, int supplementId, int quantity) {
            this.Invoke("addNewCart", new object[] {
                        userId,
                        supplementId,
                        quantity});
        }
        
        /// <remarks/>
        public void addNewCartAsync(int userId, int supplementId, int quantity) {
            this.addNewCartAsync(userId, supplementId, quantity, null);
        }
        
        /// <remarks/>
        public void addNewCartAsync(int userId, int supplementId, int quantity, object userState) {
            if ((this.addNewCartOperationCompleted == null)) {
                this.addNewCartOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddNewCartOperationCompleted);
            }
            this.InvokeAsync("addNewCart", new object[] {
                        userId,
                        supplementId,
                        quantity}, this.addNewCartOperationCompleted, userState);
        }
        
        private void OnaddNewCartOperationCompleted(object arg) {
            if ((this.addNewCartCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addNewCartCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/clearCart", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void clearCart(int id) {
            this.Invoke("clearCart", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void clearCartAsync(int id) {
            this.clearCartAsync(id, null);
        }
        
        /// <remarks/>
        public void clearCartAsync(int id, object userState) {
            if ((this.clearCartOperationCompleted == null)) {
                this.clearCartOperationCompleted = new System.Threading.SendOrPostCallback(this.OnclearCartOperationCompleted);
            }
            this.InvokeAsync("clearCart", new object[] {
                        id}, this.clearCartOperationCompleted, userState);
        }
        
        private void OnclearCartOperationCompleted(object arg) {
            if ((this.clearCartCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.clearCartCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void registerNewUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void loginCompletedEventHandler(object sender, loginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal loginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void getUserCompletedEventHandler(object sender, getUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void getAllUserCompletedEventHandler(object sender, getAllUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void getSupplementListCompletedEventHandler(object sender, getSupplementListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getSupplementListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getSupplementListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void createNewSupplementCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void updateSupplementCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void deleteSupplementCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void getCartListCompletedEventHandler(object sender, getCartListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCartListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCartListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void addNewCartCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void clearCartCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591