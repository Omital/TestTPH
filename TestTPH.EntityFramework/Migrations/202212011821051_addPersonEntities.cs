namespace TestTPH.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    public partial class addPersonEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FormalName = c.String(maxLength: 128),
                    CreatorUserId = c.Long(),
                    CreationTime = c.DateTime(nullable: false),
                    LastModifierUserId = c.Long(),
                    LastModificationTime = c.DateTime(),
                    DeleterUserId = c.Long(),
                    DeletionTime = c.DateTime(),
                    IsDeleted = c.Boolean(nullable: false),
                    ManagerName = c.String(maxLength: 128),
                    Name = c.String(maxLength: 128),
                    Family = c.String(maxLength: 128),
                    Discriminator = c.String(nullable: false, maxLength: 128),
                },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_LegalPerson_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_Person_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_RealPerson_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);

            CreateTable(
                "dbo.PersonExtraDetail",
                c => new
                {
                    PersonId = c.Int(nullable: false),
                    Address = c.String(maxLength: 128),
                    Code = c.String(maxLength: 128),
                    CreatorUserId = c.Long(),
                    CreationTime = c.DateTime(nullable: false),
                    LastModifierUserId = c.Long(),
                    LastModificationTime = c.DateTime(),
                    DeleterUserId = c.Long(),
                    DeletionTime = c.DateTime(),
                    IsDeleted = c.Boolean(nullable: false),
                },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PersonExtraDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.IsDeleted);

        }

        public override void Down()
        {
            DropForeignKey("dbo.PersonExtraDetail", "PersonId", "dbo.Person");
            DropIndex("dbo.PersonExtraDetail", new[] { "IsDeleted" });
            DropIndex("dbo.PersonExtraDetail", new[] { "PersonId" });
            DropIndex("dbo.Person", new[] { "IsDeleted" });
            DropTable("dbo.PersonExtraDetail",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PersonExtraDetail_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Person",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_LegalPerson_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_Person_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_RealPerson_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
