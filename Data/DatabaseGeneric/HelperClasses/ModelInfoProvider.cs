﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using Data.DailyLog.FactoryClasses;
using Data.DailyLog.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Data.DailyLog.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitLogEntityInfo();
			InitProjectEntityInfo();
			InitUserEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits LogEntity's info objects</summary>
		private void InitLogEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(LogFieldIndex), "LogEntity");
			this.AddElementFieldInfo("LogEntity", "CreatedByUserId", typeof(System.Int32), false, true, false, false,  (int)LogFieldIndex.CreatedByUserId, 0, 0, 20);
			this.AddElementFieldInfo("LogEntity", "DateCreatedGmt", typeof(System.DateTime), false, false, false, false,  (int)LogFieldIndex.DateCreatedGmt, 0, 0, 0);
			this.AddElementFieldInfo("LogEntity", "Details", typeof(System.String), false, false, false, false,  (int)LogFieldIndex.Details, 255, 0, 0);
			this.AddElementFieldInfo("LogEntity", "DurationInMinutes", typeof(System.Int32), false, false, false, false,  (int)LogFieldIndex.DurationInMinutes, 0, 0, 10);
			this.AddElementFieldInfo("LogEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)LogFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("LogEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)LogFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("LogEntity", "ProjectId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)LogFieldIndex.ProjectId, 0, 0, 10);
			this.AddElementFieldInfo("LogEntity", "Title", typeof(System.String), false, false, false, false,  (int)LogFieldIndex.Title, 100, 0, 0);
		}

		/// <summary>Inits ProjectEntity's info objects</summary>
		private void InitProjectEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProjectFieldIndex), "ProjectEntity");
			this.AddElementFieldInfo("ProjectEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProjectFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProjectEntity", "ImagePath", typeof(System.String), false, false, false, false,  (int)ProjectFieldIndex.ImagePath, 1073741824, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "Title", typeof(System.String), false, false, false, false,  (int)ProjectFieldIndex.Title, 100, 0, 0);
		}

		/// <summary>Inits UserEntity's info objects</summary>
		private void InitUserEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "Email", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Email, 255, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "JobTitle", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.JobTitle, 255, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Name", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Name, 100, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 550, 0, 0);
			this.AddElementFieldInfo("UserEntity", "PhoneNmber", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.PhoneNmber, 255, 0, 0);
		}
	}
}