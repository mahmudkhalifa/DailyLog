﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Data.DailyLog.HelperClasses
{
	/// <summary>Field Creation Class for entity LogEntity</summary>
	public partial class LogFields
	{
		/// <summary>Creates a new LogEntity.CreatedByUserId field instance</summary>
		public static EntityField2 CreatedByUserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.CreatedByUserId); }}
		/// <summary>Creates a new LogEntity.DateCreatedGmt field instance</summary>
		public static EntityField2 DateCreatedGmt { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.DateCreatedGmt); }}
		/// <summary>Creates a new LogEntity.Details field instance</summary>
		public static EntityField2 Details { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.Details); }}
		/// <summary>Creates a new LogEntity.DurationInMinutes field instance</summary>
		public static EntityField2 DurationInMinutes { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.DurationInMinutes); }}
		/// <summary>Creates a new LogEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.Id); }}
		/// <summary>Creates a new LogEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.IsActive); }}
		/// <summary>Creates a new LogEntity.ProjectId field instance</summary>
		public static EntityField2 ProjectId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.ProjectId); }}
		/// <summary>Creates a new LogEntity.Title field instance</summary>
		public static EntityField2 Title { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(LogFieldIndex.Title); }}
	}

	/// <summary>Field Creation Class for entity ProjectEntity</summary>
	public partial class ProjectFields
	{
		/// <summary>Creates a new ProjectEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProjectFieldIndex.Id); }}
		/// <summary>Creates a new ProjectEntity.ImagePath field instance</summary>
		public static EntityField2 ImagePath { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProjectFieldIndex.ImagePath); }}
		/// <summary>Creates a new ProjectEntity.Title field instance</summary>
		public static EntityField2 Title { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProjectFieldIndex.Title); }}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.Email field instance</summary>
		public static EntityField2 Email { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Email); }}
		/// <summary>Creates a new UserEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Id); }}
		/// <summary>Creates a new UserEntity.JobTitle field instance</summary>
		public static EntityField2 JobTitle { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.JobTitle); }}
		/// <summary>Creates a new UserEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Name); }}
		/// <summary>Creates a new UserEntity.Password field instance</summary>
		public static EntityField2 Password { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Password); }}
		/// <summary>Creates a new UserEntity.PhoneNmber field instance</summary>
		public static EntityField2 PhoneNmber { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.PhoneNmber); }}
	}
	

}