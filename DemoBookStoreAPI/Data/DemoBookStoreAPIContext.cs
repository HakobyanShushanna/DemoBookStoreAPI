using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoBookStoreAPI.Data
{
    public class DemoBookStoreAPIContext : IdentityDbContext<UserModel>
    {
        public DemoBookStoreAPIContext(DbContextOptions<DemoBookStoreAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().ToTable("AspNetUsers");
            modelBuilder.Entity<AuthorModel>().ToTable("Authors");


            modelBuilder.Entity<AwardModel>()
                .HasOne(a => a.Creator)
                .WithMany(u => u.CreatedAwards)
                .HasForeignKey("CreatorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PollModel>()
                .HasOne(v => v.Creator)
                .WithMany(u => u.CreatedPolls)
                .HasForeignKey("CreatorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PollModel>()
                .HasMany(v => v.VotedUsers)
                .WithMany(u => u.Voted)
                .UsingEntity<Dictionary<string, object>>(
                    "UserVoteAwards",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<PollModel>().WithMany().HasForeignKey("VoteAwardId"),
                    j => j.HasKey("UserId", "VoteAwardId")
                );

            modelBuilder.Entity<AwardModel>()
                .HasMany(a => a.Funders)
                .WithMany(u => u.FundedAwards)
                .UsingEntity<Dictionary<string, object>>(
                    "UserFundedAwards",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<AwardModel>().WithMany().HasForeignKey("AwardId"),
                    j => j.HasKey("UserId", "AwardId")
                );

            modelBuilder.Entity<PollModel>()
                .HasMany(v => v.Funders)
                .WithMany(u => u.FundedPolls)
                .UsingEntity<Dictionary<string, object>>(
                    "UserFundedVoteAwards",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<PollModel>().WithMany().HasForeignKey("VoteAwardId"),
                    j => j.HasKey("UserId", "VoteAwardId")
                );
        }

        public DbSet<BookShop.Models.BookModel> Book { get; set; } = default!;
        public DbSet<BookShop.Models.AuthorModel> Author { get; set; } = default!;
        public DbSet<BookShop.Models.UserModel> User { get; set; } = default!;
        public DbSet<BookShop.Models.OrderModel> Orders { get; set; } = default!;
        public DbSet<BookShop.Models.ReviewModel> Review { get; set; } = default!;
        public DbSet<PollModel> VoteAwards { get; set; }
        public DbSet<VoteOptionModel> Options { get; set; }
        public DbSet<OrderBookModel> OrderBook { get; set; }


    }
}
