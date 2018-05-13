namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertSmartphones : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Smartphones (Name,PicturePath,Price,OperatingSystem,Camera,Display,CPU,Memory,Battery,Dimension,Weight,Port) " +
                "VALUES ( 'Xiaomi Redmi 5 Plus Dual Sim 32GB, Black','~/Content/Images/Xiaomi_Redmi_5_Plus.jpg',200," +
                "'Android 7.1.2 (Nougat)','12 Mp, Front - 5 Mp, Video 1080p'," +
                "'5.99 | 1080 x 2160','CPU - Octa-core 2.0 GHz Cortex-A53'," +
                "'32 GB, 3 GB RAM','4000 mAh','158.5 x 75.5 x 8.1 mm','180','Hybrid Dual SIM (Nano) | microSD up to 128 GB | microUSB 2.0')");
        }


        public override void Down()
        {
        }
    }
}
