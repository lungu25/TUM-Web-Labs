namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertSmartphone2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Smartphones (Name,PicturePath,Price,OperatingSystem,Camera,Display,CPU,Memory,Battery,Dimension,Weight,Port) " +
                "VALUES ( 'Samsung Galaxy J3 Duos 2016 (J320H), Black','~/Content/Images/SamsungGalaxyJ3Duos2016(J320H)Black.jpg',115," +
                "'Android OS, v5.1.1 (Lollipop)','8 Mp, Front - 5 Mp, Video -1080p (Full HD)'," +
                "'5.0, 720 x 1280p','CPU - Quad-core 1.3 GHz Cortex-A7'," +
                "'8 GB, 1.5 GB RAM','2600 mAh','142.3 x 71 x 7.9 mm','138','Dual SIM (micro) | microSD up to 256 GB')");

            Sql("INSERT INTO Smartphones (Name,PicturePath,Price,OperatingSystem,Camera,Display,CPU,Memory,Battery,Dimension,Weight,Port) " +
                "VALUES ( 'Samsung Galaxy J5 2016 Duos (J510H), Black','~/Content/Images/SamsungGalaxyJ52016Duos(J510H)Black',165," +
                "'Android OS, v6.0.1 (Marshmallow)','13 Mp, Front - 5 Mp, Video -1080p (Full HD)'," +
                "'5.2, 720 x 1280p','CPU - Quad-core 1.2 GHz Cortex-A53'," +
                "'16 GB, 2 GB RAM','3100 mAh','145.8 x 72.3 x 8.1 mm','159','Dual SIM (micro) | microSD up to 256 GB')");



        }

        public override void Down()
        {
        }
    }
}
