﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Purchasing
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, AccountNumber={AccountNumber}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class Vendor : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Purchasing.Vendor>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Purchasing.Vendor>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private string _accountNumber = default(string);
        
        private string _name = default(string);
        
        private byte _creditRating = CodeFluentPersistence.DefaultByteValue;
        
        private bool _preferredVendorStatus = true;
        
        private bool _activeFlag = true;
        
        private string _purchasingWebServiceURL = default(string);
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private int _businessEntityBusinessEntityID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Person.BusinessEntity _businessEntity = null;
        
        public Vendor()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                object[] keys = new object[] {
                        this.BusinessEntityBusinessEntityID};
                string v = CodeFluentPersistence.BuildEntityKey(keys);
                return v;
            }
            set
            {
                System.Type[] types = new System.Type[] {
                        typeof(int)};
                object[] defaultValues = new object[] {
                        -1};
                object[] v1 = CodeFluentPersistence.ParseEntityKey(value, types, defaultValues);
                this.BusinessEntityBusinessEntityID = ((int)(v1[0]));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.AccountNumber;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
            set
            {
                this._accountNumber = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("AccountNumber"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Name"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultByteValue)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(byte))]
        public byte CreditRating
        {
            get
            {
                return this._creditRating;
            }
            set
            {
                this._creditRating = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("CreditRating"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((bool)(true)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(bool))]
        public bool PreferredVendorStatus
        {
            get
            {
                return this._preferredVendorStatus;
            }
            set
            {
                this._preferredVendorStatus = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("PreferredVendorStatus"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((bool)(true)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(bool))]
        public bool ActiveFlag
        {
            get
            {
                return this._activeFlag;
            }
            set
            {
                this._activeFlag = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ActiveFlag"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string PurchasingWebServiceURL
        {
            get
            {
                return this._purchasingWebServiceURL;
            }
            set
            {
                this._purchasingWebServiceURL = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("PurchasingWebServiceURL"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                this._modifiedDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ModifiedDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int BusinessEntityBusinessEntityID
        {
            get
            {
                if (((this._businessEntityBusinessEntityID == -1) 
                            && (this._businessEntity != null)))
                {
                    this._businessEntityBusinessEntityID = this._businessEntity.BusinessEntityID;
                }
                return this._businessEntityBusinessEntityID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.BusinessEntityBusinessEntityID) == true))
                {
                    return;
                }
                this._businessEntity = null;
                this._businessEntityBusinessEntityID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("BusinessEntity"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("BusinessEntityBusinessEntityID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Person.BusinessEntity BusinessEntity
        {
            get
            {
                if ((this._businessEntity == null))
                {
                    this._businessEntity = CodeFluentEntities.Bencher.Person.BusinessEntity.Load(this._businessEntityBusinessEntityID);
                }
                return this._businessEntity;
            }
            set
            {
                this._businessEntityBusinessEntityID = -1;
                this._businessEntity = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("BusinessEntity"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("BusinessEntityBusinessEntityID"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Purchasing.Vendor vendor)
        {
            if ((vendor == null))
            {
                return false;
            }
            if ((this.BusinessEntityBusinessEntityID == -1))
            {
                return base.Equals(vendor);
            }
            return (this.BusinessEntityBusinessEntityID.Equals(vendor.BusinessEntityBusinessEntityID) == true);
        }
        
        public override int GetHashCode()
        {
            if ((this.EntityKey == null))
            {
                return base.GetHashCode();
            }
            return this.EntityKey.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Purchasing.Vendor vendor = null;
			vendor = obj as CodeFluentEntities.Bencher.Purchasing.Vendor;
            return this.Equals(vendor);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Purchasing.Vendor vendor = null;
vendor = value as CodeFluentEntities.Bencher.Purchasing.Vendor;
            if ((vendor == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(vendor);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Purchasing.Vendor vendor)
        {
            if ((vendor == null))
            {
                throw new System.ArgumentNullException("vendor");
            }
            int localCompareTo = this.BusinessEntity.CompareTo(vendor.BusinessEntity);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Purchasing.Vendor.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Purchasing.Vendor\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Purchasing", "Vendor", "Delete");
            persistence.AddRawParameter("@BusinessEntityID", this.BusinessEntityBusinessEntityID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._accountNumber = CodeFluentPersistence.GetReaderValue(reader, "AccountNumber", ((string)(default(string))));
                this._name = CodeFluentPersistence.GetReaderValue(reader, "Name", ((string)(default(string))));
                this._creditRating = CodeFluentPersistence.GetReaderValue(reader, "CreditRating", ((byte)(CodeFluentPersistence.DefaultByteValue)));
                this._preferredVendorStatus = CodeFluentPersistence.GetReaderValue(reader, "PreferredVendorStatus", ((bool)(true)));
                this._activeFlag = CodeFluentPersistence.GetReaderValue(reader, "ActiveFlag", ((bool)(true)));
                this._purchasingWebServiceURL = CodeFluentPersistence.GetReaderValue(reader, "PurchasingWebServiceURL", ((string)(default(string))));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.BusinessEntityBusinessEntityID = CodeFluentPersistence.GetReaderValue(reader, "BusinessEntityID", ((int)(-1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Purchasing.Vendor Load(int businessEntityBusinessEntityID)
        {
            if ((businessEntityBusinessEntityID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Purchasing.Vendor vendor = new CodeFluentEntities.Bencher.Purchasing.Vendor();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Purchasing", "Vendor", "Load");
            persistence.AddRawParameter("@BusinessEntityBusinessEntityID", businessEntityBusinessEntityID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    vendor.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    vendor.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return vendor;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.BusinessEntityBusinessEntityID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Purchasing", "Vendor", "Load");
            persistence.AddRawParameter("@BusinessEntityBusinessEntityID", this.BusinessEntityBusinessEntityID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Purchasing", "Vendor", "Save");
            persistence.AddRawParameter("@BusinessEntityID", this.BusinessEntityBusinessEntityID);
            persistence.AddRawParameter("@AccountNumber", this.AccountNumber);
            persistence.AddRawParameter("@Name", this.Name);
            persistence.AddRawParameter("@CreditRating", this.CreditRating);
            persistence.AddRawParameter("@PreferredVendorStatus", this.PreferredVendorStatus);
            persistence.AddRawParameter("@ActiveFlag", this.ActiveFlag);
            persistence.AddRawParameter("@PurchasingWebServiceURL", this.PurchasingWebServiceURL);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Purchasing.Vendor vendor)
        {
            if ((vendor == null))
            {
                return false;
            }
            bool ret = vendor.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Purchasing.Vendor vendor)
        {
            bool ret = CodeFluentEntities.Bencher.Purchasing.Vendor.Save(vendor);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Purchasing.Vendor vendor)
        {
            if ((vendor == null))
            {
                return false;
            }
            bool ret = vendor.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("AccountNumber=");
            writer.Write(this.AccountNumber);
            writer.Write(",");
            writer.Write("Name=");
            writer.Write(this.Name);
            writer.Write(",");
            writer.Write("CreditRating=");
            writer.Write(this.CreditRating);
            writer.Write(",");
            writer.Write("PreferredVendorStatus=");
            writer.Write(this.PreferredVendorStatus);
            writer.Write(",");
            writer.Write("ActiveFlag=");
            writer.Write(this.ActiveFlag);
            writer.Write(",");
            writer.Write("PurchasingWebServiceURL=");
            writer.Write(this.PurchasingWebServiceURL);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("BusinessEntity=");
            if ((this._businessEntity != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._businessEntity)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_businessEntityBusinessEntityID=");
            writer.Write(this._businessEntityBusinessEntityID);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Purchasing.Vendor LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Purchasing.Vendor vendor;
            System.Type[] types = new System.Type[] {
                    typeof(int)};
            object[] defaultValues = new object[] {
                    -1};
            object[] v = CodeFluentPersistence.ParseEntityKey(key, types, defaultValues);
            int var0;
            var0 = ((int)(v[0]));
            vendor = CodeFluentEntities.Bencher.Purchasing.Vendor.Load(var0);
            return vendor;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Purchasing.Vendor Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Purchasing.Vendor vendor = new CodeFluentEntities.Bencher.Purchasing.Vendor();
            this.CopyTo(vendor, deep);
            return vendor;
        }
        
        public CodeFluentEntities.Bencher.Purchasing.Vendor Clone()
        {
            CodeFluentEntities.Bencher.Purchasing.Vendor localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("BusinessEntityBusinessEntityID") == true))
            {
                this.BusinessEntityBusinessEntityID = ((int)(ConvertUtilities.ChangeType(dict["BusinessEntityBusinessEntityID"], typeof(int), -1)));
            }
            if ((dict.Contains("PurchasingWebServiceURL") == true))
            {
                this.PurchasingWebServiceURL = ((string)(ConvertUtilities.ChangeType(dict["PurchasingWebServiceURL"], typeof(string), default(string))));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("AccountNumber") == true))
            {
                this.AccountNumber = ((string)(ConvertUtilities.ChangeType(dict["AccountNumber"], typeof(string), default(string))));
            }
            if ((dict.Contains("ActiveFlag") == true))
            {
                this.ActiveFlag = ((bool)(ConvertUtilities.ChangeType(dict["ActiveFlag"], typeof(bool), true)));
            }
            if ((dict.Contains("Name") == true))
            {
                this.Name = ((string)(ConvertUtilities.ChangeType(dict["Name"], typeof(string), default(string))));
            }
            if ((dict.Contains("CreditRating") == true))
            {
                this.CreditRating = ((byte)(ConvertUtilities.ChangeType(dict["CreditRating"], typeof(byte), CodeFluentPersistence.DefaultByteValue)));
            }
            if ((dict.Contains("PreferredVendorStatus") == true))
            {
                this.PreferredVendorStatus = ((bool)(ConvertUtilities.ChangeType(dict["PreferredVendorStatus"], typeof(bool), true)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Purchasing.Vendor vendor, bool deep)
        {
            if ((vendor == null))
            {
                throw new System.ArgumentNullException("vendor");
            }
            vendor.BusinessEntityBusinessEntityID = this.BusinessEntityBusinessEntityID;
            vendor.PurchasingWebServiceURL = this.PurchasingWebServiceURL;
            vendor.ModifiedDate = this.ModifiedDate;
            vendor.AccountNumber = this.AccountNumber;
            vendor.ActiveFlag = this.ActiveFlag;
            vendor.Name = this.Name;
            vendor.CreditRating = this.CreditRating;
            vendor.PreferredVendorStatus = this.PreferredVendorStatus;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, vendor));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["BusinessEntityBusinessEntityID"] = this.BusinessEntityBusinessEntityID;
            dict["PurchasingWebServiceURL"] = this.PurchasingWebServiceURL;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["AccountNumber"] = this.AccountNumber;
            dict["ActiveFlag"] = this.ActiveFlag;
            dict["Name"] = this.Name;
            dict["CreditRating"] = this.CreditRating;
            dict["PreferredVendorStatus"] = this.PreferredVendorStatus;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}