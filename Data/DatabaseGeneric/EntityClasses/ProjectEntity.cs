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

	/// <summary>Entity class which represents the entity 'Project'.<br/><br/></summary>
	[Serializable]
	public partial class ProjectEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<LogEntity> _logs;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static ProjectEntityStaticMetaData _staticMetaData = new ProjectEntityStaticMetaData();
		private static ProjectRelations _relationsFactory = new ProjectRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Logs</summary>
			public static readonly string Logs = "Logs";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProjectEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProjectEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProjectEntity", InheritanceHierarchyType.None, false, (int)Data.DailyLog.EntityType.ProjectEntity, typeof(ProjectEntity), typeof(ProjectEntityFactory), false);
				AddNavigatorMetaData<ProjectEntity, EntityCollection<LogEntity>>("Logs", a => a._logs, (a, b) => a._logs = b, a => a.Logs, () => new ProjectRelations().LogEntityUsingProjectId, typeof(LogEntity), (int)Data.DailyLog.EntityType.LogEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProjectEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProjectEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProjectEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProjectEntity</param>
		public ProjectEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Project which data should be fetched into this Project object</param>
		public ProjectEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Project which data should be fetched into this Project object</param>
		/// <param name="validator">The custom validator object for this ProjectEntity</param>
		public ProjectEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProjectEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Log' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLogs() { return CreateRelationInfoForNavigator("Logs"); }
		
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
		/// <param name="validator">The validator object for this ProjectEntity</param>
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
		public static ProjectRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Log' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLogs { get { return _staticMetaData.GetPrefetchPathElement("Logs", CommonEntityBase.CreateEntityCollection<LogEntity>()); } }

		/// <summary>The Id property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "project"."id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)ProjectFieldIndex.Id, true); }
			set { SetValue((int)ProjectFieldIndex.Id, value); }		}

		/// <summary>The ImagePath property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "project"."image_path".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ImagePath
		{
			get { return (System.String)GetValue((int)ProjectFieldIndex.ImagePath, true); }
			set	{ SetValue((int)ProjectFieldIndex.ImagePath, value); }
		}

		/// <summary>The Title property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "project"."title".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 100.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)ProjectFieldIndex.Title, true); }
			set	{ SetValue((int)ProjectFieldIndex.Title, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'LogEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(LogEntity))]
		public virtual EntityCollection<LogEntity> Logs { get { return GetOrCreateEntityCollection<LogEntity, LogEntityFactory>("Project", true, false, ref _logs); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace Data.DailyLog
{
	public enum ProjectFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>ImagePath. </summary>
		ImagePath,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Data.DailyLog.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Project. </summary>
	public partial class ProjectRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ProjectEntity and LogEntity over the 1:n relation they have, using the relation between the fields: Project.Id - Log.ProjectId</summary>
		public virtual IEntityRelation LogEntityUsingProjectId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Logs", true, new[] { ProjectFields.Id, LogFields.ProjectId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProjectRelations
	{
		internal static readonly IEntityRelation LogEntityUsingProjectIdStatic = new ProjectRelations().LogEntityUsingProjectId;

		/// <summary>CTor</summary>
		static StaticProjectRelations() { }
	}
}
