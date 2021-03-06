﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Data.DailyLog.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitLogEntityMappings();
			InitProjectEntityMappings();
			InitUserEntityMappings();
		}

		/// <summary>Inits LogEntity's mappings</summary>
		private void InitLogEntityMappings()
		{
			this.AddElementMapping("LogEntity", @"DailyLog", @"public", "log", 8, 0);
			this.AddElementFieldMapping("LogEntity", "CreatedByUserId", "created_by_user_id", false, "Bigint", 0, 20, 0, false, "", new SD.LLBLGen.Pro.ORMSupportClasses.ChangeTypeConverter<System.Int32>(), typeof(System.Int64), 0);
			this.AddElementFieldMapping("LogEntity", "DateCreatedGmt", "date_created_gmt", false, "Timestamp", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LogEntity", "Details", "details", false, "Varchar", 255, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("LogEntity", "DurationInMinutes", "duration_in_minutes", false, "Integer", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("LogEntity", "Id", "id", false, "Integer", 0, 10, 0, true, "public.log_id_seq", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("LogEntity", "IsActive", "is_active", false, "Boolean", 0, 0, 0, false, "", null, typeof(System.Boolean), 5);
			this.AddElementFieldMapping("LogEntity", "ProjectId", "project_id", true, "Integer", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("LogEntity", "Title", "title", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits ProjectEntity's mappings</summary>
		private void InitProjectEntityMappings()
		{
			this.AddElementMapping("ProjectEntity", @"DailyLog", @"public", "project", 3, 0);
			this.AddElementFieldMapping("ProjectEntity", "Id", "id", false, "Integer", 0, 10, 0, true, "public.project_id_seq", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProjectEntity", "ImagePath", "image_path", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProjectEntity", "Title", "title", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"DailyLog", @"public", "user", 6, 0);
			this.AddElementFieldMapping("UserEntity", "Email", "email", false, "Varchar", 255, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("UserEntity", "Id", "id", false, "Integer", 0, 10, 0, true, "public.user_id_seq", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("UserEntity", "JobTitle", "job_title", true, "Varchar", 255, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("UserEntity", "Name", "name", false, "Varchar", 100, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("UserEntity", "Password", "password", false, "Varchar", 550, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("UserEntity", "PhoneNmber", "phone_nmber", false, "Varchar", 255, 0, 0, false, "", null, typeof(System.String), 5);
		}

	}
}
