﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAKA.Bussiness
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PerformanceIndicator")]
	public partial class SAKADataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKPI(KPI instance);
    partial void UpdateKPI(KPI instance);
    partial void DeleteKPI(KPI instance);
    partial void InsertKPI_Calculation_Log(KPI_Calculation_Log instance);
    partial void UpdateKPI_Calculation_Log(KPI_Calculation_Log instance);
    partial void DeleteKPI_Calculation_Log(KPI_Calculation_Log instance);
    partial void InsertKPI_Value(KPI_Value instance);
    partial void UpdateKPI_Value(KPI_Value instance);
    partial void DeleteKPI_Value(KPI_Value instance);
    #endregion
		
		public SAKADataDataContext() : 
				base(global::SAKA.Bussiness.Properties.Settings.Default.PerformanceIndicatorConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SAKADataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KPI> KPIs
		{
			get
			{
				return this.GetTable<KPI>();
			}
		}
		
		public System.Data.Linq.Table<KPI_Calculation_Log> KPI_Calculation_Logs
		{
			get
			{
				return this.GetTable<KPI_Calculation_Log>();
			}
		}
		
		public System.Data.Linq.Table<KPI_Value> KPI_Values
		{
			get
			{
				return this.GetTable<KPI_Value>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI")]
	public partial class KPI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private string _Name;
		
		private decimal _Target;
		
		private decimal _Threshold;
		
		private bool _ThresholdType;
		
		private char _Period;
		
		private string _Unit;
		
		private bool _Direction;
		
		private System.DateTime _CreationDate;
		
		private System.Nullable<System.DateTime> _ModificationDate;
		
		private EntitySet<KPI_Calculation_Log> _KPI_Calculation_Logs;
		
		private EntitySet<KPI_Value> _KPI_Values;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTargetChanging(decimal value);
    partial void OnTargetChanged();
    partial void OnThresholdChanging(decimal value);
    partial void OnThresholdChanged();
    partial void OnThresholdTypeChanging(bool value);
    partial void OnThresholdTypeChanged();
    partial void OnPeriodChanging(char value);
    partial void OnPeriodChanged();
    partial void OnUnitChanging(string value);
    partial void OnUnitChanged();
    partial void OnDirectionChanging(bool value);
    partial void OnDirectionChanged();
    partial void OnCreationDateChanging(System.DateTime value);
    partial void OnCreationDateChanged();
    partial void OnModificationDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModificationDateChanged();
    #endregion
		
		public KPI()
		{
			this._KPI_Calculation_Logs = new EntitySet<KPI_Calculation_Log>(new Action<KPI_Calculation_Log>(this.attach_KPI_Calculation_Logs), new Action<KPI_Calculation_Log>(this.detach_KPI_Calculation_Logs));
			this._KPI_Values = new EntitySet<KPI_Value>(new Action<KPI_Value>(this.attach_KPI_Values), new Action<KPI_Value>(this.detach_KPI_Values));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Target", DbType="Decimal(12,2) NOT NULL")]
		public decimal Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				if ((this._Target != value))
				{
					this.OnTargetChanging(value);
					this.SendPropertyChanging();
					this._Target = value;
					this.SendPropertyChanged("Target");
					this.OnTargetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Threshold", DbType="Decimal(12,2) NOT NULL")]
		public decimal Threshold
		{
			get
			{
				return this._Threshold;
			}
			set
			{
				if ((this._Threshold != value))
				{
					this.OnThresholdChanging(value);
					this.SendPropertyChanging();
					this._Threshold = value;
					this.SendPropertyChanged("Threshold");
					this.OnThresholdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThresholdType", DbType="Bit NOT NULL")]
		public bool ThresholdType
		{
			get
			{
				return this._ThresholdType;
			}
			set
			{
				if ((this._ThresholdType != value))
				{
					this.OnThresholdTypeChanging(value);
					this.SendPropertyChanging();
					this._ThresholdType = value;
					this.SendPropertyChanged("ThresholdType");
					this.OnThresholdTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Period", DbType="Char(1) NOT NULL")]
		public char Period
		{
			get
			{
				return this._Period;
			}
			set
			{
				if ((this._Period != value))
				{
					this.OnPeriodChanging(value);
					this.SendPropertyChanging();
					this._Period = value;
					this.SendPropertyChanged("Period");
					this.OnPeriodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="NVarChar(MAX)")]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direction", DbType="Bit NOT NULL")]
		public bool Direction
		{
			get
			{
				return this._Direction;
			}
			set
			{
				if ((this._Direction != value))
				{
					this.OnDirectionChanging(value);
					this.SendPropertyChanging();
					this._Direction = value;
					this.SendPropertyChanged("Direction");
					this.OnDirectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationDate", DbType="Date NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModificationDate", DbType="Date")]
		public System.Nullable<System.DateTime> ModificationDate
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KPI_KPI_Calculation_Log", Storage="_KPI_Calculation_Logs", ThisKey="ID", OtherKey="KPI_ID")]
		public EntitySet<KPI_Calculation_Log> KPI_Calculation_Logs
		{
			get
			{
				return this._KPI_Calculation_Logs;
			}
			set
			{
				this._KPI_Calculation_Logs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KPI_KPI_Value", Storage="_KPI_Values", ThisKey="ID", OtherKey="KPI_ID")]
		public EntitySet<KPI_Value> KPI_Values
		{
			get
			{
				return this._KPI_Values;
			}
			set
			{
				this._KPI_Values.Assign(value);
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
		
		private void attach_KPI_Calculation_Logs(KPI_Calculation_Log entity)
		{
			this.SendPropertyChanging();
			entity.KPI = this;
		}
		
		private void detach_KPI_Calculation_Logs(KPI_Calculation_Log entity)
		{
			this.SendPropertyChanging();
			entity.KPI = null;
		}
		
		private void attach_KPI_Values(KPI_Value entity)
		{
			this.SendPropertyChanging();
			entity.KPI = this;
		}
		
		private void detach_KPI_Values(KPI_Value entity)
		{
			this.SendPropertyChanging();
			entity.KPI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI_Calculation_Log")]
	public partial class KPI_Calculation_Log : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Guid _KPI_ID;
		
		private bool _Success;
		
		private string _ErrorMessage;
		
		private System.DateTime _CreationDate;
		
		private EntityRef<KPI> _KPI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnKPI_IDChanging(System.Guid value);
    partial void OnKPI_IDChanged();
    partial void OnSuccessChanging(bool value);
    partial void OnSuccessChanged();
    partial void OnErrorMessageChanging(string value);
    partial void OnErrorMessageChanged();
    partial void OnCreationDateChanging(System.DateTime value);
    partial void OnCreationDateChanged();
    #endregion
		
		public KPI_Calculation_Log()
		{
			this._KPI = default(EntityRef<KPI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPI_ID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid KPI_ID
		{
			get
			{
				return this._KPI_ID;
			}
			set
			{
				if ((this._KPI_ID != value))
				{
					if (this._KPI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKPI_IDChanging(value);
					this.SendPropertyChanging();
					this._KPI_ID = value;
					this.SendPropertyChanged("KPI_ID");
					this.OnKPI_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Success", DbType="Bit NOT NULL")]
		public bool Success
		{
			get
			{
				return this._Success;
			}
			set
			{
				if ((this._Success != value))
				{
					this.OnSuccessChanging(value);
					this.SendPropertyChanging();
					this._Success = value;
					this.SendPropertyChanged("Success");
					this.OnSuccessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMessage", DbType="NVarChar(MAX)")]
		public string ErrorMessage
		{
			get
			{
				return this._ErrorMessage;
			}
			set
			{
				if ((this._ErrorMessage != value))
				{
					this.OnErrorMessageChanging(value);
					this.SendPropertyChanging();
					this._ErrorMessage = value;
					this.SendPropertyChanged("ErrorMessage");
					this.OnErrorMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationDate", DbType="Date NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KPI_KPI_Calculation_Log", Storage="_KPI", ThisKey="KPI_ID", OtherKey="ID", IsForeignKey=true)]
		public KPI KPI
		{
			get
			{
				return this._KPI.Entity;
			}
			set
			{
				KPI previousValue = this._KPI.Entity;
				if (((previousValue != value) 
							|| (this._KPI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KPI.Entity = null;
						previousValue.KPI_Calculation_Logs.Remove(this);
					}
					this._KPI.Entity = value;
					if ((value != null))
					{
						value.KPI_Calculation_Logs.Add(this);
						this._KPI_ID = value.ID;
					}
					else
					{
						this._KPI_ID = default(System.Guid);
					}
					this.SendPropertyChanged("KPI");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI_Value")]
	public partial class KPI_Value : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _KPI_ID;
		
		private System.DateTime _KPIDate;
		
		private decimal _Target;
		
		private decimal _Threshold;
		
		private bool _ThresholdType;
		
		private decimal _Value;
		
		private EntityRef<KPI> _KPI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKPI_IDChanging(System.Guid value);
    partial void OnKPI_IDChanged();
    partial void OnKPIDateChanging(System.DateTime value);
    partial void OnKPIDateChanged();
    partial void OnTargetChanging(decimal value);
    partial void OnTargetChanged();
    partial void OnThresholdChanging(decimal value);
    partial void OnThresholdChanged();
    partial void OnThresholdTypeChanging(bool value);
    partial void OnThresholdTypeChanged();
    partial void OnValueChanging(decimal value);
    partial void OnValueChanged();
    #endregion
		
		public KPI_Value()
		{
			this._KPI = default(EntityRef<KPI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPI_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid KPI_ID
		{
			get
			{
				return this._KPI_ID;
			}
			set
			{
				if ((this._KPI_ID != value))
				{
					if (this._KPI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKPI_IDChanging(value);
					this.SendPropertyChanging();
					this._KPI_ID = value;
					this.SendPropertyChanged("KPI_ID");
					this.OnKPI_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPIDate", DbType="Date NOT NULL", IsPrimaryKey=true)]
		public System.DateTime KPIDate
		{
			get
			{
				return this._KPIDate;
			}
			set
			{
				if ((this._KPIDate != value))
				{
					this.OnKPIDateChanging(value);
					this.SendPropertyChanging();
					this._KPIDate = value;
					this.SendPropertyChanged("KPIDate");
					this.OnKPIDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Target", DbType="Decimal(12,2) NOT NULL")]
		public decimal Target
		{
			get
			{
				return this._Target;
			}
			set
			{
				if ((this._Target != value))
				{
					this.OnTargetChanging(value);
					this.SendPropertyChanging();
					this._Target = value;
					this.SendPropertyChanged("Target");
					this.OnTargetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Threshold", DbType="Decimal(12,2) NOT NULL")]
		public decimal Threshold
		{
			get
			{
				return this._Threshold;
			}
			set
			{
				if ((this._Threshold != value))
				{
					this.OnThresholdChanging(value);
					this.SendPropertyChanging();
					this._Threshold = value;
					this.SendPropertyChanged("Threshold");
					this.OnThresholdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThresholdType", DbType="Bit NOT NULL")]
		public bool ThresholdType
		{
			get
			{
				return this._ThresholdType;
			}
			set
			{
				if ((this._ThresholdType != value))
				{
					this.OnThresholdTypeChanging(value);
					this.SendPropertyChanging();
					this._ThresholdType = value;
					this.SendPropertyChanged("ThresholdType");
					this.OnThresholdTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Decimal(12,2) NOT NULL")]
		public decimal Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KPI_KPI_Value", Storage="_KPI", ThisKey="KPI_ID", OtherKey="ID", IsForeignKey=true)]
		public KPI KPI
		{
			get
			{
				return this._KPI.Entity;
			}
			set
			{
				KPI previousValue = this._KPI.Entity;
				if (((previousValue != value) 
							|| (this._KPI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KPI.Entity = null;
						previousValue.KPI_Values.Remove(this);
					}
					this._KPI.Entity = value;
					if ((value != null))
					{
						value.KPI_Values.Add(this);
						this._KPI_ID = value.ID;
					}
					else
					{
						this._KPI_ID = default(System.Guid);
					}
					this.SendPropertyChanged("KPI");
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
