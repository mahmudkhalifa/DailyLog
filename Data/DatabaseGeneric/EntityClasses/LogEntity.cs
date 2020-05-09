﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Data.DailyLog.HelperClasses;
using Data.DailyLog.FactoryClasses;
using Data.DailyLog.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Data.DailyLog.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Log'.<br/><br/></summary>
	[Serializable]
	public partial class LogEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private ProjectEntity _project;
		private UserEntity _userEntity;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static LogEntityStaticMetaData _staticMetaData = new LogEntityStaticMetaData();
		private static LogRelations _relationsFactory = new LogRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Project</summary>
			public static readonly string Project = "Project";
			/// <summary>Member name UserEntity</summary>
			public static readonly string User = "UserEntity";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class LogEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public LogEntityStaticMetaData()
			{
				SetEntityCoreInfo("LogEntity", InheritanceHierarchyType.None, false, (int)Data.DailyLog.EntityType.LogEntity, typeof(LogEntity), typeof(LogEntityFactory), false);
				AddNavigatorMetaData<LogEntity, ProjectEntity>("Project", "Logs", (a, b) => a._project = b, a => a._project, (a, b) => a.Project = b, Data.DailyLog.RelationClasses.StaticLogRelations.ProjectEntityUsingProjectIdStatic, ()=>new LogRelations().ProjectEntityUsingProjectId, null, new int[] { (int)LogFieldIndex.ProjectId }, null, true, (int)Data.DailyLog.EntityType.ProjectEntity);
				AddNavigatorMetaData<LogEntity, UserEntity>("UserEntity", "Logs", (a, b) => a._userEntity = b, a => a._userEntity, (a, b) => a.UserEntity = b, Data.DailyLog.RelationClasses.StaticLogRelations.UserEntityUsingCreatedByUserIdStatic, ()=>new LogRelations().UserEntityUsingCreatedByUserId, null, new int[] { (int)LogFieldIndex.CreatedByUserId }, null, true, (int)Data.DailyLog.EntityType.UserEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static LogEntity()
		{
		}

		/// <summary> CTor</summary>
		public LogEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public LogEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this LogEntity</param>
		public LogEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Log which data should be fetched into this Log object</param>
		public LogEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Log which data should be fetched into this Log object</param>
		/// <param name="validator">The custom validator object for this LogEntity</param>
		public LogEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Project' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProject() { return CreateRelationInfoForNavigator("Project"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UserEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser() { return CreateRelationInfoForNavigator("UserEntity"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this LogEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static LogRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Project' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProject { get { return _staticMetaData.GetPrefetchPathElement("Project", CommonEntityBase.CreateEntityCollection<ProjectEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser { get { return _staticMetaData.GetPrefetchPathElement("UserEntity", CommonEntityBase.CreateEntityCollection<UserEntity>()); } }

		/// <summary>The CreatedByUserId property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."created_by_user_id".<br/>Table field type characteristics (type, precision, scale, length): Bigint, 20, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CreatedByUserId
		{
			get { return (System.Int32)GetValue((int)LogFieldIndex.CreatedByUserId, true); }
			set	{ SetValue((int)LogFieldIndex.CreatedByUserId, value); }
		}

		/// <summary>The DateCreatedGmt property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."date_created_gmt".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreatedGmt
		{
			get { return (System.DateTime)GetValue((int)LogFieldIndex.DateCreatedGmt, true); }
			set	{ SetValue((int)LogFieldIndex.DateCreatedGmt, value); }
		}

		/// <summary>The Details property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."details".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Details
		{
			get { return (System.String)GetValue((int)LogFieldIndex.Details, true); }
			set	{ SetValue((int)LogFieldIndex.Details, value); }
		}

		/// <summary>The DurationInMinutes property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."duration_in_minutes".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DurationInMinutes
		{
			get { return (System.Int32)GetValue((int)LogFieldIndex.DurationInMinutes, true); }
			set	{ SetValue((int)LogFieldIndex.DurationInMinutes, value); }
		}

		/// <summary>The Id property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)LogFieldIndex.Id, true); }
			set { SetValue((int)LogFieldIndex.Id, value); }		}

		/// <summary>The IsActive property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)LogFieldIndex.IsActive, true); }
			set	{ SetValue((int)LogFieldIndex.IsActive, value); }
		}

		/// <summary>The ProjectId property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."project_id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProjectId
		{
			get { return (Nullable<System.Int32>)GetValue((int)LogFieldIndex.ProjectId, false); }
			set	{ SetValue((int)LogFieldIndex.ProjectId, value); }
		}

		/// <summary>The Title property of the Entity Log<br/><br/></summary>
		/// <remarks>Mapped on  table field: "log"."title".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 100.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)LogFieldIndex.Title, true); }
			set	{ SetValue((int)LogFieldIndex.Title, value); }
		}

		/// <summary>Gets / sets related entity of type 'ProjectEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProjectEntity Project
		{
			get { return _project; }
			set { SetSingleRelatedEntityNavigator(value, "Project"); }
		}

		/// <summary>Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity UserEntity
		{
			get { return _userEntity; }
			set { SetSingleRelatedEntityNavigator(value, "UserEntity"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace Data.DailyLog
{
	public enum LogFieldIndex
	{
		///<summary>CreatedByUserId. </summary>
		CreatedByUserId,
		///<summary>DateCreatedGmt. </summary>
		DateCreatedGmt,
		///<summary>Details. </summary>
		Details,
		///<summary>DurationInMinutes. </summary>
		DurationInMinutes,
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>ProjectId. </summary>
		ProjectId,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Data.DailyLog.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Log. </summary>
	public partial class LogRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between LogEntity and ProjectEntity over the m:1 relation they have, using the relation between the fields: Log.ProjectId - Project.Id</summary>
		public virtual IEntityRelation ProjectEntityUsingProjectId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Project", false, new[] { ProjectFields.Id, LogFields.ProjectId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between LogEntity and UserEntity over the m:1 relation they have, using the relation between the fields: Log.CreatedByUserId - UserEntity.Id</summary>
		public virtual IEntityRelation UserEntityUsingCreatedByUserId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "UserEntity", false, new[] { UserFields.Id, LogFields.CreatedByUserId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticLogRelations
	{
		internal static readonly IEntityRelation ProjectEntityUsingProjectIdStatic = new LogRelations().ProjectEntityUsingProjectId;
		internal static readonly IEntityRelation UserEntityUsingCreatedByUserIdStatic = new LogRelations().UserEntityUsingCreatedByUserId;

		/// <summary>CTor</summary>
		static StaticLogRelations() { }
	}
}
