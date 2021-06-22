﻿namespace AutoGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BannerImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bannerImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BannerImages");
        }
    }
}
