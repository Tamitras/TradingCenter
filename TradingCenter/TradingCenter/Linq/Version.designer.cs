﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34014
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradingCenter.Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Futhead")]
	public partial class VersionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnCreated();
    partial void InsertVersion(Version instance);
    partial void UpdateVersion(Version instance);
    partial void DeleteVersion(Version instance);
    #endregion
		
		public VersionDataContext() : 
				base(global::TradingCenter.Properties.Settings.Default.FutheadConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VersionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VersionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VersionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VersionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Version> Versions
		{
			get
			{
				return this.GetTable<Version>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Version")]
	public partial class Version : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VersionID;
		
		private string _Name;
		
		private string _VersionNumber;
		
		private int _VersionNumberInt;
		
		private string _DownloadDirectory;
		
		private int _Downloaded;
		
		private System.DateTime _CreationDate;
		
		private System.DateTime _ModificationDate;
		
		private bool _Valid;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVersionIDChanging(int value);
    partial void OnVersionIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnVersionNumberChanging(string value);
    partial void OnVersionNumberChanged();
    partial void OnVersionNumberIntChanging(int value);
    partial void OnVersionNumberIntChanged();
    partial void OnDownloadDirectoryChanging(string value);
    partial void OnDownloadDirectoryChanged();
    partial void OnDownloadedChanging(int value);
    partial void OnDownloadedChanged();
    partial void OnCreationDateChanging(System.DateTime value);
    partial void OnCreationDateChanged();
    partial void OnModificationDateChanging(System.DateTime value);
    partial void OnModificationDateChanged();
    partial void OnValidChanging(bool value);
    partial void OnValidChanged();
    #endregion
		
		public Version()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VersionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int VersionID
		{
			get
			{
				return this._VersionID;
			}
			set
			{
				if ((this._VersionID != value))
				{
					this.OnVersionIDChanging(value);
					this.SendPropertyChanging();
					this._VersionID = value;
					this.SendPropertyChanged("VersionID");
					this.OnVersionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VersionNumber", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string VersionNumber
		{
			get
			{
				return this._VersionNumber;
			}
			set
			{
				if ((this._VersionNumber != value))
				{
					this.OnVersionNumberChanging(value);
					this.SendPropertyChanging();
					this._VersionNumber = value;
					this.SendPropertyChanged("VersionNumber");
					this.OnVersionNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VersionNumberInt", DbType="Int NOT NULL")]
		public int VersionNumberInt
		{
			get
			{
				return this._VersionNumberInt;
			}
			set
			{
				if ((this._VersionNumberInt != value))
				{
					this.OnVersionNumberIntChanging(value);
					this.SendPropertyChanging();
					this._VersionNumberInt = value;
					this.SendPropertyChanged("VersionNumberInt");
					this.OnVersionNumberIntChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DownloadDirectory", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DownloadDirectory
		{
			get
			{
				return this._DownloadDirectory;
			}
			set
			{
				if ((this._DownloadDirectory != value))
				{
					this.OnDownloadDirectoryChanging(value);
					this.SendPropertyChanging();
					this._DownloadDirectory = value;
					this.SendPropertyChanged("DownloadDirectory");
					this.OnDownloadDirectoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Downloaded", DbType="Int NOT NULL")]
		public int Downloaded
		{
			get
			{
				return this._Downloaded;
			}
			set
			{
				if ((this._Downloaded != value))
				{
					this.OnDownloadedChanging(value);
					this.SendPropertyChanging();
					this._Downloaded = value;
					this.SendPropertyChanged("Downloaded");
					this.OnDownloadedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreationDate
		{
			get
			{
				return this._CreationDate;
			}
			set
			{
				if ((this._CreationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._CreationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModificationDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModificationDate
		{
			get
			{
				return this._ModificationDate;
			}
			set
			{
				if ((this._ModificationDate != value))
				{
					this.OnModificationDateChanging(value);
					this.SendPropertyChanging();
					this._ModificationDate = value;
					this.SendPropertyChanged("ModificationDate");
					this.OnModificationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valid", DbType="Bit NOT NULL")]
		public bool Valid
		{
			get
			{
				return this._Valid;
			}
			set
			{
				if ((this._Valid != value))
				{
					this.OnValidChanging(value);
					this.SendPropertyChanging();
					this._Valid = value;
					this.SendPropertyChanged("Valid");
					this.OnValidChanged();
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
