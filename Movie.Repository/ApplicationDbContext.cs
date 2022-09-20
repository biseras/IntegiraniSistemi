using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie.Domain.Domain;
using Movie.Domain.Identity;
using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository
{
    public class ApplicationDbContext : IdentityDbContext<MovieUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<MovieFilm> Films { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<FilminShoppingCart> FilminShoppingCarts { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Conventious.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(builder);

            builder.Entity<MovieFilm>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            /*builder.Entity<TicketsinShoppingCart>()
                .HasKey(z => new
                {
                    z.TicketId,
                    z.ShoppingCartId
                });*/
            builder.Entity<FilminShoppingCart>()
                .HasOne(z => z.film)
                .WithMany(z => z.filmsinshoppingcart)
                .HasForeignKey(z => z.ShoppingCartId);
            builder.Entity<FilminShoppingCart>()
                .HasOne(z => z.shoppingcart)
                .WithMany(z => z.filmsinshoppingcart)
                .HasForeignKey(z => z.FilmId);
            builder.Entity<ShoppingCart>()
                .HasOne<MovieUsers>(z => z.Owner)
                .WithOne(z => z.UserCart)
                .HasForeignKey<ShoppingCart>(z => z.OwnerId);
            /*builder.Entity<TicketInOrder>()
                .HasKey(z => new
                {
                    z.TicketId,
                    z.OrderId
                });*/
            builder.Entity<FilmInOrder>()
                .HasOne(z => z.SelectedFilm)
                .WithMany(z => z.Orders)
                .HasForeignKey(z => z.FilmId);
            builder.Entity<FilmInOrder>()
                .HasOne(z => z.UserOrder)
                .WithMany(z => z.FilmInOrders)
                .HasForeignKey(z => z.OrderId);
        }


    }
}
