using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class MANAGEMENTContext : DbContext
    {
        public MANAGEMENTContext()
        {
        }

        public MANAGEMENTContext(DbContextOptions<MANAGEMENTContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; } = null!;
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public virtual DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; } = null!;
        public virtual DbSet<ApplicationWiki> ApplicationWikis { get; set; } = null!;
        public virtual DbSet<ApplicationWikiCategory> ApplicationWikiCategories { get; set; } = null!;
        public virtual DbSet<ApplicationWikiLog> ApplicationWikiLogs { get; set; } = null!;
        public virtual DbSet<ApplicationWikiTag> ApplicationWikiTags { get; set; } = null!;
        public virtual DbSet<Auth> Auths { get; set; } = null!;
        public virtual DbSet<AuthLog> AuthLogs { get; set; } = null!;
        public virtual DbSet<AuthScope> AuthScopes { get; set; } = null!;
        public virtual DbSet<DiagnosticError> DiagnosticErrors { get; set; } = null!;
        public virtual DbSet<FirewallRule> FirewallRules { get; set; } = null!;
        public virtual DbSet<FirewallRuleIpAddress> FirewallRuleIpAddresses { get; set; } = null!;
        public virtual DbSet<FirewallRuleIpAddressLog> FirewallRuleIpAddressLogs { get; set; } = null!;
        public virtual DbSet<FirewallRuleLog> FirewallRuleLogs { get; set; } = null!;
        public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
        public virtual DbSet<MeetingNote> MeetingNotes { get; set; } = null!;
        public virtual DbSet<MeetingNoteFile> MeetingNoteFiles { get; set; } = null!;
        public virtual DbSet<OtpVerificationRequest> OtpVerificationRequests { get; set; } = null!;
        public virtual DbSet<OtpVerificationRequestLog> OtpVerificationRequestLogs { get; set; } = null!;
        public virtual DbSet<OtpVerificationResult> OtpVerificationResults { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectLog> ProjectLogs { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolesAuth> RolesAuths { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserAuditLog> UserAuditLogs { get; set; } = null!;
        public virtual DbSet<UserAuditLogsHistory> UserAuditLogsHistories { get; set; } = null!;
        public virtual DbSet<UserAuth> UserAuths { get; set; } = null!;
        public virtual DbSet<UserAuthLog> UserAuthLogs { get; set; } = null!;
        public virtual DbSet<UserFavoritePage> UserFavoritePages { get; set; } = null!;
        public virtual DbSet<UserForgotPasswordDone> UserForgotPasswordDones { get; set; } = null!;
        public virtual DbSet<UserForgotPasswordRequest> UserForgotPasswordRequests { get; set; } = null!;
        public virtual DbSet<UserForgotPasswordRequestLog> UserForgotPasswordRequestLogs { get; set; } = null!;
        public virtual DbSet<UserIpAddress> UserIpAddresses { get; set; } = null!;
        public virtual DbSet<UserLog> UserLogs { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserLoginFailedAttempt> UserLoginFailedAttempts { get; set; } = null!;
        public virtual DbSet<UserLoginHistory> UserLoginHistories { get; set; } = null!;
        public virtual DbSet<UserRequest> UserRequests { get; set; } = null!;
        public virtual DbSet<UserRequestLog> UserRequestLogs { get; set; } = null!;
        public virtual DbSet<ViewApplication> ViewApplications { get; set; } = null!;
        public virtual DbSet<ViewApplicationConfig> ViewApplicationConfigs { get; set; } = null!;
        public virtual DbSet<ViewApplicationDeployRequest> ViewApplicationDeployRequests { get; set; } = null!;
        public virtual DbSet<ViewApplicationDeployRequestDone> ViewApplicationDeployRequestDones { get; set; } = null!;
        public virtual DbSet<ViewApplicationDeployRequestFailed> ViewApplicationDeployRequestFaileds { get; set; } = null!;
        public virtual DbSet<ViewApplicationLoadbalance> ViewApplicationLoadbalances { get; set; } = null!;
        public virtual DbSet<ViewApplicationLoadbalanceConfig> ViewApplicationLoadbalanceConfigs { get; set; } = null!;
        public virtual DbSet<ViewApplicationUser> ViewApplicationUsers { get; set; } = null!;
        public virtual DbSet<ViewApplicationWiki> ViewApplicationWikis { get; set; } = null!;
        public virtual DbSet<ViewGithubCommit> ViewGithubCommits { get; set; } = null!;
        public virtual DbSet<ViewGithubIssue> ViewGithubIssues { get; set; } = null!;
        public virtual DbSet<ViewProject> ViewProjects { get; set; } = null!;
        public virtual DbSet<ViewServer> ViewServers { get; set; } = null!;
        public virtual DbSet<ViewTableApplicationConfig> ViewTableApplicationConfigs { get; set; } = null!;
        public virtual DbSet<ViewTableApplicationLoadbalance> ViewTableApplicationLoadbalances { get; set; } = null!;
        public virtual DbSet<ViewTableApplicationLoadbalanceConfig> ViewTableApplicationLoadbalanceConfigs { get; set; } = null!;
        public virtual DbSet<ViewTableDeployRequest> ViewTableDeployRequests { get; set; } = null!;
        public virtual DbSet<ViewTableDeployRequestDone> ViewTableDeployRequestDones { get; set; } = null!;
        public virtual DbSet<ViewTableDeployRequestFailed> ViewTableDeployRequestFaileds { get; set; } = null!;
        public virtual DbSet<ViewTableDeployRequestHistory> ViewTableDeployRequestHistories { get; set; } = null!;
        public virtual DbSet<ViewTableDeployRequestProcessing> ViewTableDeployRequestProcessings { get; set; } = null!;
        public virtual DbSet<ViewTableDeployRequestStatus> ViewTableDeployRequestStatuses { get; set; } = null!;
        public virtual DbSet<ViewTableDeploySetting> ViewTableDeploySettings { get; set; } = null!;
        public virtual DbSet<ViewTableGithubCommit> ViewTableGithubCommits { get; set; } = null!;
        public virtual DbSet<ViewTableGithubCommitsSummaryDaily> ViewTableGithubCommitsSummaryDailies { get; set; } = null!;
        public virtual DbSet<ViewTableGithubIssue> ViewTableGithubIssues { get; set; } = null!;
        public virtual DbSet<ViewTableGithubIssueAssignee> ViewTableGithubIssueAssignees { get; set; } = null!;
        public virtual DbSet<ViewTableGithubIssueSummaryDaily> ViewTableGithubIssueSummaryDailies { get; set; } = null!;
        public virtual DbSet<ViewTableGithubRepository> ViewTableGithubRepositories { get; set; } = null!;
        public virtual DbSet<ViewTableIdGeneratorDeploy> ViewTableIdGeneratorDeploys { get; set; } = null!;
        public virtual DbSet<ViewTableServer> ViewTableServers { get; set; } = null!;
        public virtual DbSet<ViewTableServerApplicationPool> ViewTableServerApplicationPools { get; set; } = null!;
        public virtual DbSet<ViewTableServerApplicationPoolStatus> ViewTableServerApplicationPoolStatuses { get; set; } = null!;
        public virtual DbSet<ViewTableServerDrive> ViewTableServerDrives { get; set; } = null!;
        public virtual DbSet<ViewTableServerIpAddress> ViewTableServerIpAddresses { get; set; } = null!;
        public virtual DbSet<ViewTableServerService> ViewTableServerServices { get; set; } = null!;
        public virtual DbSet<ViewTableServerServiceStatus> ViewTableServerServiceStatuses { get; set; } = null!;
        public virtual DbSet<ViewTableServerStatus> ViewTableServerStatuses { get; set; } = null!;
        public virtual DbSet<ViewUser> ViewUsers { get; set; } = null!;
        public virtual DbSet<ViewUserAuditLog> ViewUserAuditLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MDFK9N3\\SQLEXPRESS;Database=MANAGEMENT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AI");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("APPLICATION");

                entity.HasIndex(e => e.AppKey, "UC_APPLICATION_AppKey")
                    .IsUnique();

                entity.HasIndex(e => e.AppKey, "ix_APPLICATION_AppKey")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "ix_APPLICATION_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Type, "ix_APPLICATION_Type");

                entity.HasIndex(e => e.RefProject, "ix_APPLICATION_refProject");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(replace(CONVERT([nvarchar](50),newid(),(0))+CONVERT([nvarchar](50),newid(),(0)),'-',''))");

                entity.Property(e => e.ApplicationPool)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastConfigUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDeployTime).HasColumnType("datetime");

                entity.Property(e => e.LastDeployVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.PackageName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefGithubId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("refGithubId");

                entity.Property(e => e.RefProject).HasColumnName("refProject");

                entity.Property(e => e.Repository)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("APPLICATION_LOG");

                entity.HasIndex(e => e.AppKey, "IX_APPLICATION_LOG_AppKey")
                    .IsUnique();

                entity.HasIndex(e => e.AppKey, "UC_APPLICATION_LOG_AppKey")
                    .IsUnique();

                entity.Property(e => e.AppKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ApplicationPool)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastConfigUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDeployTime).HasColumnType("datetime");

                entity.Property(e => e.LastDeployVersion).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(400);

                entity.Property(e => e.PackageName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefGithubId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("refGithubId");

                entity.Property(e => e.RefProject).HasColumnName("refProject");

                entity.Property(e => e.Repository)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("APPLICATION_USERS");

                entity.HasIndex(e => new { e.RefApplication, e.RefUser }, "ix_APPLICATION_USERS_refApplication_refUser_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefApplicationUserRole).HasColumnName("refApplicationUserRole");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<ApplicationUserRole>(entity =>
            {
                entity.ToTable("APPLICATION_USER_ROLE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApplicationWiki>(entity =>
            {
                entity.ToTable("APPLICATION_WIKI");

                entity.HasIndex(e => e.RefApplication, "ix_APPLICATION_WIKI_refApplication");

                entity.HasIndex(e => e.RefUser, "ix_APPLICATION_WIKI_refUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Details).HasMaxLength(4000);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.RefWikiCategory).HasColumnName("refWikiCategory");

                entity.Property(e => e.Title).HasMaxLength(400);
            });

            modelBuilder.Entity<ApplicationWikiCategory>(entity =>
            {
                entity.ToTable("APPLICATION_WIKI_CATEGORY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");
            });

            modelBuilder.Entity<ApplicationWikiLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("APPLICATION_WIKI_LOG");

                entity.Property(e => e.Details).HasMaxLength(4000);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Operation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.RefWikiCategory).HasColumnName("refWikiCategory");

                entity.Property(e => e.Title).HasMaxLength(400);
            });

            modelBuilder.Entity<ApplicationWikiTag>(entity =>
            {
                entity.HasKey(e => new { e.RefApplicationWiki, e.Tag });

                entity.ToTable("APPLICATION_WIKI_TAG");

                entity.Property(e => e.RefApplicationWiki).HasColumnName("refApplicationWiki");

                entity.Property(e => e.Tag).HasMaxLength(30);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");
            });

            modelBuilder.Entity<Auth>(entity =>
            {
                entity.ToTable("AUTH");

                entity.HasIndex(e => e.Code, "ix_AUTH_Code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Label).HasMaxLength(200);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");
            });

            modelBuilder.Entity<AuthLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("AUTH_LOG");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Label).HasMaxLength(200);

                entity.Property(e => e.Operation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");
            });

            modelBuilder.Entity<AuthScope>(entity =>
            {
                entity.ToTable("AUTH_SCOPE");

                entity.HasIndex(e => e.Action, "ix_AUTH_SCOPE_Action");

                entity.HasIndex(e => e.App, "ix_AUTH_SCOPE_App");

                entity.HasIndex(e => e.Controller, "ix_AUTH_SCOPE_Controller");

                entity.HasIndex(e => e.RefAuth, "ix_AUTH_SCOPE_refAuth");

                entity.HasIndex(e => new { e.RefAuth, e.App, e.Controller, e.Action }, "ix_AUTH_SCOPE_refAuth_App_Controller_Action_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.App)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");

                entity.Property(e => e.RefAuth).HasColumnName("refAuth");
            });

            modelBuilder.Entity<DiagnosticError>(entity =>
            {
                entity.ToTable("__DIAGNOSTIC_ERROR");

                entity.Property(e => e.Aciklama).HasMaxLength(4000);

                entity.Property(e => e.AciklamaExternal).HasMaxLength(4000);

                entity.Property(e => e.Kod).HasMaxLength(40);

                entity.Property(e => e.Metot).HasMaxLength(800);

                entity.Property(e => e.Modul).HasMaxLength(80);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefId)
                    .HasMaxLength(200)
                    .HasColumnName("refId");

                entity.Property(e => e.RefIdExternal)
                    .HasMaxLength(200)
                    .HasColumnName("refIdExternal");
            });

            modelBuilder.Entity<FirewallRule>(entity =>
            {
                entity.ToTable("FIREWALL_RULE");

                entity.HasIndex(e => e.Name, "ix_FIREWALL_RULE_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FirewallRuleIpAddress>(entity =>
            {
                entity.ToTable("FIREWALL_RULE_IP_ADDRESS");

                entity.HasIndex(e => new { e.RefFirewallRule, e.IpAddress }, "ix_FIREWALL_RULE_IP_ADDRESS_refFirewallRule_IpAddress")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefFirewallRule).HasColumnName("refFirewallRule");
            });

            modelBuilder.Entity<FirewallRuleIpAddressLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("FIREWALL_RULE_IP_ADDRESS_LOG");

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefFirewallRule).HasColumnName("refFirewallRule");
            });

            modelBuilder.Entity<FirewallRuleLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("FIREWALL_RULE_LOG");

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(400);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.ToTable("JOB_TITLE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(600);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MeetingNote>(entity =>
            {
                entity.ToTable("MEETING_NOTES");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.MeetingParticipants).HasMaxLength(500);

                entity.Property(e => e.MeetingTitle).HasMaxLength(500);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MeetingNoteFile>(entity =>
            {
                entity.ToTable("MEETING_NOTE_FILES");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefMeetingNote).HasColumnName("refMeetingNote");
            });

            modelBuilder.Entity<OtpVerificationRequest>(entity =>
            {
                entity.ToTable("OTP_VERIFICATION_REQUEST");

                entity.HasIndex(e => e.App, "ix_OTP_VERIFICATION_REQUEST_App");

                entity.HasIndex(e => new { e.App, e.Receiver, e.Channel, e.Purpose }, "ix_OTP_VERIFICATION_REQUEST_App_Receiver_Channel_Purpose_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.Channel, "ix_OTP_VERIFICATION_REQUEST_Channel");

                entity.HasIndex(e => e.Code, "ix_OTP_VERIFICATION_REQUEST_Code");

                entity.HasIndex(e => e.ExpireTime, "ix_OTP_VERIFICATION_REQUEST_ExpireTime");

                entity.HasIndex(e => e.Purpose, "ix_OTP_VERIFICATION_REQUEST_Purpose");

                entity.HasIndex(e => e.Receiver, "ix_OTP_VERIFICATION_REQUEST_Receiver");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Channel)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Receiver)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtpVerificationRequestLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("OTP_VERIFICATION_REQUEST_LOG");

                entity.HasIndex(e => e.App, "ix_OTP_VERIFICATION_REQUEST_LOG_App");

                entity.HasIndex(e => e.Channel, "ix_OTP_VERIFICATION_REQUEST_LOG_Channel");

                entity.HasIndex(e => e.Id, "ix_OTP_VERIFICATION_REQUEST_LOG_Id");

                entity.HasIndex(e => e.Purpose, "ix_OTP_VERIFICATION_REQUEST_LOG_Purpose");

                entity.HasIndex(e => e.Receiver, "ix_OTP_VERIFICATION_REQUEST_LOG_Receiver");

                entity.Property(e => e.App)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Channel)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Receiver)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtpVerificationResult>(entity =>
            {
                entity.ToTable("OTP_VERIFICATION_RESULT");

                entity.HasIndex(e => e.RefOtpVerificationRequest, "ix_OTP_VERIFICATION_RESULT_refOtpVerificationRequest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefOtpVerificationRequest).HasColumnName("refOtpVerificationRequest");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("PROJECT");

                entity.HasIndex(e => e.Code, "ix_PROJECT_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "ix_PROJECT_Name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("PROJECT_LOG");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.HasIndex(e => e.Name, "ix_ROLES_Name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");
            });

            modelBuilder.Entity<RolesAuth>(entity =>
            {
                entity.HasKey(e => new { e.RefAuth, e.RefRole });

                entity.ToTable("ROLES_AUTH");

                entity.Property(e => e.RefAuth).HasColumnName("refAuth");

                entity.Property(e => e.RefRole).HasColumnName("refRole");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");

                entity.HasIndex(e => e.Email, "ix_USER_Email");

                entity.HasIndex(e => e.Email, "ix_USER_LOG_Email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.EndDateOfWork).HasColumnType("date");

                entity.Property(e => e.GithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Picture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");

                entity.Property(e => e.RefJobTitle).HasColumnName("refJobTitle");

                entity.Property(e => e.RefRole).HasColumnName("refRole");

                entity.Property(e => e.StartDateOfWork).HasColumnType("date");
            });

            modelBuilder.Entity<UserAuditLog>(entity =>
            {
                entity.ToTable("USER_AUDIT_LOGS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventMessage).HasMaxLength(400);

                entity.Property(e => e.EventObject).HasMaxLength(100);

                entity.Property(e => e.EventObjectIdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventOperation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<UserAuditLogsHistory>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_AUDIT_LOGS_HISTORY");

                entity.Property(e => e.EventMessage).HasMaxLength(400);

                entity.Property(e => e.EventObject).HasMaxLength(100);

                entity.Property(e => e.EventObjectIdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventOperation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<UserAuth>(entity =>
            {
                entity.ToTable("USER_AUTH");

                entity.HasIndex(e => new { e.RefUser, e.RefAuth }, "ix_USER_AUTH_refUser_refAuth_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");

                entity.Property(e => e.RefAuth).HasColumnName("refAuth");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<UserAuthLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_AUTH_LOG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Operation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefAuth).HasColumnName("refAuth");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<UserFavoritePage>(entity =>
            {
                entity.ToTable("USER_FAVORITE_PAGE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Url)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserForgotPasswordDone>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_FORGOT_PASSWORD_DONE");

                entity.HasIndex(e => e.ExpireTime, "ix_USER_FORGOT_PASSWORD_DONE_ExpireTime");

                entity.HasIndex(e => e.Token, "ix_USER_FORGOT_PASSWORD_DONE_Token");

                entity.HasIndex(e => e.RefUser, "ix_USER_FORGOT_PASSWORD_DONE_refUser");

                entity.Property(e => e.Email)
                    .HasMaxLength(264)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<UserForgotPasswordRequest>(entity =>
            {
                entity.ToTable("USER_FORGOT_PASSWORD_REQUEST");

                entity.HasIndex(e => e.Email, "ix_USER_FORGOT_PASSWORD_REQUEST_Email");

                entity.HasIndex(e => e.ExpireTime, "ix_USER_FORGOT_PASSWORD_REQUEST_ExpireTime");

                entity.HasIndex(e => e.Token, "ix_USER_FORGOT_PASSWORD_REQUEST_Token");

                entity.HasIndex(e => e.RefUser, "ix_USER_FORGOT_PASSWORD_REQUEST_refUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ExpireTime).HasColumnType("datetime");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Token)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<UserForgotPasswordRequestLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_FORGOT_PASSWORD_REQUEST_LOG");

                entity.HasIndex(e => e.ExpireTime, "ix_USER_FORGOT_PASSWORD_REQUEST_LOG_ExpireTime");

                entity.HasIndex(e => e.Token, "ix_USER_FORGOT_PASSWORD_REQUEST_LOG_Token");

                entity.HasIndex(e => e.RefUser, "ix_USER_FORGOT_PASSWORD_REQUEST_LOG_refUser");

                entity.Property(e => e.Email)
                    .HasMaxLength(264)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Token)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<UserIpAddress>(entity =>
            {
                entity.HasKey(e => e.RefUser)
                    .HasName("PK_USER_IP_ADDRESS_1");

                entity.ToTable("USER_IP_ADDRESS");

                entity.Property(e => e.RefUser)
                    .ValueGeneratedNever()
                    .HasColumnName("refUser");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress4)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress5)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_LOG");

                entity.Property(e => e.Email)
                    .HasMaxLength(264)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(800);

                entity.Property(e => e.Operation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[fn_server_time]())");

                entity.Property(e => e.RefJobTitle).HasColumnName("refJobTitle");

                entity.Property(e => e.RefRole).HasColumnName("refRole");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("USER_LOGIN");

                entity.HasIndex(e => e.Token, "ix_USER_LOGIN_Token")
                    .IsUnique();

                entity.HasIndex(e => e.TokenExpireTime, "ix_USER_LOGIN_TokenExpireTime");

                entity.HasIndex(e => e.RefUser, "ix_USER_LOGIN_refUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLanguage)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AppName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceBrand).HasMaxLength(128);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceModel).HasMaxLength(128);

                entity.Property(e => e.DeviceOs)
                    .HasMaxLength(80)
                    .HasColumnName("DeviceOS");

                entity.Property(e => e.DeviceOsversion)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("DeviceOSVersion");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefOtp).HasColumnName("refOtp");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.TokenExpireTime).HasColumnType("datetime");

                entity.Property(e => e.UserAgent).HasMaxLength(1000);

                entity.Property(e => e.UserAgentHash)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLoginFailedAttempt>(entity =>
            {
                entity.ToTable("USER_LOGIN_FAILED_ATTEMPTS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.UserAgent).HasMaxLength(1000);
            });

            modelBuilder.Entity<UserLoginHistory>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_LOGIN_HISTORY");

                entity.Property(e => e.AppLanguage)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AppName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceBrand).HasMaxLength(128);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceModel).HasMaxLength(128);

                entity.Property(e => e.DeviceOs)
                    .HasMaxLength(80)
                    .HasColumnName("DeviceOS");

                entity.Property(e => e.DeviceOsversion)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("DeviceOSVersion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefOtp).HasColumnName("refOtp");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TokenExpireTime).HasColumnType("datetime");

                entity.Property(e => e.UserAgent).HasMaxLength(1000);

                entity.Property(e => e.UserAgentHash)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRequest>(entity =>
            {
                entity.ToTable("USER_REQUEST");

                entity.HasIndex(e => e.Action, "ix_USER_REQUEST_Action");

                entity.HasIndex(e => e.Controller, "ix_USER_REQUEST_Controller");

                entity.HasIndex(e => e.IpAddress, "ix_USER_REQUEST_IpAddress");

                entity.HasIndex(e => e.RecordTime, "ix_USER_REQUEST_RecordTime");

                entity.HasIndex(e => e.RefUser, "ix_USER_REQUEST_refUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Controller)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Method)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UserAgent).HasMaxLength(1000);
            });

            modelBuilder.Entity<UserRequestLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("USER_REQUEST_LOG");

                entity.HasIndex(e => e.RecordTime, "ix_USER_REQUEST_LOG_RecordTime");

                entity.HasIndex(e => e.RefUser, "ix_USER_REQUEST_LOG_refUser");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UserAgent).HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationPool)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastConfigUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDeployTime).HasColumnType("datetime");

                entity.Property(e => e.LastDeployVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.PackageName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefGithubId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("refGithubId");

                entity.Property(e => e.RefProject).HasColumnName("refProject");

                entity.Property(e => e.Repository)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewApplicationConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_CONFIG");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigDescription).HasMaxLength(400);

                entity.Property(e => e.Host)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.Value).HasMaxLength(400);
            });

            modelBuilder.Entity<ViewApplicationDeployRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_DEPLOY_REQUEST");

                entity.Property(e => e.ApplicationGithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserGithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameSurname)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewApplicationDeployRequestDone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_DEPLOY_REQUEST_DONE");

                entity.Property(e => e.ApplicationGithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserGithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameSurname)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewApplicationDeployRequestFailed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_DEPLOY_REQUEST_FAILED");

                entity.Property(e => e.ApplicationGithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserGithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameSurname)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewApplicationLoadbalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_LOADBALANCE");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastTouchTime).HasColumnType("datetime");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefProject).HasColumnName("refProject");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewApplicationLoadbalanceConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_LOADBALANCE_CONFIG");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefProject).HasColumnName("refProject");
            });

            modelBuilder.Entity<ViewApplicationUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_USER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefApplicationUserRole).HasColumnName("refApplicationUserRole");

                entity.Property(e => e.RefProject).HasColumnName("refProject");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.UserApplicationRole)
                    .HasMaxLength(50)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserGithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewApplicationWiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_APPLICATION_WIKI");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ApplicationRepository)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Details).HasMaxLength(4000);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.RefWikiCategory).HasColumnName("refWikiCategory");

                entity.Property(e => e.Title).HasMaxLength(400);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewGithubCommit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_GITHUB_COMMITS");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommitTime).HasColumnType("datetime");

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Repository)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sha)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserGithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameSurname)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewGithubIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_GITHUB_ISSUE");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Body).HasMaxLength(4000);

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GithubUsername)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IssueStatus)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.Repository)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1600);

                entity.Property(e => e.Title).HasMaxLength(1600);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserNameSurname)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPicture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_PROJECT");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_SERVER");

                entity.Property(e => e.ErrorMsg).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Memory)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsVersion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.ServerStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableApplicationConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_APPLICATION_CONFIG");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigDescription).HasMaxLength(400);

                entity.Property(e => e.Host)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(400);
            });

            modelBuilder.Entity<ViewTableApplicationLoadbalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_APPLICATION_LOADBALANCE");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.Host)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastTouchTime).HasColumnType("datetime");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTableApplicationLoadbalanceConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_APPLICATION_LOADBALANCE_CONFIG");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1600);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTableDeployRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_REQUEST");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableDeployRequestDone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_REQUEST_DONE");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableDeployRequestFailed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_REQUEST_FAILED");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableDeployRequestHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_REQUEST_HISTORY");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LogId).ValueGeneratedOnAdd();

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableDeployRequestProcessing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_REQUEST_PROCESSING");

                entity.Property(e => e.DeployTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");

                entity.Property(e => e.RefGithubAsset).HasColumnName("refGithubAsset");

                entity.Property(e => e.RefGithubRelease).HasColumnName("refGithubRelease");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.ReleaseName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableDeployRequestStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_REQUEST_STATUS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplicationDeployRequest).HasColumnName("refApplicationDeployRequest");

                entity.Property(e => e.StatusMessage).HasMaxLength(4000);

                entity.Property(e => e.StatusType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableDeploySetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_DEPLOY_SETTINGS");

                entity.Property(e => e.DirectoryPathAssetDownload)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.DirectoryPathBackup)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.DirectoryPathDeploy)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefApplication).HasColumnName("refApplication");
            });

            modelBuilder.Entity<ViewTableGithubCommit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_GITHUB_COMMITS");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommitTime).HasColumnType("datetime");

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Repository)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sha)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableGithubCommitsSummaryDaily>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_GITHUB_COMMITS_SUMMARY_DAILY");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Repository)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableGithubIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_GITHUB_ISSUE");

                entity.Property(e => e.Body).HasMaxLength(4000);

                entity.Property(e => e.CloseTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GithubUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Repository)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1600);

                entity.Property(e => e.Title).HasMaxLength(1600);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableGithubIssueAssignee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_GITHUB_ISSUE_ASSIGNEES");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefIssue).HasColumnName("refIssue");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableGithubIssueSummaryDaily>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_GITHUB_ISSUE_SUMMARY_DAILY");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Repository)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTableGithubRepository>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_GITHUB_REPOSITORY");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.FullName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimePush).HasColumnType("datetime");

                entity.Property(e => e.TimeUpdated).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlArchive)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlBranches)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlCollaborators)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlCommits)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlEvents)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlIssues)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPullRequests)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlReleases)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlSsh)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("UrlSSH");
            });

            modelBuilder.Entity<ViewTableIdGeneratorDeploy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_ID_GENERATOR_DEPLOY");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTableServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER");

                entity.Property(e => e.Details)
                    .HasMaxLength(400)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Memory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.OsVersion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewTableServerApplicationPool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_APPLICATION_POOL");

                entity.Property(e => e.ApplicationPool)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Details)
                    .HasMaxLength(400)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefServer).HasColumnName("refServer");
            });

            modelBuilder.Entity<ViewTableServerApplicationPoolStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_APPLICATION_POOL_STATUS");

                entity.Property(e => e.ApplicationPool)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTableServerDrive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_DRIVE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Label)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Name)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewTableServerIpAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_IP_ADDRESS");

                entity.Property(e => e.Details)
                    .HasMaxLength(400)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefServer).HasColumnName("refServer");
            });

            modelBuilder.Entity<ViewTableServerService>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_SERVICE");

                entity.Property(e => e.Details)
                    .HasMaxLength(400)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<ViewTableServerServiceStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_SERVICE_STATUS");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTableServerStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TABLE_SERVER_STATUS");

                entity.Property(e => e.Details)
                    .HasMaxLength(400)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefServer).HasColumnName("refServer");

                entity.Property(e => e.ServerStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.ServerTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_USER");

                entity.Property(e => e.Email)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.EndDateOfWork).HasColumnType("date");

                entity.Property(e => e.GithubUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JobTitle).HasMaxLength(600);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Picture)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RefJobTitle).HasColumnName("refJobTitle");

                entity.Property(e => e.RefRole).HasColumnName("refRole");

                entity.Property(e => e.RoleLabel).HasMaxLength(50);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.StartDateOfWork).HasColumnType("date");
            });

            modelBuilder.Entity<ViewUserAuditLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_USER_AUDIT_LOGS");

                entity.Property(e => e.EventMessage).HasMaxLength(400);

                entity.Property(e => e.EventObject).HasMaxLength(100);

                entity.Property(e => e.EventObjectIdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventOperation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.RefUser).HasColumnName("refUser");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserNameSurname)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
