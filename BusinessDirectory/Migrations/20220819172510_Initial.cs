using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessDirectory.solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BusinessType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    BusinessName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    BusinessWebsite = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "BusinessName", "BusinessType", "BusinessWebsite" },
                values: new object[,]
                {
                    { 1, "Malka", "Restaurant", "https://malkapdx.com/" },
                    { 23, "Hat Yai", "Restaurant", "http://www.hatyaipdx.com/" },
                    { 24, "Nimblefish", "Restaurant", "http://www.nimblefishpdx.com/" },
                    { 25, "Quaintrelle", "Restaurant", "http://www.quaintrelle.co/" },
                    { 26, "Jacqueline", "Restaurant", "http://www.jacquelinepdx.com/" },
                    { 27, "Mirisata", "Restaurant", "http://www.mirisata.com/" },
                    { 28, "Magna Kusina", "Restaurant", "https://www.magnapdx.com/" },
                    { 29, "Ripe Cooperative", "Restaurant", "http://www.ripecooperative.com/" },
                    { 22, "Kachka", "Restaurant", "http://kachkapdx.com/" },
                    { 30, "Urdaneta", "Restaurant", "http://urdanetapdx.com/" },
                    { 32, "Cafe Rowan", "Restaurant", "http://www.caferowan.com/" },
                    { 33, "Kim Jong Grillin", "Restaurant", "http://kjgpdx.com/" },
                    { 34, "Dirty Lettuce", "Restaurant", "http://dirtylettuce.square.site/" },
                    { 35, "Rose VL Deli", "Restaurant", "https://www.facebook.com/JaydenLHV" },
                    { 36, "Tierra Del Sol Cuisine and Catering", "Food Cart", "http://www.tierradelsolpdx.com/" },
                    { 37, "Nationale", "Art Gallery", "https://www.nationale.us/" },
                    { 38, "Froelick Gallery", "Art Gallery", "https://froelickgallery.com/" },
                    { 31, "Oma's Hideaway", "Restaurant", "http://omashideaway.com/" },
                    { 21, "Normandie", "Restaurant", "http://www.normandiepdx.com/" },
                    { 20, "Scotch Lodge", "Bar", "http://scotchlodge.com/" },
                    { 19, "Matta", "Restaurant", "http://mattapdx.com/" },
                    { 2, "Gracie's Apizza", "Restaurant", "https://www.graciesapizza.com/" },
                    { 3, "Bing Mi", "Food Cart", "https://www.bingmipdx.com/" },
                    { 4, "St. Jack", "Restaurant", "https://stjackpdx.com//" },
                    { 5, "Ringside Steakhouse", "Restaurant", "https://www.ringsidesteakhouse.com/" },
                    { 6, "Toki", "Restaurant", "https://www.tokipdx.com/" },
                    { 7, "Mucca Osteria", "Restaurant", "https://muccaosteria.com/" },
                    { 8, "Republica", "Restaurant", "https://republicapdx.square.site/" },
                    { 9, "Murata Restaurant", "Restaurant", "https://www.muratarestaurant.com/" },
                    { 10, "Lovely's Fifty Fifty", "Restaurant", "http://www.lovelysfiftyfifty.com/" },
                    { 11, "Casa Zoraya", "Restaurant", "https://www.casazorayapdx.com/" },
                    { 12, "Kabba’s Kitchen", "Food Cart", "http://kabbaskitchen.com/?utm_source=gmb&utm_medium=referral" },
                    { 13, "Eem", "Restaurant", "http://www.eempdx.com/" },
                    { 14, "Erica's Soul Food", "Food Cart", "https://repuhttp://www.ericassoulfood.com/blicapdx.square.site/" },
                    { 15, "Kee’s Loaded Kitchen", "Food Cart", "https://www.instagram.com/keesloadedkitchen/" },
                    { 16, "Berlu", "Restaurant", "https://www.berlupdx.com//" },
                    { 17, "Nong's Khao Man Gai", "Restaurant", "http://www.khaomangai.com/" },
                    { 18, "Le Pigeon", "Restaurant", "https://www.lepigeon.com/" },
                    { 39, "Froelick Gallery", "Art Gallery", "https://froelickgallery.com/" },
                    { 40, "Blackfish Gallery", "Art Gallery", "https://www.blackfish.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
