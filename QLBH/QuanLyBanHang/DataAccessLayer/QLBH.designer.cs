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

namespace DataAccessLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyBanHang")]
	public partial class QLBHDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLoaiSanPham(LoaiSanPham instance);
    partial void UpdateLoaiSanPham(LoaiSanPham instance);
    partial void DeleteLoaiSanPham(LoaiSanPham instance);
    partial void InsertNguoiDung(NguoiDung instance);
    partial void UpdateNguoiDung(NguoiDung instance);
    partial void DeleteNguoiDung(NguoiDung instance);
    partial void InsertQuyen(Quyen instance);
    partial void UpdateQuyen(Quyen instance);
    partial void DeleteQuyen(Quyen instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public QLBHDataContext() : 
				base(global::DataAccessLayer.Properties.Settings.Default.QuanLyBanHangConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LoaiSanPham> LoaiSanPhams
		{
			get
			{
				return this.GetTable<LoaiSanPham>();
			}
		}
		
		public System.Data.Linq.Table<NguoiDung> NguoiDungs
		{
			get
			{
				return this.GetTable<NguoiDung>();
			}
		}
		
		public System.Data.Linq.Table<Quyen> Quyens
		{
			get
			{
				return this.GetTable<Quyen>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSanPham")]
	public partial class LoaiSanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Ma;
		
		private string _Ten;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChanging(int value);
    partial void OnMaChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    #endregion
		
		public LoaiSanPham()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Ma
		{
			get
			{
				return this._Ma;
			}
			set
			{
				if ((this._Ma != value))
				{
					this.OnMaChanging(value);
					this.SendPropertyChanging();
					this._Ma = value;
					this.SendPropertyChanged("Ma");
					this.OnMaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_SanPhams", ThisKey="Ma", OtherKey="MaLoai")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NguoiDung")]
	public partial class NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Ma;
		
		private int _MaQuyen;
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private string _HoTen;
		
		private string _Email;
		
		private EntityRef<Quyen> _Quyen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChanging(int value);
    partial void OnMaChanged();
    partial void OnMaQuyenChanging(int value);
    partial void OnMaQuyenChanged();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public NguoiDung()
		{
			this._Quyen = default(EntityRef<Quyen>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Ma
		{
			get
			{
				return this._Ma;
			}
			set
			{
				if ((this._Ma != value))
				{
					this.OnMaChanging(value);
					this.SendPropertyChanging();
					this._Ma = value;
					this.SendPropertyChanged("Ma");
					this.OnMaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", DbType="Int NOT NULL")]
		public int MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					if (this._Quyen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quyen_NguoiDung", Storage="_Quyen", ThisKey="MaQuyen", OtherKey="Ma", IsForeignKey=true)]
		public Quyen Quyen
		{
			get
			{
				return this._Quyen.Entity;
			}
			set
			{
				Quyen previousValue = this._Quyen.Entity;
				if (((previousValue != value) 
							|| (this._Quyen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Quyen.Entity = null;
						previousValue.NguoiDungs.Remove(this);
					}
					this._Quyen.Entity = value;
					if ((value != null))
					{
						value.NguoiDungs.Add(this);
						this._MaQuyen = value.Ma;
					}
					else
					{
						this._MaQuyen = default(int);
					}
					this.SendPropertyChanged("Quyen");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Quyen")]
	public partial class Quyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Ma;
		
		private string _Ten;
		
		private EntitySet<NguoiDung> _NguoiDungs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChanging(int value);
    partial void OnMaChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    #endregion
		
		public Quyen()
		{
			this._NguoiDungs = new EntitySet<NguoiDung>(new Action<NguoiDung>(this.attach_NguoiDungs), new Action<NguoiDung>(this.detach_NguoiDungs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Ma
		{
			get
			{
				return this._Ma;
			}
			set
			{
				if ((this._Ma != value))
				{
					this.OnMaChanging(value);
					this.SendPropertyChanging();
					this._Ma = value;
					this.SendPropertyChanged("Ma");
					this.OnMaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quyen_NguoiDung", Storage="_NguoiDungs", ThisKey="Ma", OtherKey="MaQuyen")]
		public EntitySet<NguoiDung> NguoiDungs
		{
			get
			{
				return this._NguoiDungs;
			}
			set
			{
				this._NguoiDungs.Assign(value);
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
		
		private void attach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.Quyen = this;
		}
		
		private void detach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.Quyen = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Ma;
		
		private int _MaLoai;
		
		private string _Ten;
		
		private string _HinhAnh;
		
		private string _MieuTa;
		
		private int _Gia;
		
		private System.DateTime _NgaySX;
		
		private EntityRef<LoaiSanPham> _LoaiSanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChanging(int value);
    partial void OnMaChanged();
    partial void OnMaLoaiChanging(int value);
    partial void OnMaLoaiChanged();
    partial void OnTenChanging(string value);
    partial void OnTenChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnMieuTaChanging(string value);
    partial void OnMieuTaChanged();
    partial void OnGiaChanging(int value);
    partial void OnGiaChanged();
    partial void OnNgaySXChanging(System.DateTime value);
    partial void OnNgaySXChanged();
    #endregion
		
		public SanPham()
		{
			this._LoaiSanPham = default(EntityRef<LoaiSanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Ma
		{
			get
			{
				return this._Ma;
			}
			set
			{
				if ((this._Ma != value))
				{
					this.OnMaChanging(value);
					this.SendPropertyChanging();
					this._Ma = value;
					this.SendPropertyChanged("Ma");
					this.OnMaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="Int NOT NULL")]
		public int MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					if (this._LoaiSanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Ten
		{
			get
			{
				return this._Ten;
			}
			set
			{
				if ((this._Ten != value))
				{
					this.OnTenChanging(value);
					this.SendPropertyChanging();
					this._Ten = value;
					this.SendPropertyChanged("Ten");
					this.OnTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MieuTa", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string MieuTa
		{
			get
			{
				return this._MieuTa;
			}
			set
			{
				if ((this._MieuTa != value))
				{
					this.OnMieuTaChanging(value);
					this.SendPropertyChanging();
					this._MieuTa = value;
					this.SendPropertyChanged("MieuTa");
					this.OnMieuTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int NOT NULL")]
		public int Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySX", DbType="DateTime NOT NULL")]
		public System.DateTime NgaySX
		{
			get
			{
				return this._NgaySX;
			}
			set
			{
				if ((this._NgaySX != value))
				{
					this.OnNgaySXChanging(value);
					this.SendPropertyChanging();
					this._NgaySX = value;
					this.SendPropertyChanged("NgaySX");
					this.OnNgaySXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_LoaiSanPham", ThisKey="MaLoai", OtherKey="Ma", IsForeignKey=true)]
		public LoaiSanPham LoaiSanPham
		{
			get
			{
				return this._LoaiSanPham.Entity;
			}
			set
			{
				LoaiSanPham previousValue = this._LoaiSanPham.Entity;
				if (((previousValue != value) 
							|| (this._LoaiSanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiSanPham.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._LoaiSanPham.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaLoai = value.Ma;
					}
					else
					{
						this._MaLoai = default(int);
					}
					this.SendPropertyChanged("LoaiSanPham");
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