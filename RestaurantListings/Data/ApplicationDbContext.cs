using RestaurantListings.Data.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RestaurantListings.Data.Converters;
using System.Collections.Generic;

namespace RestaurantListings.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Restaurant> Restaurants { get; protected set; }
        public DbSet<Rating> Ratings { get;  set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Restaurant>(e =>
            {
                e.HasKey(p => p.Id);

                e.Property(p => p.Name)
                    .HasMaxLength(50)
                    .IsRequired();

                e.Property(p => p.Address)
                    .HasMaxLength(200)
                    .IsRequired();

                e.Property(p => p.PhoneNumber)
                    .HasMaxLength(20)
                    .IsRequired();

                e.Property(p => p.Description)
                    .HasMaxLength(200);

                e.Property(p => p.Rating)
                    .IsRequired()
                    .HasColumnType("decimal(5, 2)");

                e.Property(p => p.Tags)
                    .HasConversion(new ListConverter<string>())
                    .Metadata
                    .SetValueComparer(new ListConverter<string>.Comparer());

                e.HasData(
                    new Restaurant
                    {
                        Id = 1,
                        Name = "Yokohama",
                        Address = "331 Roundhay Road, Harehills, Leeds, LS8 4HT",
                        PhoneNumber = "+44-011-355-5011",
                        FamilyFriendly = false,
                        VeganFriendly = true,
                        Rating = 5.0M,
                        Tags = new List<string>() { "Japanese", "Asian", "Healthy" },
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent condimentum convallis arcu, vel iaculis tortor. Pellentesque eu ex libero. Vestibulum sit amet lacus lacinia, sagittis odio sit amet, bibendum ipsum. Quisque bibendum rutrum feugiat. Aenean sodales finibus posuere. Cras aliquam a elit vel sagittis. Donec ac libero ex. Quisque nec sapien augue. Vivamus non ipsum a dolor mollis tincidunt vel eget enim. Sed consectetur sem tempus euismod ultricies.",
                        PhotoUri = "/images/yokohama.jpg"
                    },
                    new Restaurant
                    {
                        Id = 2,
                        Name = "Falafel Guys",
                        Address = "50 Briggate, Leeds, LS1 6HD",
                        PhoneNumber = "+44-011-355-5337",
                        FamilyFriendly = true,
                        VeganFriendly = true,
                        Rating = 4.5M,
                        Tags = new List<string>() { "Fast food", "Healthy", "British" },
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare mauris sed tortor sodales, sed dapibus mauris maximus. Aliquam quis consectetur nisl. Pellentesque nec lacus erat. In nec tristique justo, at pulvinar quam. Suspendisse finibus mi sit amet rhoncus pharetra. Phasellus finibus augue ac molestie imperdiet. Quisque ac rhoncus lorem, sed vestibulum felis. Maecenas pharetra enim justo, et faucibus ex aliquet ut. Integer congue malesuada luctus. Donec egestas, libero eu consequat consequat, orci magna dictum erat, at auctor magna sem et lectus. Mauris vehicula ornare risus eget posuere. Curabitur eget ultricies purus. Pellentesque ac justo vehicula, congue arcu sed, varius sapien.",
                        PhotoUri = "/images/falafel.jpg"
                    },
                    new Restaurant
                    {
                        Id = 3,
                        Name = "Bengal Brasserie",
                        Address = "65 Haddon Road, Burley, Leeds, LS4 2JE",
                        PhoneNumber = "+44-011-355-5564",
                        FamilyFriendly = true,
                        VeganFriendly = true,
                        Rating = 4.0M,
                        Tags = new List<string>() { "Indian", "Asian", "Bar" },
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dictum justo eget massa rutrum, at scelerisque ipsum fringilla. Curabitur aliquam augue tellus, ac feugiat massa volutpat eget. Praesent fringilla accumsan purus, vitae interdum eros tempus vitae. Sed malesuada pharetra tristique. Sed vel consectetur nunc. Fusce mattis egestas libero non auctor. Phasellus aliquam ex eu accumsan rhoncus. Sed sed ex ut massa facilisis finibus. Vestibulum sed mauris eget sapien vestibulum viverra at nec ex. Integer eleifend malesuada rhoncus.",
                        PhotoUri = "/images/bengal.jpg"
                    },
                    new Restaurant
                    {
                        Id = 4,
                        Name = "Gaucho",
                        Address = "21-22 Park Row, Leeds, LS1 5JF",
                        PhoneNumber = "+44-011-355-5456",
                        FamilyFriendly = false,
                        VeganFriendly = false,
                        Rating = 3.0M,
                        Tags = new List<string>() { "Steakhouse", "Argentinian", "Bar" },
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus venenatis venenatis velit. In hac habitasse platea dictumst. Vivamus a venenatis dui. Praesent non magna consectetur, tristique mi in, volutpat nulla. Proin risus mauris, ultricies nec fermentum ac, pretium in turpis. Aliquam erat volutpat. Fusce semper neque urna, nec lobortis lorem placerat dictum. Sed ac lobortis lectus. Proin pharetra neque quis purus blandit vestibulum. Aenean lobortis, libero fringilla cursus malesuada, dolor nisl pulvinar felis, quis mollis lacus nisl fringilla arcu. Donec eget maximus urna. Etiam vitae velit nulla. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In tristique non dui ac pretium. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
                        PhotoUri = "/images/gaucho.jpg"
                    },
                    new Restaurant
                    {
                        Id = 5,
                        Name = "Viva Cuba",
                        Address = "342 Kirkstall Road, Leeds, LS4 2DS",
                        PhoneNumber = "+44-011-355-5894",
                        FamilyFriendly = true,
                        VeganFriendly = true,
                        Rating = 4.2M,
                        Tags = new List<string>() { "Latin", "Spanish", "Cuban" },
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sagittis tortor vel sem blandit, eget dignissim dolor porttitor. Morbi elementum lectus vitae velit elementum, quis porta purus porta. Morbi a tincidunt risus. Nam vitae enim sit amet metus imperdiet finibus. Duis id nisl sed nunc bibendum condimentum. Nunc faucibus porta leo. Ut hendrerit odio sed elit lobortis, eu euismod lacus egestas. Vivamus lacus odio, laoreet non turpis in, porttitor luctus tortor.",
                        PhotoUri = "/images/viva.jpg"
                    },
                    new Restaurant
                    {
                        Id = 6,
                        Name = "The Brunswick",
                        Address = "82 North Street, Leeds, LS2 7PN",
                        PhoneNumber = "+44-011-355-5955",
                        FamilyFriendly = true,
                        VeganFriendly = true,
                        Rating = 3.7M,
                        Tags = new List<string>() { "Bar", "British", "Pub" },
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam egestas sapien vel augue consectetur laoreet. Aliquam consequat purus non nibh euismod sollicitudin vitae id eros. Donec vehicula odio eu malesuada sollicitudin. Cras pulvinar elit nec urna sagittis, id convallis arcu tristique. Mauris vulputate sem in ornare vulputate. Donec dictum est sit amet neque laoreet, in dictum ex facilisis. Quisque porta lectus ac libero sodales consectetur. Nullam non pharetra eros, in scelerisque diam. Sed malesuada tellus in risus gravida, eu sagittis nibh pretium.",
                        PhotoUri = "/images/brunswick.jpg"
                    }
                );
            });
        }
    }
}
