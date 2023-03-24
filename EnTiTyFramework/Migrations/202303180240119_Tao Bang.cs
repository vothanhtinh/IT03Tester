namespace EnTiTyFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoBang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
            DropTable("dbo.Classes");
        }
    }
}
