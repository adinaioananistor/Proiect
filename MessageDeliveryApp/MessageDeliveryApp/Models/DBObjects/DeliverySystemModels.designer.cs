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

namespace MessageDeliveryApp.Models.DBObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="deliverysystem")]
	public partial class DeliverySystemModelsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCompany(Company instance);
    partial void UpdateCompany(Company instance);
    partial void DeleteCompany(Company instance);
    partial void InsertDeliverySystem(DeliverySystem instance);
    partial void UpdateDeliverySystem(DeliverySystem instance);
    partial void DeleteDeliverySystem(DeliverySystem instance);
    partial void InsertMesaje(Mesaje instance);
    partial void UpdateMesaje(Mesaje instance);
    partial void DeleteMesaje(Mesaje instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DeliverySystemModelsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["deliverysystemConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DeliverySystemModelsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeliverySystemModelsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeliverySystemModelsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeliverySystemModelsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Company> Companies
		{
			get
			{
				return this.GetTable<Company>();
			}
		}
		
		public System.Data.Linq.Table<DeliverySystem> DeliverySystems
		{
			get
			{
				return this.GetTable<DeliverySystem>();
			}
		}
		
		public System.Data.Linq.Table<Mesaje> Mesajes
		{
			get
			{
				return this.GetTable<Mesaje>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Company")]
	public partial class Company : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDCompany;
		
		private System.Guid _IDDeliverySystem;
		
		private string _CompanyName;
		
		private string _Addres;
		
		private string _Country;
		
		private EntityRef<DeliverySystem> _DeliverySystem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCompanyChanging(System.Guid value);
    partial void OnIDCompanyChanged();
    partial void OnIDDeliverySystemChanging(System.Guid value);
    partial void OnIDDeliverySystemChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnAddresChanging(string value);
    partial void OnAddresChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    #endregion
		
		public Company()
		{
			this._DeliverySystem = default(EntityRef<DeliverySystem>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCompany", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDCompany
		{
			get
			{
				return this._IDCompany;
			}
			set
			{
				if ((this._IDCompany != value))
				{
					this.OnIDCompanyChanging(value);
					this.SendPropertyChanging();
					this._IDCompany = value;
					this.SendPropertyChanged("IDCompany");
					this.OnIDCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDeliverySystem", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDDeliverySystem
		{
			get
			{
				return this._IDDeliverySystem;
			}
			set
			{
				if ((this._IDDeliverySystem != value))
				{
					if (this._DeliverySystem.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDDeliverySystemChanging(value);
					this.SendPropertyChanging();
					this._IDDeliverySystem = value;
					this.SendPropertyChanged("IDDeliverySystem");
					this.OnIDDeliverySystemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Addres", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Addres
		{
			get
			{
				return this._Addres;
			}
			set
			{
				if ((this._Addres != value))
				{
					this.OnAddresChanging(value);
					this.SendPropertyChanging();
					this._Addres = value;
					this.SendPropertyChanged("Addres");
					this.OnAddresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DeliverySystem_Company", Storage="_DeliverySystem", ThisKey="IDDeliverySystem", OtherKey="IDDeliverySystem", IsForeignKey=true)]
		public DeliverySystem DeliverySystem
		{
			get
			{
				return this._DeliverySystem.Entity;
			}
			set
			{
				DeliverySystem previousValue = this._DeliverySystem.Entity;
				if (((previousValue != value) 
							|| (this._DeliverySystem.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DeliverySystem.Entity = null;
						previousValue.Companies.Remove(this);
					}
					this._DeliverySystem.Entity = value;
					if ((value != null))
					{
						value.Companies.Add(this);
						this._IDDeliverySystem = value.IDDeliverySystem;
					}
					else
					{
						this._IDDeliverySystem = default(System.Guid);
					}
					this.SendPropertyChanged("DeliverySystem");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DeliverySystem")]
	public partial class DeliverySystem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDDeliverySystem;
		
		private System.Guid _IDMesaj;
		
		private string _Provider;
		
		private System.DateTime _ExpiryDate;
		
		private EntitySet<Company> _Companies;
		
		private EntityRef<Mesaje> _Mesaje;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDeliverySystemChanging(System.Guid value);
    partial void OnIDDeliverySystemChanged();
    partial void OnIDMesajChanging(System.Guid value);
    partial void OnIDMesajChanged();
    partial void OnProviderChanging(string value);
    partial void OnProviderChanged();
    partial void OnExpiryDateChanging(System.DateTime value);
    partial void OnExpiryDateChanged();
    #endregion
		
		public DeliverySystem()
		{
			this._Companies = new EntitySet<Company>(new Action<Company>(this.attach_Companies), new Action<Company>(this.detach_Companies));
			this._Mesaje = default(EntityRef<Mesaje>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDeliverySystem", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDDeliverySystem
		{
			get
			{
				return this._IDDeliverySystem;
			}
			set
			{
				if ((this._IDDeliverySystem != value))
				{
					this.OnIDDeliverySystemChanging(value);
					this.SendPropertyChanging();
					this._IDDeliverySystem = value;
					this.SendPropertyChanged("IDDeliverySystem");
					this.OnIDDeliverySystemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMesaj", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDMesaj
		{
			get
			{
				return this._IDMesaj;
			}
			set
			{
				if ((this._IDMesaj != value))
				{
					if (this._Mesaje.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDMesajChanging(value);
					this.SendPropertyChanging();
					this._IDMesaj = value;
					this.SendPropertyChanged("IDMesaj");
					this.OnIDMesajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provider", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Provider
		{
			get
			{
				return this._Provider;
			}
			set
			{
				if ((this._Provider != value))
				{
					this.OnProviderChanging(value);
					this.SendPropertyChanging();
					this._Provider = value;
					this.SendPropertyChanged("Provider");
					this.OnProviderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiryDate", DbType="DateTime NOT NULL")]
		public System.DateTime ExpiryDate
		{
			get
			{
				return this._ExpiryDate;
			}
			set
			{
				if ((this._ExpiryDate != value))
				{
					this.OnExpiryDateChanging(value);
					this.SendPropertyChanging();
					this._ExpiryDate = value;
					this.SendPropertyChanged("ExpiryDate");
					this.OnExpiryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DeliverySystem_Company", Storage="_Companies", ThisKey="IDDeliverySystem", OtherKey="IDDeliverySystem")]
		public EntitySet<Company> Companies
		{
			get
			{
				return this._Companies;
			}
			set
			{
				this._Companies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mesaje_DeliverySystem", Storage="_Mesaje", ThisKey="IDMesaj", OtherKey="IDMesaj", IsForeignKey=true)]
		public Mesaje Mesaje
		{
			get
			{
				return this._Mesaje.Entity;
			}
			set
			{
				Mesaje previousValue = this._Mesaje.Entity;
				if (((previousValue != value) 
							|| (this._Mesaje.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Mesaje.Entity = null;
						previousValue.DeliverySystems.Remove(this);
					}
					this._Mesaje.Entity = value;
					if ((value != null))
					{
						value.DeliverySystems.Add(this);
						this._IDMesaj = value.IDMesaj;
					}
					else
					{
						this._IDMesaj = default(System.Guid);
					}
					this.SendPropertyChanged("Mesaje");
				}
			}
		}

        public Guid Name { get; internal set; }

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
		
		private void attach_Companies(Company entity)
		{
			this.SendPropertyChanging();
			entity.DeliverySystem = this;
		}
		
		private void detach_Companies(Company entity)
		{
			this.SendPropertyChanging();
			entity.DeliverySystem = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mesaje")]
	public partial class Mesaje : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDMesaj;
		
		private System.Guid _IDUser;
		
		private string _Content;
		
		private System.DateTime _Date;
		
		private EntitySet<DeliverySystem> _DeliverySystems;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDMesajChanging(System.Guid value);
    partial void OnIDMesajChanged();
    partial void OnIDUserChanging(System.Guid value);
    partial void OnIDUserChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Mesaje()
		{
			this._DeliverySystems = new EntitySet<DeliverySystem>(new Action<DeliverySystem>(this.attach_DeliverySystems), new Action<DeliverySystem>(this.detach_DeliverySystems));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMesaj", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDMesaj
		{
			get
			{
				return this._IDMesaj;
			}
			set
			{
				if ((this._IDMesaj != value))
				{
					this.OnIDMesajChanging(value);
					this.SendPropertyChanging();
					this._IDMesaj = value;
					this.SendPropertyChanged("IDMesaj");
					this.OnIDMesajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUser", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDUser
		{
			get
			{
				return this._IDUser;
			}
			set
			{
				if ((this._IDUser != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDUserChanging(value);
					this.SendPropertyChanging();
					this._IDUser = value;
					this.SendPropertyChanged("IDUser");
					this.OnIDUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mesaje_DeliverySystem", Storage="_DeliverySystems", ThisKey="IDMesaj", OtherKey="IDMesaj")]
		public EntitySet<DeliverySystem> DeliverySystems
		{
			get
			{
				return this._DeliverySystems;
			}
			set
			{
				this._DeliverySystems.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Mesaje", Storage="_User", ThisKey="IDUser", OtherKey="IDUser", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Mesajes.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Mesajes.Add(this);
						this._IDUser = value.IDUser;
					}
					else
					{
						this._IDUser = default(System.Guid);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_DeliverySystems(DeliverySystem entity)
		{
			this.SendPropertyChanging();
			entity.Mesaje = this;
		}
		
		private void detach_DeliverySystems(DeliverySystem entity)
		{
			this.SendPropertyChanging();
			entity.Mesaje = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDUser;
		
		private string _Name;
		
		private string _Mail;
		
		private string _Description;
		
		private System.DateTime _JoinDate;
		
		private EntitySet<Mesaje> _Mesajes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDUserChanging(System.Guid value);
    partial void OnIDUserChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnJoinDateChanging(System.DateTime value);
    partial void OnJoinDateChanged();
    #endregion
		
		public User()
		{
			this._Mesajes = new EntitySet<Mesaje>(new Action<Mesaje>(this.attach_Mesajes), new Action<Mesaje>(this.detach_Mesajes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUser", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDUser
		{
			get
			{
				return this._IDUser;
			}
			set
			{
				if ((this._IDUser != value))
				{
					this.OnIDUserChanging(value);
					this.SendPropertyChanging();
					this._IDUser = value;
					this.SendPropertyChanged("IDUser");
					this.OnIDUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(250)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JoinDate", DbType="DateTime NOT NULL")]
		public System.DateTime JoinDate
		{
			get
			{
				return this._JoinDate;
			}
			set
			{
				if ((this._JoinDate != value))
				{
					this.OnJoinDateChanging(value);
					this.SendPropertyChanging();
					this._JoinDate = value;
					this.SendPropertyChanged("JoinDate");
					this.OnJoinDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Mesaje", Storage="_Mesajes", ThisKey="IDUser", OtherKey="IDUser")]
		public EntitySet<Mesaje> Mesajes
		{
			get
			{
				return this._Mesajes;
			}
			set
			{
				this._Mesajes.Assign(value);
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
		
		private void attach_Mesajes(Mesaje entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Mesajes(Mesaje entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}

        internal T ObjectMap<T>()
        {
            throw new NotImplementedException();
        }
    }
}
#pragma warning restore 1591
