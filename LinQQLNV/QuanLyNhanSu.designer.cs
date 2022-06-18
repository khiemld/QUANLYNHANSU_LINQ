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

namespace LinQQLNV
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QUANLYNHANVIEN")]
	public partial class QuanLyNhanSuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDangNhap(DangNhap instance);
    partial void UpdateDangNhap(DangNhap instance);
    partial void DeleteDangNhap(DangNhap instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertPHONGBAN(PHONGBAN instance);
    partial void UpdatePHONGBAN(PHONGBAN instance);
    partial void DeletePHONGBAN(PHONGBAN instance);
    partial void InsertTHANNHAN(THANNHAN instance);
    partial void UpdateTHANNHAN(THANNHAN instance);
    partial void DeleteTHANNHAN(THANNHAN instance);
    #endregion
		
		public QuanLyNhanSuDataContext() : 
				base(global::LinQQLNV.Properties.Settings.Default.QUANLYNHANVIENConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNhanSuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNhanSuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNhanSuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNhanSuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<PHONGBAN> PHONGBANs
		{
			get
			{
				return this.GetTable<PHONGBAN>();
			}
		}
		
		public System.Data.Linq.Table<THANNHAN> THANNHANs
		{
			get
			{
				return this.GetTable<THANNHAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenTaiKhoan;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenTaiKhoanChanging(string value);
    partial void OnTenTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public DangNhap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTaiKhoan", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenTaiKhoan
		{
			get
			{
				return this._TenTaiKhoan;
			}
			set
			{
				if ((this._TenTaiKhoan != value))
				{
					this.OnTenTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TenTaiKhoan = value;
					this.SendPropertyChanged("TenTaiKhoan");
					this.OnTenTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _HOTEN;
		
		private string _GIOITINH;
		
		private System.DateTime _NGAYSINH;
		
		private string _MAPB;
		
		private string _TRANGTHAI;
		
		private int _LUONG;
		
		private System.Nullable<int> _PHUCAP;
		
		private string _SDT;
		
		private string _EMAIL;
		
		private string _CHUYENMON;
		
		private string _CHUCVU;
		
		private string _DIACHI;
		
		private bool _DAXOA;
		
		private EntitySet<THANNHAN> _THANNHANs;
		
		private EntityRef<PHONGBAN> _PHONGBAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnGIOITINHChanging(string value);
    partial void OnGIOITINHChanged();
    partial void OnNGAYSINHChanging(System.DateTime value);
    partial void OnNGAYSINHChanged();
    partial void OnMAPBChanging(string value);
    partial void OnMAPBChanged();
    partial void OnTRANGTHAIChanging(string value);
    partial void OnTRANGTHAIChanged();
    partial void OnLUONGChanging(int value);
    partial void OnLUONGChanged();
    partial void OnPHUCAPChanging(System.Nullable<int> value);
    partial void OnPHUCAPChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnCHUYENMONChanging(string value);
    partial void OnCHUYENMONChanged();
    partial void OnCHUCVUChanging(string value);
    partial void OnCHUCVUChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnDAXOAChanging(bool value);
    partial void OnDAXOAChanged();
    #endregion
		
		public NHANVIEN()
		{
			this._THANNHANs = new EntitySet<THANNHAN>(new Action<THANNHAN>(this.attach_THANNHANs), new Action<THANNHAN>(this.detach_THANNHANs));
			this._PHONGBAN = default(EntityRef<PHONGBAN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOITINH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string GIOITINH
		{
			get
			{
				return this._GIOITINH;
			}
			set
			{
				if ((this._GIOITINH != value))
				{
					this.OnGIOITINHChanging(value);
					this.SendPropertyChanging();
					this._GIOITINH = value;
					this.SendPropertyChanged("GIOITINH");
					this.OnGIOITINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="DateTime NOT NULL")]
		public System.DateTime NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPB", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MAPB
		{
			get
			{
				return this._MAPB;
			}
			set
			{
				if ((this._MAPB != value))
				{
					if (this._PHONGBAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAPBChanging(value);
					this.SendPropertyChanging();
					this._MAPB = value;
					this.SendPropertyChanged("MAPB");
					this.OnMAPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANGTHAI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TRANGTHAI
		{
			get
			{
				return this._TRANGTHAI;
			}
			set
			{
				if ((this._TRANGTHAI != value))
				{
					this.OnTRANGTHAIChanging(value);
					this.SendPropertyChanging();
					this._TRANGTHAI = value;
					this.SendPropertyChanged("TRANGTHAI");
					this.OnTRANGTHAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LUONG", DbType="Int NOT NULL")]
		public int LUONG
		{
			get
			{
				return this._LUONG;
			}
			set
			{
				if ((this._LUONG != value))
				{
					this.OnLUONGChanging(value);
					this.SendPropertyChanging();
					this._LUONG = value;
					this.SendPropertyChanged("LUONG");
					this.OnLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHUCAP", DbType="Int")]
		public System.Nullable<int> PHUCAP
		{
			get
			{
				return this._PHUCAP;
			}
			set
			{
				if ((this._PHUCAP != value))
				{
					this.OnPHUCAPChanging(value);
					this.SendPropertyChanging();
					this._PHUCAP = value;
					this.SendPropertyChanged("PHUCAP");
					this.OnPHUCAPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(50)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHUYENMON", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CHUYENMON
		{
			get
			{
				return this._CHUYENMON;
			}
			set
			{
				if ((this._CHUYENMON != value))
				{
					this.OnCHUYENMONChanging(value);
					this.SendPropertyChanging();
					this._CHUYENMON = value;
					this.SendPropertyChanged("CHUYENMON");
					this.OnCHUYENMONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHUCVU", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CHUCVU
		{
			get
			{
				return this._CHUCVU;
			}
			set
			{
				if ((this._CHUCVU != value))
				{
					this.OnCHUCVUChanging(value);
					this.SendPropertyChanging();
					this._CHUCVU = value;
					this.SendPropertyChanged("CHUCVU");
					this.OnCHUCVUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DAXOA", DbType="Bit NOT NULL")]
		public bool DAXOA
		{
			get
			{
				return this._DAXOA;
			}
			set
			{
				if ((this._DAXOA != value))
				{
					this.OnDAXOAChanging(value);
					this.SendPropertyChanging();
					this._DAXOA = value;
					this.SendPropertyChanged("DAXOA");
					this.OnDAXOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_THANNHAN", Storage="_THANNHANs", ThisKey="MANV", OtherKey="MANV")]
		public EntitySet<THANNHAN> THANNHANs
		{
			get
			{
				return this._THANNHANs;
			}
			set
			{
				this._THANNHANs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHONGBAN_NHANVIEN", Storage="_PHONGBAN", ThisKey="MAPB", OtherKey="MAPB", IsForeignKey=true)]
		public PHONGBAN PHONGBAN
		{
			get
			{
				return this._PHONGBAN.Entity;
			}
			set
			{
				PHONGBAN previousValue = this._PHONGBAN.Entity;
				if (((previousValue != value) 
							|| (this._PHONGBAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHONGBAN.Entity = null;
						previousValue.NHANVIENs.Remove(this);
					}
					this._PHONGBAN.Entity = value;
					if ((value != null))
					{
						value.NHANVIENs.Add(this);
						this._MAPB = value.MAPB;
					}
					else
					{
						this._MAPB = default(string);
					}
					this.SendPropertyChanged("PHONGBAN");
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
		
		private void attach_THANNHANs(THANNHAN entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = this;
		}
		
		private void detach_THANNHANs(THANNHAN entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHONGBAN")]
	public partial class PHONGBAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAPB;
		
		private string _TENPB;
		
		private string _MATRUONGPB;
		
		private bool _DAXOA;
		
		private EntitySet<NHANVIEN> _NHANVIENs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPBChanging(string value);
    partial void OnMAPBChanged();
    partial void OnTENPBChanging(string value);
    partial void OnTENPBChanged();
    partial void OnMATRUONGPBChanging(string value);
    partial void OnMATRUONGPBChanged();
    partial void OnDAXOAChanging(bool value);
    partial void OnDAXOAChanged();
    #endregion
		
		public PHONGBAN()
		{
			this._NHANVIENs = new EntitySet<NHANVIEN>(new Action<NHANVIEN>(this.attach_NHANVIENs), new Action<NHANVIEN>(this.detach_NHANVIENs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPB", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAPB
		{
			get
			{
				return this._MAPB;
			}
			set
			{
				if ((this._MAPB != value))
				{
					this.OnMAPBChanging(value);
					this.SendPropertyChanging();
					this._MAPB = value;
					this.SendPropertyChanged("MAPB");
					this.OnMAPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENPB", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TENPB
		{
			get
			{
				return this._TENPB;
			}
			set
			{
				if ((this._TENPB != value))
				{
					this.OnTENPBChanging(value);
					this.SendPropertyChanging();
					this._TENPB = value;
					this.SendPropertyChanged("TENPB");
					this.OnTENPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATRUONGPB", DbType="VarChar(10)")]
		public string MATRUONGPB
		{
			get
			{
				return this._MATRUONGPB;
			}
			set
			{
				if ((this._MATRUONGPB != value))
				{
					this.OnMATRUONGPBChanging(value);
					this.SendPropertyChanging();
					this._MATRUONGPB = value;
					this.SendPropertyChanged("MATRUONGPB");
					this.OnMATRUONGPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DAXOA", DbType="Bit NOT NULL")]
		public bool DAXOA
		{
			get
			{
				return this._DAXOA;
			}
			set
			{
				if ((this._DAXOA != value))
				{
					this.OnDAXOAChanging(value);
					this.SendPropertyChanging();
					this._DAXOA = value;
					this.SendPropertyChanged("DAXOA");
					this.OnDAXOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHONGBAN_NHANVIEN", Storage="_NHANVIENs", ThisKey="MAPB", OtherKey="MAPB")]
		public EntitySet<NHANVIEN> NHANVIENs
		{
			get
			{
				return this._NHANVIENs;
			}
			set
			{
				this._NHANVIENs.Assign(value);
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
		
		private void attach_NHANVIENs(NHANVIEN entity)
		{
			this.SendPropertyChanging();
			entity.PHONGBAN = this;
		}
		
		private void detach_NHANVIENs(NHANVIEN entity)
		{
			this.SendPropertyChanging();
			entity.PHONGBAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THANNHAN")]
	public partial class THANNHAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _HOTEN;
		
		private string _SDT;
		
		private string _QUANHE;
		
		private bool _DAXOA;
		
		private EntityRef<NHANVIEN> _NHANVIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnQUANHEChanging(string value);
    partial void OnQUANHEChanged();
    partial void OnDAXOAChanging(bool value);
    partial void OnDAXOAChanged();
    #endregion
		
		public THANNHAN()
		{
			this._NHANVIEN = default(EntityRef<NHANVIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					if (this._NHANVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUANHE", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string QUANHE
		{
			get
			{
				return this._QUANHE;
			}
			set
			{
				if ((this._QUANHE != value))
				{
					this.OnQUANHEChanging(value);
					this.SendPropertyChanging();
					this._QUANHE = value;
					this.SendPropertyChanged("QUANHE");
					this.OnQUANHEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DAXOA", DbType="Bit NOT NULL")]
		public bool DAXOA
		{
			get
			{
				return this._DAXOA;
			}
			set
			{
				if ((this._DAXOA != value))
				{
					this.OnDAXOAChanging(value);
					this.SendPropertyChanging();
					this._DAXOA = value;
					this.SendPropertyChanged("DAXOA");
					this.OnDAXOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_THANNHAN", Storage="_NHANVIEN", ThisKey="MANV", OtherKey="MANV", IsForeignKey=true)]
		public NHANVIEN NHANVIEN
		{
			get
			{
				return this._NHANVIEN.Entity;
			}
			set
			{
				NHANVIEN previousValue = this._NHANVIEN.Entity;
				if (((previousValue != value) 
							|| (this._NHANVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHANVIEN.Entity = null;
						previousValue.THANNHANs.Remove(this);
					}
					this._NHANVIEN.Entity = value;
					if ((value != null))
					{
						value.THANNHANs.Add(this);
						this._MANV = value.MANV;
					}
					else
					{
						this._MANV = default(string);
					}
					this.SendPropertyChanged("NHANVIEN");
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
