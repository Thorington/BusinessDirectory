using Microsoft.EntityFrameworkCore;

namespace BusinessDirectory.Models
{
  public class BusinessDirectoryContext : DbContext
  {
    public BusinessDirectoryContext(DbContextOptions<BusinessDirectoryContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, BusinessType = "Restaurant", BusinessName = "Malka", BusinessWebsite="https://malkapdx.com/"},

          new Business { BusinessId = 2, BusinessType = "Restaurant", BusinessName = "Gracie's Apizza", BusinessWebsite="https://www.graciesapizza.com/" },

          new Business { BusinessId = 3, BusinessType = "Food Cart", BusinessName = "Bing Mi", BusinessWebsite="https://www.bingmipdx.com/" },

          new Business { BusinessId = 4, BusinessType = "Restaurant", BusinessName = "St. Jack", BusinessWebsite="https://stjackpdx.com//" },

          new Business { BusinessId = 5, BusinessType = "Restaurant", BusinessName = "Ringside Steakhouse", BusinessWebsite="https://www.ringsidesteakhouse.com/" },

          new Business { BusinessId = 6, BusinessType = "Restaurant", BusinessName = "Toki", BusinessWebsite="https://www.tokipdx.com/" },

          new Business { BusinessId = 7, BusinessType = "Restaurant", BusinessName = "Mucca Osteria", BusinessWebsite="https://muccaosteria.com/" },

          new Business { BusinessId = 8, BusinessType = "Restaurant", BusinessName = "Republica", BusinessWebsite="https://republicapdx.square.site/" },

          new Business { BusinessId = 9, BusinessType = "Restaurant", BusinessName = "Murata Restaurant", BusinessWebsite="https://www.muratarestaurant.com/" },

          new Business { BusinessId = 10, BusinessType = "Restaurant", BusinessName = "Lovely's Fifty Fifty", BusinessWebsite="http://www.lovelysfiftyfifty.com/" },

          new Business { BusinessId = 11, BusinessType = "Restaurant", BusinessName = "Casa Zoraya", BusinessWebsite="https://www.casazorayapdx.com/" },

          new Business { BusinessId = 12, BusinessType = "Food Cart", BusinessName = "Kabba’s Kitchen", BusinessWebsite="http://kabbaskitchen.com/?utm_source=gmb&utm_medium=referral" },

          new Business { BusinessId = 13, BusinessType = "Restaurant", BusinessName = "Eem", BusinessWebsite="http://www.eempdx.com/" },

          new Business { BusinessId = 14, BusinessType = "Food Cart", BusinessName = "Erica's Soul Food", BusinessWebsite="http://www.ericassoulfood.com/blicapdx.square.site/" },

          new Business { BusinessId = 15, BusinessType = "Food Cart", BusinessName = "Kee’s Loaded Kitchen", BusinessWebsite="https://www.instagram.com/keesloadedkitchen/" },

          new Business { BusinessId = 16, BusinessType = "Restaurant", BusinessName = "Berlu", BusinessWebsite="https://www.berlupdx.com//" },

          new Business { BusinessId = 17, BusinessType = "Restaurant", BusinessName = "Nong's Khao Man Gai", BusinessWebsite="http://www.khaomangai.com/" },

          new Business { BusinessId = 18, BusinessType = "Restaurant", BusinessName = "Le Pigeon", BusinessWebsite="https://www.lepigeon.com/" },

          new Business { BusinessId = 19, BusinessType = "Restaurant", BusinessName = "Matta", BusinessWebsite="http://mattapdx.com/" },

          new Business { BusinessId = 20, BusinessType = "Bar", BusinessName = "Scotch Lodge", BusinessWebsite="http://scotchlodge.com/" },

          new Business { BusinessId = 21, BusinessType = "Restaurant", BusinessName = "Normandie", BusinessWebsite="http://www.normandiepdx.com/" },

          new Business { BusinessId = 22, BusinessType = "Restaurant", BusinessName = "Kachka", BusinessWebsite="http://kachkapdx.com/" },

          new Business { BusinessId = 23, BusinessType = "Restaurant", BusinessName = "Hat Yai", BusinessWebsite="http://www.hatyaipdx.com/" },

          new Business { BusinessId = 24, BusinessType = "Restaurant", BusinessName = "Nimblefish", BusinessWebsite="http://www.nimblefishpdx.com/" },

          new Business { BusinessId = 25, BusinessType = "Restaurant", BusinessName = "Quaintrelle", BusinessWebsite="http://www.quaintrelle.co/" },

          new Business { BusinessId = 26, BusinessType = "Restaurant", BusinessName = "Jacqueline", BusinessWebsite="http://www.jacquelinepdx.com/" },

          new Business { BusinessId = 27, BusinessType = "Restaurant", BusinessName = "Mirisata", BusinessWebsite="http://www.mirisata.com/" },

          new Business { BusinessId = 28, BusinessType = "Restaurant", BusinessName = "Magna Kusina", BusinessWebsite="https://www.magnapdx.com/" },

          new Business { BusinessId = 29, BusinessType = "Restaurant", BusinessName = "Ripe Cooperative", BusinessWebsite="http://www.ripecooperative.com/" },

          new Business { BusinessId = 30, BusinessType = "Restaurant", BusinessName = "Urdaneta", BusinessWebsite="http://urdanetapdx.com/" },

          new Business { BusinessId = 31, BusinessType = "Restaurant", BusinessName = "Oma's Hideaway", BusinessWebsite="http://omashideaway.com/" },

          new Business { BusinessId = 32, BusinessType = "Restaurant", BusinessName = "Cafe Rowan", BusinessWebsite="http://www.caferowan.com/" },

          new Business { BusinessId = 33, BusinessType = "Restaurant", BusinessName = "Kim Jong Grillin", BusinessWebsite="http://kjgpdx.com/" },

          new Business { BusinessId = 34, BusinessType = "Restaurant", BusinessName = "Dirty Lettuce", BusinessWebsite="http://dirtylettuce.square.site/" },

          new Business { BusinessId = 35, BusinessType = "Restaurant", BusinessName = "Rose VL Deli", BusinessWebsite="https://www.facebook.com/JaydenLHV" },

          new Business { BusinessId = 36, BusinessType = "Food Cart", BusinessName = "Tierra Del Sol Cuisine and Catering", BusinessWebsite="http://www.tierradelsolpdx.com/" },

          new Business { BusinessId = 37, BusinessType = "Art Gallery", BusinessName = "Nationale", BusinessWebsite="https://www.nationale.us/" },

          new Business { BusinessId = 38, BusinessType = "Art Gallery", BusinessName = "Froelick Gallery", BusinessWebsite="https://froelickgallery.com/" },

          new Business { BusinessId = 39, BusinessType = "Art Gallery", BusinessName = "Froelick Gallery", BusinessWebsite="https://froelickgallery.com/" },

          new Business { BusinessId = 40, BusinessType = "Art Gallery", BusinessName = "Blackfish Gallery", BusinessWebsite="https://www.blackfish.com/" }
          
        );
    }
      
      public DbSet<Business> Businesses { get; set; }
      
  }
}