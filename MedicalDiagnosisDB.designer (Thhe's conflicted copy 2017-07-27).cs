﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FInal_project
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MedicalDiagonsisDB")]
	public partial class MedicalDiagnosisDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdminPanel2(AdminPanel2 instance);
    partial void UpdateAdminPanel2(AdminPanel2 instance);
    partial void DeleteAdminPanel2(AdminPanel2 instance);
    partial void InsertDiseaseClassification(DiseaseClassification instance);
    partial void UpdateDiseaseClassification(DiseaseClassification instance);
    partial void DeleteDiseaseClassification(DiseaseClassification instance);
    partial void InsertMedicineDetail(MedicineDetail instance);
    partial void UpdateMedicineDetail(MedicineDetail instance);
    partial void DeleteMedicineDetail(MedicineDetail instance);
    partial void InsertPatientDetail(PatientDetail instance);
    partial void UpdatePatientDetail(PatientDetail instance);
    partial void DeletePatientDetail(PatientDetail instance);
    partial void InsertPhotoCollection(PhotoCollection instance);
    partial void UpdatePhotoCollection(PhotoCollection instance);
    partial void DeletePhotoCollection(PhotoCollection instance);
    partial void InsertReportDetail(ReportDetail instance);
    partial void UpdateReportDetail(ReportDetail instance);
    partial void DeleteReportDetail(ReportDetail instance);
    partial void InsertSymptomsDetail_info(SymptomsDetail_info instance);
    partial void UpdateSymptomsDetail_info(SymptomsDetail_info instance);
    partial void DeleteSymptomsDetail_info(SymptomsDetail_info instance);
    #endregion
		
		public MedicalDiagnosisDBDataContext() : 
				base(global::FInal_project.Properties.Settings.Default.MedicalDiagonsisDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MedicalDiagnosisDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MedicalDiagnosisDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MedicalDiagnosisDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MedicalDiagnosisDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AdminPanel2> AdminPanel2s
		{
			get
			{
				return this.GetTable<AdminPanel2>();
			}
		}
		
		public System.Data.Linq.Table<DiseaseClassification> DiseaseClassifications
		{
			get
			{
				return this.GetTable<DiseaseClassification>();
			}
		}
		
		public System.Data.Linq.Table<MedicineDetail> MedicineDetails
		{
			get
			{
				return this.GetTable<MedicineDetail>();
			}
		}
		
		public System.Data.Linq.Table<PatientDetail> PatientDetails
		{
			get
			{
				return this.GetTable<PatientDetail>();
			}
		}
		
		public System.Data.Linq.Table<PhotoCollection> PhotoCollections
		{
			get
			{
				return this.GetTable<PhotoCollection>();
			}
		}
		
		public System.Data.Linq.Table<ReportDetail> ReportDetails
		{
			get
			{
				return this.GetTable<ReportDetail>();
			}
		}
		
		public System.Data.Linq.Table<SymptomsDetail_info> SymptomsDetail_infos
		{
			get
			{
				return this.GetTable<SymptomsDetail_info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminPanel2")]
	public partial class AdminPanel2 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminID;
		
		private string _username;
		
		private string _password;
		
		private string _contact;
		
		private string _adminName;
		
		private string _Email_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIDChanging(int value);
    partial void OnAdminIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OncontactChanging(string value);
    partial void OncontactChanged();
    partial void OnadminNameChanging(string value);
    partial void OnadminNameChanged();
    partial void OnEmail_IDChanging(string value);
    partial void OnEmail_IDChanged();
    #endregion
		
		public AdminPanel2()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminID
		{
			get
			{
				return this._AdminID;
			}
			set
			{
				if ((this._AdminID != value))
				{
					this.OnAdminIDChanging(value);
					this.SendPropertyChanging();
					this._AdminID = value;
					this.SendPropertyChanged("AdminID");
					this.OnAdminIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				if ((this._contact != value))
				{
					this.OncontactChanging(value);
					this.SendPropertyChanging();
					this._contact = value;
					this.SendPropertyChanged("contact");
					this.OncontactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string adminName
		{
			get
			{
				return this._adminName;
			}
			set
			{
				if ((this._adminName != value))
				{
					this.OnadminNameChanging(value);
					this.SendPropertyChanging();
					this._adminName = value;
					this.SendPropertyChanged("adminName");
					this.OnadminNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email_ID
		{
			get
			{
				return this._Email_ID;
			}
			set
			{
				if ((this._Email_ID != value))
				{
					this.OnEmail_IDChanging(value);
					this.SendPropertyChanging();
					this._Email_ID = value;
					this.SendPropertyChanged("Email_ID");
					this.OnEmail_IDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DiseaseClassification")]
	public partial class DiseaseClassification : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DiseaseID;
		
		private string _DiseaseName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDiseaseIDChanging(int value);
    partial void OnDiseaseIDChanged();
    partial void OnDiseaseNameChanging(string value);
    partial void OnDiseaseNameChanged();
    #endregion
		
		public DiseaseClassification()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiseaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DiseaseID
		{
			get
			{
				return this._DiseaseID;
			}
			set
			{
				if ((this._DiseaseID != value))
				{
					this.OnDiseaseIDChanging(value);
					this.SendPropertyChanging();
					this._DiseaseID = value;
					this.SendPropertyChanged("DiseaseID");
					this.OnDiseaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiseaseName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DiseaseName
		{
			get
			{
				return this._DiseaseName;
			}
			set
			{
				if ((this._DiseaseName != value))
				{
					this.OnDiseaseNameChanging(value);
					this.SendPropertyChanging();
					this._DiseaseName = value;
					this.SendPropertyChanged("DiseaseName");
					this.OnDiseaseNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MedicineDetail")]
	public partial class MedicineDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MedicineID;
		
		private string _MedicineName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMedicineIDChanging(int value);
    partial void OnMedicineIDChanged();
    partial void OnMedicineNameChanging(string value);
    partial void OnMedicineNameChanged();
    #endregion
		
		public MedicineDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MedicineID
		{
			get
			{
				return this._MedicineID;
			}
			set
			{
				if ((this._MedicineID != value))
				{
					this.OnMedicineIDChanging(value);
					this.SendPropertyChanging();
					this._MedicineID = value;
					this.SendPropertyChanged("MedicineID");
					this.OnMedicineIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MedicineName
		{
			get
			{
				return this._MedicineName;
			}
			set
			{
				if ((this._MedicineName != value))
				{
					this.OnMedicineNameChanging(value);
					this.SendPropertyChanging();
					this._MedicineName = value;
					this.SendPropertyChanged("MedicineName");
					this.OnMedicineNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PatientDetail")]
	public partial class PatientDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _patientID;
		
		private string _patientName;
		
		private string _contactnum;
		
		private string _bloodgroup;
		
		private string _city;
		
		private string _zone;
		
		private string _age;
		
		private string _gender;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpatientIDChanging(int value);
    partial void OnpatientIDChanged();
    partial void OnpatientNameChanging(string value);
    partial void OnpatientNameChanged();
    partial void OncontactnumChanging(string value);
    partial void OncontactnumChanged();
    partial void OnbloodgroupChanging(string value);
    partial void OnbloodgroupChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnzoneChanging(string value);
    partial void OnzoneChanged();
    partial void OnageChanging(string value);
    partial void OnageChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    #endregion
		
		public PatientDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int patientID
		{
			get
			{
				return this._patientID;
			}
			set
			{
				if ((this._patientID != value))
				{
					this.OnpatientIDChanging(value);
					this.SendPropertyChanging();
					this._patientID = value;
					this.SendPropertyChanged("patientID");
					this.OnpatientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string patientName
		{
			get
			{
				return this._patientName;
			}
			set
			{
				if ((this._patientName != value))
				{
					this.OnpatientNameChanging(value);
					this.SendPropertyChanging();
					this._patientName = value;
					this.SendPropertyChanged("patientName");
					this.OnpatientNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactnum", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string contactnum
		{
			get
			{
				return this._contactnum;
			}
			set
			{
				if ((this._contactnum != value))
				{
					this.OncontactnumChanging(value);
					this.SendPropertyChanging();
					this._contactnum = value;
					this.SendPropertyChanged("contactnum");
					this.OncontactnumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bloodgroup", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string bloodgroup
		{
			get
			{
				return this._bloodgroup;
			}
			set
			{
				if ((this._bloodgroup != value))
				{
					this.OnbloodgroupChanging(value);
					this.SendPropertyChanging();
					this._bloodgroup = value;
					this.SendPropertyChanged("bloodgroup");
					this.OnbloodgroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string zone
		{
			get
			{
				return this._zone;
			}
			set
			{
				if ((this._zone != value))
				{
					this.OnzoneChanging(value);
					this.SendPropertyChanging();
					this._zone = value;
					this.SendPropertyChanged("zone");
					this.OnzoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhotoCollection")]
	public partial class PhotoCollection : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ImageID;
		
		private System.Data.Linq.Binary _Photo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImageIDChanging(int value);
    partial void OnImageIDChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    #endregion
		
		public PhotoCollection()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ImageID
		{
			get
			{
				return this._ImageID;
			}
			set
			{
				if ((this._ImageID != value))
				{
					this.OnImageIDChanging(value);
					this.SendPropertyChanging();
					this._ImageID = value;
					this.SendPropertyChanged("ImageID");
					this.OnImageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReportDetail")]
	public partial class ReportDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReportID;
		
		private System.DateTime _Reporttime;
		
		private string _reportname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReportIDChanging(int value);
    partial void OnReportIDChanged();
    partial void OnReporttimeChanging(System.DateTime value);
    partial void OnReporttimeChanged();
    partial void OnreportnameChanging(string value);
    partial void OnreportnameChanged();
    #endregion
		
		public ReportDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReportID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ReportID
		{
			get
			{
				return this._ReportID;
			}
			set
			{
				if ((this._ReportID != value))
				{
					this.OnReportIDChanging(value);
					this.SendPropertyChanging();
					this._ReportID = value;
					this.SendPropertyChanged("ReportID");
					this.OnReportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reporttime", DbType="DateTime NOT NULL")]
		public System.DateTime Reporttime
		{
			get
			{
				return this._Reporttime;
			}
			set
			{
				if ((this._Reporttime != value))
				{
					this.OnReporttimeChanging(value);
					this.SendPropertyChanging();
					this._Reporttime = value;
					this.SendPropertyChanged("Reporttime");
					this.OnReporttimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reportname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string reportname
		{
			get
			{
				return this._reportname;
			}
			set
			{
				if ((this._reportname != value))
				{
					this.OnreportnameChanging(value);
					this.SendPropertyChanging();
					this._reportname = value;
					this.SendPropertyChanged("reportname");
					this.OnreportnameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SymptomsDetail_info")]
	public partial class SymptomsDetail_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _symptomsID;
		
		private string _SymptomsName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsymptomsIDChanging(int value);
    partial void OnsymptomsIDChanged();
    partial void OnSymptomsNameChanging(string value);
    partial void OnSymptomsNameChanged();
    #endregion
		
		public SymptomsDetail_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_symptomsID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int symptomsID
		{
			get
			{
				return this._symptomsID;
			}
			set
			{
				if ((this._symptomsID != value))
				{
					this.OnsymptomsIDChanging(value);
					this.SendPropertyChanging();
					this._symptomsID = value;
					this.SendPropertyChanged("symptomsID");
					this.OnsymptomsIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SymptomsName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SymptomsName
		{
			get
			{
				return this._SymptomsName;
			}
			set
			{
				if ((this._SymptomsName != value))
				{
					this.OnSymptomsNameChanging(value);
					this.SendPropertyChanging();
					this._SymptomsName = value;
					this.SendPropertyChanged("SymptomsName");
					this.OnSymptomsNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591